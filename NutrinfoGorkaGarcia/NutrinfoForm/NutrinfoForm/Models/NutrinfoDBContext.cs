using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace NutrinfoForm.Models
{
    internal class NutrinfoDBContext : DbContext
    { 
        public NutrinfoDBContext() : base(nameOrConnectionString: "NutrinfoDBContext")
        { }
        public DbSet<Elikagaia> Elikagaia { get; set; }
        public DbSet<Informazioa> Informazioa { get; set; }
        public DbSet<Osagaia> Osagaia { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
