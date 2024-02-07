using System.Data;
using Consultorio.Domain.Models;

public class ExameRepository : IExameRepository
{
    private readonly IDbConnection _dbConnection;

    public ExameRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public Task AddExame(Exame exame)
    {
        throw new NotImplementedException();
    }

    public Task DeleteExame(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Exame>> GetExames()
    {
        throw new NotImplementedException();
    }

    public Task<Exame> GetExames(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateExame(Exame exame)
    {
        throw new NotImplementedException();
    }
}