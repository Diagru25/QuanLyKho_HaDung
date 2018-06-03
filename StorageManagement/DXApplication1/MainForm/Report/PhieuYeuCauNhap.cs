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
    public partial class PhieuYeuCauNhap : DevExpress.XtraEditors.XtraForm
    {
        public PhieuYeuCauNhap()
        {
            InitializeComponent();           
            LoadData();
            
        }
        void LoadData()
        {
            var item = new ReceiptNoteDAO().GetNote().SingleOrDefault(x => x.ID == YeuCauNhap.Itemdetail.ReceiptNoteID);
            ReportParameter ID = new ReportParameter("IDP", item.ID.ToString());
            ReportParameter StorageName = new ReportParameter("StorageName", item.StorageName.ToString());
            ReportParameter EmployeeName = new ReportParameter("EmployeeName", item.EmployeeName.ToString());
            ReportParameter ReceiptDate = new ReportParameter("ReceiptDate", item.ReceiptDate.Value.ToString("dd/MM/yyyy"));
            ReportParameter Amount = new ReportParameter("Amount", item.Amount.ToString() + "đ");

            ReportDataSource rds = new ReportDataSource("DS_YCNhap", new ReceiptNoteDAO().GetDetail(YeuCauNhap.Itemdetail.ReceiptNoteID));
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { ID, StorageName, EmployeeName, ReceiptDate ,Amount});
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}