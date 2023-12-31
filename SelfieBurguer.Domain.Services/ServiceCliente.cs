﻿using SelfieBurguer.DataTransfer.Cliente;
using SelfieBurguer.Domain.Core.Interfaces.Repositories;
using SelfieBurguer.Domain.Core.Interfaces.Services;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Domain.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente _repositoryCliente;

        public ServiceCliente(IRepositoryCliente repositoryCliente) : base(repositoryCliente)
        {
            _repositoryCliente = repositoryCliente;
        }

        public Cliente RecuperarPorCpf(string cpf)
        {
            return _repositoryCliente.RecuperarPorCpf(cpf);
        }

        public Cliente Instantiate(ClienteRequest request)
        {
            Cliente cliente = new(request.Nome, request.Sobrenome, request.Email, request.Cpf);

            return cliente;
        }
    }
}