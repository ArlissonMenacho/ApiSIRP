using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteAPI.Model;

namespace TesteAPI.ContextoDeDados
{
    public class ContextCatmas : DbContext
    {
        public ContextCatmas(DbContextOptions<ContextCatmas> options) : base(options)
        {

        }
        public DbSet<ItemCatalogo> ItemsCatalogo { get; set; }
    }
}
