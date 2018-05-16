using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Tuincentrum.Models;

namespace MVC_Tuincentrum.Services
{
    public class SoortService
    {
        public List<Soort> FindByNaam(string Naam)
        {
            using(var db = new MVCTuinCentrumEntities())
            {
                var query = from soort in db.Soorts where soort.Naam.Contains(Naam) orderby soort.Naam select soort;
                var soorten = query.ToList();
                return soorten;
            }          
        }
    }
}