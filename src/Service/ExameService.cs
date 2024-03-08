using Consultorio.Domain.Models;

public class ExameService : IExameService
{
    private readonly IExameRepository _repository;

    public ExameService(IExameRepository repository)
    {
        _repository = repository;
    }

    public Task AddExame(Exame exame)
    {
        throw new NotImplementedException();
    }

    public Task DeleteExame(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Exame> GetExame(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Exame>> GetExames()
    {
        throw new NotImplementedException();
    }

    public Task UpdateExame(Exame exame)
    {
        throw new NotImplementedException();
    }
}