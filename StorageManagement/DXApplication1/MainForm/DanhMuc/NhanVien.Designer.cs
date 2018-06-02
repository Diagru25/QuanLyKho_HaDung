namespace MainForm.DanhMuc
{
    partial class uscNhanVien
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgr_NhanVien = new DevExpress.XtraGrid.GridControl();
            this.grv_NhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbo_GioiTinh = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtp_NgaySinhNV = new DevExpress.XtraEditors.DateEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Email = new DevExpress.XtraEditors.TextEdit();
            this.txb_ChucVu = new DevExpress.XtraEditors.TextEdit();
            this.txbDiaChiNV = new DevExpress.XtraEditors.TextEdit();
            this.txb_PhoneNV = new DevExpress.XtraEditors.TextEdit();
            this.txb_TenNV = new DevExpress.XtraEditors.TextEdit();
            this.txb_MaNV = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgaySinhNV.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgaySinhNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_ChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbDiaChiNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_PhoneNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_TenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_MaNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgr_NhanVien);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(429, 504);
            this.panelControl2.TabIndex = 3;
            // 
            // dgr_NhanVien
            // 
            this.dgr_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgr_NhanVien.Location = new System.Drawing.Point(2, 2);
            this.dgr_NhanVien.MainView = this.grv_NhanVien;
            this.dgr_NhanVien.Name = "dgr_NhanVien";
            this.dgr_NhanVien.Size = new System.Drawing.Size(425, 500);
            this.dgr_NhanVien.TabIndex = 0;
            this.dgr_NhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_NhanVien});
            // 
            // grv_NhanVien
            // 
            this.grv_NhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.grv_NhanVien.GridControl = this.dgr_NhanVien;
            this.grv_NhanVien.Name = "grv_NhanVien";
            this.grv_NhanVien.OptionsBehavior.ReadOnly = true;
            this.grv_NhanVien.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.grv_NhanVien.OptionsFind.AlwaysVisible = true;
            this.grv_NhanVien.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã NV";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 72;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Họ tên";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 141;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Chức vụ";
            this.gridColumn3.FieldName = "Regency";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 194;
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
            this.panelControl3.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::MainForm.Properties.Resources.delete_32x32;
            this.btnXoa.Location = new System.Drawing.Point(398, 32);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::MainForm.Properties.Resources.edit_32x32;
            this.btnSua.Location = new System.Drawing.Point(218, 32);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::MainForm.Properties.Resources.add_32x32;
            this.btnThem.Location = new System.Drawing.Point(36, 32);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThen_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbo_GioiTinh);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.dtp_NgaySinhNV);
            this.panelControl1.Controls.Add(this.label8);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.txb_Email);
            this.panelControl1.Controls.Add(this.txb_ChucVu);
            this.panelControl1.Controls.Add(this.txbDiaChiNV);
            this.panelControl1.Controls.Add(this.txb_PhoneNV);
            this.panelControl1.Controls.Add(this.txb_TenNV);
            this.panelControl1.Controls.Add(this.txb_MaNV);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(429, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(574, 404);
            this.panelControl1.TabIndex = 5;
            // 
            // cbo_GioiTinh
            // 
            this.cbo_GioiTinh.FormattingEnabled = true;
            this.cbo_GioiTinh.Location = new System.Drawing.Point(126, 208);
            this.cbo_GioiTinh.Name = "cbo_GioiTinh";
            this.cbo_GioiTinh.Size = new System.Drawing.Size(160, 21);
            this.cbo_GioiTinh.TabIndex = 19;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(190, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(192, 19);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // dtp_NgaySinhNV
            // 
            this.dtp_NgaySinhNV.EditValue = null;
            this.dtp_NgaySinhNV.Location = new System.Drawing.Point(126, 244);
            this.dtp_NgaySinhNV.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_NgaySinhNV.Name = "dtp_NgaySinhNV";
            this.dtp_NgaySinhNV.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dtp_NgaySinhNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_NgaySinhNV.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_NgaySinhNV.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtp_NgaySinhNV.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtp_NgaySinhNV.Size = new System.Drawing.Size(160, 20);
            this.dtp_NgaySinhNV.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(310, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Chức vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(310, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(310, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(310, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(19, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(19, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(19, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(19, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã nhân viên";
            // 
            // txb_Email
            // 
            this.txb_Email.Location = new System.Drawing.Point(398, 208);
            this.txb_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(160, 20);
            this.txb_Email.TabIndex = 7;
            // 
            // txb_ChucVu
            // 
            this.txb_ChucVu.Location = new System.Drawing.Point(398, 244);
            this.txb_ChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ChucVu.Name = "txb_ChucVu";
            this.txb_ChucVu.Size = new System.Drawing.Size(160, 20);
            this.txb_ChucVu.TabIndex = 6;
            // 
            // txbDiaChiNV
            // 
            this.txbDiaChiNV.Location = new System.Drawing.Point(398, 127);
            this.txbDiaChiNV.Margin = new System.Windows.Forms.Padding(4);
            this.txbDiaChiNV.Name = "txbDiaChiNV";
            this.txbDiaChiNV.Size = new System.Drawing.Size(160, 20);
            this.txbDiaChiNV.TabIndex = 5;
            // 
            // txb_PhoneNV
            // 
            this.txb_PhoneNV.Location = new System.Drawing.Point(398, 167);
            this.txb_PhoneNV.Margin = new System.Windows.Forms.Padding(4);
            this.txb_PhoneNV.Name = "txb_PhoneNV";
            this.txb_PhoneNV.Size = new System.Drawing.Size(160, 20);
            this.txb_PhoneNV.TabIndex = 4;
            // 
            // txb_TenNV
            // 
            this.txb_TenNV.Location = new System.Drawing.Point(126, 167);
            this.txb_TenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txb_TenNV.Name = "txb_TenNV";
            this.txb_TenNV.Size = new System.Drawing.Size(160, 20);
            this.txb_TenNV.TabIndex = 1;
            // 
            // txb_MaNV
            // 
            this.txb_MaNV.Location = new System.Drawing.Point(126, 125);
            this.txb_MaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txb_MaNV.Name = "txb_MaNV";
            this.txb_MaNV.Size = new System.Drawing.Size(160, 20);
            this.txb_MaNV.TabIndex = 0;
            // 
            // uscNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Name = "uscNhanVien";
            this.Size = new System.Drawing.Size(1003, 504);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgaySinhNV.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgaySinhNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_ChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbDiaChiNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_PhoneNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_TenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_MaNV.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl dgr_NhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_NhanVien;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateEdit dtp_NgaySinhNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txb_Email;
        private DevExpress.XtraEditors.TextEdit txb_ChucVu;
        private DevExpress.XtraEditors.TextEdit txbDiaChiNV;
        private DevExpress.XtraEditors.TextEdit txb_PhoneNV;
        private DevExpress.XtraEditors.TextEdit txb_TenNV;
        private DevExpress.XtraEditors.TextEdit txb_MaNV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.ComboBox cbo_GioiTinh;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
    }
}
