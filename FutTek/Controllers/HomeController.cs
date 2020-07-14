using FutTek.Models;
using FutTek.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FutTek.Controllers
{
    public class HomeController : Controller
    {
        //laczenie z baza

        private ApplicationDbContext _context;
        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: 
        public ActionResult WszystkieZamowienia()
        {
            var ordery = _context.Orders.ToList();
            var potrawy = _context.Potrawas.ToList();

            var viewModel = new NewOrderViewModel
            {
                Potrawy = potrawy,
            };



            return View(ordery);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


    }
}