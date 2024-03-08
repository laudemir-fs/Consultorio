using Consultorio.Domain.Models;

public interface IConsultaRepository
{
    Task<IEnumerable<Consulta>> GetConsultas();
    Task<Consulta> GetConsulta(int id);
    Task AddConsulta(Consulta consulta);
    Task UpdateConsulta(Consulta consulta);
    Task DeleteConsulta(int id);
}