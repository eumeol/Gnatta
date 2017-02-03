(function () {

    "use strict";

    var mainApp = angular.module('mainApp');

    function mainCtrl(GetUsers) {
        var vm = this;     

        GetUsers.query(function (data) {
            vm.users = data;
        });    
    }

    mainApp.controller('mainCtrl', mainCtrl);

}());