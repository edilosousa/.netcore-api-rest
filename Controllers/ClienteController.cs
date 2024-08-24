using api.Models;
using api.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/v1/cliente")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        [HttpPost]
        public IActionResult Add(ClienteViewModel clienteView)
        {
            var cliente = new Cliente(   clienteView.cliente_nome,
                                                        clienteView.cliente_endereco,
                                                        clienteView.cliente_telefone, 
                                                        clienteView.cliente_foto,
                                                        clienteView.cliente_status,
                                                        clienteView.cliente_email,
                                                        clienteView.cliente_observacoes
                                                        );
            _clienteRepository.Add( cliente );
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var cliente = _clienteRepository.GetAll();
            return Ok(cliente); 
        }
    }
}
