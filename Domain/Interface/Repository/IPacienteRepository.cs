public interface IPacienteRepository
{
    Task <IEnumerable<Paciente>> GetAllPacientes();
    //Task<Paciente> GetPaciente(int id);
    Task InserirPaciente(Paciente paciente);
    //Task UpdatePaciente(Paciente paciente);
    //Task DeletePaciente(int id);
}