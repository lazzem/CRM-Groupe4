using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Offre
    {
        [Key]
        public int IdOffer { get; set; }
        public virtual Produit Products { get; set; }
        public int? IdProduit { get; set; }
        public String Image { get; set; }
        public String Titee { get; set; }
        public String Description { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }

    }
}
