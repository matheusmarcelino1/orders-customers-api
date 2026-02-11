using OrdersCustomers.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersCustomers.Domain.Entities
{
    public class Pedido
    {
        public Guid Id { get; private set; }
        public Guid ClienteId { get; private set; }
        public DateTime DataPedido { get; private set; }
        public decimal ValorTotal { get; private set; }
        public StatusPedido Status { get; private set; }

        public Pedido(Guid clienteId, decimal valorTotal)
        {
            Id = Guid.NewGuid();
            ClienteId = clienteId;
            ValorTotal = valorTotal;
            DataPedido = DateTime.UtcNow;
            Status = StatusPedido.Criado;
        }

        public void Processar()
        {
            if (Status != StatusPedido.Criado)
                throw new InvalidOperationException("Pedido não pode ser processado.");

            Status = StatusPedido.Processando;
        }

        public void Finalizar()
        {
            if (Status != StatusPedido.Processando)
                throw new InvalidOperationException("Pedido não pode ser finalizado.");

            Status = StatusPedido.Finalizado;
        }
    }
}
