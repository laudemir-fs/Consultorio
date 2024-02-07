
using System.Data;
using System.Data.Common;
using System.Reflection.Metadata;
using Dapper;


public class PacienteRepository : IPacienteRepository
{
    private readonly IDbConnection _dbConnection;

    public PacienteRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public Task DeletePaciente(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Paciente> GetPaciente(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdatePaciente(Paciente paciente)
    {
        throw new NotImplementedException();
    }

    public async Task InserirPaciente(Paciente paciente)
    {
        try
        {
            await _dbConnection.ExecuteAsync("[InserirPaciente]", new {paciente.Nome, 
            paciente.CPF,
            paciente.DataNascimento,
            paciente.Sexo, 
            paciente.Telefone,
            paciente.Email
            }, commandType: CommandType.StoredProcedure);
        }
        catch (Exception ex)
        {
            throw new Exception($"{nameof(InserirPaciente)} | Erro : {ex.Message}");
        }
    }

    public async Task<IEnumerable<Paciente>> GetAllPacientes()
    {
        return await _dbConnection.QueryAsync<Paciente>("[ListarPacientes]");
    }
}