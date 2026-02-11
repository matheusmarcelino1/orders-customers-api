using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersCustomers.Application.Events
{
    public class PedidoCriadoEvent
    {
        public Guid PedidoId { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
