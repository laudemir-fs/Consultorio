public interface IPacienteService
{
    Task<object> ListAll();
    Task<byte[]> ExportToExcelBytes();
    //Task<Paciente> GetPaciente(int id);
    Task Inserir(PacienteInsert paciente);
    //Task GetDados();
    //Task UpdatePaciente(Paciente paciente);
    //Task DeletePaciente(int id);
}