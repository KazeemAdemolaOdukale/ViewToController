using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewToController.Models;

namespace ViewToController.Controllers
{
    public class StudentController : Controller
    {
        StudentDbContext db = new StudentDbContext();

        // GET: Student
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Student student)
        {
            if (ModelState.IsValid)
            {
                List<Student> studs = db.Students.Where(y => y.Id == student.Id).ToList();
                if (studs.Count > 0)
                {
                    ViewBag.Duplicate = "Record already exist";
                }
                else
                {
                    db.Students.Add(student);
                    db.SaveChanges();
                    ViewBag.SuccessMessage = "Record successfully added";
                }
            }
            return View();
        }
    }
}