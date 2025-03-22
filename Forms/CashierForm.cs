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

namespace OOADPROV2.Forms
{
    public partial class CashierForm : Form
    {
        private LoadingForm loadingFormReference;
        private LoginForm loginFormReference;
        private DBConnectionForm databaseConnectionFormReference;

        public CashierForm(LoadingForm loadingForm, DBConnectionForm databaseConnectionForm, LoginForm login, User user)
        {
            InitializeComponent();
            loadingFormReference = loadingForm;
            loginFormReference = login;
            databaseConnectionFormReference = databaseConnectionForm;
            this.FormClosed += new FormClosedEventHandler(CashierForm_FormClosed);

        }
        private void CashierForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadingFormReference.Close();
            loginFormReference.Close();
            databaseConnectionFormReference.Close();
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {

        }
    }
}
