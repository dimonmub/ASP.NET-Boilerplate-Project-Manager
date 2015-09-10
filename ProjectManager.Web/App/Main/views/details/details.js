(function () {
    'use strict';
    angular
        .module('app')
        .controller('app.views.details', details);
    details.$inject = ['$scope', 'userService', 'redirectUrl', 'ShareData', 'alertService'];

    function details($scope, userService, redirectUrl, ShareData, alertService) {

        var vm = this;        
        vm.closeAlert = closeAlert;
        vm.taskDescription = taskDescription;

        getProject();
        getTasksById();          

        function closeAlert(index) {
            alertService.closeAlert(index);
        }

        function getProject() {
            userService.getProjectById(ShareData.value)
                .success(function (data) {
                    vm.project = data.result;
                })
                .error(function (error) {
                    vm.status = 'Unable to load project : ' + error;
                    console.log(vm.status);
                });
        }

        function getTasksById() {            
            userService.getTasksById(ShareData.value)
                .success(function (data) {
                    vm.tasks = data.result;
                })
                .error(function (error) {
                    vm.status = 'Unable to load TasksById data: ' + error.message;
                    console.log(vm.status);
                });
        };

        function taskDescription(taskId) {
            ShareData.value2 = taskId;
            redirectUrl.taskDescription();
        };
    }
})();