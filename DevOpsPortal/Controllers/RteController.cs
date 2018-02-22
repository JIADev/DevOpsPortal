using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DevOpsPortal.Models;

namespace DevOpsPortal.Controllers
{
    public class RteController : Controller
    {
        // GET: Rte
        public ActionResult Index()
        {
            return View();
        }

        // GET: Rte/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rte/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rte/Create
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

        // GET: Rte/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Rte/Edit/5
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

        // GET: Rte/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rte/Delete/5
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