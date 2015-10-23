var Tmc = Tmc || {};

Tmc.State = function (s) {
    var self = this;
    self.stateId = s.StateId;
    self.stateName = s.StateName;
    self.schools = [];
    angular.forEach(s.Schools, function (s) {
        self.schools.push(new Tmc.School(s));
    });
};
 