
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

tmcApp.directive('cursor', function () {
    return {
        restrict: 'A',
        link: function (scope, element, attrs) {
            angular.element(element).attr('style', 'cursor: pointer').bind('click', function () {
            });
        }
    }
});
tmcApp.directive('routeMap', function () {
    return {
        link: function (scope, element, attrs) {
            element.bind('click', function () {
                var route = '#/' + attrs.routeMap;
                scope.$apply(function () {
                    scope.setRoute(route);
                });
            });
        }
    }
});
tmcApp.directive('updateRoute', function () {
    return {
        link: function (scope, element, attrs) {
            element.bind('click', function () {
                scope.$apply(function () {
                    scope.setSchool(attrs.updateRoute, attrs.title);
                });
            });
        }
    }
});
tmcApp.directive('accordionBody', function () {
    return {
        link: function (scope, element, attrs) {
            $(element).click(function (event) {
                scope.getRoundMeeringDays(attrs.accordionBody);
                event.preventDefault();
            });
        }
    }
});

tmcApp.directive('elementId', function () {
    return {
        link: function (scope, element, attrs) {
            $(element).attr('id', attrs.elementId);
        }
    }
})

tmcApp.directive('staffFlag', function () {
    return {
        scope: {
            lastName: '='
        },
        transclude: true,
        template: '<div>{{lastName}}<i class="pull-right fa fa-question></i></div>'
    };
});

tmcApp.directive('setValue', function () {
    return {
        scope: {
            setValue: '&'
        },
        link: function (scope, element, attrs) {
            var e = angular.element(element);
            e.on('click', function (event) {
                //e.parent().addClass('active');
                scope.setValue();
                event.preventDefault();
            });
        }
    };
});

tmcApp.directive('offLink', function () {
    return {
        link: function (scope, element, attrs) {
            angular.element(element).on('click', function (event) {
                event.preventDefault();
            });
        }
    }
});

tmcApp.directive('tooltip', function () {
    return {
        restrict: 'E',
        scope: {
            person: '=',
            title: '&',
        },
        replace: true,
        template: '<i class="pull-right fa" style="font-weight: bold;font-family:verdana;cursor:pointer;" data-html="true" data-placement="top" data-original-title="{{title}}">{{text}}</i>',
        link: function (scope, element, attrs) {
            var e = angular.element(element);
            var staff = scope.person;

            if (staff.typeId != 1 && staff.typeId != 999) {
                if (staff.typeId == 2) {
                    scope.title = 'Algebra teacher!';
                    scope.text = "A";
                }
                else if (staff.typeId == 3) {
                    scope.title = 'Intervention teacher!';
                    scope.text = "I";
                }
                e.show();
            } else e.hide();
            e.tooltip();
        }
    };
});

tmcApp.directive('tooltipindividualstudentpage', function () {
    return {
        restrict: 'E',
        scope: {
            person1: '=',
            title: '&'
        },
        replace: true,
        template: '<i class="pull-right fa" style="font-weight: bold;font-family:verdana;cursor:pointer;" data-html="true" data-placement="top" data-original-title="{{title}}">{{text}}</i>',
        link: function (scope, element, attrs) {
            var e = angular.element(element);
            var staff = scope.person1;
            if (staff !== undefined && staff.staffTypeId != 1 && staff.staffTypeId != 999) {
                if (staff.staffTypeId == 2) {
                    scope.title = 'Algebra teacher!';
                    scope.text = "A";
                }
                else if (staff.staffTypeId == 3) {
                    scope.title = 'Intervention teacher!';
                    scope.text = "I";
                }
                e.show();
            } else e.hide();
            e.tooltip();
        }
    };
});

/**
 * Directive used for showing alert innformation
 */
tmcApp.directive('alertBox', function () {
    return {
        restrict: 'E',
        replace: true,
        scope: {
            alertMsg: '@ ',
            okClick: '&'
        },
        link: function (scope, element, attr) {
        },
        template: "<div class='alert_box overlay' style='z-index: 1010;'>  \
                    <div class='x_closed float_right msg_h' ng-click='okClick()'>X</div> \
                    <span class='msg_h'>Alert Message</span> \
                    <hr class='alert'> \
                    <span class='msg_text'>{{alertMsg}} </span><br><br> \
                    <a class='btn_modal' href='javascript:void(0);' ng-click='okClick()'>OK</a>\
                   </div>"
    };
});

/**
 * Directive used for showing loader
 */
tmcApp.directive('loader', function () {

    return {
        restrict: 'AE',
        replace: true,
        scope: {
            msg: '@ '
        },
        template: "<div style='z-index:99999 !important;' class='modal fade' id='pageLoaderModal' tabindex='-1' role='dialog' aria-labelledby='myModalLabel' aria-hidden='true'> \
                    <div class='modal-body'> \
                        <div class='loader-out'>\
                            <img src='/Content/img/preloader.gif'>\
                        </div>\
                    </div>\
                  </div>"
    };
});
