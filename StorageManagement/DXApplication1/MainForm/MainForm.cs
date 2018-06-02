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
using MainForm.DanhMuc;
using MainForm.HeThong;

namespace MainForm
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Login frm;
        private Account acc = new Account();
        public MainForm(Account _acc, Login _frm)
        {
            InitializeComponent();

            frm = _frm;
            acc = _acc;
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

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadUserControl(YeuCauXuat.Instance);
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadUserControl(NguyenLieu.Instance);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadUserControl(uscNhanVien.Instance);
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadUserControl(KhachHang.Instance);
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadUserControl(NhaCC.Instance);
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadUserControl(LoaiNL.Instance);
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadUserControl(ThanhPham.Instance);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangePassword frm = new ChangePassword(acc);

            LoadUserControl(frm);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserInfo frm = new UserInfo(acc);

            LoadUserControl(frm);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadUserControl(DanhSachQuyen.Instance);
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadUserControl(LoaiTP.Instance);
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadUserControl(PhanQuyen.Instance);
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadUserControl(ChiTietTonKho.Instance);
        }
    }
}
