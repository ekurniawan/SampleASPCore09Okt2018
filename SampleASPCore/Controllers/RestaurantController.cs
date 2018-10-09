using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleASPCore.Models;

namespace SampleASPCore.Controllers
{
    public class RestaurantController : Controller
    {
        static List<Restaurant> listRestaurant = new List<Restaurant>
        {
            new Restaurant {Id=1,Nama="Sate Klathak Pak Pong",Alamat="Pasar Jejeran"},
            new Restaurant {Id=2,Nama="Bakmi Jawa Mbah Hadi",Alamat="Terminal jombor"}
        };

        // GET: Restaurant
        public ActionResult Index()
        {
            if (TempData["Keterangan"] != null)
            {
                ViewBag.Keterangan = TempData["Keterangan"].ToString();
            }
            else
            {
                ViewBag.Keterangan = "";
            }
            return View(listRestaurant);
        }

        // GET: Restaurant/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Restaurant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Restaurant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurant restaurant)
        {
            try
            {
                listRestaurant.Add(restaurant);
                TempData["Keterangan"] = $"<div class='alert alert-success'>Data Restaurant {restaurant.Nama} berhasil ditambah !</div>";
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Error = $"<div class='alert alert-danger'>Pesan Kesalahan {ex.Message}</div>";
                return View();
            }
        }

        // GET: Restaurant/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Restaurant/Edit/5
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

        // GET: Restaurant/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Restaurant/Delete/5
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