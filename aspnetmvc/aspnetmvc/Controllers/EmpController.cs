using aspnetmvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnetmvc.Controllers
{
    public class EmpController : Controller
    {
        [NonAction]
        public List<Employee> GetEmployees()
        {
            var emp = new List<Employee>();
            emp.Add(new Employee { EmpCode = 1, Name = "AAAA", Age = 25, Salary = 25000 });
            emp.Add(new Employee { EmpCode = 2, Name = "BBBB", Age = 24, Salary = 25000 });
            emp.Add(new Employee { EmpCode = 3, Name = "CCCC", Age = 26, Salary = 25000 });
            emp.Add(new Employee { EmpCode = 4, Name = "DDDD", Age = 24, Salary = 25000 });

            return emp;
        }

        // GET: Emp
        public ActionResult EmpList()
        {
            return View(GetEmployees());
        }

        // GET: Emp/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Emp/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emp/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Emp/Edit/5
        public ActionResult EmpEdit(int id)
        {
            return View();
        }

        // POST: Emp/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Emp/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Emp/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
