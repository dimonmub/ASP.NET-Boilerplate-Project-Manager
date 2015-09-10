(function () {
    'use strict';

    angular
        .module('app')
        .service('userService', userService);

    userService.$inject = ['$http'];

    function userService($http) {
        var userService = {};
        userService.getAllProjects = function () {
            return $http.get('/home/projects');
        };
        userService.getProjectById = function (id) {
            return $http.get('/home/getProjectById/' + id)
        };
        userService.getTasksById = function (id) {
            return $http.get('/home/tasks/' + id)
        };
        userService.getTaskById = function (id) {
            return $http.get('/home/getTaskById/' + id)
        };
        return userService;
    };
})();
    
    


   


