using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using SelfieBurguer.Application.Interfaces;
using SelfieBurguer.DataTransfer.Pedido;
using System.Collections.Generic;
using System.Reflection;

namespace SelfieBurguer.API.Controllers
{
    [Route("api/pedido")]
    [ApiController]
    public class PedidosController : Controller
    {
        private readonly IApplicationServicePedido _applicationServicePedido;

        public PedidosController(IApplicationServicePedido ApplicationServicePedido)
        {
            _applicationServicePedido = ApplicationServicePedido;
        }

        /// <summary>
        /// GET api/pedidos
        /// </summary>
        /// <returns></returns>
        [HttpGet("/api/pedidos")]
        public ActionResult<IEnumerable<PedidoResponse>> RecuperarTodos()
        {
            var response = _applicationServicePedido.Listar();

            return Ok(response);
        }

        /// <summary>
        /// GET api/pedidos/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<PedidoResponse> RecuperarPorId([FromRoute] int id)
        {
            var response = _applicationServicePedido.RecuperarPorId(id);

            return response.Id > 0 ? Ok(response) : NotFound();
        }

        /// <summary>
        /// POST api/pedido
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post([FromBody] PedidoRequest request)
        {
            // FLUXO:
            // 1) Criar objeto PEDIDO com o ClienteId (request.ClienteId)
            // 2) Criar objeto PedidoProduto
            // 3) Vincular PedidoId criado no passo 1 no PedidoProduto criado no passo 2
            // 4) Vincular produtos (int[] ProdutosIds) em PedidoProduto
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
            _applicationServicePedido.Add(request);

            return Created(uri, request);
        }

        ///// <summary>
        ///// PUT api/pedido/5
        ///// </summary>
        ///// <param name="id"></param>
        ///// <param name="request"></param>
        ///// <returns></returns>
        //[HttpPut("{id}")]
        //public ActionResult Put([FromRoute] int id, [FromBody] PedidoRequest request)
        //{
        //    if (request == null || id == 0) return BadRequest();

        //    _applicationServicePedido.Update(id, request);

        //    return Ok($"Pedido {request.Nome} atualizado com sucesso!");
        //}

        ///// <summary>
        ///// DELETE api/pedido/5
        ///// </summary>
        ///// <param name="id"></param>
        ///// <param name="request"></param>
        ///// <returns></returns>
        //[HttpDelete("{id}")]
        //public ActionResult Delete([FromRoute] int id)
        //{
        //    if (id == 0) return BadRequest();

        //    _applicationServicePedido.Delete(id);

        //    return Ok($"Pedido {id} removido com sucesso!");
        //}
    }
}