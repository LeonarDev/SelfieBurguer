using SelfieBurguer.Application.Dtos.Cliente;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Application.Interfaces.Mappers
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDto clienteDto);

        IEnumerable<ClienteDto> MapperEntitiesListToDtosList(IEnumerable<Cliente> clientes);

        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}