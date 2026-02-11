using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersCustomers.Application.DTOs
{
    public class CreatePedidoDto
    {
        public Guid ClienteId { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
