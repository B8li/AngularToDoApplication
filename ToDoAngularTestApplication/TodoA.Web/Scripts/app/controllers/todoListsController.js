/*
    Define the todoLists controller responsible for rendering the users created to do lists
*/
(function () {
    var todoApp = angular.module("todoApp");

    todoApp.controller("ToDoListsController", function ($scope, todoListFactory) {
        $scope.TodoLists = [];

        // get the to-do lists from the server
        todoListFactory.getUserTodoLists($scope);
    });
})();