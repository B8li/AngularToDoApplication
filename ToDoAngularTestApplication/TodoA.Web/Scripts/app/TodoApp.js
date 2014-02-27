/*
    Define the main application module
*/
(function () {
    var todoApp = angular.module("todoApp", ['ngRoute', "ui.bootstrap"]);

    // document ready function
    // TODO : Move someplace else using angular?
    $(function () {
        $(".list-action button").tooltip();
    });

})();