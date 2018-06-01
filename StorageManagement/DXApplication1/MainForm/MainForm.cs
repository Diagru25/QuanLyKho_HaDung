using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MainForm.Model.EF;

namespace MainForm
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm(Account acc)
        {
            InitializeComponent();
        }
        void LoadUserControl(Control ctrl)
        {
            if (!panelmain.Controls.Contains(ctrl))
            {
                panelmain.Controls.Add(ctrl);
                ctrl.Dock = DockStyle.Fill;
            }
            ctrl.BringToFront();
        }
    }
}
