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
    public partial class LoaiTP : DevExpress.XtraEditors.XtraUserControl
    {
        private static LoaiTP instance;

        BindingSource list = new BindingSource();
        public LoaiTP()
        {
            InitializeComponent();

            dgr_LTP.DataSource = list;

            Load_All();
        }

        public static LoaiTP Instance
        {
            get
            {
                if (instance == null) instance = new LoaiTP();
                return instance;
            }
        }

        #region chức năng
        private void Disable_Control()
        {
            txbMaLTP.Enabled = false;
            txbTenLTP.Enabled = false;
            txb_TacDung.Enabled = false;
            txb_MoTa.Enabled = false;

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
            txbMaLTP.Enabled = false;
            txbTenLTP.Enabled = true;
            txb_TacDung.Enabled = true;
            txb_MoTa.Enabled = true;
        }

        private void Clear_Control()
        {
            txbMaLTP.Text = "";
            txbTenLTP.Text = "";
            txb_TacDung.Text = "";
            txb_MoTa.Text = "";
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
            Load_dgr_LTP();

            AddLTPBinding();
        }

        private void Load_dgr_LTP()
        {
            list.DataSource = new TypeProductDAO().ListAll();
        }

        private void AddLTPBinding()
        {
            txbMaLTP.DataBindings.Add("Text", dgr_LTP.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txbTenLTP.DataBindings.Add("Text", dgr_LTP.DataSource, "Name", true, DataSourceUpdateMode.Never);
            txb_TacDung.DataBindings.Add("Text", dgr_LTP.DataSource, "Faculty", true, DataSourceUpdateMode.Never);
            txb_MoTa.DataBindings.Add("Text", dgr_LTP.DataSource, "Describe", true, DataSourceUpdateMode.Never);

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
                    TypeProduct item = new TypeProduct();

                    item.Name = txbTenLTP.Text;
                    item.Faculty = txb_TacDung.Text;
                    item.Describe = txb_MoTa.Text;

                    long result = new TypeProductDAO().Insert_TypeProduct(item);

                    if (result != 0)
                    {
                        MessageBox.Show("Thêm loại thành phẩm thành công");
                        Disable_Control();
                        Load_dgr_LTP();
                    }
                    else
                        MessageBox.Show("Thêm loại thành phẩm xảy ra lỗi");
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
                    TypeProduct item = new TypeProduct();

                    item.ID = Convert.ToInt32(txbMaLTP.Text);
                    item.Name = txbTenLTP.Text;
                    item.Faculty = txb_TacDung.Text;
                    item.Describe = txb_MoTa.Text;

                    bool result = new TypeProductDAO().Update_TypeProduct(item);

                    if (result)
                    {
                        MessageBox.Show("Sửa loại thành phẩm thành công");
                        Disable_Control();
                        Load_dgr_LTP();
                    }
                    else
                        MessageBox.Show("Sửa loại thành phẩm xảy ra lỗi");
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
                    long Emp_ID = Convert.ToInt32(grv_LTP.GetFocusedRowCellValue("ID"));

                    bool result = new TypeProductDAO().Delete_TypeProduct(Emp_ID);
                    if (result)
                    {
                        MessageBox.Show("Xóa loại thành phẩm thành công");
                        Disable_Control();
                        Load_dgr_LTP();
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
                Load_dgr_LTP();
            }
        }
    }
}
