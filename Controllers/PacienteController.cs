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
    public IActionResult GetAllPatients()
    {
        var pacientes = _pacienteService.GetAllPacientes();
        return Ok(pacientes);
    }
    
    // GET: api/Pacientes/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Paciente>> GetPaciente(int id)
    {
        var paciente = await _pacienteService.GetPaciente(id);

        if (paciente == null)
        {
            return NotFound();
        }

        return paciente;
    }

    // PUT: api/Pacientes/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutPaciente(int id, Paciente paciente)
    {
        if (id != paciente.PacienteID)
        {
            return BadRequest();
        }

        await _pacienteService.UpdatePaciente(paciente);

        return NoContent();
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

    // DELETE: api/Pacientes/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePaciente(int id)
    {
        await _pacienteService.DeletePaciente(id);

        return NoContent();
    }
}


