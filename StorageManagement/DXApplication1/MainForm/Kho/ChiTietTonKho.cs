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

namespace MainForm.Kho
{
    public partial class ChiTietTonKho : DevExpress.XtraEditors.XtraUserControl
    {
        private static ChiTietTonKho instance;
        public ChiTietTonKho()
        {
            InitializeComponent();

            Load_cbo_kho();
        }

        public static ChiTietTonKho Instance
        {
            get
            {
                if (instance == null) instance = new ChiTietTonKho();
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        #region Load data
        private void Load_cbo_kho()
        {
            cbo_Kho.DataSource = new StorageDAO().Load_Storage_cbo();
            cbo_Kho.ValueMember = "ID";
            cbo_Kho.DisplayMember = "Name";
        }

        private void Load_dgr_TonKho(long sto_id)
        {
            dgr_TonKho.DataSource = new StorageDAO().Load_NL_TonKho(sto_id);
        }
        #endregion


        private void cbo_Kho_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                long sto_id = Convert.ToInt32(cbo_Kho.SelectedValue);

                Load_dgr_TonKho(sto_id);
            }
            catch
            {

            }

        }

        private void cbo_Kho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_Kho_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
