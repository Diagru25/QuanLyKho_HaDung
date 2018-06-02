namespace MainForm.HeThong
{
    partial class DanhSachQuyen
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
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTenQuyen = new DevExpress.XtraEditors.TextEdit();
            this.txbMaQuyen = new DevExpress.XtraEditors.TextEdit();
            this.grv_Quyen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgr_Quyen = new DevExpress.XtraGrid.GridControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenQuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaQuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Quyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_Quyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::MainForm.Properties.Resources.delete_32x32;
            this.btnXoa.Location = new System.Drawing.Point(410, 20);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 40);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::MainForm.Properties.Resources.add_32x32;
            this.btnThem.Location = new System.Drawing.Point(48, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnXoa);
            this.panelControl3.Controls.Add(this.btnSua);
            this.panelControl3.Controls.Add(this.btnThem);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(414, 417);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(589, 87);
            this.panelControl3.TabIndex = 5;
            // 
            // btnSua
            // 
            this.btnSua.Image = global::MainForm.Properties.Resources.edit_32x32;
            this.btnSua.Location = new System.Drawing.Point(230, 20);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(197, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(246, 19);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "THÔNG TIN QUYỀN TRUY CẬP";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên quyền";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 299;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã quyền";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(81, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(81, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã ";
            // 
            // txbTenQuyen
            // 
            this.txbTenQuyen.Location = new System.Drawing.Point(201, 185);
            this.txbTenQuyen.Margin = new System.Windows.Forms.Padding(4);
            this.txbTenQuyen.Name = "txbTenQuyen";
            this.txbTenQuyen.Size = new System.Drawing.Size(160, 20);
            this.txbTenQuyen.TabIndex = 20;
            // 
            // txbMaQuyen
            // 
            this.txbMaQuyen.Location = new System.Drawing.Point(201, 143);
            this.txbMaQuyen.Margin = new System.Windows.Forms.Padding(4);
            this.txbMaQuyen.Name = "txbMaQuyen";
            this.txbMaQuyen.Size = new System.Drawing.Size(160, 20);
            this.txbMaQuyen.TabIndex = 19;
            // 
            // grv_Quyen
            // 
            this.grv_Quyen.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.grv_Quyen.GridControl = this.dgr_Quyen;
            this.grv_Quyen.Name = "grv_Quyen";
            this.grv_Quyen.OptionsBehavior.ReadOnly = true;
            this.grv_Quyen.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.grv_Quyen.OptionsFind.AlwaysVisible = true;
            this.grv_Quyen.OptionsView.ShowGroupPanel = false;
            // 
            // dgr_Quyen
            // 
            this.dgr_Quyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgr_Quyen.Location = new System.Drawing.Point(2, 2);
            this.dgr_Quyen.MainView = this.grv_Quyen;
            this.dgr_Quyen.Name = "dgr_Quyen";
            this.dgr_Quyen.Size = new System.Drawing.Size(410, 500);
            this.dgr_Quyen.TabIndex = 0;
            this.dgr_Quyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_Quyen});
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.txbTenQuyen);
            this.panelControl2.Controls.Add(this.txbMaQuyen);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(414, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(589, 417);
            this.panelControl2.TabIndex = 4;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dgr_Quyen);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(414, 504);
            this.panelControl1.TabIndex = 3;
            // 
            // DanhSachQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "DanhSachQuyen";
            this.Size = new System.Drawing.Size(1003, 504);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txbTenQuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaQuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Quyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_Quyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txbTenQuyen;
        private DevExpress.XtraEditors.TextEdit txbMaQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_Quyen;
        private DevExpress.XtraGrid.GridControl dgr_Quyen;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}
