using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Context;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok($"O contato com nome {contato.Name} foi adicionado com sucesso!");
        }
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var contato = _context.Contatos.Find(id);
            if (contato == null)
                return NotFound();

            return Ok(contato);
        }
        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome)
        {
            var contatos = _context.Contatos.Where(x => x.Name.Contains(nome));
            if (nome == null)
            {
                var todosContatos = _context.Contatos.ToList();
                return Ok(todosContatos);
            }
            return Ok(contatos);
        }

        [HttpDelete("{id}")]
        public IActionResult RemoverPorId(int id)
        {
            var contato = _context.Contatos.Find(id);
            if (contato == null)
                return NotFound();
            _context.Remove(contato);
            _context.SaveChanges();
            return Ok($"O contato com nome {contato.Name} foi removido com sucesso");
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarPorId(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);
            if (contatoBanco == null)
                return NotFound();
            contatoBanco.Name = contato.Name;
            contatoBanco.PhoneNumber = contato.PhoneNumber;
            contatoBanco.Active = contato.Active;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();
            return Ok($"O contato foi atualizado com sucesso");
        }

    }
}