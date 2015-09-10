(function () {
    'use strict';

    angular
        .module('app')
        .controller('app.views.projects', projects);
    projects.$inject = ['$scope', 'userService', 'redirectUrl', 'ShareData', 'alertService'];
    function projects($scope, userService, redirectUrl, ShareData, alertService) {

        var vm = this;        

        vm.closeAlert = closeAlert;
        vm.details = details;

        getAllProjects();

        function closeAlert(index) {
            alertService.closeAlertIdx(index);
        };
        
        function getAllProjects() {
            userService.getAllProjects()
                .success(function (data) {
                    vm.projects = data.result;                    
                })
                .error(function (error) {
                    vm.status = 'Unable to load AllProjects data: ' + error.message;
                    console.log(vm.status);
                });
        };

        function details(projectId) {
            ShareData.value = projectId;
            redirectUrl.details();
        };
    }
})();