using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteAPI.ContextoDeDados;
using TesteAPI.Interfaces;
using TesteAPI.Model;

namespace TesteAPI.Repository
{
    public class ItemCatalogoRepository:IItemCatalogoRepository
    {
        private readonly ContextCatmas _contextoDeDados;
        private readonly DbSet<ItemCatalogo> _dbSet;
        public ItemCatalogoRepository(ContextCatmas contextoDeDados)
        {
            _contextoDeDados = contextoDeDados;
            _dbSet = _contextoDeDados.Set<ItemCatalogo>();
        }
        public async Task<ItemCatalogo> BuscarDescricaoItemCatalogo(long NumeroSequencialDoItem)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Sequencial == NumeroSequencialDoItem); 
        }
    }
}
