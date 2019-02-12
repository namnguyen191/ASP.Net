using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HTMLHelpers2.Models
{
    public class Context:DbContext
    {
        public DbSet<Department> Departments { get; set; }
    }
}