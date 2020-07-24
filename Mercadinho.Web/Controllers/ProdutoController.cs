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
public class ProdutoController : Controller
{
    private readonly IProdutoRepositorio ProdutoRepositorio;
    public ProdutoController(IProdutoRepositorio produtoRepositorio)
    {
        ProdutoRepositorio = produtoRepositorio;
    }

    [HttpPost]
    public ActionResult AdicionarProduto([FromBody] Produto produto)
    {
        try
        {

            ProdutoRepositorio.Adicionar(produto);
            return Created("api/produto", produto);

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
            var produtos = await ProdutoRepositorio.ObterTodosProdutos();
            return Ok(produtos);
        }
        catch (Exception ex)
        {

            return BadRequest(ex.ToString());
        }
    }

    [HttpGet("{ProdutoId}")]
    public async Task<IActionResult> ObterProdutoPorId(int ProdutoId)
    {
        try
        {
            var produtos = await ProdutoRepositorio.ObterProdutoPorId(ProdutoId);
            return Ok(produtos);
        }
        catch (Exception ex)
        {

            return BadRequest(ex.ToString());
        }
    }

    [HttpPut("{ProdutoId}")]
    public async Task<IActionResult> Atualizar(int ProdutoId, [FromBody] Produto produto)
    {
        try
        {

            var produtos = await ProdutoRepositorio.ObterProdutoPorId(ProdutoId);
            if (produtos == null)
            {
                return NotFound("Usuario não encontrado");
            }

            ProdutoRepositorio.Atualizar(produto);

            return Ok("Usuario atualizado com Sucesso");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());

        }
    }


    [HttpDelete("{ProdutoId}")]
    public async Task<IActionResult> Deletar(int ProdutoId)
    {
        try
        {
            var produtos = await ProdutoRepositorio.ObterProdutoPorId(ProdutoId);
            if (produtos == null)
            {
                return NotFound("Usuario não encontrado");
            }

            ProdutoRepositorio.Remover(produtos);

            return Ok("Usuario deletado com sucesso !");


        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());

        }
    }


}
}
