using FutTek.Models;
using FutTek.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FutTek.Controllers
{
    public class KucharzController : Controller
    {
        //laczenie z baza

        private ApplicationDbContext _context;
        public KucharzController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Kucharz
        public ActionResult Index()
        {
            var ordery = _context.Orders.ToList();
            var potrawy = _context.Potrawas.ToList();

            var viewModel = new NewOrderViewModel
            {
                Potrawy = potrawy
            };

            ViewBag.Ordery = ordery;


            return View(viewModel);
        }

        public ActionResult Wyslij(int id)
        {
            var order = _context.Orders.SingleOrDefault(c => c.Id == id);
            if (order == null)
            {
                return HttpNotFound();
            }

            order.CzyWykonano = true;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}