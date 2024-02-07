using Consultorio.Domain.Models;

public interface IConsultaService
{
    Task<IEnumerable<Consulta>> GetConsultas();
    Task<Paciente> GetConsulta(int id);
    Task AddConsulta(Consulta consulta);
    Task UpdateConsulta(Consulta consulta);
    Task DeleteConsulta(int id);
}