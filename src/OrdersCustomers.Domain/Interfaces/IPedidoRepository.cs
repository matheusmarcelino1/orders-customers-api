using OrdersCustomers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersCustomers.Domain.Interfaces
{
    public interface IPedidoRepository
    {
        Task AddAsync(Pedido pedido);
        Task<List<Pedido>> GetAllAsync();
        Task<Pedido?> GetByIdAsync(Guid id);
    }
}
