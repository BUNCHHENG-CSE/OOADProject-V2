using OOADPROV2.Forms.CashierDashboardForm;
using OOADPROV2.Models;
using OOADPROV2.Utilities.Facade.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOADPROV2.Forms
{
    public partial class CashierForm : Form
    {
        private readonly LoadingForm loadingFormReference;
        private readonly LoginForm loginFormReference;
        private readonly DBConnectionForm databaseConnectionFormReference;
        private readonly DisplayFacade displayFacade;
        public CashierForm(LoadingForm loadingForm, DBConnectionForm databaseConnectionForm, LoginForm login, Users user)
        {
            InitializeComponent();
            loadingFormReference = loadingForm;
            loginFormReference = login;
            databaseConnectionFormReference = databaseConnectionForm;
            displayFacade = new DisplayFacade(panelcontrolMain);
            this.FormClosed += new FormClosedEventHandler(CashierForm_FormClosed);
            btnCashierProducts.Click += (object? sender, EventArgs e) => displayFacade.OpenForm<CashierProductForm>();
            btnOrder.Click += (object? sender, EventArgs e) => displayFacade.OpenForm<OrderForm>();
            btnLogout.Click += (_, _) => { this.Hide(); loginFormReference.Show(); };
            if (user != null)
                LabelUser.Text += $" {user.Username?.ToUpper()}";
        }
        private void CashierForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            loadingFormReference.Close();
            loginFormReference.Close();
            databaseConnectionFormReference.Close();
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            displayFacade.OpenForm<CashierProductForm>();
        }
     
    }
}
