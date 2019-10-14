using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VMSCarSales.Models.EF;
using VMSCarSales.Models;

namespace VMSCarSales.Models
{
    public static class StaticData
    {
        public static List<CarViewModel> CarList = new List<CarViewModel>();
        public static void Save(CarViewModel model)
        {
            model.Id = model.Id ?? new Random().Next(999999);
            CarList.Add(model);
            
        }
    }
}