using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities;

sealed class Helper
{
    
    public string ConnectionStringKey { get; set; } = "DBConnectionString";
    public IConfiguration? Configuration { get; private set; }
    public SqlConnection? Connection { get; private set; }

    private static Helper? _instance;
    private static readonly object _lock = new();
    private Helper() { }
    public static Helper Instance
    {
        get
        {
            lock (_lock)
            {
                _instance ??= new Helper();
                return _instance;
            }
        }
    }
    public void LoadConfiguration(string jsonFile)
    {
     

        var builder = new ConfigurationBuilder();

        if (File.Exists(jsonFile))
        {
            builder.AddJsonFile(jsonFile, optional: false, reloadOnChange: true);
        }
        else
        {
            builder.AddJsonFile("DBConnectionFormat.json", optional: false, reloadOnChange: true);

        }

        Configuration = builder.Build();
    }

    public SqlConnection OpenConnection()
    {
        try
        {
            string? connStr = Configuration?.GetRequiredSection(ConnectionStringKey).Value;
            Connection = new SqlConnection(connStr);
            Connection.Open();
           // MessageBox.Show($"Connected to server successfully", "Connection To Server");
            return Connection;
        }
        catch (Exception ex)
        {
            Connection = null;
            throw new Exception($"Failed to connect to the server > {ex.Message}");
        }
    }

    public string GetDBConnectionSetting(string connectionType)
    {
        var procSettingSection = Configuration?.GetRequiredSection($"{connectionType}");
        return procSettingSection?.Value ?? "";
    }


}
