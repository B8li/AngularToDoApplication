/*
    define the applicaiton routes
*/

(function () {
    var todoApp = angular.module("todoApp");

    todoApp.config(function ($routeProvider) {
        $routeProvider
            .when('/', {
                controller: "ToDoListsController",
                templateUrl: '/views/partials/todolists'
            })
            .when("/listdetails", {

            })
            .otherwise({ redirectTo: '/' });
    });
})();