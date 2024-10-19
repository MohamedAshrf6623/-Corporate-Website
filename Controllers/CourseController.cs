using Microsoft.AspNetCore.Mvc;
using MVC5_Day15.Context;
using MVC5_Day15.Models;

namespace MVC5_Day15.Controllers
{
    public class CourseController: Controller
    {
        TrainingContext db = new TrainingContext();
        public ActionResult UniqueName(string Name, int CourseId)
        {
            string name = Name;
            int id = CourseId;
            if (id == 0)
            {
                var Crs = db.Courses.SingleOrDefault(s => s.Name == name);
                if (Crs == null)
                {
                    return Json(true);
                }
                else
                {
                    return Json(false);
                }
            }
            else
            {
                var Crs = db.Courses.SingleOrDefault(s => s.CourseId == id);
                if (Crs.Name == name)
                {
                    return Json(true);
                }
                else
                {
                    var Crs2 = db.Courses.SingleOrDefault(s => s.Name == name);
                    if (Crs2 == null)
                    {
                        return Json(true);
                    }
                    else
                    {
                        return Json(false);
                    }
                }

            }
        }
        public ActionResult GetAll()
        {
            var res = db.Courses.ToList();//model
            return View("GetAll", res);
        }
        public IActionResult Details(int id)
        {
            var res = db.Courses.FirstOrDefault(c=>c.CourseId == id);//model
            return View(res);
        }
        [HttpGet]
        public IActionResult New()
        {
   
            var dept = db.Departments.ToList();
            ViewBag.dept = dept;
            return View();
        }
        [HttpPost]
        public IActionResult Save(Course crs)
        {
            if(crs.Name != null)
            //if(ModelState.IsValid)
            {
                db.Courses.Add(crs);
                db.SaveChanges();
                return RedirectToAction("GetAll", "Course");
            }
            else
            {
                var dept = db.Departments.ToList();
                ViewBag.dept = dept;
                return View("New",crs);
            }
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var dept = db.Departments.ToList();
            ViewBag.dept = dept;
            var res = db.Courses.FirstOrDefault(c=>c.CourseId == id);//model
            return View(res);
        }
        [HttpPost]
        public IActionResult EditSave(Course crs)
        {
            //if (crs.Name != null)
            if(ModelState.IsValid)
            {
                db.Courses.Update(crs);
                db.SaveChanges();
                return RedirectToAction("GetAll", "Course");
            }
            else
            {
                var dept = db.Departments.ToList();
                ViewBag.dept = dept;
                return View(crs);
            }

        }
        public IActionResult Delete(int id)
        {
            var crs = db.Courses.FirstOrDefault(c=>c.CourseId == id);
            //if (crs != null)
            if(ModelState.IsValid)
            {
                db.Courses.Remove(crs);
                db.SaveChanges();
            }
            return RedirectToAction("GetAll", "Course");


        }
    }
}
