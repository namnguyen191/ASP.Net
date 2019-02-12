using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lab6.Models
{
    [Table("Doctor")]
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Office { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }       
    }
}