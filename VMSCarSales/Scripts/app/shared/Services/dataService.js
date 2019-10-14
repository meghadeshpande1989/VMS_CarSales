
angular
    .module('app')
    .service("dataService", function ($http) {
    var $this = this;
        $this.AddCar = function (car) {
            var request = $http({
                method: 'POST',
                url: '/Home/AddCar',
                data: JSON.stringify(car),
                dataType: "json"
            });
            return request;
        }  

    $this.GetAll = function () {
        var request = $http({
            method: 'GET',
            url: '/Home/GetAllCars',
        });
        return request;
    }

    
});