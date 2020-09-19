using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ao188116_MIS4200.Models;

namespace ao188116_MIS4200.DAL
{
    public class ao188116_MIS4200Context : DbContext
    {
        public ao188116_MIS4200Context() : base ("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ao188116_MIS4200Context, ao188116_MIS4200.Migrations.MISContext.Configuration>("DefaultConnection")) ;
        }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Vet> Vets { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}