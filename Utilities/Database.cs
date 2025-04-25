using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities;

sealed class Database
{

    private static Database? _instance;
    private static readonly object _lock = new();

    public IConfiguration Configuration { get; private set; }
    private SqlConnection? _connection;

    private Database()
    {
        LoadConfiguration("appSettings.json");
    }

    public static Database Instance
    {
        get
        {
            lock (_lock)
            {
                _instance ??= new Database();
                return _instance;
            }
        }
    }

    public void LoadConfiguration(string jsonFile)
    {
        var builder = new ConfigurationBuilder();
        var configFile = File.Exists(jsonFile) ? jsonFile : "DBConnectionFormat.json";
        builder.AddJsonFile(configFile, optional: false, reloadOnChange: true);
        Configuration = builder.Build();
    }

    public SqlConnection OpenConnection()
    {
        if (_connection == null || _connection.State == System.Data.ConnectionState.Closed)
        {
            var connStr = Configuration.GetRequiredSection("DBConnectionString").Value;
            _connection = new SqlConnection(connStr);
            _connection.Open();
        }
        return _connection;
    }

    public void CloseConnection()
    {
        if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
            _connection.Close();
    }
    public string GetDBConnectionSetting(string authType)
        => Configuration[$"DBConnectionString{authType}"] ?? "";
}
