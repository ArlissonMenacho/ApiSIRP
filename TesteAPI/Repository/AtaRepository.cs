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
    public class AtaRepository :IAtaRepository
    {
        private readonly ContextAPI _contextoDeDados;
        private readonly DbSet<Ata> _dbSet;
        public AtaRepository(ContextAPI contextoDeDados)
        {
            _contextoDeDados = contextoDeDados;
            _dbSet = _contextoDeDados.Set<Ata>();
        }

        public async Task<Ata> buscarAtasPorNumero(int codDaAta)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.CodigoAta == codDaAta);
        }

    }
}
