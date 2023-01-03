using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("Calculadora")]
    public class CalculadoraController : ControllerBase
    {
        [HttpGet("SomarDoisNumeros/{num1}/{num2}")]
        public IActionResult Somar(int num1, int num2)
        {
            var soma = num1 + num2;
            return Ok($"A soma de {num1} e {num2} é igual a {soma}");
        }

        [HttpGet("SubtrairDoisNumeros/{num1}/{num2}")]
        public IActionResult Subtrair(int num1, int num2)
        {
            var subtracao = num1 - num2;
            return Ok($"A subtração de {num1} e {num2} é igual a {subtracao}");
        }
    }
}