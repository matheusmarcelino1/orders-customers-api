using OrdersCustomers.Application.DTOs;
using OrdersCustomers.Application.Interfaces;
using OrdersCustomers.Domain.Entities;
using OrdersCustomers.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersCustomers.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public async Task<ClienteDto> CreateAsync(CreateClienteDto dto)
        {
            var cliente = new Cliente(dto.Nome, dto.Email);

            await _repository.AddAsync(cliente);

            return new ClienteDto
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Email = cliente.Email
            };
        }

        public async Task<List<ClienteDto>> GetAllAsync()
        {
            var clientes = await _repository.GetAllAsync();

            return clientes.Select(c => new ClienteDto
            {
                Id = c.Id,
                Nome = c.Nome,
                Email = c.Email
            }).ToList();
        }

        public async Task<ClienteDto?> GetByIdAsync(Guid id)
        {
            var cliente = await _repository.GetByIdAsync(id);

            if (cliente == null)
                return null;

            return new ClienteDto
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Email = cliente.Email
            };
        }
    }
}
