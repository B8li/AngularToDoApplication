/*
    Define the todoLists controller responsible for rendering the users created to do lists
*/
(function () {
    var todoApp = angular.module("todoApp");

    /*
        Define the contorller for the modal window for editing to do lists
    */

    todoApp.controller("ListEditModalController", function ($scope, $modalInstance) {

        $scope.data = {
           Data: ""
        };
        
        /*
            Modal Actions - 
            Close with  configuration 
            Cancel, closing and no action
        */

        $scope.addList = function () {
            $modalInstance.close($scope.data);
        };

        $scope.cancelList = function () {
            $modalInstance.dismiss('cancel');
        };
    });
})();
