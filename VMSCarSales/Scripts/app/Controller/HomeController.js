(function () {
    'use strict';

    angular
        .module('app')
        .controller('HomeController', ['$scope', 'dataService', function ($scope, dataService) {
            $scope.cars = [];
            $scope.vehicleList = [{ "name": "Car" }, { "name": "Boat" }, { "name": "Bike" }];
            $scope.bodyTypeList = [{ "name": "Bus" }, { "name": "Cab Chassis" }, { "name": "Convertible" }, { "name": "Coupe" }, { "name": "Hatch" },
                { "name": "Light Truck" }, { "name": "People Mover" }, { "name": "Sedan" }, { "name": "SUV" }, { "name": "Ute" }, { "name": "Van" }]

            GetCars();  
            $scope.SaveCar = function () {
                var VehicleModel = {
                    Id: $scope.id,
                    Engine: $scope.engine,
                    BodyType: $scope.bodyType,
                    VehicleType: $scope.vehicleType,
                    Make: $scope.make,
                    VehicleModel: $scope.vehicleModel,
                    Doors: $scope.doors,
                    Wheels: $scope.wheels
                };
              
                if (VehicleModel.VehicleType == 'Car') {
                    if ((VehicleModel.Doors == 2 || VehicleModel.Doors == 4) && (VehicleModel.Wheels == 4 )) {
                        var requestResponse = dataService.AddCar(VehicleModel);
                        alert('Data Saved successfully');
                    }
                    else {

                        alert('Please add Correct number of wheels and doors !');
                    }
                   
                }
               
            };  
            function GetCars() {
                var requestResponse = dataService.GetAll();
                requestResponse.then(function (response) {
                    $scope.cars = response.data;
                }, function () {

                })
            };  
           
            
        }
        ]);

  
})();
