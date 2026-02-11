using OrdersCustomers.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersCustomers.Application.Interfaces
{
    public interface IClienteService
    {
        Task<ClienteDto> CreateAsync(CreateClienteDto dto);
        Task<List<ClienteDto>> GetAllAsync();
        Task<ClienteDto?> GetByIdAsync(Guid id);
    }
}
