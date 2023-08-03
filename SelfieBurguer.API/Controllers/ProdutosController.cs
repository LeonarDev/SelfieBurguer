using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using SelfieBurguer.Application.Interfaces;
using SelfieBurguer.DataTransfer.Produto;
using System.Collections.Generic;
using System.Reflection;

namespace SelfieBurguer.API.Controllers
{
    [Route("api/produto")]
    [ApiController]
    public class ProdutosController : Controller
    {
        private readonly IApplicationServiceProduto _applicationServiceProduto;

        public ProdutosController(IApplicationServiceProduto ApplicationServiceProduto)
        {
            _applicationServiceProduto = ApplicationServiceProduto;
        }

        /// <summary>
        /// GET api/produtos
        /// </summary>
        /// <returns></returns>
        [HttpGet("/api/produtos")]
        public ActionResult<IEnumerable<ProdutoResponse>> GetAll()
        {
            var response = _applicationServiceProduto.GetAll();

            return Ok(response);
        }

        /// <summary>
        /// GET api/produtos/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<ProdutoResponse> GetById([FromRoute] int id)
        {
            var response = _applicationServiceProduto.GetById(id);

            return response.Id > 0 ? Ok(response) : NotFound();
        }

        /// <summary>
        /// GET api/produtos?categoria=bebida
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<ProdutoResponse>> GetByCategoria([FromQuery] string categoria)
        {
            var response = _applicationServiceProduto.GetByCategoria(categoria);

            return response.Count() > 0 ? Ok(response) : NotFound();
        }

        /// <summary>
        /// POST api/produto
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post([FromBody] ProdutoRequest request)
        {
            if (request == null) return BadRequest();

            foreach (PropertyInfo property in request.GetType().GetProperties())
            {
                if (property.PropertyType == typeof(string))
                {
                    string value = (string)property.GetValue(request);

                    if (string.IsNullOrEmpty(value))
                        return BadRequest();
                }
            }

            string uri = HttpContext.Request.GetDisplayUrl();
            _applicationServiceProduto.Add(request);

            return Created(uri, request);
        }

        /// <summary>
        /// PUT api/produto/5
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public ActionResult Put([FromRoute] int id, [FromBody] ProdutoRequest request)
        {
            if (request == null || id == 0) return BadRequest();

            _applicationServiceProduto.Update(id, request);

            return Ok($"Produto {request.Nome} atualizado com sucesso!");
        }

        /// <summary>
        /// DELETE api/produto/5
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            if (id == 0) return BadRequest();

            _applicationServiceProduto.Delete(id);

            return Ok($"Produto {id} removido com sucesso!");
        }
    }
}