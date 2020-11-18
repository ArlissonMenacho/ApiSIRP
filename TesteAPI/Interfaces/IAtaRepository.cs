using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteAPI.Model;

namespace TesteAPI.Interfaces
{
    public interface IAtaRepository
    {
        Task<Ata> buscarAtasPorNumero(int codDaAta);
    }
}
