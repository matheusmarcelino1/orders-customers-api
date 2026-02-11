using OrdersCustomers.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersCustomers.Application.Interfaces
{
    public interface IPedidoService
    {
        Task<PedidoDto> CreateAsync(CreatePedidoDto dto);
        Task<List<PedidoDto>> GetAllAsync();
        Task<PedidoDto?> GetByIdAsync(Guid id);
    }
}
