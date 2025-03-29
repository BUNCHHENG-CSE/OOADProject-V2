using Microsoft.VisualBasic.ApplicationServices;
using OOADPROV2.Models;
using OOADPROV2.Utilities;
using OOADPROV2.Utilities.Builder.User;
using OOADPROV2.Utilities.Commands.Staff;
using OOADPROV2.Utilities.Commands.User;
using OOADPROV2.Utilities.Function;
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

public partial class AddUserForm : Form
{
    private  Users? effectedUser = null;
    private Staffs? effectedStaff = null;

    private int userCount = 0;
    private readonly int indexOfUpdateUser;
    public AddUserForm(UserForm userform)
    {
        InitializeComponent();
        btnClear.Click += DoClickClearFormInput;
        btnInsert.Click += DoClickInsertUser;
        btnUpdate.Click += DoClickUpdateUser;
        cBStaffID.SelectedValueChanged += Select_Handling_StaffID;
        chBShowPass.CheckedChanged += CheckedShowPassword;
    }

    private void CheckedShowPassword(object? sender, EventArgs e)
    {
        if (chBShowPass.Checked)
        {
            txtPassword.UseSystemPasswordChar = false;
        }
        else
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }

    private void DoClickUpdateUser(object? sender, EventArgs e)
    {
        if (cBStaffID.SelectedItem == null)
        {
            MessageBox.Show("Staff selection is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }

        effectedUser.Username = txtUsername.Text.Trim();

        if (txtPassword.Text.Trim().Length > 3)
        {    
            effectedUser.Password = SecurityHelper.HashPassword(txtPassword.Text.Trim());
        }

        effectedUser.Staff = new Staffs
        {
            StaffID = int.Parse(cBStaffID.SelectedItem.ToString()),
            StaffName = txtStaffName.Text.Trim(),
            StaffPosition = txtStaffPosition.Text.Trim()
        };

        
        var (isValid, errorMessage) = UserValidatorBuilder.Create().Build().Validate(effectedUser);

        if (!isValid)
        {
            MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        try
        {

            var result = UserCommands.UpdateUser(effectedUser);
            if (result == true)
            {
                MessageBox.Show($"Successfully updated an existing staff with the id {txtUserID.Text}");
                UserLoadingChanged?.Invoke(this, result);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to update an existing staff > {ex.Message}");
        }

    }

    private void DoClickInsertUser(object? sender, EventArgs e)
    {
        if (cBStaffID.SelectedItem == null ||
        !int.TryParse(cBStaffID.SelectedItem.ToString(), out int staffId))
        {
            MessageBox.Show("Valid staff selection is required.", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }



        var newUser = UserBuilder.Create()
             .WithUsername(txtUsername.Text.Trim())
             .WithPassword(txtPassword.Text.Trim())
             .WithStaff(staffId, txtStaffName.Text.Trim(), txtStaffPosition.Text.Trim())
             .Build();
        try
        {
            var result = UserCommands.AddUser(newUser);
            if (result)
            {
                MessageBox.Show($"Successfully inserted user: {newUser.Username}");
                UserLoadingChanged?.Invoke(this, result);
            }
            else
            {
                MessageBox.Show($"Failed to insert user: {newUser.Username}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        LoadingUser();
        ClearFormInput();
    }

    private void DoClickClearFormInput(object? sender, EventArgs e)
    {
        ClearFormInput();
    }
    private void ClearFormInput()
    {
        txtUserID.Text = (userCount + 1).ToString();
        txtStaffName.Text = "";
        cBStaffID.SelectedItem = null;
        txtUsername.Text = "";
        txtPassword.Text = "";
        txtStaffPosition.Text = "";
        picStaff.Image = null;
    }
    private void AddUserForm_Load(object sender, EventArgs e)
    {

        LoadingUser();
        LoadingDataStaffID();
        if (txtUsername.Text == "")
        {
            txtUserID.Text = (userCount + 1).ToString();
            cBStaffID.SelectedIndex = -1;
            txtStaffName.Clear();
            txtStaffPosition.Clear();
            picStaff.Image = null;
        }
        else
        {
            cBStaffID.SelectedItem = effectedUser.Staff.StaffID.ToString();
            txtStaffName.Text = effectedUser.Staff.StaffName;
            txtStaffPosition.Text = effectedUser.Staff.StaffPosition;
            if (effectedUser.Staff.Photo != null)
            {
                picStaff.Image = ConvertImageClass.ConvertByteArrayToImage(effectedUser.Staff.Photo);
            }
            else
            {
                picStaff.Image = null;
            }
        }

    }
    private void LoadingUser()
    {
        try
        {
            var result = UserCommands.GetAllUsers();
            if (result.LastOrDefault() != null) { userCount = result.LastOrDefault().UserID; }
            else { userCount = 0; }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Retrieving user", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void Select_Handling_StaffID(object? sender, EventArgs e)
    {
        if (cBStaffID.SelectedItem != null)
        {
            string? staffID = cBStaffID.SelectedItem.ToString();
            if (staffID == null) return;

            try
            {
                effectedStaff = StaffCommands.GetOneStaff(int.Parse(staffID.Trim()));
                txtStaffName.Text = effectedStaff.StaffName;
                txtStaffPosition.Text = effectedStaff.StaffPosition;
                picStaff.Image = effectedStaff.Photo != null ? ConvertImageClass.ConvertByteArrayToImage(effectedStaff.Photo) : null;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }

        }
    }
    private void LoadingDataStaffID()
    {
        try
        {
            var result = StaffCommands.GetIDStaff();
            List<string> ls = [];
            foreach (var staff in result)
            {
                ls.Add(staff.StaffID.ToString());
            }
            cBStaffID.DataSource = ls;


        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Retrieving staff ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    public void LoadUserDetails(Users user)
    {
        if (user == null)
            return;
        txtUserID.Clear();
        txtUserID.Text = user.UserID.ToString();
        txtUsername.Text = user.Username;
        //txtPassword.Text = user.Password;
        effectedUser = user;
    }
    public event LoadingEventHandler? UserLoadingChanged;
}
