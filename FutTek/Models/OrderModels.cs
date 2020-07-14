using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FutTek.Models
{
    public class OrderModels
    {
        public int Id { get; set; }
        public Potrawa Potrawa { get; set; }

        [Display(Name = "Rodzaj potrawy")]
        public byte PotrawaId { get; set; }
        [Display(Name = "Numer Stolika")]
        public byte NumerStolika { get; set; }
        public bool CzyWykonano { get; set; } = false;
        public bool CzyDostarczono { get; set; } = false;
    }
}