

public class PacienteService : IPacienteService
{
    private readonly IPacienteRepository _pacienteRepository;

    public PacienteService(IPacienteRepository pacienteRepository)
    {
        _pacienteRepository = pacienteRepository;
    }

    public async Task<IEnumerable<Paciente>> ListAll()
    {
        return await _pacienteRepository.ListAll();
    }

    public async Task Inserir(Paciente paciente)
    {
        await _pacienteRepository.InserirPaciente(paciente);
    }

}
