public interface IPacienteService
{
    Task<IList<Paciente>> ListAll();
    //Task<Paciente> GetPaciente(int id);
    Task Inserir(PacienteInsert paciente);
    //Task UpdatePaciente(Paciente paciente);
    //Task DeletePaciente(int id);
}