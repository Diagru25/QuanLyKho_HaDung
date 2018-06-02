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

namespace MainForm.HeThong
{
    public partial class ChangePassword : DevExpress.XtraEditors.XtraUserControl
    {
        private Account acc = new Account();
        public ChangePassword(Account _acc)
        {
            InitializeComponent();

            acc = _acc;
        }

        private void Clear_Control()
        {
            txb_confirm_pass.Text = "";
            txb_cur_pass.Text = "";
            txb_new_pass.Text = "";
        }

        private int check()
        {
            if(acc.PassWord != txb_cur_pass.Text)
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng");
                return 0;
            }
            else
            {
                if(txb_new_pass.Text != txb_confirm_pass.Text)
                {
                    return 2;
                }
                else
                {
                    bool result = new AccoutDAO().Change_Pass(acc.UserName, txb_new_pass.Text);

                    if(result)
                    {
                        MessageBox.Show("Thay đổi mật khẩu thành công");
                        return 1;
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra");
                        return 0;
                    }
                }
            }
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thay đổi mật khẩu không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                check();
                Clear_Control();
            }

            return;
        }
    }
}
