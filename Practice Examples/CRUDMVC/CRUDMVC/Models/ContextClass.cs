using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUDMVC.Models
{
    public class ContextClass:DbContext
    {
        public DbSet<Employee>Employees { get; set; }
    }
}