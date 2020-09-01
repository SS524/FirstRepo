using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
   
    public class StudentController : Controller
    {
        // GET: Student
        StudentDbContext db;
        public StudentController()
        {
            db = new StudentDbContext();
        }

        public ActionResult Index()
        {
            List<Student> ls = db.Students.ToList();

            return View(ls);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student obj)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(obj);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public ActionResult Edit(int id)
        {
            Student obj = db.Students.Find(id);
            return View(obj);
        }
        [HttpPost]
        public ActionResult Edit(Student obj,int id)
        {
            Student record = db.Students.Find(id);
            if (ModelState.IsValid)
            {
                record.Name = obj.Name;
                record.Email = obj.Email;
                record.Age = obj.Age;
                record.Gender = obj.Gender;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public ActionResult Delete(int id)
        {
            Student obj = db.Students.Find(id);
            return View(obj);
        }
        [HttpPost]
        public ActionResult Delete(int id,Student st)
        {
            Student obj = db.Students.Find(id);
            db.Students.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}