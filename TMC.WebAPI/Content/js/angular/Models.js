var Tmc = Tmc || {};

Tmc.QueueItem = function (mediaItem) {
    var self = this;
    self.mediaId = mediaItem.listingMediaId;
    self.name = mediaItem.fileName;
    self.type =  'image/jpeg'; 
    self.isProfile = false;
    self.size = 10000;
    self.url = 'http://localhost:59974/bytes/sample.jpg/12';
    self.lastModifiedDate = new Date();
    //return self;
};



Tmc.State = function (s) {
    var self = this;
    self.lastModifiedDate = new Date();
    self.type =  'image/jpeg';//todo
    self.schools = [];
    angular.forEach(s.Schools, function (s) {
        self.schools.push(new Tmc.School(s));
    });
};
 