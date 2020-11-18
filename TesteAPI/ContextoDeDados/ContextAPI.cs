using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteAPI.Model;

namespace TesteAPI.ContextoDeDados
{
    public class ContextAPI : DbContext
    {
        public ContextAPI(DbContextOptions<ContextAPI> options) : base(options)
        {

        }
        public DbSet<Ata> Atas { get; set; }
        public DbSet<ItemAta> ItemsAta { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemAta>()
                .HasNoKey();
        }
    }
}
