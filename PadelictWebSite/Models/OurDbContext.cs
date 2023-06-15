using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PadelictWebSite.Models
{
    public class OurDbContext : DbContext
    {
        public OurDbContext() : base("PadelictConnection")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<registos>().ToTable("Registos");
            modelBuilder.Entity<Avaliacao>().ToTable("Avaliacao");
            modelBuilder.Entity<Concelhos>().ToTable("Concelhos");





            Database.SetInitializer<OurDbContext>(null);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<registos> Registos { get; set; }
        public DbSet<Concelhos> Concelhos { get; set; }
        public DbSet<Avaliacao> Avaliacao { get; set; }
        








    }
}
