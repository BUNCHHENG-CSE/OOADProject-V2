﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOADPROV2.Forms.AdminDashboardForm;

public partial class AddStaffForm : Form
{
    public AddStaffForm(StaffForm staffForm)
    {
        InitializeComponent();
    }

    private void AddStaffForm_Load(object sender, EventArgs e)
    {

    }
    public event LoadingEventHandler? StaffLoadingChanged;
}
