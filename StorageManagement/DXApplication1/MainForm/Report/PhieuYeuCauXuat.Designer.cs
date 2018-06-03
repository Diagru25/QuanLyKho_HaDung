namespace MainForm.Report
{
    partial class PhieuYeuCauXuat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_YCXuat = new Report.DS_YCXuat();
            this.ReceiptNoteDetailViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_YCXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptNoteDetailViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DS_YCXuat;
            // 
            // DS_YCXuat
            // 
            this.DS_YCXuat.DataSetName = "DS_YCXuat";
            this.DS_YCXuat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReceiptNoteDetailViewBindingSource
            // 
            this.ReceiptNoteDetailViewBindingSource.DataSource = typeof(Model.View.ReceiptNoteView);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_YCXuat";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MainForm.Report.PhieuYeuCauXuat.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(774, 483);
            this.reportViewer1.TabIndex = 0;
            // 
            // PhieuYeuCauXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 483);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PhieuYeuCauXuat";
            this.Text = "Phiếu yêu cầu xuất";
            this.Load += new System.EventHandler(this.PhieuYeuCauXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_YCXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptNoteDetailViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReceiptNoteDetailViewBindingSource;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private Report.DS_YCXuat DS_YCXuat;
    }
}