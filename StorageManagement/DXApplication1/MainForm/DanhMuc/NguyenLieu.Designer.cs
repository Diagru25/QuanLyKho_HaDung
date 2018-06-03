namespace MainForm.DanhMuc
{
    partial class NguyenLieu
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
            this.dgr_NL = new DevExpress.XtraGrid.GridControl();
            this.grv_NL = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cbo_LoaiNL = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_DonViTinh = new DevExpress.XtraEditors.TextEdit();
            this.txb_Gia = new DevExpress.XtraEditors.TextEdit();
            this.txb_TenNL = new DevExpress.XtraEditors.TextEdit();
            this.txb_MaNL = new DevExpress.XtraEditors.TextEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_NL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_NL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txb_DonViTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_Gia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_TenNL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_MaNL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dgr_NL);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(429, 504);
            this.panelControl1.TabIndex = 0;
            // 
            // dgr_NL
            // 
            this.dgr_NL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgr_NL.Location = new System.Drawing.Point(2, 2);
            this.dgr_NL.MainView = this.grv_NL;
            this.dgr_NL.Name = "dgr_NL";
            this.dgr_NL.Size = new System.Drawing.Size(425, 500);
            this.dgr_NL.TabIndex = 1;
            this.dgr_NL.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_NL});
            // 
            // grv_NL
            // 
            this.grv_NL.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.grv_NL.GridControl = this.dgr_NL;
            this.grv_NL.Name = "grv_NL";
            this.grv_NL.OptionsBehavior.ReadOnly = true;
            this.grv_NL.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.grv_NL.OptionsFind.AlwaysVisible = true;
            this.grv_NL.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã NL";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 62;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Nguyên liệu";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 204;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Loại nguyên liệu";
            this.gridColumn3.FieldName = "TypeMaterialID";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 141;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.cbo_LoaiNL);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.label6);
            this.panelControl2.Controls.Add(this.label5);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.txb_DonViTinh);
            this.panelControl2.Controls.Add(this.txb_Gia);
            this.panelControl2.Controls.Add(this.txb_TenNL);
            this.panelControl2.Controls.Add(this.txb_MaNL);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(429, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(574, 404);
            this.panelControl2.TabIndex = 1;
            // 
            // cbo_LoaiNL
            // 
            this.cbo_LoaiNL.FormattingEnabled = true;
            this.cbo_LoaiNL.Location = new System.Drawing.Point(125, 252);
            this.cbo_LoaiNL.Name = "cbo_LoaiNL";
            this.cbo_LoaiNL.Size = new System.Drawing.Size(160, 21);
            this.cbo_LoaiNL.TabIndex = 36;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(186, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(211, 19);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "THÔNG TIN NGUYÊN LIỆU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(315, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(315, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Đơn vị tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(19, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Loại NL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(19, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên NL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(18, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã NL";
            // 
            // txb_DonViTinh
            // 
            this.txb_DonViTinh.Location = new System.Drawing.Point(397, 167);
            this.txb_DonViTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txb_DonViTinh.Name = "txb_DonViTinh";
            this.txb_DonViTinh.Size = new System.Drawing.Size(160, 20);
            this.txb_DonViTinh.TabIndex = 22;
            // 
            // txb_Gia
            // 
            this.txb_Gia.Location = new System.Drawing.Point(397, 209);
            this.txb_Gia.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Gia.Name = "txb_Gia";
            this.txb_Gia.Size = new System.Drawing.Size(160, 20);
            this.txb_Gia.TabIndex = 21;
            // 
            // txb_TenNL
            // 
            this.txb_TenNL.Location = new System.Drawing.Point(125, 209);
            this.txb_TenNL.Margin = new System.Windows.Forms.Padding(4);
            this.txb_TenNL.Name = "txb_TenNL";
            this.txb_TenNL.Size = new System.Drawing.Size(160, 20);
            this.txb_TenNL.TabIndex = 20;
            // 
            // txb_MaNL
            // 
            this.txb_MaNL.Location = new System.Drawing.Point(125, 167);
            this.txb_MaNL.Margin = new System.Windows.Forms.Padding(4);
            this.txb_MaNL.Name = "txb_MaNL";
            this.txb_MaNL.Size = new System.Drawing.Size(160, 20);
            this.txb_MaNL.TabIndex = 19;
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
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::MainForm.Properties.Resources.edit_32x32;
            this.btnSua.Location = new System.Drawing.Point(223, 27);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::MainForm.Properties.Resources.add_32x32;
            this.btnThem.Location = new System.Drawing.Point(41, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // NguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "NguyenLieu";
            this.Size = new System.Drawing.Size(1003, 504);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_NL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_NL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txb_DonViTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_Gia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_TenNL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_MaNL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl dgr_NL;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_NL;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txb_DonViTinh;
        private DevExpress.XtraEditors.TextEdit txb_Gia;
        private DevExpress.XtraEditors.TextEdit txb_TenNL;
        private DevExpress.XtraEditors.TextEdit txb_MaNL;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.ComboBox cbo_LoaiNL;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
    }
}
