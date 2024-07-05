using MySqlConnector;
using System.Data;
using Microsoft.Data.SqlClient;

namespace AquarioMania.DataContext;

public class DapperContext
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;
    public DapperContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public IDbConnection CreateConnection()
        => new SqlConnection(_configuration.GetSection("Settings").GetSection("ConnectionString").Value);
}
