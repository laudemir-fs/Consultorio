using Consultorio.Domain.Models;

public interface IExameService
{
    Task<IEnumerable<Exame>> GetExames();
    Task<Exame> GetExame(int id);
    Task AddExame(Exame exame);
    Task UpdateExame(Exame exame);
    Task DeleteExame(int id);
}