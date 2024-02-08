using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PacientesController : ControllerBase
{
    private readonly IPacienteService _pacienteService;

    public PacientesController(IPacienteService pacienteService)
    {
        _pacienteService = pacienteService;
    }

    // GET: api/Pacientes
    [HttpGet]
    public ActionResult GetAllPacientes()
    {
            var pacientes =  _pacienteService.ListAll();
            return Ok(pacientes);
    }

    // POST: api/Pacientes
    [HttpPost]
        public async Task<IActionResult> Inserir([FromBody] Paciente paciente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
            await _pacienteService.Inserir(paciente);
            return Ok("Sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

}


