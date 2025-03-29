using OOADPROV2.Models;
using OOADPROV2.Utilities.Builder.Staff;
using OOADPROV2.Utilities.Commands.Staff;
using OOADPROV2.Utilities.Function;
using ScottPlot.Renderable;
using System.Drawing.Imaging;

namespace OOADPROV2.Forms.AdminDashboardForm;

public partial class AddStaffForm : Form
{
    private string? imgLocation = "";
    private Staffs? effectedStaff = null;
    private readonly List<string> listBoxStaff = [];
    private int staffCount = 0;
    private readonly int indexOfUpdateStaff;
    private string[] StaffPosition { get; set; } = ["Administrator", "Cashier", "Cleaner", "Waiter"];
    private static string[] Genders { get; set; } = ["Female", "Male"];
    public AddStaffForm(StaffForm staffForm)
    {
        InitializeComponent();

        cBStaffGender.DataSource = Genders;
        btnClear.Click += DoClickClearFormInput;
        btnInsert.Click += DoClickInsertStaff;
        btnUpdate.Click += DoClickUpdateStaff;
        btnUploadPhoto.Click += DoClickUploadStaffPhoto;
        cBStaffPosition.DataSource = StaffPosition;
        dtpDOB.Format = DateTimePickerFormat.Custom;
        dtpHiredDate.Format = DateTimePickerFormat.Custom;
        listBoxStaff.Clear();
    }

    private void DoClickUploadStaffPhoto(object? sender, EventArgs e)
    {
        OpenFileDialog dialog = new OpenFileDialog
        {
            Filter = "SELECT Photo(*.Jpg; *.png; *.Gif)|*.Jpg; *.png; *.Gif"
        };
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            imgLocation = dialog.FileName.ToString();
            picStaff.ImageLocation = imgLocation;
        }
    }

    private void DoClickUpdateStaff(object? sender, EventArgs e)
    {
        if (effectedStaff == null) return;

        byte[]? staffImages = null;

        effectedStaff.StaffName = txtStaffName.Text.Trim();
        effectedStaff.StaffAddress = rtxtStaffAddress.Text.Trim();
        effectedStaff.ContactNumber = txtContactNumber.Text.Trim();
        effectedStaff.Gender = cBStaffGender.SelectedItem?.ToString();
        effectedStaff.StaffPosition = cBStaffPosition.SelectedItem?.ToString();
        effectedStaff.BirthDate = dtpDOB.Value;
        effectedStaff.HiredDate = dtpHiredDate.Value;

        if (picStaff.Image != null)
        {
            using var ms = new MemoryStream();
            picStaff.Image.Save(ms, ImageFormat.Png);
            staffImages = ms.ToArray();
        }
        effectedStaff.Photo = staffImages;

        var (isValid, errorMessage) = StaffValidatorBuilder.Create().Build().Validate(effectedStaff);
        
        if (!isValid)
        {
            MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        try
        {

            var result = StaffCommands.UpdateStaff(effectedStaff);
            if (result == true)
            {
                MessageBox.Show($"Successfully updated an existing staff with the id {txtStaffID.Text}");
                StaffLoadingChanged?.Invoke(this, result);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to update an existing staff > {ex.Message}");
        }


    }

    private void DoClickInsertStaff(object? sender, EventArgs e)
    {
        byte[]? staffImages = null;
        
        //if (!string.IsNullOrEmpty(imgLocation) && File.Exists(imgLocation))
        //{
        //    FileStream stream = new(imgLocation, FileMode.Open, FileAccess.Read);
        //    BinaryReader reader = new(stream);
        //    staffImages = reader.ReadBytes((int)stream.Length);
        //}
        if (!string.IsNullOrEmpty(imgLocation) && File.Exists(imgLocation))
            staffImages = File.ReadAllBytes(imgLocation);

       
            var newStaff = StaffBuilder.Create()
                .WithName(txtStaffName.Text.Trim())
                .WithGender(cBStaffGender.SelectedItem?.ToString() ?? "")
                .WithBirthDate(dtpDOB.Value)
                .WithAddress(rtxtStaffAddress.Text.Trim())
                .WithContactNumber(txtContactNumber.Text.Trim())
                .WithPosition(cBStaffPosition.SelectedItem?.ToString() ?? "")
                .WithHiredDate(dtpHiredDate.Value)
                .WithPhoto(staffImages)
                .Build();
        try
        {
            var result = StaffCommands.AddStaff(newStaff);
            if (result)
            {
                MessageBox.Show("Successfully inserted new staff member.");
                StaffLoadingChanged?.Invoke(this, result);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error inserting staff: {ex.Message}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        ClearFormInput();
        LoadStaff();
    }

    private void DoClickClearFormInput(object? sender, EventArgs e)
    {
        ClearFormInput();
    }
    private void ClearFormInput()
    {
        txtStaffID.Text = (staffCount + 1).ToString();
        txtStaffName.Text = "";
        cBStaffGender.SelectedItem = null;
        dtpDOB.Value = DateTime.Now;
        rtxtStaffAddress.Text = "";
        txtContactNumber.Text = "";
        cBStaffPosition.SelectedItem = null;
        dtpHiredDate.Value = DateTime.Now;
        picStaff.Image = null;
    }
    private void AddStaffForm_Load(object sender, EventArgs e)
    {
        LoadStaff();
        if (txtStaffName.Text == "")

            txtStaffID.Text = (staffCount + 1).ToString();

    }
    private void LoadStaff()
    {
        try
        {
            var result = StaffCommands.GetAllStaffs();
            if (result.LastOrDefault() != null) { staffCount = result.LastOrDefault().StaffID; }
            else { staffCount = 0; }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Retriving staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    public void LoadStaffDetails(Staffs staff)
    {
        ArgumentNullException.ThrowIfNull(staff);

        txtStaffID.Clear();
        txtStaffID.Text = staff.StaffID.ToString();
        txtStaffName.Text = staff.StaffName;
        cBStaffGender.SelectedItem = staff.Gender;
        dtpDOB.Value = staff.BirthDate ?? DateTime.Now;
        cBStaffPosition.Text = staff.StaffPosition;
        rtxtStaffAddress.Text = staff.StaffAddress;
        txtContactNumber.Text = staff.ContactNumber;
        dtpHiredDate.Value = staff.HiredDate ?? DateTime.Now;


        if (staff.Photo != null)
        {
            picStaff.Image = ConvertImageClass.ConvertByteArrayToImage(staff.Photo);
        }
        else
        {
            picStaff.Image = null;
        }

        effectedStaff = staff;
    }
    public event LoadingEventHandler? StaffLoadingChanged;
}
