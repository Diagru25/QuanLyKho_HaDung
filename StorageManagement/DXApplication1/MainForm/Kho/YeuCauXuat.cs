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
using MainForm.Model.View;
using MainForm;
using MainForm.Report;

namespace MainForm.Kho
{
    public partial class YeuCauXuat : DevExpress.XtraEditors.XtraUserControl
    {
        private static YeuCauXuat _instance;
        private static DeliveryNoteDetail _itemdetail = new DeliveryNoteDetail();


        public static YeuCauXuat Instance
        {
            get
            {
                _instance = new YeuCauXuat();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }

        public static DeliveryNoteDetail Itemdetail
        {
            get
            {
                return _itemdetail;
            }

            set
            {
                _itemdetail = value;
            }
        }

        public YeuCauXuat()
        {           
            InitializeComponent();
            LoadList();       
        }
        void LoadList()
        {
            cb_Storage.DataSource = new StorageDAO().ListAll();
            cb_Storage.ValueMember = "ID";
            cb_Storage.DisplayMember = "Name";

            cb_Customer.DataSource = new CustomerDAO().ListAll();
            cb_Customer.ValueMember = "ID";
            cb_Customer.DisplayMember = "Name";
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (date_Out.DateTime.Year == 0001 )
            {
                MessageBox.Show("Chọn ngày nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DeliveryNote dn = new DeliveryNote();
            dn.CustomerID = Convert.ToInt64(cb_Customer.SelectedValue);
            dn.StorageID = Convert.ToInt64(cb_Storage.SelectedValue);
            dn.DeliveryDate = date_Out.DateTime;
            dn.EmployeeID = MainForm.UserID;
            dn.Status = 0;

            var res = new DeliveryNoteDAO().Insert(dn);
            if (res!= 0)
            {
                MessageBox.Show("Thêm thành công phiếu xuất ! Mời thêm chi tiết phiếu", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridControl1.Enabled = true;
                btn_ThemChiTietXuat.Enabled = true;
                btn_Finish.Enabled = true;
                Itemdetail.DeliveryNoteID = res;
            }
        }

        private void btn_ThemChiTietXuat_Click(object sender, EventArgs e)
        {
            ThemChiTietXuat f = new ThemChiTietXuat();
            f.FormClosed += ThemChiTietXuat_Closed;
            f.Show();
            return;
        }

        private void ThemChiTietXuat_Closed(object sender, FormClosedEventArgs e)
        {
            var dao = new DeliveryNoteDAO();
            dao.InsertDetail(Itemdetail);
            gridControl1.DataSource = dao.GetDetail(Itemdetail.DeliveryNoteID);
            new DeliveryNoteDAO().Amount(Itemdetail.DeliveryNoteID);
        }

        private void btn_XoaChiTietXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs =  MessageBox.Show("Bạn muốn xóa chi tiết phiếu ?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(rs == DialogResult.OK)
            {
                var dao = new DeliveryNoteDAO();
                dao.DeleteDetail(Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID").ToString()));
                gridControl1.DataSource = dao.GetDetail(Itemdetail.DeliveryNoteID);
                if(dao.GetDetail(Itemdetail.DeliveryNoteID).Count == 0)
                {
                    btn_XoaChiTietXuat.Enabled = false;
                }
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btn_XoaChiTietXuat.Enabled = true;
        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {
            if(new DeliveryNoteDAO().GetDetail(Itemdetail.DeliveryNoteID).Count == 0)
            {
                MessageBox.Show("Bạn phải nhập chi tiết phiếu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đã hoàn thành !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_Print.Enabled = true;                      
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            new PhieuYeuCauXuat().Show(this);
        }
    }
}
