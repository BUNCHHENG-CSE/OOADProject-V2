using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using OOADPROV2.Utilities;
using OOADPROV2.Utilities.Facade.Database;

namespace OOADPROV2.Forms;

public partial class DBConnectionForm : Form
{
    private readonly LoadingForm _loadingForm;
   
    public DBConnectionForm(LoadingForm loadingForm)
    {
        InitializeComponent();
        _loadingForm = loadingForm;
        cBAuthentication.DataSource = new[] { "WindowAuth", "ServerAuth" };
        cBAuthentication.SelectedIndex = -1;
        cBAuthentication.SelectedValueChanged += SelectAuthType;
        btnConnect.Click += DoConnect;
        btnCancel.Click += (_, _) => CloseForm();

    }
    private void SelectAuthType(object? sender, EventArgs e)
    {
        bool serverAuth = cBAuthentication.SelectedItem?.ToString() == "ServerAuth";
        txtUser.Enabled = txtPassword.Enabled = labelUser.Enabled = labelPassword.Enabled = serverAuth;
        if (!serverAuth)
        {
            txtUser.Clear();
            txtPassword.Clear();
        }
    }

    private void DoConnect(object? sender, EventArgs e)
    {
        string authType = cBAuthentication.SelectedItem?.ToString() ?? "";
        if (string.IsNullOrEmpty(txtServerName.Text) || string.IsNullOrEmpty(txtDatabaseName.Text) || string.IsNullOrEmpty(authType))
        {
            MessageBox.Show("Server name, database name, and authentication are required!");
            return;
        }

        if (authType == "ServerAuth" && (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text)))
        {
            MessageBox.Show("User and Password required for Server Authentication!");
            return;
        }

        bool success = DBConnectionFacade.Connect(authType, txtServerName.Text, txtDatabaseName.Text, txtUser.Text, txtPassword.Text);
        if (success)
        {
            var loginForm = new LoginForm(_loadingForm, this);
            loginForm.Show();
            this.Hide();
        }
    }

    private void CloseForm()
    {
        _loadingForm.Close();
        this.Close();
    }
}
class DBConnection
{
    public string? DBConnectionString { get; set; }
}