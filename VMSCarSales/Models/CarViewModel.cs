using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VMSCarSales.Models
{
    public class CarViewModel
    {
        public int? Id { get; set; }
        public string Engine { get; set; }
        public string BodyType { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string VehicleType { get; set; }
        public int Doors { get; set; }
        public int Wheels { get; set; }
    }
}