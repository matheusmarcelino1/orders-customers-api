using Microsoft.AspNetCore.Mvc;
using OrdersCustomers.Application.DTOs;
using OrdersCustomers.Application.Interfaces;

namespace OrdersCustomers.Api.Controllers
{
    [ApiController]
    [Route("pedidos")]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService _service;

        public PedidoController(IPedidoService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<PedidoDto>> Create(CreatePedidoDto dto)
        {
            var pedido = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = pedido.Id }, pedido);
        }

        [HttpGet]
        public async Task<ActionResult<List<PedidoDto>>> GetAll()
        {
            var pedidos = await _service.GetAllAsync();
            return Ok(pedidos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PedidoDto>> GetById(Guid id)
        {
            var pedido = await _service.GetByIdAsync(id);

            if (pedido == null)
                return NotFound();

            return Ok(pedido);
        }
    }
}
