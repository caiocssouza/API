using API_Viagem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace API_Viagem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteDBContext _context;

        public ClienteController(ClienteDBContext context)
        {
            _context = context;
        }

        //MÉTODO GET - LISTA OS CLIENTES
        [HttpGet]
        public IEnumerable<Cliente> GetClientes()
        {
            return _context.Clientes;
        }

        //MÉTODO GET: LISTA POR ID

        [HttpGet("{id}")]
        public IActionResult GetClientePorId(int id)
        {
            Cliente cliente = _context.Clientes.SingleOrDefault(modelo => modelo.id == id);
            if (cliente == null)
            {
                return NotFound();
            }
            return new ObjectResult(cliente);

        }

        //CREATE CLIENTE

        [HttpPost]
        public IActionResult NovoCliente(Cliente novoCliente)
        {
            if (novoCliente == null)
            {
                return BadRequest();
            }

            _context.Clientes.Add(novoCliente);
            _context.SaveChanges();
            return new ObjectResult(novoCliente);
        }

        //atualiza um cliente
        [HttpPut("{id}")]
        public IActionResult AtualizaCliente(int id, Cliente cliente)
        {
            if (id != cliente.id)
            {
                return BadRequest();
            }
            _context.Entry(cliente).State = EntityState.Modified;
            _context.SaveChanges();

            return new NoContentResult();
        }
        //APAGAR CLIENTE
        [HttpDelete("{id}")]
        public IActionResult DeletarCliente(int id)
        {
            var cliente = _context.Clientes.SingleOrDefault(modelo => modelo.id == id);

            if (cliente == null)
            {
                return BadRequest();
            }

            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
            return Ok(cliente);
        }
    }
}
    

