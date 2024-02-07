using Consultorio.Domain.Models;

public class TipoExameService : ITipoExameService
{
    private readonly ITipoExameRepository _repository;

    public TipoExameService(ITipoExameRepository repository)
    {
        _repository = repository;
    }

    public Task AddTipoExame(TipoExame tipoExameExame)
    {
        throw new NotImplementedException();
    }

    public Task DeleteTipoExame(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TipoExame>> GetTipoExames()
    {
        throw new NotImplementedException();
    }

    public Task<TipoExame> GetTipoExames(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateTipoExame(TipoExame tipoexame)
    {
        throw new NotImplementedException();
    }
}