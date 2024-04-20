
public class ResponseService : IResponseService
{
    private readonly ITooltipsRepository _tooltipsRepository;
     private readonly IPacienteRepository _pacienteRepository;

    public ResponseService(ITooltipsRepository tooltipsRepository, IPacienteRepository pacienteRepository)
    {
        _tooltipsRepository = tooltipsRepository;
        _pacienteRepository = pacienteRepository;
    }

    public async Task<object> ListAll()
    {
    var Tooltips = await _tooltipsRepository.ListAll();
    var pacientes = await _pacienteRepository.ListAll();

    var result = new
    {
        Tooltips,
        pacientes
    };

    return result;
    }

}