using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FutTek.Models;

namespace FutTek.ViewModels
{
    public class NewOrderViewModel
    {
        public IEnumerable<Potrawa> Potrawy { get; set; }
        public OrderModels OrderModels { get; set; }
    }
}