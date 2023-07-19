using SelfieBurguer.Application.Dtos.Cliente;
using SelfieBurguer.Domain.Entities;
using SelfieBurguer.Infrastructure.CrossCutting.Interfaces;

namespace SelfieBurguer.Infrastructure.CrossCutting.Mapper
{
    public class MapperCliente : IMapperCliente
    {
        IEnumerable<ClienteDto> clientesDtos = new List<ClienteDto>();

        public Cliente MapperDtoToEntity(ClienteDto clienteDto)
        {
            var cliente = new Cliente()
            {
                Id = clienteDto.Id,
                Usuario = new Usuario()
                {
                    Nome = clienteDto.Nome,
                    Email = clienteDto.Email
                }
            };

            return cliente;
        }

        public ClienteDto MapperEntityToDto(Cliente cliente)
        {
            var clienteDto = new ClienteDto()
            {
                Id = cliente.Id,
                Nome = cliente.Usuario.Nome,
                Email = cliente.Usuario.Email
            };

            return clienteDto;
        }

        public IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes)
        {
            var clientesDtos = clientes.Select(c =>
                new ClienteDto
                {
                    Id = c.Id,
                    Nome = c.Usuario.Nome,
                    Email = c.Usuario.Email
                }
            );

            return clientesDtos;
        }
    }
}
