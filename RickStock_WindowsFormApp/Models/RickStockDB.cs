using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RickStock_WindowsFormApp.Models
{
    public partial class RickStockDB : DbContext
    {
        public RickStockDB()
            : base("name=RickStockDB")
        {
        }

        public DbSet<Manager> Managers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
