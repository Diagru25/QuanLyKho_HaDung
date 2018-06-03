namespace MainForm.Kho
{
    partial class SoPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoPhieuNhap));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btn_XoaPhieu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_DuyetPhieu = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(381, 504);
            this.panelControl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 500);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu nhập";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 17);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(371, 480);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn8,
            this.gridColumn10});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã phiếu";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 99;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Kho nhập";
            this.gridColumn2.FieldName = "StorageName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 125;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Trạng thái";
            this.gridColumn3.FieldName = "TrangThai";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 129;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "gridColumn8";
            this.gridColumn8.FieldName = "ReceiptDate";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "gridColumn10";
            this.gridColumn10.FieldName = "Amount";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.textEdit4);
            this.panelControl3.Controls.Add(this.labelControl6);
            this.panelControl3.Controls.Add(this.textEdit3);
            this.panelControl3.Controls.Add(this.textEdit2);
            this.panelControl3.Controls.Add(this.textEdit1);
            this.panelControl3.Controls.Add(this.labelControl5);
            this.panelControl3.Controls.Add(this.dateEdit1);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(381, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(622, 127);
            this.panelControl3.TabIndex = 2;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(281, 89);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.ReadOnly = true;
            this.textEdit4.Size = new System.Drawing.Size(130, 20);
            this.textEdit4.TabIndex = 14;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(219, 92);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 13);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Thành tiền";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(80, 53);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.ReadOnly = true;
            this.textEdit3.Size = new System.Drawing.Size(130, 20);
            this.textEdit3.TabIndex = 12;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(281, 53);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Size = new System.Drawing.Size(130, 20);
            this.textEdit2.TabIndex = 11;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(478, 53);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(130, 20);
            this.textEdit1.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(261, 11);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(203, 19);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "THÔNG TIN PHIẾU NHẬP";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(80, 89);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEdit1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEdit1.Properties.ReadOnly = true;
            this.dateEdit1.Size = new System.Drawing.Size(130, 20);
            this.dateEdit1.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(4, 92);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Ngày nhập";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(219, 56);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Kho nhập";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(429, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nhân viên";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã phiếu nhập";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btn_XoaPhieu);
            this.panelControl4.Controls.Add(this.btn_Print);
            this.panelControl4.Controls.Add(this.btn_DuyetPhieu);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl4.Location = new System.Drawing.Point(381, 404);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(622, 100);
            this.panelControl4.TabIndex = 3;
            // 
            // btn_XoaPhieu
            // 
            this.btn_XoaPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaPhieu.Image")));
            this.btn_XoaPhieu.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_XoaPhieu.Location = new System.Drawing.Point(448, 36);
            this.btn_XoaPhieu.Name = "btn_XoaPhieu";
            this.btn_XoaPhieu.Size = new System.Drawing.Size(120, 40);
            this.btn_XoaPhieu.TabIndex = 2;
            this.btn_XoaPhieu.Text = "Xóa phiếu";
            this.btn_XoaPhieu.Visible = false;
            this.btn_XoaPhieu.Click += new System.EventHandler(this.btn_XoaPhieu_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Enabled = false;
            this.btn_Print.Image = ((System.Drawing.Image)(resources.GetObject("btn_Print.Image")));
            this.btn_Print.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_Print.Location = new System.Drawing.Point(261, 36);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(120, 40);
            this.btn_Print.TabIndex = 1;
            this.btn_Print.Text = "In phiếu";
            // 
            // btn_DuyetPhieu
            // 
            this.btn_DuyetPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btn_DuyetPhieu.Image")));
            this.btn_DuyetPhieu.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_DuyetPhieu.Location = new System.Drawing.Point(64, 36);
            this.btn_DuyetPhieu.Name = "btn_DuyetPhieu";
            this.btn_DuyetPhieu.Size = new System.Drawing.Size(120, 40);
            this.btn_DuyetPhieu.TabIndex = 0;
            this.btn_DuyetPhieu.Text = "Duyệt phiếu";
            this.btn_DuyetPhieu.Visible = false;
            this.btn_DuyetPhieu.Click += new System.EventHandler(this.btn_DuyetPhieu_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupBox2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(381, 127);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(622, 277);
            this.panelControl2.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridControl2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 273);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(3, 17);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(612, 253);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mã chi tiết";
            this.gridColumn4.FieldName = "ID";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 96;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Nguyên liệu";
            this.gridColumn5.FieldName = "MaterialName";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 208;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Số lượng";
            this.gridColumn6.FieldName = "Quantity";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 121;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Đơn giá";
            this.gridColumn7.FieldName = "Price";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 169;
            // 
            // SoPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "SoPhieuNhap";
            this.Size = new System.Drawing.Size(1003, 504);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btn_XoaPhieu;
        private DevExpress.XtraEditors.SimpleButton btn_Print;
        private DevExpress.XtraEditors.SimpleButton btn_DuyetPhieu;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
    }
}
