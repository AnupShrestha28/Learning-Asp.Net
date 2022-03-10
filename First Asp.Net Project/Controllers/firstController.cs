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
        MainEntities db = new MainEntities();
        // GET: first
        public ActionResult Index()
        {
            List<emmployee> all_data = db.emmployees.ToList();
            return View(all_data);
        }
       
    }
}