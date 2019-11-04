using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Avis
    {
        [Key]
        public int IdView { get; set; }

        public DateTime Date { get; set; }
        public string Description { get; set; }

        /* [ForeignKey("ComplaintID")]
         public virtual Complaint complaint { get; set; }

         public int? ComplaintID { get; set; }*/

    }
}
