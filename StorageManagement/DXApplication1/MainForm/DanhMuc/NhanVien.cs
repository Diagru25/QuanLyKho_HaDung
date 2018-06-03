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
using MainForm.Model.DAO;
using MainForm.Model.EF;
using MainForm.Properties;

namespace MainForm.DanhMuc
{
    public partial class uscNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        private static uscNhanVien instance;

        BindingSource list = new BindingSource();
        public static uscNhanVien Instance
        {
            get
            {
                if (instance == null) instance = new uscNhanVien();
                return instance;
            }

        }

        public uscNhanVien()
        {
            InitializeComponent();

            dgr_NhanVien.DataSource = list;

            Load_All();
        }

        #region chức năng
        private void Disable_Control()
        {
            txbDiaChiNV.Enabled = false;
            txb_ChucVu.Enabled = false;
            txb_MaNV.Enabled = false;
            txb_PhoneNV.Enabled = false;
            txb_TenNV.Enabled = false;
            txb_Email.Enabled = false;
            cbo_GioiTinh.Enabled = false;
            dtp_NgaySinhNV.Enabled = false;

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
            txbDiaChiNV.Enabled = true;
            txb_ChucVu.Enabled = true;
            txb_MaNV.Enabled = false;
            txb_PhoneNV.Enabled = true;
            txb_TenNV.Enabled = true;
            txb_Email.Enabled = true;
            cbo_GioiTinh.Enabled = true;
            dtp_NgaySinhNV.Enabled = true;
        }

        private void Clear_Control()
        {
            txbDiaChiNV.Text = "";
            txb_ChucVu.Text = "";
            txb_MaNV.Text = "";
            txb_PhoneNV.Text = "";
            txb_TenNV.Text = "";
            txb_Email.Text = "";
            cbo_GioiTinh.SelectedIndex = 0;
            dtp_NgaySinhNV.DateTime = DateTime.Now;
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
            Load_dgr_NhanVien();
            Load_cbo_gioitinh();
            AddNhanVienBinding();
        }

        private void Load_cbo_gioitinh()
        {
            var a = new { ID = false, Name = "Nam" };
            var b = new { ID = true, Name = "Nữ" };
            List<object> list_gender = new List<object>();
            list_gender.Add(a);
            list_gender.Add(b);

            cbo_GioiTinh.DataSource = list_gender;
            cbo_GioiTinh.ValueMember = "ID";
            cbo_GioiTinh.DisplayMember = "Name";
        }

        private void Load_dgr_NhanVien()
        {
            list.DataSource = new EmployeeDAO().ListAll();
        }

        private void AddNhanVienBinding()
        {
            txbDiaChiNV.DataBindings.Add("Text", dgr_NhanVien.DataSource, "Address", true, DataSourceUpdateMode.Never);
            txb_ChucVu.DataBindings.Add("Text", dgr_NhanVien.DataSource, "Regency", true, DataSourceUpdateMode.Never);
            txb_Email.DataBindings.Add("Text", dgr_NhanVien.DataSource, "Email", true, DataSourceUpdateMode.Never);
            txb_MaNV.DataBindings.Add("Text", dgr_NhanVien.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txb_PhoneNV.DataBindings.Add("Text", dgr_NhanVien.DataSource, "Phone", true, DataSourceUpdateMode.Never);
            txb_TenNV.DataBindings.Add("Text", dgr_NhanVien.DataSource, "Name", true, DataSourceUpdateMode.Never);
            cbo_GioiTinh.DataBindings.Add("SelectedValue", dgr_NhanVien.DataSource, "Gender", true, DataSourceUpdateMode.Never);
            dtp_NgaySinhNV.DataBindings.Add("DateTime", dgr_NhanVien.DataSource, "DateOfBirth", true, DataSourceUpdateMode.Never);

        }
        #endregion

        #region Event
        private void btnThen_Click(object sender, EventArgs e)
        {
            if(btnThem.Text == "Thêm")
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

            if(btnThem.Text == "Lưu")
            {
                if(Validate())
                {
                    Employee item = new Employee();

                    item.Name = txb_TenNV.Text;
                    item.Address = txbDiaChiNV.Text;
                    item.Email = txb_Email.Text;
                    item.Phone = txb_PhoneNV.Text;
                    item.Regency = txb_ChucVu.Text;
                    item.Gender = (bool)cbo_GioiTinh.SelectedValue;
                    item.DateOfBirth = dtp_NgaySinhNV.DateTime;

                    long result = new EmployeeDAO().Insert_Employee(item);

                    if (result != 0)
                    {
                        MessageBox.Show("Thêm nhân viên thành công");
                        Disable_Control();
                        Load_dgr_NhanVien();
                    }
                    else
                        MessageBox.Show("Thêm nhân viên xảy ra lỗi");
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
                    Employee item = new Employee();

                    item.ID = Convert.ToInt32(txb_MaNV.Text);
                    item.Name = txb_TenNV.Text;
                    item.Address = txbDiaChiNV.Text;
                    item.Email = txb_Email.Text;
                    item.Phone = txb_PhoneNV.Text;
                    item.Regency = txb_ChucVu.Text;
                    item.Gender = (bool)cbo_GioiTinh.SelectedValue;
                    item.DateOfBirth = dtp_NgaySinhNV.DateTime;

                    bool result = new EmployeeDAO().Update_Employee(item);

                    if (result)
                    {
                        MessageBox.Show("Sửa nhân viên thành công");
                        Disable_Control();
                        Load_dgr_NhanVien();
                    }
                    else
                        MessageBox.Show("Sửa nhân viên xảy ra lỗi");
                }
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(btnXoa.Text == "Xóa")
            {

                DialogResult rs = MessageBox.Show( "Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo);
                if(rs == DialogResult.Yes)
                {
                    long Emp_ID = Convert.ToInt32(grv_NhanVien.GetFocusedRowCellValue("ID"));

                    bool result = new EmployeeDAO().Delete_Employee(Emp_ID);
                    if (result)
                    {
                        MessageBox.Show("Xóa nhân viên thành công");
                        Disable_Control();
                        Load_dgr_NhanVien();
                    }
                    else
                        MessageBox.Show("Có lỗi xảy ra");
                }
                
            }
            
            if(btnXoa.Text == "Hủy")
            {
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                btnXoa.Text = "Xóa";

                Disable_Control();
                Load_dgr_NhanVien();
            }
        }
        #endregion
    }
}
