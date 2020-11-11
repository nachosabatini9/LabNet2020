using Practica.Entities;
using Practica3.Logic;
using Practica3.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace Practica3.MVC.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            var logic = new EmployeesLogic();
            var employees = logic.GetAll();

            List<EmployeesView> employeesViews =(from em in employees
                                                 select new EmployeesView() { Id = em.EmployeeID, FirstName = em.FirstName, LastName=em.LastName, City=em.City, Country=em.Country}).ToList();

            return View(employeesViews);
        }
        public ActionResult Insert() {
            return View();
        }
        
        [HttpPost]
        public ActionResult Insert(EmployeesView employees)
        {
            var logic = new EmployeesLogic();
            var employeeEntity = new Employees {
                FirstName = employees.FirstName,
                LastName = employees.LastName,
                City = employees.City,
                Country = employees.Country
            };
            
            logic.Insert(employeeEntity);
            return  RedirectToAction("Index");
        }
        public ActionResult Delete(int id) {
            var logic = new EmployeesLogic();
            logic.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id){
            var logic = new EmployeesLogic();
            var employee = logic.GetOne(id);
            EmployeesView employeeView = new EmployeesView()
            {   Id = employee.EmployeeID,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                City = employee.City,
                Country = employee.Country
            };
            return View(employeeView);
        }
        [HttpPost]
        public ActionResult Update(EmployeesView employees)
        {
            var logic = new EmployeesLogic();
            var employeeEntity = new Employees
            {   EmployeeID = employees.Id,
                FirstName = employees.FirstName,
                LastName = employees.LastName,
                City = employees.City,
                Country = employees.Country
            };

            logic.Update(employeeEntity);
            return RedirectToAction("Index");
        }
    }
}