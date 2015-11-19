
tmcApp.directive('studentInfo', function ($compile) {
    //return {
    //    restrict: 'E',
    //    replace: true,
    //    scope:{
    //        student: "="
    //    },
    //    template: '<button data-placement="left" data-html="true" data-container="body" data-original-title="Info" data-content="" rel="popover" class="btn btn-xs"><i class="fa fa-gear"></i></button>',
    //    link: function (scope, element, attrs) {
    //        angular.element(element).click(function (e) {
    //            $this = $(this);
    //            $this.popover();
    //        });
    //        $(element).on('show.bs.popover', function () {
    //            var popover = $(element).data('bs.popover');
    //            popover.options.content = scope.student.studentId;
    //            popover.setContent();
    //        });
    //    }
    //};
    return {
        restrict: 'EAC',
        scope: {
            student: "="
        },
        template: "<a id='pop-over-link{{student.studentId}}'>Show pop-over</a>" +
                  "<div id='pop-over-content{{student.studentId}}' style='display:none'><button class='btn btn-primary' ng-click='testFunction()'>Ok</button></div>",
        link: function (scope, elements, attrs) {
            var e = $("#pop-over-link" + scope.student.studentId);
            e.popover({
                'placement': 'top',
                'trigger': 'click',
                'html': true,
                //'container': 'body',
                'content': function () {
                    return $compile($("#pop-over-content" + scope.student.studentId).html())(scope);
                }
            });

            scope.testFunction = function () {
                alert("it works");
                console.log("maybe");
            }

        }
    }
});
 
//upload preview used in upload image
tmcApp.directive('ngThumb', ['$window', function ($window) {
    var helper = {
        support: !!($window.FileReader && $window.CanvasRenderingContext2D),
        isFile: function(item) {
            return angular.isObject(item) && item instanceof $window.File;
        },
        isImage: function(file) {
            var type =  '|' + file.type.slice(file.type.lastIndexOf('/') + 1) + '|';
            return '|jpg|png|jpeg|bmp|gif|'.indexOf(type) !== -1;
        }
    };

    return {
        restrict: 'A',
        template: '<canvas/>',
        link: function(scope, element, attributes) {
            if (!helper.support) return;

            var params = scope.$eval(attributes.ngThumb);

            if (!helper.isFile(params.file)) return;
            if (!helper.isImage(params.file)) return;

            var canvas = element.find('canvas');
            var reader = new FileReader();

            reader.onload = onLoadFile;
            reader.readAsDataURL(params.file);

            function onLoadFile(event) {
                var img = new Image();
                img.onload = onLoadImage;
                img.src = event.target.result;
            }

            function onLoadImage() {
                var width = params.width || this.width / this.height * params.height;
                var height = params.height || this.height / this.width * params.width;
                canvas.attr({ width: width, height: height });
                canvas[0].getContext('2d').drawImage(this, 0, 0, width, height);
            }
        }
    };
}]);