using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HTMLHelpers2.Models
{   
    [Table("department")]
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}