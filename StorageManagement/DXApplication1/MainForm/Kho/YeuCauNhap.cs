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
    public partial class YeuCauNhap : DevExpress.XtraEditors.XtraUserControl
    {
        private static YeuCauNhap _instance;
        private static ReceiptNoteDetail _itemdetail = new ReceiptNoteDetail();


        public static YeuCauNhap Instance
        {
            get
            {
                 _instance = new YeuCauNhap();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }

        public static ReceiptNoteDetail Itemdetail
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
        public YeuCauNhap()
        {
            InitializeComponent();
            LoadList();
        }
        void LoadList()
        {
            cb_Storage.DataSource = new StorageDAO().ListAll();
            cb_Storage.ValueMember = "ID";
            cb_Storage.DisplayMember = "Name";
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (date_In.DateTime.Year == 0001)
            {
                MessageBox.Show("Chọn ngày nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ReceiptNote dn = new ReceiptNote();
            dn.StorageID = Convert.ToInt64(cb_Storage.SelectedValue);
            dn.ReceiptDate = date_In.DateTime;
            dn.EmployeeID = MainForm.UserID;
            dn.Status = 0;

            var res = new ReceiptNoteDAO().Insert(dn);
            if (res != 0)
            {
                MessageBox.Show("Thêm thành công phiếu nhập ! Mời thêm chi tiết phiếu", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridControl1.Enabled = true;
                btn_ThemChiTietNhap.Enabled = true;
                btn_Finish.Enabled = true;
                Itemdetail.ReceiptNoteID = res;
            }
        }

        private void btn_ThemChiTietNhap_Click(object sender, EventArgs e)
        {
            ThemChiTietNhap f = new ThemChiTietNhap();
            f.FormClosed += ThemChiTietNhap_Closed;
            f.Show();
            return;
        }

        private void ThemChiTietNhap_Closed(object sender, FormClosedEventArgs e)
        {
            var dao = new ReceiptNoteDAO();
            dao.InsertDetail(Itemdetail);
            gridControl1.DataSource = dao.GetDetail(Itemdetail.ReceiptNoteID);
            new ReceiptNoteDAO().Amount(Itemdetail.ReceiptNoteID);
        }

        private void btn_XoaChiTietNhap_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn xóa chi tiết phiếu ?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                var dao = new ReceiptNoteDAO();
                dao.DeleteDetail(Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID").ToString()));
                gridControl1.DataSource = dao.GetDetail(Itemdetail.ReceiptNoteID);
                if (dao.GetDetail(Itemdetail.ReceiptNoteID).Count == 0)
                {
                    btn_XoaChiTietNhap.Enabled = false;
                }
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btn_XoaChiTietNhap.Enabled = true;
        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {
            if (new ReceiptNoteDAO().GetDetail(Itemdetail.ReceiptNoteID).Count == 0)
            {
                MessageBox.Show("Bạn phải nhập chi tiết phiếu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đã hoàn thành !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_Print.Enabled = true;
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            new PhieuYeuCauNhap().Show(this);
        }
    }
}
