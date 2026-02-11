using OrdersCustomers.Domain.Entities;
using OrdersCustomers.Domain.Enums;

namespace OrdersCustomers.Tests;

public class PedidoTests
{
    [Fact]
    public void Pedido_Deve_Iniciar_Com_Status_Criado()
    {
        var pedido = new Pedido(Guid.NewGuid(), 100);

        Assert.Equal(StatusPedido.Criado, pedido.Status);
    }

    [Fact]
    public void Pedido_Deve_Mudar_Para_Processando()
    {
        var pedido = new Pedido(Guid.NewGuid(), 100);

        pedido.Processar();

        Assert.Equal(StatusPedido.Processando, pedido.Status);
    }

    [Fact]
    public void Pedido_Nao_Pode_Finalizar_Sem_Processar()
    {
        var pedido = new Pedido(Guid.NewGuid(), 100);

        Assert.Throws<InvalidOperationException>(() => pedido.Finalizar());
    }
}
