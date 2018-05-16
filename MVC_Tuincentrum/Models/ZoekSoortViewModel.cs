using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Tuincentrum.Models
{
    public class ZoekSoortViewModel
    {
        [Display(Name = "Zoek op soortnaam")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Gelieve een zoekopdracht in te vullen")]
        public string beginNaam { get; set; }

        public List<Soort> Soorten {get; set;}
    }
}