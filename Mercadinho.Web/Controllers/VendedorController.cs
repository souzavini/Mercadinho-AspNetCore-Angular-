using Mercadinho.Dominio.Contratos;
using Mercadinho.Dominio.Entidades;
using Mercadinho.Repositorio.Contexto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mercadinho.web.Controllers
{
    [Route("api/[Controller]")]
    public class VendedorController : Controller
    {
        private readonly IVendedorRepositorio VendedorRepositorio;
        public VendedorController(IVendedorRepositorio vendedorRepositorio)
        {
            VendedorRepositorio = vendedorRepositorio;
        }

        [HttpPost]
        public ActionResult AdicionarVendedor([FromBody] Vendedor vendedor)
        {
            try
            {

                VendedorRepositorio.Adicionar(vendedor);
                return Created("api/vendedor", vendedor);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());

            }
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            try
            {
                var vendedores = await VendedorRepositorio.ObterTodosVendedores();
                return Ok(vendedores);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }

        [HttpGet("{VendedorId}")]
        public async Task<IActionResult> ObterVendedorPorId(int VendedorId)
        {
            try
            {
                var vendedores = await VendedorRepositorio.ObterVendedorPorId(VendedorId);
                return Ok(vendedores);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }

        [HttpPut("{VendedorId}")]
        public async Task<IActionResult> Atualizar(int VendedorId, [FromBody] Vendedor vendedor)
        {
            try
            {

                var vendedores = await VendedorRepositorio.ObterVendedorPorId(VendedorId);
                if(vendedores == null)
                {
                    return NotFound("Usuario não encontrado");
                }

                VendedorRepositorio.Atualizar(vendedor);

                return Ok("Usuario atualizado com Sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());

            }
        }


        [HttpDelete("{VendedorId}")]
        public async Task<IActionResult> Deletar(int VendedorId)
        {
            try
            {
                var vendedores = await VendedorRepositorio.ObterVendedorPorId(VendedorId);
                if (vendedores == null)
                {
                    return NotFound("Usuario não encontrado");
                }

                VendedorRepositorio.Remover(vendedores);

                return Ok("Usuario deletado com sucesso !");


            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());

            }
        }

        
    }
}
        


    


