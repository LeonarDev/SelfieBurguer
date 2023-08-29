using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using SelfieBurguer.Application.Interfaces;
using SelfieBurguer.DataTransfer.Cliente;
using System.Reflection;

namespace SelfieBurguer.API.Controllers
{
    [Route("api/cliente")]
    [ApiController]
    public class ClientesController : Controller
    {
        private readonly IApplicationServiceCliente _applicationServiceCliente;

        public ClientesController(IApplicationServiceCliente ApplicationServiceCliente)
        {
            _applicationServiceCliente = ApplicationServiceCliente;
        }

        /// <summary>
        /// GET api/clientes
        /// </summary>
        /// <returns></returns>
        [HttpGet("/api/clientes")]
        public ActionResult<IEnumerable<ClienteResponse>> RecuperarTodos()
        {
            var response = _applicationServiceCliente.RecuperarTodos();

            return Ok(response);
        }

        /// <summary>
        /// GET api/clientes/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<ClienteResponse> RecuperarPorId([FromRoute] int id)
        {
            var response = _applicationServiceCliente.RecuperarPorId(id);

            return response.Id > 0 ? Ok(response) : NotFound();
        }

        /// <summary>
        /// GET api/cliente?cpf=12345678910
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<ClienteResponse> RecuperarPorCpf([FromQuery] string cpf)
        {
            var response = _applicationServiceCliente.RecuperarPorCpf(cpf);

            return response.Id > 0 ? Ok(response) : NotFound();
        }

        /// <summary>
        /// POST api/cliente
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Adicionar([FromBody] ClienteRequest request)
        {
            if (request == null) return BadRequest();

            foreach (PropertyInfo property in request.GetType().GetProperties())
            {
                if (property.PropertyType == typeof(string))
                {
                    string value = (string)property.GetValue(request);

                    if (string.IsNullOrEmpty(value))
                    {
                        return BadRequest();
                    }
                }
            }

            string uri = HttpContext.Request.GetDisplayUrl();

            ClienteResponse cliente = _applicationServiceCliente.Add(request);

            return Created(uri, cliente);
        }

        /// <summary>
        /// PUT api/cliente/5
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public ActionResult Editar([FromRoute] int id, [FromBody] ClienteRequest request)
        {
            if (request == null || id == 0) return BadRequest();

            _applicationServiceCliente.Update(id, request);

            return Ok($"Cliente {request.Nome} {request.Sobrenome} atualizado com sucesso!");
        }

        /// <summary>
        /// DELETE api/cliente/5
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public ActionResult Deletar([FromRoute] int id)
        {
            if (id == 0) return BadRequest();

            _applicationServiceCliente.Delete(id);

            return Ok($"Cliente {id} removido com sucesso!");
        }
    }
}