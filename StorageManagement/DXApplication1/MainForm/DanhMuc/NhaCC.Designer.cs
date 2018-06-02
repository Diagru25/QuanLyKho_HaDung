namespace MainForm.DanhMuc
{
    partial class NhaCC
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
            this.dgr_NCC = new DevExpress.XtraGrid.GridControl();
            this.grv_NCC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txb_MoTa = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_DiaChiNCC = new DevExpress.XtraEditors.TextEdit();
            this.txb_PhoneNCC = new DevExpress.XtraEditors.TextEdit();
            this.txb_TenNCC = new DevExpress.XtraEditors.TextEdit();
            this.txb_MaNCC = new DevExpress.XtraEditors.TextEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_NCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_NCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txb_DiaChiNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_PhoneNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_TenNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_MaNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dgr_NCC);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(414, 504);
            this.panelControl1.TabIndex = 0;
            // 
            // dgr_NCC
            // 
            this.dgr_NCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgr_NCC.Location = new System.Drawing.Point(2, 2);
            this.dgr_NCC.MainView = this.grv_NCC;
            this.dgr_NCC.Name = "dgr_NCC";
            this.dgr_NCC.Size = new System.Drawing.Size(410, 500);
            this.dgr_NCC.TabIndex = 0;
            this.dgr_NCC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_NCC});
            // 
            // grv_NCC
            // 
            this.grv_NCC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.grv_NCC.GridControl = this.dgr_NCC;
            this.grv_NCC.Name = "grv_NCC";
            this.grv_NCC.OptionsBehavior.ReadOnly = true;
            this.grv_NCC.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.grv_NCC.OptionsFind.AlwaysVisible = true;
            this.grv_NCC.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Nhà CC";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 93;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên nhà cung cấp";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 299;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txb_MoTa);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.label6);
            this.panelControl2.Controls.Add(this.label5);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.txb_DiaChiNCC);
            this.panelControl2.Controls.Add(this.txb_PhoneNCC);
            this.panelControl2.Controls.Add(this.txb_TenNCC);
            this.panelControl2.Controls.Add(this.txb_MaNCC);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(414, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(589, 417);
            this.panelControl2.TabIndex = 1;
            // 
            // txb_MoTa
            // 
            this.txb_MoTa.Location = new System.Drawing.Point(133, 206);
            this.txb_MoTa.Multiline = true;
            this.txb_MoTa.Name = "txb_MoTa";
            this.txb_MoTa.Size = new System.Drawing.Size(432, 113);
            this.txb_MoTa.TabIndex = 36;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(197, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(226, 19);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "THÔNG TIN NHÀ CUNG CẤP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(317, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(317, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(26, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mô tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(26, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(26, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã ";
            // 
            // txb_DiaChiNCC
            // 
            this.txb_DiaChiNCC.Location = new System.Drawing.Point(405, 122);
            this.txb_DiaChiNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txb_DiaChiNCC.Name = "txb_DiaChiNCC";
            this.txb_DiaChiNCC.Size = new System.Drawing.Size(160, 20);
            this.txb_DiaChiNCC.TabIndex = 22;
            // 
            // txb_PhoneNCC
            // 
            this.txb_PhoneNCC.Location = new System.Drawing.Point(405, 162);
            this.txb_PhoneNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txb_PhoneNCC.Name = "txb_PhoneNCC";
            this.txb_PhoneNCC.Size = new System.Drawing.Size(160, 20);
            this.txb_PhoneNCC.TabIndex = 21;
            // 
            // txb_TenNCC
            // 
            this.txb_TenNCC.Location = new System.Drawing.Point(133, 162);
            this.txb_TenNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txb_TenNCC.Name = "txb_TenNCC";
            this.txb_TenNCC.Size = new System.Drawing.Size(160, 20);
            this.txb_TenNCC.TabIndex = 20;
            // 
            // txb_MaNCC
            // 
            this.txb_MaNCC.Location = new System.Drawing.Point(133, 120);
            this.txb_MaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txb_MaNCC.Name = "txb_MaNCC";
            this.txb_MaNCC.Size = new System.Drawing.Size(160, 20);
            this.txb_MaNCC.TabIndex = 19;
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
            this.panelControl3.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::MainForm.Properties.Resources.delete_32x32;
            this.btnXoa.Location = new System.Drawing.Point(410, 20);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 40);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::MainForm.Properties.Resources.edit_32x32;
            this.btnSua.Location = new System.Drawing.Point(230, 20);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::MainForm.Properties.Resources.add_32x32;
            this.btnThem.Location = new System.Drawing.Point(48, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // NhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "NhaCC";
            this.Size = new System.Drawing.Size(1003, 504);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_NCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_NCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txb_DiaChiNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_PhoneNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_TenNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_MaNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl dgr_NCC;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_NCC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txb_DiaChiNCC;
        private DevExpress.XtraEditors.TextEdit txb_PhoneNCC;
        private DevExpress.XtraEditors.TextEdit txb_TenNCC;
        private DevExpress.XtraEditors.TextEdit txb_MaNCC;
        private System.Windows.Forms.TextBox txb_MoTa;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
    }
}
