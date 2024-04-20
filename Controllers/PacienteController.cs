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
            var result =  _pacienteService.ListAll();
            return Ok(result);
    }

    // GET: api/Pacientes
    [HttpGet("ExportToExcel")]
    public async Task<IActionResult> ExportToExcel()
    {
       var fileBytes = await _pacienteService.ExportToExcelBytes();
        return File(fileBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Pacientes.xlsx");
    }

    // POST: api/Pacientes
    [HttpPost]
        public async Task<IActionResult> Inserir([FromBody] PacienteInsert paciente)
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


