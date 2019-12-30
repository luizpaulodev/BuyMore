using BuyMore.Dom.Contratos;
using BuyMore.Dom.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace BuyMore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepositorio produtoRepositorio;
        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            this.produtoRepositorio = produtoRepositorio;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(produtoRepositorio.ObterTodos());
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("adicionar")]
        public ActionResult Adicionar(Produto produto)
        {
            try
            {
                produtoRepositorio.Adicionar(produto);            

                return Created("api/produto", produto);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }            
        }
    }
}

//