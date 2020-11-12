using Errores;
using Lab.Capas.MVC.Models;
using Lab.Entities;
using Lab.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Capas.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var employeesLogic = new EmployeesLogic();
            var employees = employeesLogic.GetAll();

            List<EmployeeView> eView = (from e in employees 
                                        select new EmployeeView() 
                                        { 
                                            EmployeeId = e.EmployeeID, 
                                            LastName = e.LastName, 
                                            FirstName = e.FirstName, 
                                            Title = e.Title, 
                                            Address = e.Address, 
                                            City = e.City 
                                        }).ToList();

            return View(eView);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeView e)
        {
            try
            {
                EmployeesLogic employeesLogic = new EmployeesLogic();

                Employees employeeEntity = new Employees()
                {
                    EmployeeID = e.EmployeeId,
                    LastName = e.LastName,
                    FirstName = e.FirstName,
                    Title = e.Title,
                    Address = e.Address,
                    City = e.City
                };

                if (employeeEntity.EmployeeID==0)
                {
                    employeesLogic.Create(employeeEntity);
                }
                else
                {
                    employeesLogic.Update(employeeEntity);
                }
                return RedirectToAction("index");
            }
            catch(SaveLogsException)
            {
                return RedirectToAction("error");
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                EmployeesLogic employeesLogic = new EmployeesLogic();
                Employees e = employeesLogic.GetOne(id);
                employeesLogic.Delete(e);
                return RedirectToAction("index");
            }
            catch(SaveLogsException)
            {
                return RedirectToAction("error");
            }
        }

        public ActionResult Update(EmployeeView employeeView)
        {
            try
            {
                EmployeesLogic employeesLogic = new EmployeesLogic();

                var employee = employeesLogic.GetOne(employeeView.EmployeeId);

                if (employeesLogic.GetId(employee) == employeeView.EmployeeId)
                {
                    return View("create", employeeView);
                }

                return View("error");
            }
            catch (SaveLogsException)
            {
                return RedirectToAction("error");
            }
        }
        /*
        public ActionResult Update(int id)
        {
            try
            {
                EmployeesLogic employeesLogic = new EmployeesLogic();
        
                var employees = employeesLogic.GetAll();

                // entiendo que esta forma no seria la ideal pero rompia
                List<EmployeeView> eView = (from e in employees
                                            select new EmployeeView()
                                            {
                                                EmployeeId = e.EmployeeID,
                                                LastName = e.LastName,
                                                FirstName = e.FirstName,
                                                Title = e.Title,
                                                Address = e.Address,
                                                City = e.City
                                            }).ToList();

                foreach (var e in eView)
                {
                    if (e.EmployeeId == id)
                    {
                        return View("create", e);
                    }
                }
                return null;
            }
            catch (SaveLogsException)
            {
                return RedirectToAction("error");
            }
        }*/
        public ActionResult Error()
        {
            return View();
        }
    }
}