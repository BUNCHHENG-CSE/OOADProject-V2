using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using OOADPROV2.Utilities;

namespace OOADPROV2.Forms;

public partial class DBConnectionForm : Form
{
    string[] authentication { get; set; } = new string[] { "Window Authentication", "Server Authentication" };
    public static IConfiguration? Configuration { get; set; } = null;

    string? ConnectionStringToDatabase;

    private LoadingForm loadingFormReference;
    public DBConnectionForm(LoadingForm loadingForm)
    {
        InitializeComponent();
        this.loadingFormReference = loadingForm;
        cBAuthentication.DataSource = authentication;
        cBAuthentication.SelectedIndex = -1;
        cBAuthentication.SelectedValueChanged += Select_Handling_Authentication;
        Helper.Instance.LoadConfiguration("DBConnectionFormat.json");
        btnConnect.Click += DoClickConnect;
        btnCancel.Click += DoClickCancel;
        labelUser.Enabled = false;
        labelPassword.Enabled = false;
        txtUser.Enabled = false;
        txtPassword.Enabled = false;
        txtUser.Clear();
        txtPassword.Clear();
        this.FormClosed += new FormClosedEventHandler(DBConnection_Handler);

    }
    private void DoClickCancel(object? sender, EventArgs e)
    {
        loadingFormReference.Close();
        this.Close();
    }
    private void DBConnection_Handler(object? sender, FormClosedEventArgs e)
    {
        loadingFormReference.Close();
    }

    private void DoClickConnect(object? sender, EventArgs e)
    {
        if (txtServerName.Text == "") { MessageBox.Show("Server name is required!!!"); return; }
        if (txtDatabaseName.Text == "") { MessageBox.Show("Database name is required!!!"); return; }
        if (cBAuthentication.SelectedItem == null) { MessageBox.Show("Authentication is required!!!"); return; }

        if (ConnectionStringToDatabase == null) { MessageBox.Show("Connection string is required!!!"); return; }
        
        if (cBAuthentication.SelectedItem.ToString().Equals("Server Authentication"))
        {
            if (txtUser.Text == "") { MessageBox.Show("User is required!!!"); return; }
            if (txtPassword.Text == "") { MessageBox.Show("Password is required!!!"); return; }
            ConnectionStringToDatabase = string.Format(ConnectionStringToDatabase, txtServerName.Text, txtDatabaseName.Text, txtUser.Text, txtPassword.Text);
        }
        else
        {
            ConnectionStringToDatabase = string.Format(ConnectionStringToDatabase, txtServerName.Text, txtDatabaseName.Text);
        }
        DBConnection dBConnection = new DBConnection();
        dBConnection.DBConnectionString = ConnectionStringToDatabase;
        string dbJsonData = JsonConvert.SerializeObject(dBConnection);
        File.WriteAllText($"{Environment.CurrentDirectory}/appSettings.json", dbJsonData);

        LoginForm loginForm = new LoginForm(loadingFormReference, this);
        loginForm.Show();
        this.Hide();
    }
    private void Select_Handling_Authentication(object? sender, EventArgs e)
    {
        if (cBAuthentication.SelectedItem != null)
        {
            string? authentication = cBAuthentication.SelectedItem.ToString();
            if (authentication == null) return;
            if (authentication.Equals("Server Authentication"))
            {
                txtUser.Enabled = true;
                txtPassword.Enabled = true;
                labelUser.Enabled = true;
                labelPassword.Enabled = true;
                ConnectionStringToDatabase = Helper.Instance.GetDBConnectionSetting("DBConnectionStringServerAuth");
            }
            else
            {
                labelUser.Enabled = false;
                labelPassword.Enabled = false;
                txtUser.Enabled = false;
                txtPassword.Enabled = false;
                txtUser.Clear();
                txtPassword.Clear();
                ConnectionStringToDatabase = Helper.Instance.GetDBConnectionSetting("DBConnectionStringWindowAuth");
            }
        }
    }
}
class DBConnection
{
    public string? DBConnectionString { get; set; }
}