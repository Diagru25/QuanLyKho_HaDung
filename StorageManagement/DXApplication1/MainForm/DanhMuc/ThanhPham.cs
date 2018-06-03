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
    public partial class ThanhPham : DevExpress.XtraEditors.XtraUserControl
    {
        private static ThanhPham instance;

        BindingSource list = new BindingSource();
        public ThanhPham()
        {
            InitializeComponent();

            dgr_TP.DataSource = list;

            Load_All();
        }

        public static ThanhPham Instance
        {
            get
            {
                if (instance == null) instance = new ThanhPham();
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
            txb_MaTP.Enabled = false;
            txb_TenTP.Enabled = false;
            txb_GiaTP.Enabled = false;
            txb_DonViTinh.Enabled = false;
            cbo_LoaiTP.Enabled = false;

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
            txb_MaTP.Enabled = false;
            txb_TenTP.Enabled = true;
            txb_GiaTP.Enabled = true;
            txb_DonViTinh.Enabled = true;
            cbo_LoaiTP.Enabled = true;
        }

        private void Clear_Control()
        {
            txb_MaTP.Text = "";
            txb_TenTP.Text = "";
            txb_GiaTP.Text = "";
            txb_DonViTinh.Text = "";
            cbo_LoaiTP.SelectedIndex = 0;
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
            Load_cbo_LoaiTP();
            Load_dgr_TP();

            AddTPBinding();
        }

        private void Load_dgr_TP()
        {
            list.DataSource = new ProductDAO().ListAll();
        }
        private void Load_cbo_LoaiTP()
        {
            cbo_LoaiTP.DataSource = new TypeProductDAO().ListAll();
            cbo_LoaiTP.ValueMember = "ID";
            cbo_LoaiTP.DisplayMember = "Name";
        }

        private void AddTPBinding()
        {
            txb_MaTP.DataBindings.Add("Text", dgr_TP.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txb_TenTP.DataBindings.Add("Text", dgr_TP.DataSource, "Name", true, DataSourceUpdateMode.Never);
            //txb_GiaTP.DataBindings.Add("Text", dgr_TP.DataSource, "Price", true, DataSourceUpdateMode.Never);
            txb_DonViTinh.DataBindings.Add("Text", dgr_TP.DataSource, "Unit", true, DataSourceUpdateMode.Never);
            cbo_LoaiTP.DataBindings.Add("SelectedValue", dgr_TP.DataSource, "TypeProductID", true, DataSourceUpdateMode.Never);

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
                    Product item = new Product();

                    item.Name = txb_TenTP.Text;
                    item.Unit = txb_DonViTinh.Text;
                    item.TypeProductID = Convert.ToInt32(cbo_LoaiTP.SelectedValue);

                    long result = new ProductDAO().Insert_Product(item);

                    if (result != 0)
                    {
                        MessageBox.Show("Thêm thành phẩm thành công");
                        Disable_Control();
                        Load_dgr_TP();
                    }
                    else
                        MessageBox.Show("Thêm thành phẩm xảy ra lỗi");
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
                    Product item = new Product();

                    item.ID = Convert.ToInt32(txb_MaTP.Text);
                    item.Name = txb_TenTP.Text;
                    item.Unit = txb_DonViTinh.Text;
                    item.TypeProductID = Convert.ToInt32(cbo_LoaiTP.SelectedValue);

                    bool result = new ProductDAO().Update_Product(item);

                    if (result)
                    {
                        MessageBox.Show("Sửa thành phẩm thành công");
                        Disable_Control();
                        Load_dgr_TP();
                    }
                    else
                        MessageBox.Show("Sửa thành phẩm xảy ra lỗi");
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
                    long Emp_ID = Convert.ToInt32(grv_TP.GetFocusedRowCellValue("ID"));

                    bool result = new ProductDAO().Delete_Product(Emp_ID);
                    if (result)
                    {
                        MessageBox.Show("Xóa thành phẩm thành công");
                        Disable_Control();
                        Load_dgr_TP();
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
                Load_dgr_TP();
            }
        }
    }
}
