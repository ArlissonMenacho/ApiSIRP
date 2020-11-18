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
    public class ItemAtaRepository:IItemAtaRepository
    {
        private readonly ContextAPI _contextoDeDados;
        private readonly DbSet<ItemAta> _dbSet;
        public ItemAtaRepository(ContextAPI contextoDeDados)
        {
            _contextoDeDados = contextoDeDados;
            _dbSet = _contextoDeDados.Set<ItemAta>();
        }

        public async Task<IList<ItemAta>> BuscarItensDaAtaPorCodigoAta(int codigoDaAta, int anoDaAta)
        {
            return await _dbSet.Where(x => x.CodigoAta == codigoDaAta && x.Ano == anoDaAta).ToListAsync();
        }

    }
}
