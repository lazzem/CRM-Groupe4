using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine.Entities
{
    public class Ville
    {
        [Key]
        public int Id_ville { get; set; }
        public String Ville_nom { get; set; }
    }
}
