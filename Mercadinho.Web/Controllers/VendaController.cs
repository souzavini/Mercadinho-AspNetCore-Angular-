using Mercadinho.Dominio.Contratos;
using Mercadinho.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mercadinho.web.Controllers
{
    [Route("api/[Controller]")]
    public class VendaController : Controller
    {
        private readonly IVendaRepositorio VendaRepositorio;
        public VendaController(IVendaRepositorio vendaRepositorio)
        {
            VendaRepositorio = vendaRepositorio;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            try
            {
                var vendas = await VendaRepositorio.ObterTodasVendas();
                return Ok(vendas);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public ActionResult AdicionarVenda([FromBody] Venda venda)
        {
            try
            {

                VendaRepositorio.Adicionar(venda);
                return Created("api/vendedor", venda);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());

            }
        }

    }
}
