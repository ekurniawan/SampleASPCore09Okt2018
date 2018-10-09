using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleASPCore.DAL;

namespace SampleASPCore.Controllers
{
    public class JenisController : Controller
    {
        private IJenis _jenis;
        public JenisController(IJenis jenis)
        {
            _jenis = jenis;
        }

        // GET: Jenis
        public ActionResult Index()
        {
            var results = _jenis.GetAll();
            return View(results);
        }

        // GET: Jenis/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Jenis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jenis/Create
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

        // GET: Jenis/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Jenis/Edit/5
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

        // GET: Jenis/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Jenis/Delete/5
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