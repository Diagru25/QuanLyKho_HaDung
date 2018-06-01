using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MainForm.Model.DAO;

namespace MainForm
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var res = new AccoutDAO().Login(metroTextBox1.Text, metroTextBox2.Text);
            if (res != null)
            {
                MessageBox.Show("Đăng nhập thành công", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mf = new MainForm(res);
                this.Hide();
                mf.Show();
            }
        }
    }
}
