using First_Asp.Net_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First_Asp.Net_Project.Controllers
{
    public class firstController : Controller
    {
        AnoopEntities db = new AnoopEntities();
        // GET: first
        public ActionResult Index()
        {
            List<emmployee> all_data = db.emmployees.ToList();
            return View(all_data);
        }
        public ActionResult doctor()
        {
            List<doctabl> all_data = db.doctabls.ToList();
            return View(all_data);
        }


        public ActionResult anoops()
        {
            List<emmployee> all_data = db.emmployees.ToList();
            return View(all_data);
        }

        public ActionResult create()
        {
          
            return View();
        }

        public ActionResult SaveData(emmployee emmployee)
        {
            db.emmployees.Add(emmployee);
            db.SaveChanges();
            return RedirectToAction("Doctor");
        }
    }
}