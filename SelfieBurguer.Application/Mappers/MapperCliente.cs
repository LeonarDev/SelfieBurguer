using SelfieBurguer.Application.Dtos.Cliente;
using SelfieBurguer.Application.Interfaces.Mappers;
using SelfieBurguer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieBurguer.Application.Mappers
{
    public class MapperCliente : IMapperCliente
    {
        public Cliente MapperDtoToEntity(ClienteDto clienteDto)
        {
            // Alterar ClienteDto para seu respectivo ClienteRequest que será recebido via post
            var Cliente = new Cliente()
            {
                Id = clienteDto.Id
            };

            return Cliente;
        }

        public IEnumerable<ClienteDto> MapperEntitiesListToDtosList(IEnumerable<Cliente> clientes)
        {
            throw new NotImplementedException();
        }

        public ClienteDto MapperEntityToDto(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
