namespace MainForm.DanhMuc
{
    partial class ThanhPham
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
            this.dgr_TP = new DevExpress.XtraGrid.GridControl();
            this.grv_TP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cbo_LoaiTP = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_DonViTinh = new DevExpress.XtraEditors.TextEdit();
            this.txb_GiaTP = new DevExpress.XtraEditors.TextEdit();
            this.txb_TenTP = new DevExpress.XtraEditors.TextEdit();
            this.txb_MaTP = new DevExpress.XtraEditors.TextEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_TP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_TP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txb_DonViTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_GiaTP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_TenTP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_MaTP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dgr_TP);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(429, 504);
            this.panelControl1.TabIndex = 0;
            // 
            // dgr_TP
            // 
            this.dgr_TP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgr_TP.Location = new System.Drawing.Point(2, 2);
            this.dgr_TP.MainView = this.grv_TP;
            this.dgr_TP.Name = "dgr_TP";
            this.dgr_TP.Size = new System.Drawing.Size(425, 500);
            this.dgr_TP.TabIndex = 1;
            this.dgr_TP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_TP});
            // 
            // grv_TP
            // 
            this.grv_TP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.grv_TP.GridControl = this.dgr_TP;
            this.grv_TP.Name = "grv_TP";
            this.grv_TP.OptionsBehavior.ReadOnly = true;
            this.grv_TP.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.grv_TP.OptionsFind.AlwaysVisible = true;
            this.grv_TP.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã TP";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 62;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên thành phẩm";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 204;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.cbo_LoaiTP);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.label6);
            this.panelControl2.Controls.Add(this.label5);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.txb_DonViTinh);
            this.panelControl2.Controls.Add(this.txb_GiaTP);
            this.panelControl2.Controls.Add(this.txb_TenTP);
            this.panelControl2.Controls.Add(this.txb_MaTP);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(429, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(574, 404);
            this.panelControl2.TabIndex = 1;
            // 
            // cbo_LoaiTP
            // 
            this.cbo_LoaiTP.FormattingEnabled = true;
            this.cbo_LoaiTP.Location = new System.Drawing.Point(125, 252);
            this.cbo_LoaiTP.Name = "cbo_LoaiTP";
            this.cbo_LoaiTP.Size = new System.Drawing.Size(160, 21);
            this.cbo_LoaiTP.TabIndex = 36;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(186, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(212, 19);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "THÔNG TIN THÀNH PHẨM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(309, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(309, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Đơn vị tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(18, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Loại TP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(18, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên TP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(18, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã TP";
            // 
            // txb_DonViTinh
            // 
            this.txb_DonViTinh.Location = new System.Drawing.Point(397, 169);
            this.txb_DonViTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txb_DonViTinh.Name = "txb_DonViTinh";
            this.txb_DonViTinh.Size = new System.Drawing.Size(160, 20);
            this.txb_DonViTinh.TabIndex = 22;
            // 
            // txb_GiaTP
            // 
            this.txb_GiaTP.Location = new System.Drawing.Point(397, 209);
            this.txb_GiaTP.Margin = new System.Windows.Forms.Padding(4);
            this.txb_GiaTP.Name = "txb_GiaTP";
            this.txb_GiaTP.Size = new System.Drawing.Size(160, 20);
            this.txb_GiaTP.TabIndex = 21;
            // 
            // txb_TenTP
            // 
            this.txb_TenTP.Location = new System.Drawing.Point(125, 209);
            this.txb_TenTP.Margin = new System.Windows.Forms.Padding(4);
            this.txb_TenTP.Name = "txb_TenTP";
            this.txb_TenTP.Size = new System.Drawing.Size(160, 20);
            this.txb_TenTP.TabIndex = 20;
            // 
            // txb_MaTP
            // 
            this.txb_MaTP.Location = new System.Drawing.Point(125, 167);
            this.txb_MaTP.Margin = new System.Windows.Forms.Padding(4);
            this.txb_MaTP.Name = "txb_MaTP";
            this.txb_MaTP.Size = new System.Drawing.Size(160, 20);
            this.txb_MaTP.TabIndex = 19;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnXoa);
            this.panelControl3.Controls.Add(this.btnSua);
            this.panelControl3.Controls.Add(this.btnThem);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(429, 404);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(574, 100);
            this.panelControl3.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::MainForm.Properties.Resources.delete_32x32;
            this.btnXoa.Location = new System.Drawing.Point(403, 27);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 40);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::MainForm.Properties.Resources.edit_32x32;
            this.btnSua.Location = new System.Drawing.Point(223, 27);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::MainForm.Properties.Resources.add_32x32;
            this.btnThem.Location = new System.Drawing.Point(41, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ThanhPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "ThanhPham";
            this.Size = new System.Drawing.Size(1003, 504);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_TP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_TP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txb_DonViTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_GiaTP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_TenTP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_MaTP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl dgr_TP;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_TP;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txb_DonViTinh;
        private DevExpress.XtraEditors.TextEdit txb_GiaTP;
        private DevExpress.XtraEditors.TextEdit txb_TenTP;
        private DevExpress.XtraEditors.TextEdit txb_MaTP;
        private System.Windows.Forms.ComboBox cbo_LoaiTP;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
    }
}
