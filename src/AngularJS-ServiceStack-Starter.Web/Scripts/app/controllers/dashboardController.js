(function () {
    'use strict';
    
    var appModule = angular.module('starterApp');

    appModule.controller('dashboardController', ['$scope',  function ($scope) {

        $scope.announcements = [];
        
        $scope.init = function () {

            $scope.announcements = ["Announcement1", "Announcement2"];
        };

        $scope.init();
    }]);

}());