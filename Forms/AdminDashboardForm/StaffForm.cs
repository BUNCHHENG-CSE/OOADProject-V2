using OOADPROV2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOADPROV2.Forms.AdminDashboardForm
{
    public partial class StaffForm : Form
    {
        int staffCount = 0;
        private System.Windows.Forms.Timer clickTimer;
        private const int DoubleClick = 300;
        private Staffs _selectedStaff;
        public StaffForm()
        {
            InitializeComponent();
            btnAddStaff.Click += DoClickAddStaff;
            clickTimer = new System.Windows.Forms.Timer();
            clickTimer.Interval = DoubleClick;
            //clickTimer.Tick += ClickTimer_Tick;
        }
        private void DoClickAddStaff(object? sender, EventArgs e)
        {
            AddStaffForm staffAddForm = new AddStaffForm(this);
            staffAddForm.StaffLoadingChanged += (sender, result) =>
            {
                if (result)
                {
                    flowLayoutPanelStaff.Controls.Clear();
                    //LoadingDataStaff();
                }
            };
            staffAddForm.Show();

        }
        private void StaffForm_Load(object sender, EventArgs e)
        {

        }
    }
}
