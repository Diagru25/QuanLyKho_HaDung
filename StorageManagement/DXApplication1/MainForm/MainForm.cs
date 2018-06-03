using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MainForm.Model.EF;
using MainForm.Kho;

namespace MainForm
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private static long? _userID;

        public static long? UserID
        {
            get
            {
                return _userID;
            }
        }

        public MainForm(Account acc)
        {
            InitializeComponent();
            _userID = acc.EmployeeID;
        }
        void LoadUserControl(Control ctrl)
        {
            if (panelmain.Controls.Count != 0) panelmain.Controls.Clear();
            if (!panelmain.Controls.Contains(ctrl))
            {
                panelmain.Controls.Add(ctrl);
                ctrl.Dock = DockStyle.Fill;
            }
            ctrl.BringToFront();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadUserControl(YeuCauXuat.Instance);
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadUserControl(YeuCauNhap.Instance);
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadUserControl(SoPhieuXuat.Instance);
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadUserControl(SoPhieuNhap.Instance);
        }
    }
}
