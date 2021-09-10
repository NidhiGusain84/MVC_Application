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
            
            return View();
        }
        public IActionResult Thankyou(Employee employee)
        {
            return View(employee);
        }
    }
}
