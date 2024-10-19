using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC5_Day15.Context;
using MVC5_Day15.Models;
using System.Net.Security;

namespace MVC5_Day15.Controllers
{
    public class StudentController : Controller
    {
        TrainingContext db = new TrainingContext();
        public ContentResult First()
        {
            ContentResult res = new ContentResult();
            res.Content = "Hello";
            return res;
            
        }
        public ActionResult UniqueName(string Name ,int SSN)
        {
            string name = Name;
            int id = SSN;
            if (id == 0)
            {
                var std = db.Students.SingleOrDefault(s => s.Name == name);
                if (std == null)
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
                var std = db.Students.SingleOrDefault(s => s.SSN == id);
                if (std.Name == name)
                { 
                    return Json(true);
                }
                else
                {
                    var std2 = db.Students.SingleOrDefault(s => s.Name == name);
                    if (std2 == null)
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
            var res = db.Students.ToList();//model
            return View("GetAll",res);
        }
        public IActionResult Details(int id)
        {
            var res = db.Students.FirstOrDefault(s=>s.SSN == id);//model
            return View(res);
        }
        [HttpGet]
        public IActionResult New()
        {
            var depts = db.Departments.ToList();
            ViewBag.depts = depts;
            return View();
        }
        [HttpPost]
        public IActionResult Save(Student std)
        {
            //if (std.Name != null )
            if(ModelState.IsValid)
            {
                db.Students.Add(std);
                db.SaveChanges();
                return RedirectToAction("GetAll", "Student");
            }
            else
            {
                var depts = db.Departments.ToList();
                ViewBag.depts = depts;
                return View("New",std);
            }
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var dept = db.Departments.ToList();
            ViewBag.dept = dept;
            var res = db.Students.FirstOrDefault(s=>s.SSN == id);//model
            return View(res);
        }
        [HttpPost]
        public IActionResult EditSave(Student std)
        {
            //if (std.Name != null)

            if (ModelState.IsValid)
            {
                db.Students.Update(std);
                db.SaveChanges();
                return RedirectToAction("GetAll", "Student");
            }
            else
            {
                var dept = db.Departments.ToList();
                ViewBag.dept = dept;
                return View("Edit", std);
            }

        }
        public IActionResult Delete(int id)
        {
            var std = db.Students.FirstOrDefault(s=>s.SSN == id);
            //if (std != null)
            if(ModelState.IsValid) 
            {
                db.Students.Remove(std);
                db.SaveChanges();
            }
                return RedirectToAction("GetAll", "Student");
            

        }
    }
}
