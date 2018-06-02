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
    public partial class KhachHang : DevExpress.XtraEditors.XtraUserControl
    {

        private static KhachHang instance;

        BindingSource list = new BindingSource();
        public KhachHang()
        {
            InitializeComponent();

            dgr_KhachHang.DataSource = list;

            Load_All();
        }

        public static KhachHang Instance
        {
            get
            {
                if (instance == null) instance = new KhachHang();
                return instance;
            }

        }

        #region chức năng
        private void Disable_Control()
        {
            txbTenKH.Enabled = false;
            txb_DiaChiKH.Enabled = false;
            txb_MaKH.Enabled = false;
            txb_PhoneKH.Enabled = false;
            dtp_NgaySinhKH.Enabled = false;

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
            txbTenKH.Enabled = true;
            txb_DiaChiKH.Enabled = true;
            txb_MaKH.Enabled = false;
            txb_PhoneKH.Enabled = true;
            dtp_NgaySinhKH.Enabled = true;
        }

        private void Clear_Control()
        {
            txbTenKH.Text = "";
            txb_DiaChiKH.Text = "";
            txb_MaKH.Text = "";
            txb_PhoneKH.Text = "";
            dtp_NgaySinhKH.DateTime = DateTime.Now;
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
            Load_dgr_KhachHang();
            AddKhachHangBinding();
        }

        private void Load_dgr_KhachHang()
        {
            list.DataSource = new CustomerDAO().ListAll();
        }

        private void AddKhachHangBinding()
        {
            txb_DiaChiKH.DataBindings.Add("Text", dgr_KhachHang.DataSource, "Address", true, DataSourceUpdateMode.Never);
            txb_MaKH.DataBindings.Add("Text", dgr_KhachHang.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txb_PhoneKH.DataBindings.Add("Text", dgr_KhachHang.DataSource, "Phone", true, DataSourceUpdateMode.Never);
            txbTenKH.DataBindings.Add("Text", dgr_KhachHang.DataSource, "Name", true, DataSourceUpdateMode.Never);
            dtp_NgaySinhKH.DataBindings.Add("DateTime", dgr_KhachHang.DataSource, "DateOfBirth", true, DataSourceUpdateMode.Never);

        }
        #endregion

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
                    Customer item = new Customer();

                    item.Name = txbTenKH.Text;
                    item.Address = txb_DiaChiKH.Text;;
                    item.Phone = txb_PhoneKH.Text;;
                    item.DateOfBirth = dtp_NgaySinhKH.DateTime;

                    long result = new CustomerDAO().Insert_Customer(item);

                    if (result != 0)
                    {
                        MessageBox.Show("Thêm khách hàng thành công");
                        Disable_Control();
                        Load_dgr_KhachHang();
                    }
                    else
                        MessageBox.Show("Thêm khách hàng xảy ra lỗi");
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
                    Customer item = new Customer();

                    item.ID = Convert.ToInt32(txb_MaKH.Text);
                    item.Name = txbTenKH.Text;
                    item.Address = txb_DiaChiKH.Text;;
                    item.Phone = txb_PhoneKH.Text;
                    item.DateOfBirth = dtp_NgaySinhKH.DateTime;

                    bool result = new CustomerDAO().Update_Customer(item);

                    if (result)
                    {
                        MessageBox.Show("Sửa khách hàng thành công");
                        Disable_Control();
                        Load_dgr_KhachHang();
                    }
                    else
                        MessageBox.Show("Sửa khách hàng xảy ra lỗi");
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
                    long Emp_ID = Convert.ToInt32(grv_KhachHang.GetFocusedRowCellValue("ID"));

                    bool result = new CustomerDAO().Delete_Customer(Emp_ID);
                    if (result)
                    {
                        MessageBox.Show("Xóa Khách hàng thành công");
                        Disable_Control();
                        Load_dgr_KhachHang();
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
                Load_dgr_KhachHang();
            }
        }
    }
}
