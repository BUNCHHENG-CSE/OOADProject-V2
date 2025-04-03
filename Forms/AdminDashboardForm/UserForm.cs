using Microsoft.VisualBasic.ApplicationServices;
using OOADPROV2.Models;
using OOADPROV2.Utilities;
using OOADPROV2.Utilities.Commands.User;
using OOADPROV2.Utilities.Function;
using OOADPROV2.Utilities.Observer;
using OOADPROV2.Utilities.Observer.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOADPROV2.Forms.AdminDashboardForm;

public partial class UserForm : Form,IObservers<Users>
{
    private System.Windows.Forms.Timer clickTimer;
    private const int DoubleClick = 300;
    private Users _selectedUser;
    private readonly UserNotifier _userNotifier = new();
    public UserForm()
    {
        InitializeComponent();
        btnAddUser.Click += DoClickAddUser;
        clickTimer = new System.Windows.Forms.Timer();
        clickTimer.Interval = DoubleClick;
        clickTimer.Tick += ClickTimer_Tick;
        _userNotifier.Attach(this);
    }

    private void DoClickAddUser(object? sender, EventArgs e)
    {
        AddUserForm userAddForm = new (_userNotifier);
        
        userAddForm.Show();
    }

    private void UserForm_Load(object sender, EventArgs e)
    {
        LoadingDataUser();
    }
    private void LoadingDataUser()
    {
        try
        {
            flowLayoutPanelUser.Padding = new Padding(20, 20, 20, 20);
            var result = UserGet.All();
            foreach (var user in result)
            {
                Panel userPanel = new()
                {
                    Width = 185,
                    Height = 250,
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(20),
                    Margin = new Padding(20, 20, 20, 20)
                };
                PictureBox pictureBox = new()
                {
                    Width = 180,
                    Height = 180,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Image = user.Staff.Photo != null ? ConvertImageClass.ConvertByteArrayToImage(user.Staff.Photo) : null
                };

                Label userNameLabel = new()
                {
                    Text = user.Username,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Size = new Size(180, 30),
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = false,
                    Location = new Point(5, 190)
                };

                Label userPosition = new()
                {
                    Text = user.Staff.StaffPosition,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Size = new Size(180, 30),
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = false,
                    Location = new Point(5, 215)
                };


                pictureBox.MouseDown += (s, e) =>
                {
                    if (e.Clicks == 1)
                    {
                        _selectedUser = user;
                        clickTimer.Start();
                    }
                    else if (e.Clicks == 2)
                    {
                        clickTimer.Stop();
                        DeleteUserById(user.UserID);
                    }
                };

                flowLayoutPanelUser.Padding = new Padding(20);
                userPanel.Controls.Add(pictureBox);
                userPanel.Controls.Add(userNameLabel);
                userPanel.Controls.Add(userPosition);
                flowLayoutPanelUser.Controls.Add(userPanel);
            }
            Helper.Instance.CloseConnection();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Retriving staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void ClickTimer_Tick(object? sender, EventArgs e)
    {
        clickTimer.Stop();
        if (_selectedUser != null)
        {
            LoadUserForUpdate(_selectedUser);
        }
    }

    private void LoadUserForUpdate(Users user)
    {
        AddUserForm updateForm = new(_userNotifier);
        updateForm.LoadUserDetails(user);
        updateForm.ShowDialog();
        flowLayoutPanelUser.Controls.Clear();
        LoadingDataUser();
    }
    private void DeleteUserById(int userID)
    {
        try
        {
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete this member?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                var result = UserGet.All();
                bool isDeleted = UserCommands.DeleteUser(userID);
                if (isDeleted)
                {
                    MessageBox.Show("User deleted successfully!");
                    flowLayoutPanelUser.Controls.Clear();
                    LoadingDataUser();
                }
                else
                {
                    MessageBox.Show("Failed to delete the user member.");
                }
            }
            else
            {

            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error deleting user: {ex.Message}");
        }
    }
    public void Update(Users user)
    {
        flowLayoutPanelUser.Controls.Clear();
        LoadingDataUser();
    }
}
