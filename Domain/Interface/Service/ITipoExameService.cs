using Consultorio.Domain.Models;

public interface ITipoExameService
{
    Task<IEnumerable<TipoExame>> GetTipoExames();
    Task<TipoExame> GetTipoExames(int id);
    Task AddTipoExame(TipoExame tipoExameExame);
    Task UpdateTipoExame(TipoExame tipoexame);
    Task DeleteTipoExame(int id);
}