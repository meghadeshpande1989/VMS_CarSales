//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VMSCarSales.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Car
    {
        public int Id { get; set; }
        public string Engine { get; set; }
        public string BodyType { get; set; }
        public string Make { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleType { get; set; }
        public Nullable<int> Doors { get; set; }
        public Nullable<int> Wheels { get; set; }
    }
}
