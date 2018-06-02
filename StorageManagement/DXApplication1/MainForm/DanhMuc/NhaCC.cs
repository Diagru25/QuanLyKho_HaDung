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
    public partial class NhaCC : DevExpress.XtraEditors.XtraUserControl
    {
        private static NhaCC instance;

        BindingSource list = new BindingSource();
        public NhaCC()
        {
            InitializeComponent();

            dgr_NCC.DataSource = list;

            Load_All();
        }

        public static NhaCC Instance
        {
            get
            {
                if (instance == null) instance = new NhaCC();
                return instance;
            }

        }

        #region chức năng
        private void Disable_Control()
        {
            txb_DiaChiNCC.Enabled = false;
            txb_MaNCC.Enabled = false;
            txb_MoTa.Enabled = false;
            txb_PhoneNCC.Enabled = false;
            txb_TenNCC.Enabled = false;

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
            txb_DiaChiNCC.Enabled = true;
            txb_MaNCC.Enabled = false;
            txb_MoTa.Enabled = true;
            txb_PhoneNCC.Enabled = true;
            txb_TenNCC.Enabled = true;
        }

        private void Clear_Control()
        {
            txb_DiaChiNCC.Text = "";
            txb_MaNCC.Text = "";
            txb_MoTa.Text = "";
            txb_PhoneNCC.Text = "";
            txb_TenNCC.Text = "";
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
            Load_dgr_NCC();
            AddNCCBinding();
        }

        private void Load_dgr_NCC()
        {
            list.DataSource = new SupplierDAO().ListAll();
        }

        private void AddNCCBinding()
        {
            txb_DiaChiNCC.DataBindings.Add("Text", dgr_NCC.DataSource, "Address", true, DataSourceUpdateMode.Never);
            txb_MaNCC.DataBindings.Add("Text", dgr_NCC.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txb_MoTa.DataBindings.Add("Text", dgr_NCC.DataSource, "Describe", true, DataSourceUpdateMode.Never);
            txb_PhoneNCC.DataBindings.Add("Text", dgr_NCC.DataSource, "Phone", true, DataSourceUpdateMode.Never);
            txb_TenNCC.DataBindings.Add("Text", dgr_NCC.DataSource, "Name", true, DataSourceUpdateMode.Never);

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
                    Supplier item = new Supplier();

                    item.Name = txb_TenNCC.Text;
                    item.Address = txb_DiaChiNCC.Text;
                    item.Describe = txb_MoTa.Text;
                    item.Phone = txb_PhoneNCC.Text;

                    long result = new SupplierDAO().Insert_Supplier(item);

                    if (result != 0)
                    {
                        MessageBox.Show("Thêm nhà cung cấp thành công");
                        Disable_Control();
                        Load_dgr_NCC();
                    }
                    else
                        MessageBox.Show("Thêm nhà cung cấp xảy ra lỗi");
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
                    Supplier item = new Supplier();

                    item.ID = Convert.ToInt32(txb_MaNCC.Text);
                    item.Name = txb_TenNCC.Text;
                    item.Address = txb_DiaChiNCC.Text;
                    item.Describe = txb_MoTa.Text;
                    item.Phone = txb_PhoneNCC.Text;

                    bool result = new SupplierDAO().Update_Supplier(item);

                    if (result)
                    {
                        MessageBox.Show("Sửa nhà cung cấp thành công");
                        Disable_Control();
                        Load_dgr_NCC();
                    }
                    else
                        MessageBox.Show("Sửa nhà cung cấp xảy ra lỗi");
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
                    long Emp_ID = Convert.ToInt32(grv_NCC.GetFocusedRowCellValue("ID"));

                    bool result = new SupplierDAO().Delete_Supplier(Emp_ID);
                    if (result)
                    {
                        MessageBox.Show("Xóa nhà cung cấp thành công");
                        Disable_Control();
                        Load_dgr_NCC();
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
                Load_dgr_NCC();
            }
        }
    }
}
