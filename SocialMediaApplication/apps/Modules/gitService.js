(function () {

    "use strict";

    var GetUsers = function ($resource) {
        return $resource('https://api.github.com/users');
    };

    angular.module('gitService', ['ngResource'])
        .factory('GetUsers', GetUsers);

})();