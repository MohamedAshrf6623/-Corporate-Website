using Microsoft.AspNetCore.Mvc;
using MVC5_Day15.Context;
using MVC5_Day15.Models;
using MVC5_Day15.ViewModels;

namespace MVC5_Day15.Controllers
{
    public class InstructoreController : Controller
    {
        TrainingContext db = new TrainingContext();

        public ActionResult UniqueName(string Name, int InstructoreId)
        {
            string name = Name;
            int id = InstructoreId;
            if (id == 0)
            {
                var inst = db.Instructores.SingleOrDefault(s => s.Name == name);
                if (inst == null)
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
                var inst = db.Instructores.SingleOrDefault(s => s.InstructoreId == id);
                if (inst.Name == name)
                {
                    return Json(true);
                }
                else
                {
                    var inst2 = db.Instructores.SingleOrDefault(s => s.Name == name);
                    if (inst2 == null)
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
            var res = db.Instructores.ToList();//model
            return View("GetAllInst", res);
        }
        public IActionResult Details(int id)
        {
            var res = db.Instructores.FirstOrDefault(i=>i.InstructoreId == id);//model
            return View(res);
        }
        //public IActionResult InstractorCourseVM(int id)
        //{
        //    var inst = db.Instructores.FirstOrDefault(i => i.InstructoreId == id);
        //    List<string> Courses = new List<string>();
        //    Courses.Add(".Net");
        //    Courses.Add("UI/UX");
        //    Courses.Add("FrontEnd");
        //    Courses.Add("Marketing");

        //    InstractorCourses IC = new InstractorCourses();
        //    IC.Message = "Instractor and Courses";
        //    IC.Color = "red";
        //    IC.Instructor = inst.Name;
        //    IC.Address = inst.Address;
        //    IC.Salary = inst.Salary;
        //    IC.courses = Courses;
        //    return View(IC);

        //}
        [HttpGet]
        public IActionResult New()
        {
            var depts = db.Departments.ToList();
            ViewBag.depts = depts;
            var crs = db.Courses.ToList();
            ViewBag.crs = crs;
            return View();
        }
        [HttpPost]
        public IActionResult Save(Instructore inst)
        {
            //if (inst.Name != null)
            if(ModelState.IsValid)
            {
                db.Instructores.Add(inst);
                db.SaveChanges();
                return RedirectToAction("GetAll", "Instructore");
            }
            else
            {
                var depts = db.Departments.ToList();
                ViewBag.depts = depts;
                var crs = db.Courses.ToList();
                ViewBag.crs = crs;
                return View("New",inst);
            }

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var depts = db.Departments.ToList();
            ViewBag.depts = depts;
            var crs = db.Courses.ToList();
            ViewBag.crs = crs;
            var res = db.Instructores.FirstOrDefault( i=>i.InstructoreId ==id);//model
            return View(res);
        }
        [HttpPost]
        public IActionResult EditSave(Instructore inst)
        {
            if (inst.Name != null)
            //if(ModelState.IsValid)
            {
                db.Instructores.Update(inst);
                db.SaveChanges();
                return RedirectToAction("GetAll", "Instructore");
            }
            else
            {
                var depts = db.Departments.ToList();
                ViewBag.depts = depts;
                var crs = db.Courses.ToList();
                ViewBag.crs = crs;
                return View("Edit",inst);
            }

        }
        public IActionResult Delete(int id)
        {
            var inst = db.Instructores.FirstOrDefault(i => i.InstructoreId == id);
            if (ModelState.IsValid)
            {
                db.Instructores.Remove(inst);
                db.SaveChanges();
            }
            return RedirectToAction("GetAll","Instructore");
          
        }

    }
}
