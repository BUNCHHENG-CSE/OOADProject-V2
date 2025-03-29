using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Facade.Dashboard;

public  class DisplayFacade(Panel mainPanel)
{
    private readonly  Panel _mainPanel = mainPanel;
    public void OpenForm<T>() where T : Form, new()
    {
        if (_mainPanel.Controls.Count > 0)
        {
            if (_mainPanel.Controls[0] is Form oldForm)
            {
                oldForm.Close();
                oldForm.Dispose();
            }
        }

        var newForm = new T
        {
            TopLevel = false,
            Dock = DockStyle.Fill,
            FormBorderStyle = FormBorderStyle.None
        };

        _mainPanel.Controls.Clear();
        _mainPanel.Controls.Add(newForm);
        newForm.Show();
    }
}
