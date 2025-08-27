using EstudantesWebApi.Models;
using EstudantesWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace EstudantesWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstudantesController : ControllerBase
    {
        private readonly IEstudanteService _service;

        // Injeção de dependência
        public EstudantesController(IEstudanteService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Estudante>> GetEstudantes()
        {
            return Ok(_service.GetAll());
        }

        [HttpPost]
        public ActionResult<Estudante> PostEstudante([FromBody] Estudante novoEstudante)
        {
            var estudanteCriado = _service.Add(novoEstudante);
            return CreatedAtAction(nameof(GetEstudantes), new { id = estudanteCriado.Id }, estudanteCriado);
        }
    }
}
