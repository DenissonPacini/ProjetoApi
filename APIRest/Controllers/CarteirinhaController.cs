using APIRest.Dominio.Entidades;
using APIRest.Dominio.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarteirinhaController : ControllerBase
    {
        private readonly IRepositorioCarteirinha _repositorioCarteirinha;

        public CarteirinhaController(IRepositorioCarteirinha repositorioCarteirinha)
        {
            _repositorioCarteirinha = repositorioCarteirinha;
        }

        [HttpGet]
        public IActionResult GetCarteirinha(string Aluno)
        {
            var dados = _repositorioCarteirinha.GetCarteirinha(Aluno);

            return (IActionResult)dados;
        }
        [HttpPost]
        public IActionResult SalvaCarteirinha(Carteirinha dados)
        {
            if (ModelState.IsValid)
            {
                _repositorioCarteirinha.SaveCarteirinha(dados);
                return Ok();
            }
            else
                return NotFound();

        }
    }
}
