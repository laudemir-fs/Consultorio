

public class PacienteService : IPacienteService
{
    private readonly IPacienteRepository _pacienteRepository;

    public PacienteService(IPacienteRepository pacienteRepository)
    {
        _pacienteRepository = pacienteRepository;
    }

    public async Task<IList<Paciente>> ListAll()
{
    var pacientes = await _pacienteRepository.ListAll();

    foreach (var paciente in pacientes)
    {
        paciente.Data = paciente.DataNascimento.ToString("dd-MM-yyyy");
    }

    return pacientes;
}
    
        public async Task Inserir(PacienteInsert paciente)
    {
        await _pacienteRepository.InserirPaciente(paciente);
    }

   
}
