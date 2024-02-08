using Consultorio.Domain.Models;

public interface IExameRepository
{
    Task<IEnumerable<Exame>> GetExames();
    //Task<Exame> GetExames(int id);
    Task AddExame(Exame exame);
    //Task UpdateExame(Exame exame);
    //Task DeleteExame(int id);
}