(function () {
    'use strict';

    // Declare app level module which depends on filters, and services
    var appModule = angular.module('starterApp',
        ['ngResource', 'ui.bootstrap']);

    appModule.config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/dashboard', { templateUrl: 'Scripts/app/views/dashboard.html', controller: 'dashboardController' });
        $routeProvider.otherwise({ redirectTo: '/dashboard' });
    }]);

}());