namespace MainForm.Kho
{
    partial class YeuCauXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeuCauXuat));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cb_Customer = new System.Windows.Forms.ComboBox();
            this.cb_Storage = new System.Windows.Forms.ComboBox();
            this.btn_Print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Finish = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Create = new DevExpress.XtraEditors.SimpleButton();
            this.date_Out = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_XoaChiTietXuat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ThemChiTietXuat = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_Out.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Out.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(306, 504);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cb_Customer);
            this.groupControl2.Controls.Add(this.cb_Storage);
            this.groupControl2.Controls.Add(this.btn_Print);
            this.groupControl2.Controls.Add(this.btn_Finish);
            this.groupControl2.Controls.Add(this.btn_Create);
            this.groupControl2.Controls.Add(this.date_Out);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(2, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(302, 500);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Thông tin phiếu xuất";
            // 
            // cb_Customer
            // 
            this.cb_Customer.FormattingEnabled = true;
            this.cb_Customer.Location = new System.Drawing.Point(132, 181);
            this.cb_Customer.Name = "cb_Customer";
            this.cb_Customer.Size = new System.Drawing.Size(135, 21);
            this.cb_Customer.TabIndex = 2;
            // 
            // cb_Storage
            // 
            this.cb_Storage.FormattingEnabled = true;
            this.cb_Storage.Location = new System.Drawing.Point(132, 112);
            this.cb_Storage.Name = "cb_Storage";
            this.cb_Storage.Size = new System.Drawing.Size(135, 21);
            this.cb_Storage.TabIndex = 2;
            // 
            // btn_Print
            // 
            this.btn_Print.Enabled = false;
            this.btn_Print.Image = ((System.Drawing.Image)(resources.GetObject("btn_Print.Image")));
            this.btn_Print.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_Print.Location = new System.Drawing.Point(168, 230);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(120, 40);
            this.btn_Print.TabIndex = 9;
            this.btn_Print.Text = "In phiếu";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Finish
            // 
            this.btn_Finish.Image = ((System.Drawing.Image)(resources.GetObject("btn_Finish.Image")));
            this.btn_Finish.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_Finish.Location = new System.Drawing.Point(24, 287);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(264, 40);
            this.btn_Finish.TabIndex = 8;
            this.btn_Finish.Text = "Hoàn thành phiếu xuất";
            this.btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Image = ((System.Drawing.Image)(resources.GetObject("btn_Create.Image")));
            this.btn_Create.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_Create.Location = new System.Drawing.Point(24, 230);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(120, 40);
            this.btn_Create.TabIndex = 7;
            this.btn_Create.Text = "Lập phiếu xuất";
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // date_Out
            // 
            this.date_Out.EditValue = null;
            this.date_Out.Location = new System.Drawing.Point(132, 147);
            this.date_Out.Name = "date_Out";
            this.date_Out.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_Out.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_Out.Size = new System.Drawing.Size(135, 20);
            this.date_Out.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn kho xuất";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_XoaChiTietXuat);
            this.panelControl2.Controls.Add(this.btn_ThemChiTietXuat);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(306, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(697, 79);
            this.panelControl2.TabIndex = 1;
            // 
            // btn_XoaChiTietXuat
            // 
            this.btn_XoaChiTietXuat.Enabled = false;
            this.btn_XoaChiTietXuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaChiTietXuat.Image")));
            this.btn_XoaChiTietXuat.Location = new System.Drawing.Point(406, 17);
            this.btn_XoaChiTietXuat.Name = "btn_XoaChiTietXuat";
            this.btn_XoaChiTietXuat.Size = new System.Drawing.Size(141, 40);
            this.btn_XoaChiTietXuat.TabIndex = 1;
            this.btn_XoaChiTietXuat.Text = "Xóa chi tiết xuất";
            this.btn_XoaChiTietXuat.Click += new System.EventHandler(this.btn_XoaChiTietXuat_Click);
            // 
            // btn_ThemChiTietXuat
            // 
            this.btn_ThemChiTietXuat.Enabled = false;
            this.btn_ThemChiTietXuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemChiTietXuat.Image")));
            this.btn_ThemChiTietXuat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_ThemChiTietXuat.Location = new System.Drawing.Point(121, 17);
            this.btn_ThemChiTietXuat.Name = "btn_ThemChiTietXuat";
            this.btn_ThemChiTietXuat.Size = new System.Drawing.Size(163, 40);
            this.btn_ThemChiTietXuat.TabIndex = 0;
            this.btn_ThemChiTietXuat.Text = "Thêm chi tiết xuất";
            this.btn_ThemChiTietXuat.Click += new System.EventHandler(this.btn_ThemChiTietXuat_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.groupControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(306, 79);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(697, 425);
            this.panelControl3.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(693, 421);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Chi tiết phiếu xuất";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Enabled = false;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(689, 399);
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
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã phiếu";
            this.gridColumn1.FieldName = "DeliveryNoteID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nguyên liệu";
            this.gridColumn2.FieldName = "MaterialName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số lượng";
            this.gridColumn3.FieldName = "Quantity";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Giá";
            this.gridColumn4.FieldName = "Price";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "ID";
            this.gridColumn5.FieldName = "ID";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // YeuCauXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "YeuCauXuat";
            this.Size = new System.Drawing.Size(1003, 504);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_Out.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Out.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btn_XoaChiTietXuat;
        private DevExpress.XtraEditors.SimpleButton btn_ThemChiTietXuat;
        private DevExpress.XtraEditors.DateEdit date_Out;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_Print;
        private DevExpress.XtraEditors.SimpleButton btn_Finish;
        private DevExpress.XtraEditors.SimpleButton btn_Create;
        private System.Windows.Forms.ComboBox cb_Customer;
        private System.Windows.Forms.ComboBox cb_Storage;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}
