using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VossDesign.Controllers
{
    public class PermitsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["Title"] = "Business Permit Application";
            return View();
        }

        public IActionResult Renewal()
        {
            ViewData["Title"] = "Business Permit Renewal";
            return View();
        }


        public IActionResult Health()
        {
            ViewData["Title"] = "Health Permit";
            return View();
        }

        public IActionResult Building()
        {
            return View();
        }
        
    }
}
