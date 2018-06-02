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
    public partial class LoaiNL : DevExpress.XtraEditors.XtraUserControl
    {
        private static LoaiNL instance;

        BindingSource list = new BindingSource();
        public LoaiNL()
        {
            InitializeComponent();

            dgr_LNN.DataSource = list;

            Load_All();
        }

        public static LoaiNL Instance
        {
            get
            {
                if (instance == null) instance = new LoaiNL();
                return instance;
            }
        }

        #region chức năng
        private void Disable_Control()
        {
            txbMaLNL.Enabled = false;
            txbTenLNL.Enabled = false;
            cbo_NCC.Enabled = false;

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
            txbMaLNL.Enabled = false;
            txbTenLNL.Enabled = true;
            cbo_NCC.Enabled = true;
        }

        private void Clear_Control()
        {
            txbMaLNL.Text = "";
            txbTenLNL.Text = "";
            cbo_NCC.SelectedIndex = 0;
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
            Load_cbo_NCC();
            Load_dgr_LNN();
            
            AddLNNBinding();
        }
        private void Load_cbo_NCC()
        {
            cbo_NCC.DataSource = new SupplierDAO().ListAll();
            cbo_NCC.ValueMember = "ID";
            cbo_NCC.DisplayMember = "Name";
        }

        private void Load_dgr_LNN()
        {
            list.DataSource = new TypeMaterialDAO().ListAll();
        }

        private void AddLNNBinding()
        {
            txbMaLNL.DataBindings.Add("Text", dgr_LNN.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txbTenLNL.DataBindings.Add("Text", dgr_LNN.DataSource, "Name", true, DataSourceUpdateMode.Never);
            cbo_NCC.DataBindings.Add("SelectedValue", dgr_LNN.DataSource, "SupplierID", true, DataSourceUpdateMode.Never);

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
                    TypeMaterial item = new TypeMaterial();

                    item.Name = txbTenLNL.Text;
                    item.SupplierID = Convert.ToInt32(cbo_NCC.SelectedValue);

                    long result = new TypeMaterialDAO().Insert_TypeMaterial(item);

                    if (result != 0)
                    {
                        MessageBox.Show("Thêm loại nguyên liệu thành công");
                        Disable_Control();
                        Load_dgr_LNN();
                    }
                    else
                        MessageBox.Show("Thêm loại nguyên liệu xảy ra lỗi");
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
                    TypeMaterial item = new TypeMaterial();

                    item.ID = Convert.ToInt32(txbMaLNL.Text);
                    item.Name = txbTenLNL.Text;
                    item.SupplierID = Convert.ToInt32(cbo_NCC.SelectedValue);

                    bool result = new TypeMaterialDAO().Update_TypeMaterial(item);

                    if (result)
                    {
                        MessageBox.Show("Sửa loại nguyên liệu thành công");
                        Disable_Control();
                        Load_dgr_LNN();
                    }
                    else
                        MessageBox.Show("Sửa loại nguyên liệu xảy ra lỗi");
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
                    long Emp_ID = Convert.ToInt32(grv_LNN.GetFocusedRowCellValue("ID"));

                    bool result = new TypeMaterialDAO().Delete_TypeMaterial(Emp_ID);
                    if (result)
                    {
                        MessageBox.Show("Xóa loại nguyên liệu thành công");
                        Disable_Control();
                        Load_dgr_LNN();
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
                Load_dgr_LNN();
            }
        }
    }
}
