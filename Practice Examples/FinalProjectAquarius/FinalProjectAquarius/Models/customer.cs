using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalProjectAquarius.Models
{
    [Table("customer")]
    public class Customer
    {
        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string address { get; set; }
        public string phoneNo { get; set; }
        public string email { get; set; }
        public string passwrd { get; set; }
    }
}