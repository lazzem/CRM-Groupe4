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
    public class Complaint
    {
        [Key]
        public string ComplaintID { get; set; }
        public DateTime Creation_date { get; set; }
        public DateTime Processing_date { get; set; }
        public DateTime Clossing_date { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        [ForeignKey("IdUser")]
        public virtual User user { get; set; }

        public int? IdUser { get; set; }

    }
}
