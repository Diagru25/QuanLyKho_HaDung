using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MainForm.Model.EF;
using MainForm.Model.DAO;
using MainForm.Properties;

namespace MainForm.HeThong
{
    public partial class PhanQuyen : DevExpress.XtraEditors.XtraUserControl
    {
        private static PhanQuyen instance;

        BindingSource list = new BindingSource();
        public PhanQuyen()
        {
            InitializeComponent();

            dgr_PhanQuyen.DataSource = list;

            Load_All();
        }

        public static PhanQuyen Instance
        {
            get
            {
                if (instance == null) instance = new PhanQuyen();
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        #region chức năng
        private void Disable_Control()
        {
            txb_Username.Enabled = false;
            txb_pass.Enabled = false;
            cbo_NhanVien.Enabled = false;
            cbo_Quyen.Enabled = false;
            cbo_TrangThai.Enabled = false;
            dtp_NgayTao.Enabled = false;

            btnThem.Enabled = true;
            btnThem.Text = "Thêm";
            btnThem.Image = Resources.add_32x32;

            btnSua.Enabled = true;
            btnSua.Text = "Sửa";
            btnSua.Image = Resources.edit_32x32;

            btnXoa.Text = "Xóa";
            btnXoa.Image = Resources.delete_32x32;

        }

        private void Enable_Control()
        {
            txb_Username.Enabled = true;
            txb_pass.Enabled = true;
            cbo_NhanVien.Enabled = true;
            cbo_Quyen.Enabled = true;
            cbo_TrangThai.Enabled = true;
            dtp_NgayTao.Enabled = false;
        }

        private void Clear_Control()
        {
            txb_Username.Text = "";
            txb_pass.Text = "";
            cbo_NhanVien.SelectedIndex = 0;
            cbo_Quyen.SelectedIndex = 0;
            cbo_TrangThai.SelectedIndex = 0;
            dtp_NgayTao.DateTime = DateTime.Now;
        }

        private bool Validate()
        {
            return true;
        }

        #endregion

        #region Load data

        private void Load_All()
        {
            Disable_Control();
            Load_cbo_Quyen();
            Load_cbo_NhanVien();
            Load_cbo_TrangThai();
            Load_dgr_PhanQuyen();

            AddPhanQuyeninding();
        }

        private void Load_dgr_PhanQuyen()
        {
            // làm view model

            list.DataSource = new AccoutDAO().List_View_Account();
        }
        private void Load_cbo_Quyen()
        {
            cbo_Quyen.DataSource = new PermissionDAO().ListAll();
            cbo_Quyen.ValueMember = "ID";
            cbo_Quyen.DisplayMember = "Name";
        }

        private void Load_cbo_NhanVien()
        {
            cbo_NhanVien.DataSource = new EmployeeDAO().ListAll();
            cbo_NhanVien.ValueMember = "ID";
            cbo_NhanVien.DisplayMember = "Name";
        }

        private void Load_cbo_TrangThai()
        {
            var a = new { ID = true, Name = "Kích hoạt" };
            var b = new { ID = false, Name = "Khóa" };
            List<object> list_status = new List<object>();
            list_status.Add(a);
            list_status.Add(b);

            cbo_TrangThai.DataSource = list_status;
            cbo_TrangThai.ValueMember = "ID";
            cbo_TrangThai.DisplayMember = "Name";
        }

        private void AddPhanQuyeninding()
        {
            txb_Username.DataBindings.Add("Text", dgr_PhanQuyen.DataSource, "UserName", true, DataSourceUpdateMode.Never);
            txb_pass.DataBindings.Add("Text", dgr_PhanQuyen.DataSource, "PassWord", true, DataSourceUpdateMode.Never);
            cbo_NhanVien.DataBindings.Add("SelectedValue", dgr_PhanQuyen.DataSource, "EmployeeID", true, DataSourceUpdateMode.Never);
            cbo_Quyen.DataBindings.Add("SelectedValue", dgr_PhanQuyen.DataSource, "PermissionID", true, DataSourceUpdateMode.Never);
            cbo_TrangThai.DataBindings.Add("SelectedValue", dgr_PhanQuyen.DataSource, "Status", true, DataSourceUpdateMode.Never);
            dtp_NgayTao.DataBindings.Add("DateTime", dgr_PhanQuyen.DataSource, "CreateDate", true, DataSourceUpdateMode.Never);

        }
        #endregion

        #region Event
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Lưu";
                btnThem.Image = Resources.download_32x32;
                btnXoa.Text = "Hủy";
                btnXoa.Image = Resources.cancel_32x32;
                btnSua.Enabled = false;

                Clear_Control();
                Enable_Control();

                return;
            }

            if (btnThem.Text == "Lưu")
            {
                if (Validate())
                {
                    Account item = new Account();

                    item.UserName = txb_Username.Text;
                    item.PassWord = txb_pass.Text;
                    item.PermissionID = Convert.ToInt32(cbo_Quyen.SelectedValue);
                    item.EmployeeID = Convert.ToInt32(cbo_NhanVien.SelectedValue);
                    item.Status = (bool)cbo_TrangThai.SelectedValue;
                    item.CreateDate = DateTime.Now;

                    bool result = new AccoutDAO().Insert_Account(item);

                    if (result)
                    {
                        MessageBox.Show("Thêm tài khoản thành công");
                        Disable_Control();
                        Load_dgr_PhanQuyen();
                    }
                    else
                        MessageBox.Show("Thêm tài khoản xảy ra lỗi");
                }
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu";
                btnSua.Image = Resources.download_32x32;
                btnXoa.Text = "Hủy";
                btnXoa.Image = Resources.cancel_32x32;
                btnThem.Enabled = false;

                Enable_Control();

                return;
            }

            if (btnSua.Text == "Lưu")
            {
                if (Validate())
                {
                    Account item = new Account();

                    item.UserName = txb_Username.Text;
                    item.PermissionID = Convert.ToInt32(cbo_Quyen.SelectedValue);
                    item.EmployeeID = Convert.ToInt32(cbo_NhanVien.SelectedValue);
                    item.Status = (bool)cbo_TrangThai.SelectedValue;

                    bool result = new AccoutDAO().Update_Account(item);

                    if (result)
                    {
                        MessageBox.Show("Sửa tài khoản thành công");
                        Disable_Control();
                        Load_dgr_PhanQuyen();
                    }
                    else
                        MessageBox.Show("Sửa tài khoản xảy ra lỗi");
                }
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {

                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    string Emp_ID = grv_PhanQuyen.GetFocusedRowCellValue("UserName").ToString();

                    bool result = new AccoutDAO().Delete_Account(Emp_ID);
                    if (result)
                    {
                        MessageBox.Show("Xóa tài khoản thành công");
                        Disable_Control();
                        Load_dgr_PhanQuyen();
                    }
                    else
                        MessageBox.Show("Có lỗi xảy ra");
                }

            }

            if (btnXoa.Text == "Hủy")
            {
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                btnXoa.Text = "Xóa";

                Disable_Control();
                Load_dgr_PhanQuyen();
            }
        }
        #endregion
    }
}
