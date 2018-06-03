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

namespace MainForm.Kho
{
    public partial class SoPhieuNhap : DevExpress.XtraEditors.XtraUserControl
    {
        private static SoPhieuNhap _instance;
        public SoPhieuNhap()
        {
            InitializeComponent();
            gridControl1.DataSource = new ReceiptNoteDAO().GetNote();
        }

        public static SoPhieuNhap Instance
        {
            get
            {
                _instance = new SoPhieuNhap();
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btn_Print.Enabled = true;
            textEdit3.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            textEdit2.Text = gridView1.GetFocusedRowCellValue("StorageName").ToString();
            textEdit1.Text = gridView1.GetFocusedRowCellValue("EmployeeName").ToString();
            dateEdit1.DateTime = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("ReceiptDate").ToString());
            textEdit4.Text = gridView1.GetFocusedRowCellValue("Amount").ToString();
            gridControl2.DataSource = new ReceiptNoteDAO().GetDetail(Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID").ToString()));
            if(gridView1.GetFocusedRowCellValue("Status").ToString() == "0")
            {
                btn_DuyetPhieu.Visible = true;
                btn_XoaPhieu.Visible = true;
            }
            else
            {
                btn_DuyetPhieu.Visible = false;
                btn_XoaPhieu.Visible = false;
            }
        }

        private void btn_DuyetPhieu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn duyêt phiếu ?", "Duyệt", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                new ReceiptNoteDAO().Duyet(Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID").ToString()));
                MessageBox.Show("Đã duyệt !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridControl1.DataSource = new ReceiptNoteDAO().GetNote();
                gridControl2.DataSource = null;
                btn_DuyetPhieu.Visible = false;
                btn_XoaPhieu.Visible = false;
                btn_Print.Enabled = false;
            }
            return;
        }

        private void btn_XoaPhieu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa phiếu ?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                new ReceiptNoteDAO().Delete(Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID").ToString()));
                MessageBox.Show("Đã xóa !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridControl1.DataSource = new ReceiptNoteDAO().GetNote();
                gridControl2.DataSource = null;
                btn_DuyetPhieu.Visible = false;
                btn_XoaPhieu.Visible = false;
                btn_Print.Enabled = false;
            }
            return;
        }
    }
}
