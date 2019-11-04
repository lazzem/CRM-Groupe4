using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenWeb.Models
{
    public class ProduitModel
    {
        public string Libelle { get; set; }

        public string Nom { get; set; }
        public float Prix { get; set; }
        public int Quantitee { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }

        // [ForeignKey("Category")]
        public int? Id_categorie { get; set; }

        public IEnumerable<SelectListItem> Boutiques { get; set; }

        // [ForeignKey("Category")]
        public int? Id_boutique { get; set; }

    }
}