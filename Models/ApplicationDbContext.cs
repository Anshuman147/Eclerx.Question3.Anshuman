using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Eclerx.Question3.Anshuman.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base("Connection")
        {

        }
        public DbSet<Supplier> supplier { get; set; }
    }
}