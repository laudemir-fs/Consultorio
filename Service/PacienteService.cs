

public class PacienteService : IPacienteService
{
    private readonly IPacienteRepository _pacienteRepository;

    public PacienteService(IPacienteRepository pacienteRepository)
    {
        _pacienteRepository = pacienteRepository;
    }

    public async Task<IEnumerable<Paciente>> GetAllPacientes()
    {
        return await _pacienteRepository.GetAllPacientes();
    }

    public async Task Inserir(Paciente paciente)
    {
        await _pacienteRepository.InserirPaciente(paciente);
    }

    public Task DeletePaciente(int id)
    {   
        throw new NotImplementedException();
    }

    public Task<Paciente> GetPaciente(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdatePaciente(Paciente paciente)
    {
        throw new NotImplementedException();
    }

    public Task AddPaciente(Paciente paciente)
    {
        throw new NotImplementedException();
    }

}
