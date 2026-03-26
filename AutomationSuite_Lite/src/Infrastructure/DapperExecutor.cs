using System.Data.SqlClient;

public class DapperExecutor
{
    private readonly string _connectionString;

    public DapperExecutor(string connectionString)
    {
        _connectionString = connectionString;
    }
}
