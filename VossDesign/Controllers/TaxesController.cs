using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VossDesign.Controllers
{
    public class TaxesController : Controller
    {
        // GET: Taxes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Amusement()
        {
            ViewData["Title"] = "Amusement Tax";
            return View();
        }


        public ActionResult Realproperty()
        {
            ViewData["Title"] = "Real property Tax";
            return View();
        }


        public ActionResult Business()
        {
            ViewData["Title"] = "Business, Transfers and Contrator Tax";
            return View();
        }


        public ActionResult Market()
        {
            ViewData["Title"] = "Market Business Tax";
            return View();
        }


        // GET: Taxes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Taxes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Taxes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Taxes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Taxes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Taxes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Taxes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}