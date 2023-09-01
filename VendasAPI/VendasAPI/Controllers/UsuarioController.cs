using Microsoft.AspNetCore.Mvc;
using VendasAPI.Model;

namespace VendasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        List<Usuario> usuarios = new List<Usuario>();

        [HttpGet("{id}")]
        public IActionResult GetUsuariosById(int Id) {
            Usuario user = usuarios.FirstOrDefault(user => user.Id == Id);
            if(user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }

        [HttpPost]
        public void AddUsuario([FromBody] Usuario user)
        {
            usuarios.Add(user);
        }

    }
}
