
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection.Metadata;
using Dapper;


public class PacienteRepository : IPacienteRepository
{
    private readonly IDbConnection _dbConnection;

    public PacienteRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public async Task InserirPaciente(PacienteInsert paciente)
    {
        try
        {
            await _dbConnection.ExecuteAsync("[InserirPaciente]", new {
            paciente.Nome, 
            paciente.CPF,
            paciente.DataNascimento,
            paciente.Sexo, 
            paciente.Telefone,
            paciente.Email,
            paciente.PacienteID
            }, commandType: CommandType.StoredProcedure);
        }
        catch (Exception ex)
        {
            throw new Exception($"{nameof(InserirPaciente)} | Erro : {ex.Message}");
        }
    }

    public async Task<IList<Paciente>> ListAll()
    {
        var paciente =_dbConnection.Query<Paciente>("[ListarPacientes]");
        return (IList<Paciente>)paciente;
    }
}