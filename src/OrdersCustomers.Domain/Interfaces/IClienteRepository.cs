using OrdersCustomers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersCustomers.Domain.Interfaces
{
    public interface IClienteRepository
    {
        Task AddAsync(Cliente cliente);
        Task<List<Cliente>> GetAllAsync();
        Task<Cliente?> GetByIdAsync(Guid id);
    }
}
