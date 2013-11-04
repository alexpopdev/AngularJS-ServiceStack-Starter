(function () {
    'use strict';
    
    var appModule = angular.module('starterApp');

    appModule.controller('dashboardController', ['$scope', function dashboardController($scope) {

        $scope.viewModel = {
            announcements: []
        };
        
        $scope.init = function () {

           $scope.viewModel.announcements = ["Client-side Announcement1", "Client-side Announcement2"];
        };

        $scope.init();
    }]);

}());