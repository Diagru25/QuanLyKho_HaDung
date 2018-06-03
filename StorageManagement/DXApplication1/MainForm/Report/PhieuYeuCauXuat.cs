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
using Microsoft.Reporting.WinForms;
using MainForm.Kho;
using MainForm.Model.DAO;
using MainForm.Model.EF;

namespace MainForm.Report
{
    public partial class PhieuYeuCauXuat : DevExpress.XtraEditors.XtraForm
    {
        public PhieuYeuCauXuat()
        {
            InitializeComponent();           
            LoadData();
            
        }
        void LoadData()
        {
            var item = new DeliveryNoteDAO().GetNote().SingleOrDefault(x => x.ID == YeuCauXuat.Itemdetail.DeliveryNoteID);
            ReportParameter ID = new ReportParameter("IDP", item.ID.ToString());
            ReportParameter StorageName = new ReportParameter("StorageName", item.StorageName.ToString());
            ReportParameter EmployeeName = new ReportParameter("EmployeeName", item.EmployeeName.ToString());
            ReportParameter DeliveryDate = new ReportParameter("DeliveryDate", item.DeliveryDate.Value.ToString("dd/MM/yyyy"));
            ReportParameter Amount = new ReportParameter("Amount", item.Amount.ToString() + "đ");
            ReportParameter CustomerName = new ReportParameter("CustomerName", item.CustomerName.ToString());

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DS_YC";
            rds.Value = new DeliveryNoteDAO().GetDetail(YeuCauXuat.Itemdetail.DeliveryNoteID);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { ID, StorageName, EmployeeName, DeliveryDate, Amount,CustomerName});
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void PhieuYeuCauXuat_Load(object sender, EventArgs e)
        {

        }
    }
}