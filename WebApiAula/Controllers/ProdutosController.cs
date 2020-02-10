using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using WebApiAula.Models;

namespace WebApiAula.Controllers
{
    public class ProdutosController : ApiController
    {
        List<Produto> produtos = new List<Produto>();

        /// <summary>
        /// Método responsável por adicionar um Produto
        /// </summary>
        /// <param name="produto">Objeto Produto</param>
        [HttpPost]
        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        /// <summary>
        /// Método responsável retornar uma lista de Produtos
        /// </summary>
        /// <returns>Lista de Produtos no formato json</returns>
        [HttpGet]
        public JsonResult<List<Produto>> ListarProdutos()
        {
            for (int i = 0; i < 10; i++)
            {
                produtos.Add(new Produto { Id = i, NomeDoProduto = $"Produto {i}" });
            }

            return Json(produtos);
        }
    }
}
