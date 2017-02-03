(function () {

    "use strict";

    //service module for interacting with gitHub
    var GetUsers = function ($resource) {
        return $resource('https://api.github.com/users/:id');
    };

    angular.module('gitService', ['ngResource'])
        .factory('GetUsers', GetUsers);

    
})();