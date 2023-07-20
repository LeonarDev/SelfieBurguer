using SelfieBurguer.Application.Dtos.Cliente;
using SelfieBurguer.Application.Interfaces;
using SelfieBurguer.Application.Interfaces.Mappers;
using SelfieBurguer.Domain.Core.Interfaces.Services;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente _serviceCliente;
        private readonly IMapperCliente _mapperCliente;

        public ApplicationServiceCliente(IServiceCliente serviceCliente, IMapperCliente mapperCliente)
        {
            _serviceCliente = serviceCliente;
            _mapperCliente = mapperCliente;
        }

        public void Add(ClienteDto clienteDto)
        {
            Cliente cliente = _mapperCliente.MapperDtoToEntity(clienteDto);
            _serviceCliente.Add(cliente);
        }

        public void Update(ClienteDto clienteDto)
        {
            Cliente cliente = _mapperCliente.MapperDtoToEntity(clienteDto);
            _serviceCliente.Update(cliente);
        }

        public void Delete(ClienteDto clienteDto)
        {
            Cliente cliente = _mapperCliente.MapperDtoToEntity(clienteDto);
            _serviceCliente.Delete(cliente);
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            IEnumerable<Cliente> clientes = _serviceCliente.GetAll();
            IEnumerable<ClienteDto> clientesDto = _mapperCliente.MapperEntitiesListToDtosList(clientes);

            return clientesDto;
        }

        public ClienteDto GetById(int id)
        {
            Cliente cliente = _serviceCliente.GetById(id);
            ClienteDto clienteDto = _mapperCliente.MapperEntityToDto(cliente);

            return clienteDto;
        }
    }
}