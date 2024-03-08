using Consultorio.Domain.Models;

public interface ITipoExameRepository
{
    Task<IEnumerable<TipoExame>> GetTipoExames();
    Task<TipoExame> GetTipoExame(int id);
    Task AddTipoExame(TipoExame tipoExame);
    Task UpdateTipoExame(TipoExame tipoExame);
    Task DeleteTipoExame(int id);
}