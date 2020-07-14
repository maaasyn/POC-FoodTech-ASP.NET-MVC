using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FutTek.Models;
using FutTek.ViewModels;

namespace FutTek.Controllers
{
    public class KelnerController : Controller
    {
        //laczenie z baza

        private ApplicationDbContext _context;
        public KelnerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Kelner
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

        [HttpPost]
        public ActionResult DodajZamowienie(OrderModels orderModels)
        {
            _context.Orders.Add(orderModels);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DostarczonoDoStolika(int id)
        {
            var order = _context.Orders.SingleOrDefault(c => c.Id == id);
            if (order == null)
            {
                return HttpNotFound();
            }
            order.CzyDostarczono = true;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }



}