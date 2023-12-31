﻿using Microsoft.AspNetCore.Mvc;
using VendasAPI.Model;
using Newtonsoft.Json;
using System.Linq;

namespace VendasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly List<Usuario> usuarios = new List<Usuario>();

        public void alimentaLista()
        {
            Usuario usr1 = new Usuario();
            usr1.Email = "juju";
            usr1.Password = "12345";
            usr1.Id = 1;
            usuarios.Add(usr1);
        }

        [HttpPost]
        public IActionResult AddUsuario([FromBody] Usuario user)
        {
            if (user == null)
            {
                return BadRequest("Usuário nulo!");
            }

            usuarios.Add(user);
            return Ok(user);
        }

       /* [HttpGet("{id}")]
        public IActionResult GetUsuariosById(int Id) {
            Usuario? user = usuarios.FirstOrDefault(user => user.Id == Id);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound(user);
        }*/


        [HttpGet]

        public IActionResult GetUsuarios()
        {
            alimentaLista();
            return Ok(usuarios);
        }

        /*Não precisa serializar
         */

    }

}
