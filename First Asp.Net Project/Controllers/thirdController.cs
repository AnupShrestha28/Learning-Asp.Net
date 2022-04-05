using First_Asp.Net_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First_Asp.Net_Project.Controllers
{
    public class thirdController : Controller
    {
        AnoopEntities db = new AnoopEntities();
        // GET: third
        public ActionResult Index3()
        {
            List<employee_salary_details> all_data = db.employee_salary_details.ToList();
            return View(all_data);
        }
        public ActionResult create()
        {
            var emplist = db.emmployees.ToList();
            //viewbag empList = emplist;
            ViewBag.employeeList = new SelectList(emplist, "eid", "ename");
            return View();
        }
        
        public ActionResult SaveData(employee_salary_details employee_Salary_Details)
        {
            db.employee_salary_details.Add(employee_Salary_Details);
            db.SaveChanges();
            return RedirectToAction("Index3");
        }
        public ActionResult Updatedata(employee_salary_details employee_Salary_Details)
        {
            db.Entry(employee_Salary_Details).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index3");
        }
        public ActionResult Edit(int id)
        {
            var emplist = db.emmployees.ToList();
            //viewbag empList = emplist;
            ViewBag.employeeList = new SelectList(emplist, "eid", "ename");
            employee_salary_details employee_Salary_Details = db.employee_salary_details.Find(id);
            //emmployee emmployee = db.emmployees.FirstOrDefault(x => x.id == id);
            return View(employee_Salary_Details);

        }
        public ActionResult deletedata(int id)

        {
            employee_salary_details data = db.employee_salary_details.Find(id);
            db.employee_salary_details.Remove(data);
            db.SaveChanges();
            return RedirectToAction("index3");

        }

    }
}