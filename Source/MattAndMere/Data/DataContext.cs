using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MattAndMere.Entities;

namespace MattAndMere.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        
        public DbSet<Reservation> Reservations { get; set; }
    }
}