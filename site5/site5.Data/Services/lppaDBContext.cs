using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using site5.site5.Entities.Models;


namespace site5.site5.Data.Services
{
    public class lppaDBContext:DbContext
    {
        public DbSet<Productos> Products { get; set; }

        public lppaDBContext() : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}