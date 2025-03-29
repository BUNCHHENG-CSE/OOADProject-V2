using Newtonsoft.Json;
using OOADPROV2.Utilities.Factories;

namespace OOADPROV2.Utilities.Facade.Database;

public class DBConnectionFacade
{
    public static bool Connect(string authType, string server, string database, string user = "", string password = "")
    {
        try
        {
            var connectionString = EntityFactory.CreateConnectionString(authType, server, database, user, password);

            SaveConnectionString(connectionString);
            Helper.Instance.OpenConnection();
            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Connection failed: {ex.Message}");
            return false;
        }
    }

    private static void SaveConnectionString(string connectionString)
    {
        var connectionData = JsonConvert.SerializeObject(new { DBConnectionString = connectionString });
        File.WriteAllText($"{Environment.CurrentDirectory}/appSettings.json", connectionData);
        Helper.Instance.LoadConfiguration("appSettings.json");
    }
}
