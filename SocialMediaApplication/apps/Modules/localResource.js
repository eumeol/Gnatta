(function () {

    "use strict";

    //function for interacting with local database
    angular
        .module('dbService')
        .factory('saveUser', ['$resource',saveUser]);

    function saveUser($resource) {
        return $resource('http://localhost:53780/api/users/:id');
    }

})();