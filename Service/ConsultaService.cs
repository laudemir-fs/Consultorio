using Consultorio.Domain.Models;

public class ConsultaService : IConsultaService
{
    private readonly IConsultaRepository _repository;

    public ConsultaService(IConsultaRepository repository)
    {
        _repository = repository;
    }

    public Task AddConsulta(Consulta consulta)
    {
        throw new NotImplementedException();
    }

    public Task DeleteConsulta(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Paciente> GetConsulta(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Consulta>> GetConsultas()
    {
        throw new NotImplementedException();
    }

    public Task UpdateConsulta(Consulta consulta)
    {
        throw new NotImplementedException();
    }
}