using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteAPI.Model;

namespace TesteAPI.Interfaces
{
    public interface IItemAtaRepository
    {
        Task<IList<ItemAta>> BuscarItensDaAtaPorCodigoAta(int codigoDaAta, int anoDaAta);
    }
}
