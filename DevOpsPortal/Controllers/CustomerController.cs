using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevOpsPortal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DevOpsPortal.Controllers
{
    public class CustomerController : Controller
    {
          


        // GET: Config
        public ActionResult Index()
        {
            var customers = Settings.GetSettings().customers;
            return View(customers);
        }

        // GET: Config/Details/5
        public ActionResult Details(string name)
        {
            var customer = Settings.GetSettings().customers.First(c => c.name == name);
            var environment = Settings.GetSettings().customers.First(c => c.name == name).environments;
            return View(customer);
        }

        // GET: Config/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Config/Create
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

        // GET: Config/Edit/5
        public ActionResult Edit(string name)
        {
            var customer = Settings.GetSettings().customers.First(c => c.name == name);
            return View(customer);
        }

        // POST: Config/Edit/5
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

        // GET: Config/Delete/5
        public ActionResult Delete(string name)
        {
            var customer = Settings.GetSettings().customers.First(c => c.name == name);
            return View(customer);
        }

        // POST: Config/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string name, IFormCollection collection)
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