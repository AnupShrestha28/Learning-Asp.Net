using First_Asp.Net_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            return RedirectToAction("Index");
        }

        public ActionResult Updatedata(emmployee emmployee)
        {
            db.Entry(emmployee).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            emmployee emmployee = db.emmployees.Find(id);
          //emmployee emmployee = db.emmployees.FirstOrDefault(x => x.id == id);
            return View(emmployee);
        }
        public ActionResult deletedata(int e_id)

        {
            emmployee data = db.emmployees.Find(e_id);
            db.emmployees.Remove(data);
            db.SaveChanges();
            return RedirectToAction("index");

        }

    }
}