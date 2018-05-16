using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MVC_Tuincentrum.Models
{
    public class PlantProperties
    {
        [Range(0, 1000)]
        [HiddenInput()]
        public decimal VerkoopPrijs { get; set; }

        [ScaffoldColumn(false)]
        public string Kleur { get; set; }

        [ScaffoldColumn(false)]
        public int Levnr { get; set; }

        [ScaffoldColumn(false)]
        public Leverancier Leverancier { get; set; }
    }
}