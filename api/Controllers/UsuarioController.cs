using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }
        [HttpGet("Apresentar/{nome}/{idade}")]
        public IActionResult Apresentar(string nome, int idade)
        {
            var mensagem = $"Olá {nome},Você tem {idade} anos, seja Bem-Vindo a minha primeira API!";
            return Ok(mensagem);
        }
    }
}