using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lab6.Models
{
    [Table("Patient")]
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Dob { get; set; }
        public int DocId { get; set; }
    }
}