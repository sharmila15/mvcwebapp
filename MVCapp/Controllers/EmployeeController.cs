using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCapp.Models;
using BusinessLayer;

namespace MVCapp.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            List<BusinessLayer.Employee> employees = employeeBusinessLayer.Employees.ToList();
            return View(employees);
        }
        [HttpGet]
        public ActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection formCollection)
        {
            //foreach(string key in formCollection.AllKeys)
            //{
            //    Response.Write("Key= " + key + " ");
            //    Response.Write(formCollection[key]);
            //    Response.Write("<br/>");
            //}
            BusinessLayer.Employee employee = new BusinessLayer.Employee();
            employee.Name = formCollection["Name"];
            employee.Gender = formCollection["Gender"];
            employee.City = formCollection["City"];
            employee.DateOfBirth = Convert.ToDateTime(formCollection["DateOfBirth"]);

            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            employeeBusinessLayer.

            return View();
        }
        // GET: Employee

        //public ActionResult Index(int departmentId)
        //{
        //    EmployeeContext employeecontext = new EmployeeContext();
        //    List<Employee> employees = employeecontext.Employees.Where(emp => emp.DepartmentId==departmentId).ToList();

        //    return View(employees);
        //}

        //public ActionResult Details(int id)
        //{
        //    EmployeeContext employeecontext = new EmployeeContext();
        //    Employee employee= employeecontext.Employees.Single(emp => emp.EmployeeId == id);
        //    //Employee employee = new Employee()
        //    //{
        //    //    EmployeeId=20,
        //    //    Name="Sharmi",
        //    //    Gender="Female",
        //    //    City="London"
        //    //};
        //    return View(employee);
        //}

        ////// GET: Employee/Details/5
        ////public ActionResult Details(int id)
        ////{
        ////    return View();
        ////}

        ////// GET: Employee/Create
        ////public ActionResult Create()
        ////{
        ////    return View();
        ////}

        ////// POST: Employee/Create
        ////[HttpPost]
        ////public ActionResult Create(FormCollection collection)
        ////{
        ////    try
        ////    {
        ////        // TODO: Add insert logic here

        ////        return RedirectToAction("Index");
        ////    }
        ////    catch
        ////    {
        ////        return View();
        ////    }
        ////}

        ////// GET: Employee/Edit/5
        ////public ActionResult Edit(int id)
        ////{
        ////    return View();
        ////}

        ////// POST: Employee/Edit/5
        ////[HttpPost]
        ////public ActionResult Edit(int id, FormCollection collection)
        ////{
        ////    try
        ////    {
        ////        // TODO: Add update logic here

        ////        return RedirectToAction("Index");
        ////    }
        ////    catch
        ////    {
        ////        return View();
        ////    }
        ////}

        ////// GET: Employee/Delete/5
        ////public ActionResult Delete(int id)
        ////{
        ////    return View();
        ////}

        ////// POST: Employee/Delete/5
        ////[HttpPost]
        ////public ActionResult Delete(int id, FormCollection collection)
        ////{
        ////    try
        ////    {
        ////        // TODO: Add delete logic here

        ////        return RedirectToAction("Index");
        ////    }
        ////    catch
        ////    {
        ////        return View();
        ////    }
        ////}
    }
}
