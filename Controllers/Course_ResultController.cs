using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using MVC5_Day15.Context;
using MVC5_Day15.Models;

namespace MVC5_Day15.Controllers
{
    public class Course_ResultController : Controller
    {
        TrainingContext db = new TrainingContext();
        public IActionResult DegreeLimit(int D)
        {
            if (D >= 0 && D <= 300)
            {
                return Json(true);
            }
            return Json(false);
        }
        public ActionResult GetAll()
        {
            var res = db.Course_Results.ToList();//model
            return View("GetAll", res);
        }
        public IActionResult Details(int id)
        {
            var res = db.Course_Results.FirstOrDefault(c=>c.Course_ResultId == id);//model
            return View(res);
        }
        [HttpGet]
        public IActionResult New()
        {

            var Crs = db.Courses.ToList();
            ViewBag.Crs = Crs;
            var std = db.Students.ToList();
            ViewBag.std = std;
            return View();
        }
        [HttpPost]
        public IActionResult Save(Course_Result crs)
        {
            //if (crs.Degree != null)
            if(ModelState.IsValid)
            {
                db.Course_Results.Add(crs);
                db.SaveChanges();
                return RedirectToAction("GetAll", "Course_Result");
            }
            else
            {
                var Crs = db.Courses.ToList();
                ViewBag.Crs = Crs;
                var std = db.Students.ToList();
                ViewBag.std = std;
                return View("New",crs);
            }
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var crsresult = db.Course_Results.FirstOrDefault(c => c.Course_ResultId == id);
            var Crs = db.Courses.ToList();
            ViewBag.Crs = Crs;
            var std = db.Students.ToList();
            ViewBag.std = std;
         
            ViewBag.CourseId = crsresult.CourseId;
            ViewBag.SSN = crsresult.SSN;
            return View(crsresult);
        }
        [HttpPost]
        public IActionResult EditSave(Course_Result crs)
        {
            //if (crs.Degree != null)
            if(ModelState.IsValid)
            {
                db.Course_Results.Update(crs);
                db.SaveChanges();
                return RedirectToAction("GetAll", "Course_Result");
            }
            else
            {
              
                return View("Edit",crs);
            }

        }
        public IActionResult Delete(int id)
        {
            var crs = db.Course_Results.FirstOrDefault(c => c.Course_ResultId == id);
            //if (crs != null)
            if(ModelState.IsValid) 
            {
                db.Course_Results.Remove(crs);
                db.SaveChanges();
            }
            return RedirectToAction("GetAll", "Course_Result");


        }
    }
}
