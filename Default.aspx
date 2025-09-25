<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WebForms + AngularJS Demo</title>
    <script src="Scripts/angular.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div ng-app="myApp" ng-controller="userCtrl">
            <h2>Users</h2>
            <ul>
                <li ng-repeat="u in users">
                    {{u.Id}} - {{u.Name}} ({{u.Email}})
                </li>
            </ul>
            <button ng-click="load()">Load Users</button>
        </div>
    </form>

    <script type="text/javascript">
        var app = angular.module("myApp", []);
        app.controller("userCtrl", function ($scope, $http) {
            $scope.users = [];

            $scope.load = function () {
                $http({
                    method: "POST",
                    url: "Default.aspx/GetUsers",
                    headers: { "Content-Type": "application/json" }
                }).then(function (response) {
                    // response.data.d is the returned list
                    $scope.users = response.data.d;
                }, function (error) {
                    console.error("Error:", error);
                });
            };

            // Optionally auto-load
            //$scope.load();
        });
    </script>
</body>
</html>
