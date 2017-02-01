(function () {
    "use strict";

    var mainApp = angular.module('mainApp');

    function UserEditCtrl(GetUsers) {
        var vm = this;
        vm.user = {};
        vm.message = '';

        GetUsers.get({ id: 5 },
            function (data) {
                vm.user = data;
                vm.origUser = angular.copy(data);
            });

        if (vm.user && vm.user.id) {
            vm.title = "Update " + vm.user.login;
        }
        else {
            vm.title = "New User";
        }

        vm.submit = function () {

        };

        vm.cancel = function (editForm) {
            editForm.$setPristine();
            vm.user = angular.copy(vm.origUser);
            vm.message = '';
        };

    }

    mainApp.controller('UserEditCtrl', UserEditCtrl);

}());