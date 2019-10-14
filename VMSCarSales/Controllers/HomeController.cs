using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VMSCarSales.Models;
using VMSCarSales.Models.EF;

namespace VMSCarSales.Controllers
{
    public class HomeController : Controller
    {
        private CarSalesDbEntities db = null;
        public HomeController()
        {
            db = new CarSalesDbEntities();
        }
        // GET: Car
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public JsonResult AddCar(Car model)
        {
            db.Cars.Add(model);
            db.SaveChanges();
            string message = "Car has been saved successfully!";
            return Json(message, JsonRequestBehavior.AllowGet);
        }
     
        [HttpGet]
        public JsonResult GetAllCars()
        {
            var cars = db.Cars.ToList();
            return Json(cars, JsonRequestBehavior.AllowGet);
        }
    }
}