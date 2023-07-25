using Microsoft.AspNetCore.Mvc;
using SelfieBurguer.Application.Dtos.Cliente;
using SelfieBurguer.Application.Interfaces;

namespace SelfieBurguer.API.Controllers
{
    [Route("api/clientes")]
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
        [HttpGet]
        public ActionResult<IEnumerable<ClienteResponse>> GetAll()
        {
            var response = _applicationServiceCliente.GetAll();

            return Ok(response);
        }

        /// <summary>
        /// GET api/clientes/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<ClienteResponse> GetById([FromRoute] int id)
        {
            var response = _applicationServiceCliente.GetById(id);

            return response.Id > 0 ? Ok(response) : NotFound();
        }

        /// <summary>
        /// POST api/clientes
        /// </summary>
        /// <param name="clienteDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post([FromBody] ClienteRequest request)
        {
            if (request == null || request.IdUsuario == 0) return BadRequest();

            _applicationServiceCliente.Add(request);

            return Ok($"Cliente {request.IdUsuario} cadastrado com sucesso!");
        }

        /// <summary>
        /// PUT api/clientes/5
        /// </summary>
        /// <param name="clienteDTO"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult Put([FromBody] ClienteRequest request)
        {
            if (request == null || request.IdUsuario == 0) return BadRequest();

            _applicationServiceCliente.Update(request);

            return Ok($"Cliente {request.IdUsuario} atualizado com sucesso!");
        }

        /// <summary>
        /// DELETE api/clientes/5
        /// </summary>
        /// <param name="clienteDTO"></param>
        /// <returns></returns>
        [HttpDelete()]
        public ActionResult Delete([FromBody] ClienteRequest request)
        {
            try
            {
                if (request == null || request.IdUsuario == 0) return BadRequest();

                _applicationServiceCliente.Delete(request);

                return Ok($"Cliente {request.IdUsuario} removido com sucesso!");
            }
            catch
            {
                throw;
            }
        }
    }
}