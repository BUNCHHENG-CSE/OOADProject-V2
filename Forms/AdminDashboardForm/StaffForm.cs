using OOADPROV2.Models;
using OOADPROV2.Utilities;
using OOADPROV2.Utilities.Commands.Staff;
using OOADPROV2.Utilities.Function;
using OOADPROV2.Utilities.Observer;
using OOADPROV2.Utilities.Observer.Staff;
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

public partial class StaffForm : Form , IObservers<Staffs>
{
    private readonly System.Windows.Forms.Timer clickTimer;
    private new const int DoubleClick = 300;
    private  Staffs _selectedStaff;
    private readonly StaffNotifier _staffNotifier = new();
    public StaffForm()
    {
        InitializeComponent();
        btnAddStaff.Click += DoClickAddStaff;
        clickTimer = new System.Windows.Forms.Timer
        {
            Interval = DoubleClick
        };
        clickTimer.Tick += ClickTimer_Tick;
        _staffNotifier.Attach(this);
    }
    private void DoClickAddStaff(object? sender, EventArgs e)
    {
        AddStaffForm staffAddForm = new(_staffNotifier);
        
        staffAddForm.Show();

    }
    private void StaffForm_Load(object sender, EventArgs e)
    {
        LoadingDataStaff();
    }
    private void LoadingDataStaff()
    {
        try
        {
            flowLayoutPanelStaff.Padding = new Padding(20, 20, 20, 20);
            var result = StaffGet.All();

            
            foreach (var staff in result)
            {
                Panel productPanel = new()
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
                    Image = staff.Photo != null ? ConvertImageClass.ConvertByteArrayToImage(staff.Photo) : null
                };

                Label staffNameLabel = new()
                {
                    Text = staff.StaffName,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Size = new Size(180, 30),
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = false,
                    Location = new Point(5, 190)
                };

                Label staffPosition = new()
                {
                    Text = staff.StaffPosition,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Size = new Size(180, 30),
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = false,
                    Location = new Point(5, 215)
                };
                staffPosition.TextAlign = ContentAlignment.MiddleCenter;

                pictureBox.MouseDown += (s, e) =>
                {
                    if (e.Clicks == 1)
                    {
                        _selectedStaff = staff;
                        clickTimer.Start();
                    }
                    else if (e.Clicks == 2)
                    {
                        clickTimer.Stop();
                        DeleteStaffById(staff.StaffID);
                    }
                };

                flowLayoutPanelStaff.Padding = new Padding(20);
                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(staffNameLabel);
                productPanel.Controls.Add(staffPosition);
                flowLayoutPanelStaff.Controls.Add(productPanel);
            }
            Database.Instance.CloseConnection();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Retriving staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void ClickTimer_Tick(object? sender, EventArgs e)
    {
        clickTimer.Stop();
        if (_selectedStaff != null)
        {
            LoadStaffForUpdate(_selectedStaff);
        }
    }
    private void LoadStaffForUpdate(Staffs staff)
    {
        AddStaffForm updateForm = new (_staffNotifier);
        updateForm.LoadStaffDetails(staff);
        updateForm.ShowDialog();
        flowLayoutPanelStaff.Controls.Clear();
        LoadingDataStaff();
    }
    private void DeleteStaffById(int staffid)
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
                var result = StaffGet.All();
                bool isDeleted = StaffCommands.DeleteStaff(staffid);
                if (isDeleted)
                {
                    MessageBox.Show("Staff deleted successfully!");
                    flowLayoutPanelStaff.Controls.Clear();
                    LoadingDataStaff();
                }
                else
                {
                    MessageBox.Show("Failed to delete the staff member.");
                }
            }
            else
            {

            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error deleting staff: {ex.Message}");
        }
    }
    public void Update(Staffs data)
    {
        flowLayoutPanelStaff.Controls.Clear();
        LoadingDataStaff();
    }
}
