(function () {
    "use strict";

    var mainApp = angular.module('mainApp');

    function UserEditCtrl(GetUsers, saveUser, $location, $window, $routeParams, ngToast) {

        var vm = this;
        vm.user = {}; 
        vm.id = $routeParams.id;
        vm.message = '';

        //service module to get user from gitHub
        GetUsers.get({ id: vm.id }, function (data) {
            vm.user = data;
        });

        if (vm.user) {
            vm.title = "Update " + vm.id;
            vm.origUser = angular.copy(vm.user);
        }
        else {
            vm.title = "New User";
        }
      
        //function to save user data to the local sql express database, called from userEditCtrl
        vm.save = function (data) {           
            saveUser.save(data,function () {
                vm.origUser = angular.copy(data);
                ngToast.create('User has been inserted to the database successfully...');
            });
        };

        //function to reset the form, called from userEditCtrl
        vm.reset = function (data) {                        
            vm.user = angular.copy(vm.origUser);
        };

        //function to route user to the user edit form
        vm.submit = function (data) {
            var editLocation = $location.absUrl() + 'edit/' + data;
            vm.thelocation = editLocation;
            $window.location.href = editLocation;
            vm.message = '';

        };

    }

    //added to avoid any minification issue
    mainApp.controller('UserEditCtrl', ['GetUsers', 'saveUser', '$location',
        '$window', '$routeParams', 'ngToast', UserEditCtrl]);

}());