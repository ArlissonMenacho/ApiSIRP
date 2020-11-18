using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteAPI.Interfaces;
using TesteAPI.Model;

namespace TesteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaController : ControllerBase
    {
        private readonly IItemAtaRepository _itemAtaRepository;
        private readonly IAtaRepository _AtaRepository;
        private readonly IItemCatalogoRepository _itemCatalogoRepository;
        public ConsultaController(IItemAtaRepository itemAtaRepository,
            IItemCatalogoRepository itemCatalogoRepository, IAtaRepository ataRepository)
        {
            _itemAtaRepository = itemAtaRepository;
            _AtaRepository = ataRepository;
            _itemCatalogoRepository = itemCatalogoRepository;
        }

        [HttpGet("{numeroDaAta}/{anoDaAta}/ItensDaAta")]
        public async Task<IActionResult> BuscarItensDaAta(int numeroDaAta, int anoDaAta)
        {
            var resultado = await _AtaRepository.buscarAtasPorNumero(numeroDaAta);
            IList<ItemAta> itemsDaAta = new List<ItemAta>();
            itemsDaAta = await _itemAtaRepository.BuscarItensDaAtaPorCodigoAta(numeroDaAta, anoDaAta);
            foreach (var item in itemsDaAta)
            {
                var resultado3 = await _itemCatalogoRepository.BuscarDescricaoItemCatalogo(item.CodigoMaterial);
                return Ok(resultado3);
            }
            return BadRequest();
        }
    }
}