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
    public partial class UserInfo : DevExpress.XtraEditors.XtraUserControl
    {
        private Account acc = new Account();
        public UserInfo(Account _acc)
        {
            InitializeComponent();

            acc = _acc;

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
            txb_TenDangNhap.Enabled = false;
            txb_Quyen.Enabled = false;
            cbo_GioiTinh.Enabled = false;
            dtp_NgaySinhNV.Enabled = false;

            btnSua.Text = "Sửa";
            btnSua.Enabled = true;
            btnSua.Image = Resources.edit_32x32;
            btnHuy.Enabled = false;


        }

        private void Enable_Control()
        {
            txbDiaChiNV.Enabled = true;
            txb_ChucVu.Enabled = true;
            txb_MaNV.Enabled = false;
            txb_PhoneNV.Enabled = true;
            txb_TenNV.Enabled = true;
            txb_Email.Enabled = true;
            txb_TenDangNhap.Enabled = false;
            txb_Quyen.Enabled = false;
            cbo_GioiTinh.Enabled = true;
            dtp_NgaySinhNV.Enabled = true;

            btnHuy.Enabled = true;
        }

        private void Clear_Control()
        {
            txbDiaChiNV.Text = "";
            txb_ChucVu.Text = "";
            txb_MaNV.Text = "";
            txb_PhoneNV.Text = "";
            txb_TenNV.Text = "";
            txb_Email.Text = "";
            txb_TenDangNhap.Text = "";
            txb_Quyen.Text = "";
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
            Load_cbo_gioitinh();
            Load_Info();
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

        private void Load_Info()
        {
            Employee item = new EmployeeDAO().Get_Emp_By_ID(acc.EmployeeID);

            txb_TenDangNhap.Text = acc.UserName;
            txb_Quyen.Text = new AccoutDAO().Get_Name_Permision_By_PerID(acc.PermissionID);
            txbDiaChiNV.Text = item.Address;
            txb_ChucVu.Text = item.Regency;
            txb_MaNV.Text = item.ID.ToString();
            txb_PhoneNV.Text = item.Phone;
            txb_TenNV.Text = item.Name;
            txb_Email.Text = item.Email;
            cbo_GioiTinh.SelectedValue = item.Gender;
            dtp_NgaySinhNV.DateTime = (DateTime)item.DateOfBirth;
        }
        #endregion

        #region Event
        private void btnSua_Click(object sender, EventArgs e)
        {
            if(btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu";
                btnSua.Image = Resources.download_32x32;
                Enable_Control();

                return;
            }

            if(btnSua.Text == "Lưu")
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
                        MessageBox.Show("Cập nhật thông tin thành công");
                        Disable_Control();
                        Load_Info();
                    }
                    else
                        MessageBox.Show("Cập nhật thông tin xảy ra lỗi");
                }
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Clear_Control();
            Load_All();

        }
        #endregion
    }
}
