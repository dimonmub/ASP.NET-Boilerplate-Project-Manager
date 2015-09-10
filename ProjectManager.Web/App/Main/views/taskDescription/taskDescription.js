(function () {
    'use strict';
    angular
        .module('app')
        .controller('app.views.task.description', taskDescription);
    taskDescription.$inject = ['$scope', 'userService', 'redirectUrl', 'ShareData', 'alertService'];

    function taskDescription($scope, userService, redirectUrl, ShareData, alertService) {

        var vm = this;        
        vm.closeAlert = closeAlert;

        getTask();
        
        function closeAlert(index) {
            alertService.closeAlert(index);
        }

        function getTask() {
            userService.getTaskById(ShareData.value2)
                .success(function (data) {
                    vm.task = data.result;
                })
                .error(function (error) {
                    vm.status = 'Unable to load project : ' + error;
                    console.log(vm.status);
                });
        }
    }
})();