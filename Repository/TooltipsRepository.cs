
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection.Metadata;
using Dapper;


public class TooltipsRepository : ITooltipsRepository
{
    private readonly IDbConnection _dbConnection;

    public TooltipsRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public async Task<IList<Tooltips>> ListAll()
    {
        var tooltips =_dbConnection.Query<Tooltips>("[ListarTooltips]");
        
        return (IList<Tooltips>)tooltips;
    }
}