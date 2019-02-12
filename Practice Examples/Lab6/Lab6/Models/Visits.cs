using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lab6.Models
{
    [Table("Visits")]
    public class Visits
    {
        public int Id { get; set; }
        public int DocId { get; set; }
        public int PaId { get; set; }
        public DateTime Date { get; set; }
        public string Complaint { get; set; }
    }
}