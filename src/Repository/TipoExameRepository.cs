using System.Data;
using Consultorio.Domain.Models;

public class TipoExameRepository : ITipoExameRepository
{
    private readonly IDbConnection _dbConnection;

    public TipoExameRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public Task AddTipoExame(TipoExame tipoExame)
    {
        throw new NotImplementedException();
    }

    public Task DeleteTipoExame(int id)
    {
        throw new NotImplementedException();
    }

    public Task<TipoExame> GetTipoExame(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TipoExame>> GetTipoExames()
    {
        throw new NotImplementedException();
    }

    public Task UpdateTipoExame(TipoExame tipoExame)
    {
        throw new NotImplementedException();
    }
}

