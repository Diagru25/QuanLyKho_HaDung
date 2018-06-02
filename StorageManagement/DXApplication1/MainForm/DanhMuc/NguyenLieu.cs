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

namespace MainForm.DanhMuc
{
    public partial class NguyenLieu : DevExpress.XtraEditors.XtraUserControl
    {
        private static NguyenLieu instance;

        BindingSource list = new BindingSource();

        public NguyenLieu()
        {
            InitializeComponent();

            dgr_NL.DataSource = list;

            Load_All();
        }

        public static NguyenLieu Instance
        {
            get
            {
                if (instance == null) instance = new NguyenLieu();
                return instance;
            }
        }

        #region chức năng
        private void Disable_Control()
        {
            txb_MaNL.Enabled = false;
            txb_TenNL.Enabled = false;
            txb_Gia.Enabled = false;
            txb_DonViTinh.Enabled = false;
            cbo_LoaiNL.Enabled = false;

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
            txb_MaNL.Enabled = false;
            txb_TenNL.Enabled = true;
            txb_Gia.Enabled = true;
            txb_DonViTinh.Enabled = true;
            cbo_LoaiNL.Enabled = true;
        }

        private void Clear_Control()
        {
            txb_MaNL.Text = "";
            txb_TenNL.Text = "";
            txb_Gia.Text = "";
            txb_DonViTinh.Text = "";
            cbo_LoaiNL.SelectedIndex = 0;
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
            Load_dgr_NL();
            Load_cbo_LNL();
            AddNLBinding();
        }

        private void Load_cbo_LNL()
        {

            cbo_LoaiNL.DataSource = new TypeMaterialDAO().ListAll();
            cbo_LoaiNL.ValueMember = "ID";
            cbo_LoaiNL.DisplayMember = "Name";
        }

        private void Load_dgr_NL()
        {
            list.DataSource = new MaterialDAO().ListAll();
        }

        private void AddNLBinding()
        {
            txb_DonViTinh.DataBindings.Add("Text", dgr_NL.DataSource, "Unit", true, DataSourceUpdateMode.Never);
            txb_Gia.DataBindings.Add("Text", dgr_NL.DataSource, "Price", true, DataSourceUpdateMode.Never);
            txb_MaNL.DataBindings.Add("Text", dgr_NL.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txb_TenNL.DataBindings.Add("Text", dgr_NL.DataSource, "Name", true, DataSourceUpdateMode.Never);
            cbo_LoaiNL.DataBindings.Add("SelectedValue", dgr_NL.DataSource, "TypeMaterialID", true, DataSourceUpdateMode.Never);

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
                    Material item = new Material();

                    item.Name = txb_TenNL.Text;
                    item.Unit = txb_DonViTinh.Text;
                    item.Price = Convert.ToDecimal(txb_Gia.Text);
                    item.TypeMaterialID = Convert.ToInt32(cbo_LoaiNL.SelectedValue);

                    long result = new MaterialDAO().Insert_Material(item);

                    if (result != 0)
                    {
                        MessageBox.Show("Thêm nguyên liệu thành công");
                        Disable_Control();
                        Load_dgr_NL();
                    }
                    else
                        MessageBox.Show("Thêm nguyên liệu xảy ra lỗi");
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
                    Material item = new Material();

                    item.ID = Convert.ToInt32(txb_MaNL.Text);
                    item.Name = txb_TenNL.Text;
                    item.Unit = txb_DonViTinh.Text;
                    item.Price = Convert.ToDecimal(txb_Gia.Text);
                    item.TypeMaterialID = Convert.ToInt32(cbo_LoaiNL.SelectedValue);

                    bool result = new MaterialDAO().Update_Material(item);

                    if (result)
                    {
                        MessageBox.Show("Sửa nguyên liệu thành công");
                        Disable_Control();
                        Load_dgr_NL();
                    }
                    else
                        MessageBox.Show("Sửa nguyên liệu xảy ra lỗi");
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
                    long Emp_ID = Convert.ToInt32(grv_NL.GetFocusedRowCellValue("ID"));

                    bool result = new MaterialDAO().Delete_Material(Emp_ID);
                    if (result)
                    {
                        MessageBox.Show("Xóa nguyên liệu thành công");
                        Disable_Control();
                        Load_dgr_NL();
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
                Load_dgr_NL();
            }
        }
    }
}
