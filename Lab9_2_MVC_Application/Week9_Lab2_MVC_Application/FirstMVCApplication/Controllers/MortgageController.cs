using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApplication.Controllers
{
    public class MortgageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPage()
        {
            ViewData["FirstName"] = "Nidhi";
            ViewData["LastName"] = "Gusain";
            return View();
        }

        public IActionResult DisplayForm()
        {
            return View();
        }
        public IActionResult ResponsePage(string firstName, string lastName, string email)
        {
            ViewData["FirstName"] = firstName;
            ViewData["LastName"] = lastName;
            ViewData["Email"] = email;
            return View();
        }

    }
}
