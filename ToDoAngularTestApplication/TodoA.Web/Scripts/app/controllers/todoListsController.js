/*
    Define the todoLists controller responsible for rendering the users created to do lists
*/
(function () {
    var todoApp = angular.module("todoApp");

    todoApp.controller("ToDoListsController", function ($scope, todoListFactory, $location) {
        $scope.TodoLists = [];
        
        /*
            Initialization
            ==========================================
        */

        // get the to-do lists from the server
        var promise = todoListFactory.getUserTodoLists();
        
        // This code will happen in 'future'.
        promise.then(function (data) {
            $scope.TodoLists = data;
        });

        /*
            Event handling
            ==========================================
        */
        
        $scope.ViewDetails = function (data) {
            var listId = data.Id;
            $location.path("listdetails/" + listId);
            console.log("Click: " + listId);
        };
    });
})();
