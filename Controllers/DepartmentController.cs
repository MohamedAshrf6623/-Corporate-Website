using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC5_Day15.Context;
using MVC5_Day15.Models;
using MVC5_Day15.ViewModels;

namespace MVC5_Day15.Controllers
{
    public class DepartmentController : Controller
    {
        TrainingContext db = new TrainingContext();

        public IActionResult Index()
        {
            return View();
        }
        public ActionResult UniqueName(string Name, int DepartmentId)
        {
            string name = Name;
            int id = DepartmentId;
            if (id == 0)
            {
                var dept = db.Departments.SingleOrDefault(s => s.Name == name);
                if (dept == null)
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
                var dept = db.Departments.SingleOrDefault(s => s.DepartmentId == id);
                if (dept.Name == name)
                {
                    return Json(true);
                }
                else
                {
                    var dept2 = db.Departments.SingleOrDefault(s => s.Name == name);
                    if (dept2 == null)
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
            var res = db.Departments.ToList();//model
            return View("GetAll", res);
        }
        public IActionResult Details(int id)
        {
            var res = db.Departments.Include(s=>s.Students).FirstOrDefault(D => D.DepartmentId == id);//model
            return View(res);
        }
        //public IActionResult DeptWithBranches(int id)
        //{
        //    var res = db.Departments.Include(s => s.Students).FirstOrDefault(D => D.DepartmentId == id);//model

        //    List<string> Branches = new List<string>();
        //    Branches.Add("Ismailia");
        //    Branches.Add("Cairo");
        //    Branches.Add("Aswan");
        //    Branches.Add("Alex");
        //    ViewData["Brc"] = Branches;
        //    ViewData["Msg"] = "Hello ViewData";
        //    ViewData["Color"] = "Red";
        //    ViewBag.Msg = "Hello ViewBag";
        //    return View(res);
        //}
        //public IActionResult DeptWithBranchesVM(int id)
        //{
        //    var res = db.Departments.FirstOrDefault(D => D.DepartmentId == id);//model

        //    List<string> Branches = new List<string>();
        //    Branches.Add("Ismailia");
        //    Branches.Add("Cairo");
        //    Branches.Add("Aswan");
        //    Branches.Add("Alex");
        //    Deptmsgcolorbranches DeptVM = new Deptmsgcolorbranches();
        //    DeptVM.Department = res.Name;
        //    DeptVM.Manager = res.Manager;
        //    DeptVM.Message = "Hello From View Model !";
        //    DeptVM.Color = "Blue";
           
        //    DeptVM.Branches = Branches;
        //    return View(DeptVM);
        //}
        public IActionResult New()
        {
       
            return View();
        }
        [HttpPost]
        public IActionResult Save(Department dept)
        {
            //if (dept.Name != null)
            if(ModelState.IsValid)
            {
                db.Departments.Add(dept);
                db.SaveChanges();
                return RedirectToAction("GetAll", "Department");
            }
            else
            {
                return View("New",dept);
            }
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var res = db.Departments.FirstOrDefault(d=>d.DepartmentId== id);//model
            return View(res);
        }
        [HttpPost]
        public IActionResult EditSave(Department dept)
        {
            if (dept.Name != null)
            //if(ModelState.IsValid)
            {
                db.Departments.Update(dept);
                db.SaveChanges();
                return RedirectToAction("GetAll", "Department");
            }
            else
            {
                return View("Edit",dept);
            }

        }
        public IActionResult Delete(int id)
        {
            var dept = db.Departments.FirstOrDefault(d=>d.DepartmentId == id);
            //if (dept != null)
            if(ModelState.IsValid)
            {
                db.Departments.Remove(dept);
                db.SaveChanges();
            }
                return RedirectToAction("GetAll", "Department");


        }
    }
}
