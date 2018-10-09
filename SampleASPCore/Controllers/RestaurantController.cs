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
            var result = GetRestaurantById(id);
            return View(result);
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
            //var result = listRestaurant.Where(r => r.Id == id).SingleOrDefault();
            var result = GetRestaurantById(id);
            if (result == null)
                throw new Exception("Data tidak ditemukan");

            return View(result);
        }

        public Restaurant GetRestaurantById(int id)
        {
            var result = (from r in listRestaurant where r.Id == id select r).SingleOrDefault();
            return result;
        }

        // POST: Restaurant/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Restaurant restaurant)
        {
            try
            {
                var result = GetRestaurantById(restaurant.Id);
                result.Nama = restaurant.Nama;
                result.Alamat = restaurant.Alamat;

                TempData["Keterangan"] = $"<div class='alert alert-success'>Data Restaurant {restaurant.Nama} berhasil diedit !</div>";
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Error = $"<div class='alert alert-danger'>Pesan Kesalahan {ex.Message}</div>";
                return View();
            }
        }

        // GET: Restaurant/Delete/5
        public ActionResult Delete(int id)
        {
            var result = GetRestaurantById(id);
            return View(result);
        }

        // POST: Restaurant/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeletePost(int Id)
        {
            try
            {
                var result = GetRestaurantById(Id);
                listRestaurant.Remove(result);

                TempData["Keterangan"] = $"<div class='alert alert-success'>Data Restaurant berhasil didelete !</div>";
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Error = $"<div class='alert alert-danger'>Pesan Kesalahan {ex.Message}</div>";
                return View();
            }
        }
    }
}