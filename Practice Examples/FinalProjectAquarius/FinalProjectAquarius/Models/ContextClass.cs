using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FinalProjectAquarius.Models
{
    public class ContextClass:DbContext
    {
        public DbSet<Customer>customers { get; set; }
    }
}