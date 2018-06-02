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

namespace MainForm.HeThong
{
    public partial class DanhSachQuyen : DevExpress.XtraEditors.XtraUserControl
    {

        private static DanhSachQuyen instance;

        BindingSource list = new BindingSource();
        public DanhSachQuyen()
        {
            InitializeComponent();

            dgr_Quyen.DataSource = list;

            Load_All();
        }

        public static DanhSachQuyen Instance
        {
            get
            {
                if (instance == null) instance = new DanhSachQuyen();
                return instance;
            }
        }

        #region chức năng
        private void Disable_Control()
        {
            txbMaQuyen.Enabled = false;
            txbTenQuyen.Enabled = false;

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
            txbMaQuyen.Enabled = false;
            txbTenQuyen.Enabled = true;
        }

        private void Clear_Control()
        {
            txbMaQuyen.Text = "";
            txbTenQuyen.Text = "";
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
            Load_dgr_Quyen();

            AddQuyenBinding();
        }

        private void Load_dgr_Quyen()
        {
            list.DataSource = new PermissionDAO().ListAll();
        }

        private void AddQuyenBinding()
        {
            txbMaQuyen.DataBindings.Add("Text", dgr_Quyen.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txbTenQuyen.DataBindings.Add("Text", dgr_Quyen.DataSource, "Name", true, DataSourceUpdateMode.Never);


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
                    Permission item = new Permission();

                    item.Name = txbTenQuyen.Text;

                    long result = new PermissionDAO().Insert_Permission(item);

                    if (result != 0)
                    {
                        MessageBox.Show("Thêm quyền thành công");
                        Disable_Control();
                        Load_dgr_Quyen();
                    }
                    else
                        MessageBox.Show("Thêm quyền xảy ra lỗi");
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
                    Permission item = new Permission();

                    item.ID = Convert.ToInt32(txbMaQuyen.Text);
                    item.Name = txbTenQuyen.Text;

                    bool result = new PermissionDAO().Update_Permission(item);

                    if (result)
                    {
                        MessageBox.Show("Sửa quyền thành công");
                        Disable_Control();
                        Load_dgr_Quyen();
                    }
                    else
                        MessageBox.Show("Sửa quyền xảy ra lỗi");
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
                    long Emp_ID = Convert.ToInt32(grv_Quyen.GetFocusedRowCellValue("ID"));

                    bool result = new PermissionDAO().Delete_Permission(Emp_ID);
                    if (result)
                    {
                        MessageBox.Show("Xóa thành công");
                        Disable_Control();
                        Load_dgr_Quyen();
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
                Load_dgr_Quyen();
            }
        }
    }
}
