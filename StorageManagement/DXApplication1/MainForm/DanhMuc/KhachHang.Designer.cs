namespace MainForm.DanhMuc
{
    partial class KhachHang
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
            this.dgr_KhachHang = new DevExpress.XtraGrid.GridControl();
            this.grv_KhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtp_NgaySinhKH = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_DiaChiKH = new DevExpress.XtraEditors.TextEdit();
            this.txb_PhoneKH = new DevExpress.XtraEditors.TextEdit();
            this.txbTenKH = new DevExpress.XtraEditors.TextEdit();
            this.txb_MaKH = new DevExpress.XtraEditors.TextEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_KhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_KhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgaySinhKH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgaySinhKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_DiaChiKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_PhoneKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_MaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dgr_KhachHang);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(429, 504);
            this.panelControl1.TabIndex = 0;
            // 
            // dgr_KhachHang
            // 
            this.dgr_KhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgr_KhachHang.Location = new System.Drawing.Point(2, 2);
            this.dgr_KhachHang.MainView = this.grv_KhachHang;
            this.dgr_KhachHang.Name = "dgr_KhachHang";
            this.dgr_KhachHang.Size = new System.Drawing.Size(425, 500);
            this.dgr_KhachHang.TabIndex = 1;
            this.dgr_KhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_KhachHang});
            // 
            // grv_KhachHang
            // 
            this.grv_KhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.grv_KhachHang.GridControl = this.dgr_KhachHang;
            this.grv_KhachHang.Name = "grv_KhachHang";
            this.grv_KhachHang.OptionsBehavior.ReadOnly = true;
            this.grv_KhachHang.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.grv_KhachHang.OptionsFind.AlwaysVisible = true;
            this.grv_KhachHang.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã KH";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 144;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên khách hàng";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 263;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.dtp_NgaySinhKH);
            this.panelControl2.Controls.Add(this.label6);
            this.panelControl2.Controls.Add(this.label5);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.txb_DiaChiKH);
            this.panelControl2.Controls.Add(this.txb_PhoneKH);
            this.panelControl2.Controls.Add(this.txbTenKH);
            this.panelControl2.Controls.Add(this.txb_MaKH);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(429, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(574, 404);
            this.panelControl2.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(189, 97);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(210, 19);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // dtp_NgaySinhKH
            // 
            this.dtp_NgaySinhKH.EditValue = null;
            this.dtp_NgaySinhKH.Location = new System.Drawing.Point(126, 257);
            this.dtp_NgaySinhKH.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_NgaySinhKH.Name = "dtp_NgaySinhKH";
            this.dtp_NgaySinhKH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_NgaySinhKH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_NgaySinhKH.Size = new System.Drawing.Size(160, 20);
            this.dtp_NgaySinhKH.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(304, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(309, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(12, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(12, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(12, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã khách hàng";
            // 
            // txb_DiaChiKH
            // 
            this.txb_DiaChiKH.Location = new System.Drawing.Point(397, 169);
            this.txb_DiaChiKH.Margin = new System.Windows.Forms.Padding(4);
            this.txb_DiaChiKH.Name = "txb_DiaChiKH";
            this.txb_DiaChiKH.Size = new System.Drawing.Size(160, 20);
            this.txb_DiaChiKH.TabIndex = 22;
            // 
            // txb_PhoneKH
            // 
            this.txb_PhoneKH.Location = new System.Drawing.Point(398, 214);
            this.txb_PhoneKH.Margin = new System.Windows.Forms.Padding(4);
            this.txb_PhoneKH.Name = "txb_PhoneKH";
            this.txb_PhoneKH.Size = new System.Drawing.Size(160, 20);
            this.txb_PhoneKH.TabIndex = 21;
            // 
            // txbTenKH
            // 
            this.txbTenKH.Location = new System.Drawing.Point(126, 214);
            this.txbTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txbTenKH.Name = "txbTenKH";
            this.txbTenKH.Size = new System.Drawing.Size(160, 20);
            this.txbTenKH.TabIndex = 20;
            // 
            // txb_MaKH
            // 
            this.txb_MaKH.Location = new System.Drawing.Point(126, 169);
            this.txb_MaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txb_MaKH.Name = "txb_MaKH";
            this.txb_MaKH.Size = new System.Drawing.Size(160, 20);
            this.txb_MaKH.TabIndex = 19;
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
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "KhachHang";
            this.Size = new System.Drawing.Size(1003, 504);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_KhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_KhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgaySinhKH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgaySinhKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_DiaChiKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_PhoneKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_MaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl dgr_KhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_KhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtp_NgaySinhKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txb_DiaChiKH;
        private DevExpress.XtraEditors.TextEdit txb_PhoneKH;
        private DevExpress.XtraEditors.TextEdit txbTenKH;
        private DevExpress.XtraEditors.TextEdit txb_MaKH;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
    }
}
