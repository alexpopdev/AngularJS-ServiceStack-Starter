(function () {
    'use strict';

    var appModule = angular.module('starterApp');

    appModule.factory('announcementsService', ['$resource', function announcementsService($resource) {
        var AnnouncementsResource = $resource('api/announcements');
        
        return {
            getAnnouncements: function () {
                return AnnouncementsResource.query();
            },
        };
    }]);

}());