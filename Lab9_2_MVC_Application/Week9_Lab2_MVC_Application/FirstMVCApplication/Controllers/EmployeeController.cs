using FirstMVCApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApplication.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EmployeeForm()
        {
            ViewData["Message"] = "";
            return View();
        }
        [HttpPost]
        public IActionResult Thankyou(Employee employee)
        {
            if (employee.FirstName == null)
            {
                ViewData["Message"] = "Please fill in all fields.";
                return View("EmployeeForm");
            }
            else if (employee.LastName == null)
            {
                ViewData["Message"] = "Please fill in all fields.";
                return View("EmployeeForm");
            }
            else if (employee.Email == null)
            {
                ViewData["Message"] = "Please fill in all fields.";
                return View("EmployeeForm");
            }
            else if (employee.Password == null)
            {
                ViewData["Message"] = "Please fill in all fields.";
                return View("EmployeeForm");
            }
            else
            {
                return View(employee);
            }
        }
    }
}
