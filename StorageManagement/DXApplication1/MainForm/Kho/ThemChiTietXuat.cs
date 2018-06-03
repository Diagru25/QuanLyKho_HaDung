using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MainForm.Model.DAO;

namespace MainForm.Kho
{
    public partial class ThemChiTietXuat : DevExpress.XtraEditors.XtraForm
    {
        public ThemChiTietXuat()
        {
            InitializeComponent();
            comboBox1.DataSource = new MaterialDAO().ListAll();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
        }

        private void btn_ThemChiTietXuat_Click(object sender, EventArgs e)
        {
            try
            {
                YeuCauXuat.Itemdetail.MaterialID = Convert.ToInt64(comboBox1.SelectedValue);
                YeuCauXuat.Itemdetail.Quantity = Convert.ToUInt16(textEdit1.Text);
                YeuCauXuat.Itemdetail.Price = Convert.ToDecimal(textEdit2.Text);
                MessageBox.Show("Thêm thành công chi tiết phiếu", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Xem lại số lượng và đơn giá !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}