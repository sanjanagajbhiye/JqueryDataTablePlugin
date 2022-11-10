using DataTablePlugin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataTablePlugin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        employeeDBEntities db = new employeeDBEntities(); 
        public ActionResult Index()
        {
            var data = db.Employees.ToList();
            return View(data);
        }

        public ActionResult MyDataTable()
        {
            return View();
        }

        public ActionResult EmpData()
        {
            var data = db.Employees.ToList();
            return View(data);
        }
    }
}