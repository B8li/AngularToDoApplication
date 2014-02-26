/*
    Define the todoLists controller responsible for rendering the users created to do lists
*/
(function () {
    var todoApp = angular.module("todoApp");

    todoApp.controller("ToDoListsDetailsController", function ($scope, todoListFactory, $location, $routeParams) {
        // the to do list empty object that will be bound to the page
        $scope.TodoList = {};

        /*
           Initialization
           ==========================================
       */

        // get the to-do lists from the server
        var promise = todoListFactory.getListDetailsById($routeParams.id);

        // This code will happen in 'future'.
        promise.then(function (data) {
            $scope.TodoList = data;
        });
        
        /*
         Event Handlers
         ==========================================
        */

    });
})();
