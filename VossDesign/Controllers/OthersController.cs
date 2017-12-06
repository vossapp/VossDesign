using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VossDesign.Controllers
{
    public class OthersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sealing()
        {
            ViewData["Title"] = "Sealing of Weights & Measurement";
            return View();
        }
        public IActionResult Retirement()
        {
            ViewData["Title"] = "Business Retirement";
            return View();
        }
    }
}