using System.Data;
using Consultorio.Domain.Models;
using Dapper;
using Microsoft.AspNetCore.Connections;
using Microsoft.Extensions.Configuration;

public class ConsultaRepository : IConsultaRepository
{
    private readonly IDbConnection _dbConnection;

    public ConsultaRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public Task AddConsulta(Consulta consulta)
    {
        throw new NotImplementedException();
    }

    public Task DeleteConsulta(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Consulta> GetConsulta(int id)
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