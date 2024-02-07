public interface IPacienteService
{
    Task<IEnumerable<Paciente>> GetAllPacientes();
    
    Task<Paciente> GetPaciente(int id);
    Task Inserir(Paciente paciente);
    Task UpdatePaciente(Paciente paciente);
    Task DeletePaciente(int id);
}