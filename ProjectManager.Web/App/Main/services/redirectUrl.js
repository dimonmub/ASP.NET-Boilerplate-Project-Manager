(function () {
	'use strict';

	angular
        .module('app')
        .factory('redirectUrl', redirectUrl);
	redirectUrl.$inject =['$window'];

	function redirectUrl($window) {
		var redirectUrl = {};
		redirectUrl.projects = function () {
			var url = "#/projects";
			$window.location.href = url;
		}
		redirectUrl.details = function () {
		    var url = "#/details";
		    $window.location.href = url;
		}
		redirectUrl.taskDescription = function () {
		    var url = "#/taskDescription";
		    $window.location.href = url;
		}
		return redirectUrl;
	}
})();