using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Net_MVC_Framework.Models
{
    public class Movie
    {
        public int id { get; set; }
        public String Name { get; set; }
        public List<Auteur> Auteurs { get; set; }


    }

   


}