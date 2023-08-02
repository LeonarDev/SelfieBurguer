using AutoMapper;
using SelfieBurguer.Application.Interfaces;
using SelfieBurguer.DataTransfer.Cliente;
using SelfieBurguer.Domain.Core.Interfaces.Services;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente _serviceCliente;
        private readonly IMapper _mapper;

        public ApplicationServiceCliente(IServiceCliente serviceCliente, IMapper mapper)
        {
            _serviceCliente = serviceCliente;
            _mapper = mapper;
        }

        public ClienteResponse Add(ClienteRequest request)
        {
            Cliente cliente = _serviceCliente.Instantiate(request);
            _serviceCliente.Add(cliente);
            return _mapper.Map<ClienteResponse>(cliente);
        }

        public void Update(int id, ClienteRequest request)
        {
            // verificar necessidade da transaction (unitOfWork)

            Cliente cliente = _serviceCliente.GetById(id);

            cliente.SetNome(request.Nome);
            cliente.SetSobrenome(request.Sobrenome);
            cliente.SetEmail(request.Email);

            _serviceCliente.Update(cliente);
        }

        public void Delete(int id)
        {
            Cliente cliente = _serviceCliente.GetById(id);
            _serviceCliente.Delete(cliente);
        }

        public IEnumerable<ClienteResponse> GetAll()
        {
            IEnumerable<Cliente> clientes = _serviceCliente.GetAll();

            return _mapper.Map<IEnumerable<ClienteResponse>>(clientes);
        }

        public ClienteResponse GetById(int id)
        {
            Cliente cliente = _serviceCliente.GetById(id);
            return _mapper.Map<ClienteResponse>(cliente);
        }

        public ClienteResponse GetByEmail(string email)
        {
            Cliente cliente = _serviceCliente.GetByEmail(email);
            return _mapper.Map<ClienteResponse>(cliente);
        }
    }
}