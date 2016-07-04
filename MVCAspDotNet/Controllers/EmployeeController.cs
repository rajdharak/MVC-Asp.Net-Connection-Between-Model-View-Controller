using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAspDotNet.Models;

namespace MVCAspDotNet.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details()
        {
            Employee emp = new Employee()
            {
                EmployeeID=101,
                Name= "Dharak",
                City="Vadodara"
            };
            return View(emp);
        }
    }
}