(function () {

    "use strict";

    var mainApp = angular.module('mainApp');

    function mainCtrl(GetUsers) {
        var vm = this;

        vm.testMsg = "Let's do it!";

        GetUsers.query(function (data) {
            vm.users = data;
        });      
    }

    mainApp.controller('mainCtrl', mainCtrl);

}());