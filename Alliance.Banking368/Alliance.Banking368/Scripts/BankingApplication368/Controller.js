
angular.module("BankingApplication368")
      .controller('LoginController', function ($scope, $window, LoginService) {
          $scope.successmessage = '';
          $scope.errormessage = '';
         

          //obtain form data and store in a object to send for validation
          $scope.LoginData = {
              EmailId: '',
              Password: ''
          };
             $scope.Login = function () {
              LoginService.GetUser($scope.LoginData).then(function (d) {
                  if (d.data != null) {

                      sessionStorage.setItem("Name", d.data.Name);
                      sessionStorage.setItem("AccountNumber", d.data.AccountNumber);
                      sessionStorage.setItem("EmailId", d.data.EmailId);
                      sessionStorage.setItem("MobileNumber", d.data.MobileNumber);
                      sessionStorage.setItem("Balance", d.data.Balance);
                      sessionStorage.setItem("User_ID", d.data.ID);
                      $window.location.href = "Home/AccountSummary";
                      

                  }
                  else {
                      $scope.errormessage = "Invalid Credentials";
                  }
              });
          }
      })
.controller("AccountSummaryController", function ($scope, $http, $window, TransactionService) {
    var user_data = {
        successmessage: "welcome " + sessionStorage.getItem('Name'),
        AccountNumber: sessionStorage.getItem('AccountNumber'),
        EmailId: sessionStorage.getItem('EmailId'),
        MobileNumber: sessionStorage.getItem('MobileNumber'),
        Balance: sessionStorage.getItem('Balance'),
        ID: sessionStorage.getItem('User_ID')
    };
    $scope.user_data=user_data;
    $scope.Ministatement = function () {
        
        $window.location.href = "/Home/MiniStatement";
       
    }
    $scope.Logout = function () {
        sessionStorage.clear();
        $window.location.href = "/Home/Logout";
    }
    

    
    
})
.controller("MiniStatementController",function($scope,$http,$window,TransactionService)
{
    var user_data = {
            successmessage: "welcome " + sessionStorage.getItem('Name'),
            AccountNumber: sessionStorage.getItem('AccountNumber'),
            EmailId: sessionStorage.getItem('EmailId'),
            MobileNumber: sessionStorage.getItem('MobileNumber'),
            Balance: sessionStorage.getItem('Balance'),
            ID: sessionStorage.getItem('User_ID')
        
    };
    $scope.user_data = user_data;
    TransactionService.GetFive($scope.user_data).then(function (e) {
        if (e.data != null) {
            $scope.transactions = e.data;
        }
        else{
            $scope.errormessage="No Transaction Exists";
        }
    })

    $scope.Logout = function () {
        sessionStorage.clear();
        $window.location.href = "/Home/Logout";
    }
      
})
 .factory('LoginService', function ($http) {
     var res = {}
     res.GetUser = function (d) {
         return $http({
             url: '/api/User',
             method: 'post',
             data: JSON.stringify(d),
             headers: { 'content-type': 'application/json' }
         });
     };
     return res;
 })
.factory('TransactionService', function ($http) {
    var trans = {}
    trans.GetFive = function (f) {
        return $http({
            url: '/api/Transaction',
            method: 'post',
            data: JSON.stringify(f),
            headers: { 'content-type': 'application/json' }
        });
    };
    return trans;
    
});