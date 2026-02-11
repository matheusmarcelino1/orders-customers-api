using OrdersCustomers.Application.DTOs;
using OrdersCustomers.Application.Events;
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
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _repository;

        public PedidoService(IPedidoRepository repository)
        {
            _repository = repository;
        }

        public async Task<PedidoDto> CreateAsync(CreatePedidoDto dto)
        {
            var pedido = new Pedido(dto.ClienteId, dto.ValorTotal);

            await _repository.AddAsync(pedido);

            var evento = new PedidoCriadoEvent
            {
                PedidoId = pedido.Id,
                DataCriacao = DateTime.UtcNow
            };

            Console.WriteLine($"Evento disparado: Pedido {evento.PedidoId} criado em {evento.DataCriacao}");

            return new PedidoDto
            {
                Id = pedido.Id,
                ClienteId = pedido.ClienteId,
                ValorTotal = pedido.ValorTotal,
                Status = pedido.Status
            };
        }

        public async Task<List<PedidoDto>> GetAllAsync()
        {
            var pedidos = await _repository.GetAllAsync();

            return pedidos.Select(p => new PedidoDto
            {
                Id = p.Id,
                ClienteId = p.ClienteId,
                ValorTotal = p.ValorTotal,
                Status = p.Status
            }).ToList();
        }

        public async Task<PedidoDto?> GetByIdAsync(Guid id)
        {
            var pedido = await _repository.GetByIdAsync(id);

            if (pedido == null)
                return null;

            return new PedidoDto
            {
                Id = pedido.Id,
                ClienteId = pedido.ClienteId,
                ValorTotal = pedido.ValorTotal,
                Status = pedido.Status
            };
        }
    }
}
