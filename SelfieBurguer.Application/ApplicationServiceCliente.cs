using SelfieBurguer.Application.Dtos.Cliente;
using SelfieBurguer.Application.Interfaces;
using SelfieBurguer.Domain.Core.Interfaces.Services;
using SelfieBurguer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieBurguer.Application
{
    public  class ApplicationServiceCliente
    {
        public class ApplicationServiceCliente : IApplicationServiceCliente
        {
            private readonly IServiceCliente serviceCliente;
            private readonly IMapper mapper;
            public ApplicationServiceCliente(IServiceCliente serviceCliente, IMapper mapper)
            {
                this.serviceCliente = serviceCliente;
                this.mapper = mapper;
            }
            public void Add(ClienteDto clienteDto)
            {
                var cliente = mapper.Map<Cliente>(clienteDto);
                serviceCliente.Add(cliente);
            }

            public IEnumerable<ClienteDto> GetAll()
            {
                var clientes = serviceCliente.GetAll();
                var clientesDto = mapper.Map<IEnumerable<ClienteDto>>(clientes);

                return clientesDto;
            }

            public ClienteDto GetById(int id)
            {
                var cliente = serviceCliente.GetById(id);
                var clienteDto = mapper.Map<ClienteDto>(cliente);

                return clienteDto;
            }

            public void Delete(ClienteDto clienteDto)
            {
                var cliente = mapper.Map<Cliente>(clienteDto);
                serviceCliente.Remove(cliente);
            }

            public void Update(ClienteDto clienteDto)
            {
                var cliente = mapper.Map<Cliente>(clienteDto);
                serviceCliente.Update(cliente);
            }
        }
    }
}
