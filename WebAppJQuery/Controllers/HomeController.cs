using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppJQuery.Models;
using Newtonsoft.Json;

namespace WebAppJQuery.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //public JsonResult GetStudent()
        //{
            //Student std = new Student()
            //{
            //    Id = 1,
            //    Name = "Aniket",
            //    Email = "Aniket@gmail.com"

            //};
            //var JsonData = JsonConvert.SerializeObject(std);

            //return Json(JsonData, JsonRequestBehavior.AllowGet);
        //}

        [HttpPost]
        public JsonResult AddStudent(Student std) 
        {
            return Json("true", JsonRequestBehavior.AllowGet);
        }
    }
}