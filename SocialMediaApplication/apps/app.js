(function () {

    "use strict";

    var app = angular.module('mainApp', ['gitService', 'dbService', 'ngRoute', 'ngToast']);
   
    app.config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: '/apps/Views/UsersListView.html',
                controller: 'mainCtrl as vm'})
            .when('/edit', {
                templateUrl: '/apps/Views/UsersEditView.html',
                controller: 'UserEditCtrl as editCtrl'})
            .when('/edit/:id', {
                templateUrl: '/apps/Views/UsersEditView.html',
                controller: 'UserEditCtrl as editCtrl'})
            .otherwise({ redirectTo: '/' });
    }]);

})();