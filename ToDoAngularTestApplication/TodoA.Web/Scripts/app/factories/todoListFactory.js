/*
    Define the service that will retrieve the 
*/
(function () {
    // get the application module already defined in the TodoApp.js script file
    var todoApp = angular.module("todoApp");

    todoApp.factory("todoListFactory", function ($http) {
        // define the factory object
        var factory = {};

        /*
            The method will retrieve the user User To-do lists.
        */

        factory.getUserTodoLists = function ($scope) {
            // return the result using promises
            $http.get("/TodoLists/GetUserTodoLists")
                .success(function (data) {
                    $scope.TodoLists = data;
                });
        };

        // return the factory object
        return factory;
    });
})();