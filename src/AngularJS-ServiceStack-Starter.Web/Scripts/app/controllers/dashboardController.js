(function () {
    'use strict';
    
    var appModule = angular.module('starterApp');

    appModule.controller('dashboardController', ['$scope', 'announcementsService', function dashboardController($scope, announcementsService) {

        $scope.viewModel = {
            announcements: []
        };
        
        $scope.init = function () {

            //$scope.viewModel.announcements = [{ id: 1, content: "Client-side Announcement1" }, { id: 2, content: "Client-side Announcement2" }];

          $scope.viewModel.announcements = announcementsService.getAnnouncements();
        };

        $scope.init();
    }]);

}());