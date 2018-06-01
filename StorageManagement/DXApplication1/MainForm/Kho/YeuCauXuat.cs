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

namespace MainForm.Kho
{
    public partial class YeuCauXuat : DevExpress.XtraEditors.XtraUserControl
    {
        private static YeuCauXuat _instance;

        public YeuCauXuat()
        {
            InitializeComponent();
        }

        public static YeuCauXuat Instance
        {
            get
            {
                if (_instance == null) _instance = new YeuCauXuat();
                return _instance;
            }
        }
    }
}
