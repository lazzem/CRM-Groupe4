using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenWeb.Models
{
    public class BoutiqueModel
    {
       
        public string Nom { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        // public string adresse { get; set; }
        public IEnumerable<SelectListItem> Villes { get; set; }
        public string Zone { get; set; }
        public string Service { get; set; }
        public string Heure_ouverture { get; set; }
        public string Heure_fermeture { get; set; }
        public float Ascisse_X { get; set; }
        public float Ordonné_Y { get; set; }

        public int? Id_ville { get; set; }

    }
}