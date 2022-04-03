using First_Asp.Net_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First_Asp.Net_Project.Controllers
{
    public class secondController : Controller
    {
        AnoopEntities db = new AnoopEntities();
        // GET: second
        public ActionResult Index2()
        {
            List<teacher> all_data = db.teachers.ToList();
            return View(all_data);
           
        }

        public ActionResult create()
        {

            return View();
        }
        public ActionResult SaveData(teacher teacher)
        {
            db.teachers.Add(teacher);
            db.SaveChanges();
            return RedirectToAction("Index2");
        }

        public ActionResult Updatedata(teacher teacher)
        {
            db.Entry(teacher).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index2");
        }
        public ActionResult Edit(int id)
        {
            teacher teacher = db.teachers.Find(id);
            //emmployee emmployee = db.emmployees.FirstOrDefault(x => x.id == id);
            return View(teacher);
        }
        public ActionResult deletedata(int Teacher_id)

        {
            teacher data = db.teachers.Find(Teacher_id);
            db.teachers.Remove(data);
            db.SaveChanges();
            return RedirectToAction("index2");

        }
    }
}