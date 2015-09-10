(function () {
    'use strict';

    var app = angular.module('app', [
        'ngAnimate',
        'ngSanitize',

        'ui.router',
        'ui.bootstrap',
        'ui.jq',

        'abp'
    ]);

    //Configuration for Angular UI routing.
    app.config([
        '$stateProvider', '$urlRouterProvider',
        function($stateProvider, $urlRouterProvider) {
            $urlRouterProvider.otherwise('/');
            $stateProvider
                .state('home', {
                    url: '/',
                    templateUrl: '/App/Main/views/home/home.cshtml',
                    menu: 'Home' //Matches to name of 'Home' menu in ProjectManagerNavigationProvider
                })
                .state('about', {
                    url: '/about',
                    templateUrl: '/App/Main/views/about/about.cshtml',
                    menu: 'About' //Matches to name of 'About' menu in ProjectManagerNavigationProvider
                })
                .state('projects', {
                    url: '/projects',
                    templateUrl: '/App/Main/views/projects/projects.cshtml',
                    menu: 'Projects'
                })
                .state('details', {
                    url: '/details',
                    templateUrl: '/App/Main/views/details/details.cshtml'
                })
                .state('taskDescription', {
                    url: '/taskDescription',
                    templateUrl: '/App/Main/views/taskDescription/taskDescription.cshtml'
                });
        }
    ]);
})();