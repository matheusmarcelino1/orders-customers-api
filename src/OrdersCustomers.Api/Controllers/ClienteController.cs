using Microsoft.AspNetCore.Mvc;
using OrdersCustomers.Application.DTOs;
using OrdersCustomers.Application.Interfaces;

namespace OrdersCustomers.Api.Controllers
{
    [ApiController]
    [Route("clientes")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _service;

        public ClienteController(IClienteService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<ClienteDto>> Create(CreateClienteDto dto)
        {
            var cliente = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = cliente.Id }, cliente);
        }

        [HttpGet]
        public async Task<ActionResult<List<ClienteDto>>> GetAll()
        {
            var clientes = await _service.GetAllAsync();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClienteDto>> GetById(Guid id)
        {
            var cliente = await _service.GetByIdAsync(id);

            if (cliente == null)
                return NotFound();

            return Ok(cliente);
        }
    }
}