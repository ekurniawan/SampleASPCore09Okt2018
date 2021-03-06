﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleASPCore.DAL;
using SampleASPCore.Models;

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
            var result = _jenis.GetById(id.ToString());
            return View(result);
        }

        // GET: Jenis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jenis/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Jenis jenis)
        {
            try
            {
                _jenis.Create(jenis);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Error = $"Pesan kesalahan: {ex.Message}";
                return View();
            }
        }

        // GET: Jenis/Edit/5
        public ActionResult Edit(int id)
        {
            var result = _jenis.GetById(id.ToString());
            return View(result);
        }

        // POST: Jenis/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Jenis jenis)
        {
            try
            {
                _jenis.Edit(jenis);
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
            var result = _jenis.GetById(id.ToString());
            return View(result);
        }

        // POST: Jenis/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id)
        {
            try
            {
                _jenis.Delete(id.ToString());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}