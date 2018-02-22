using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DevOpsPortal.Models;

namespace DevOpsPortal.Controllers
{
    public class EnvironmentController : Controller
    {
        // GET: Config
        public ActionResult Index(string name)
        {
            var environment = Settings.GetSettings().customers.First(c => c.name == name).environments.First(e => e.name == name);
            return View(environment);
        }

        // GET: Config/Details/5
        public ActionResult Details(string name)
        {
            return View();
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
        public ActionResult Edit(string name, string env)
        {
            var environment = Settings.GetSettings().customers.First(c => c.name == name).environments.First(e => e.name == name);
            return View(environment);
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
        public ActionResult Delete(string name, string env)
        {
            var environment = Settings.GetSettings().customers.First(c => c.name == name).environments.First(e => e.name == name);
            return View(environment);
        }

        // POST: Config/Delete/5
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