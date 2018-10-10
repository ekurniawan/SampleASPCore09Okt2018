using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleASPCore.DAL;

namespace SampleASPCore.Controllers
{
    public class RumahmakanController : Controller
    {
        private IRumahmakan _rumahmakan;
        public RumahmakanController(IRumahmakan rumahmakan)
        {
            _rumahmakan = rumahmakan;
        }

        // GET: Rumahmakan
        public ActionResult Index()
        {
            var results = _rumahmakan.GetRumahmakanWithJenis();
            return View(results);
        }

        public ActionResult GetAll()
        {
            var results = _rumahmakan.GetAll();
            return View(results);
        }

        // GET: Rumahmakan/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rumahmakan/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rumahmakan/Create
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

        // GET: Rumahmakan/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Rumahmakan/Edit/5
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

        // GET: Rumahmakan/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rumahmakan/Delete/5
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