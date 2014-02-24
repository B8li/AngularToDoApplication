/*
    Define the todoLists controller responsible for rendering the users created to do lists
*/
(function () {
    var todoApp = angular.module("todoApp");

    todoApp.controller("ToDoListsController", function ($scope) {
        $scope.TodoLists = [
            {
                Name: "Groceries",
                CreatedOn: moment().add("days", -3),
                FinishedItems: 2,
                RemainingItems: 4
            },
            {
                Name: "Shopping",
                CreatedOn: moment().add("days", -7),
                FinishedItems: 6,
                RemainingItems: 2
            },
            {
                Name: "Work",
                CreatedOn: moment().add("days", -2),
                FinishedItems: 1,
                RemainingItems: 12
            },
            {
                Name: "Party",
                CreatedOn: moment().add("days", -1),
                FinishedItems: 10,
                RemainingItems: 20
            }
        ];
    });
})();