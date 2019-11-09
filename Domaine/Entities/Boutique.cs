using Domain.Entities;
using Domaine.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Boutique
    {
        [Key]
        public int Id_boutique { get; set; }
        public string Nom { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        // public string adresse { get; set; }

        [ForeignKey("Id_ville")]
        public virtual Ville Ville { get; set; }
        // [ForeignKey("Boutique")]
        public int? Id_ville { get; set; }
        public string Zone { get; set; }
        public string Service { get; set; }
 
        public float Ascisse_X { get; set; }
        public float Ordonné_Y { get; set; }

        


        public virtual ICollection<Produit> Produits { get; set; }


    }
}
