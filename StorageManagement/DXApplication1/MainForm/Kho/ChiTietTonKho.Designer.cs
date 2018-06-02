namespace MainForm.Kho
{
    partial class ChiTietTonKho
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbo_Kho = new System.Windows.Forms.ComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgr_TonKho = new DevExpress.XtraGrid.GridControl();
            this.grc_TonKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_TonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grc_TonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1003, 100);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbo_Kho);
            this.groupControl1.Controls.Add(this.metroButton1);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(999, 96);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Chọn kiểu xem";
            // 
            // cbo_Kho
            // 
            this.cbo_Kho.FormattingEnabled = true;
            this.cbo_Kho.Location = new System.Drawing.Point(257, 48);
            this.cbo_Kho.Name = "cbo_Kho";
            this.cbo_Kho.Size = new System.Drawing.Size(138, 21);
            this.cbo_Kho.TabIndex = 10;
            this.cbo_Kho.SelectedIndexChanged += new System.EventHandler(this.cbo_Kho_SelectedIndexChanged);
            this.cbo_Kho.SelectedValueChanged += new System.EventHandler(this.cbo_Kho_SelectedValueChanged);
            this.cbo_Kho.TextChanged += new System.EventHandler(this.cbo_Kho_TextChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(828, 38);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(103, 31);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "In báo cáo";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(193, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chọn kho";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 100);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1003, 404);
            this.panelControl2.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgr_TonKho);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(2, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(999, 400);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Chi tiết tồn kho";
            // 
            // dgr_TonKho
            // 
            this.dgr_TonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgr_TonKho.Location = new System.Drawing.Point(2, 20);
            this.dgr_TonKho.MainView = this.grc_TonKho;
            this.dgr_TonKho.Name = "dgr_TonKho";
            this.dgr_TonKho.Size = new System.Drawing.Size(995, 378);
            this.dgr_TonKho.TabIndex = 0;
            this.dgr_TonKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grc_TonKho});
            // 
            // grc_TonKho
            // 
            this.grc_TonKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.grc_TonKho.GridControl = this.dgr_TonKho;
            this.grc_TonKho.Name = "grc_TonKho";
            this.grc_TonKho.OptionsBehavior.ReadOnly = true;
            this.grc_TonKho.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.grc_TonKho.OptionsFind.AlwaysVisible = true;
            this.grc_TonKho.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nguyên liệu";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Số lượng";
            this.gridColumn2.FieldName = "Quantity";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Đơn vị tính";
            this.gridColumn3.FieldName = "Unit";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // ChiTietTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "ChiTietTonKho";
            this.Size = new System.Drawing.Size(1003, 504);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_TonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grc_TonKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl dgr_TonKho;
        private DevExpress.XtraGrid.Views.Grid.GridView grc_TonKho;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ComboBox cbo_Kho;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}
