using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCValidation.Models
{
    public class ContextClass:DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}