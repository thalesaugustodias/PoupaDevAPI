using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoupaDevAPI.Entities;
using PoupaDevAPI.Models;
using PoupaDevAPI.Persistence;

namespace PoupaDevAPI.Controllers
{
    [Route("api/objetivos-financeiros")]
    [ApiController]
    public class ObjetivosFinanceirosController : ControllerBase
    {
        private readonly PoupaDevContext _context;
        public ObjetivosFinanceirosController(PoupaDevContext context)
        {
            _context = context;
        }
        //Para chegar nesse GET api/objetivos-financeiros
        [HttpGet]
        public IActionResult GetTodos()
        {
            var objetivos = _context.Objetivos;
            return Ok();
        }

        //Para acessar esse GET api/objetivos-financeiros/1
        [HttpGet("{id}")]
        public IActionResult GetPorId(int id)
        {
            var objetivo = _context.Objetivos.SingleOrDefault(o => o.Id == id);

            if (objetivo == null)
            {
                return NotFound();
            }
            return Ok();
        }

        // POST api/objetivos-financeiros
        [HttpPost]
        public IActionResult Post(ObjetivoFinanceiroInputModel model)
        {
            var objetivo = new ObjetivoFinanceiro(model.Titulo, model.Descricao, model.ValorObjetivo);

            _context.Objetivos.Add(objetivo);
            var id = objetivo.Id;

            return CreatedAtAction(
                "GetPorId",
                new { id },
                model
                );
        }

        //POST api/objetivos-financeiros/1/operacoes
        [HttpPost("{id}/operacoes")]
        public IActionResult PostOperacao(int id, OperacaoInputModel model)
        {
            var operacao = new Operacao(model.Valor, model.TipoOperacao);

            var objetivo = _context.Objetivos.SingleOrDefault(o => o.Id == id);

            if (objetivo == null)
            {
                return NotFound();
            }
            objetivo.RealizarOperacao(operacao);

            return NoContent();
        }
    }
}
