namespace MainForm.Kho
{
    partial class ThemChiTietNhap
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_ThemChiTietNhap = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(51, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chọn vật liệu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(51, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Số lượng";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(51, 110);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Đơn giá";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(159, 72);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(180, 20);
            this.textEdit1.TabIndex = 3;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(159, 107);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(180, 20);
            this.textEdit2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(159, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // btn_ThemChiTietNhap
            // 
            this.btn_ThemChiTietNhap.Location = new System.Drawing.Point(159, 145);
            this.btn_ThemChiTietNhap.Name = "btn_ThemChiTietNhap";
            this.btn_ThemChiTietNhap.Size = new System.Drawing.Size(163, 23);
            this.btn_ThemChiTietNhap.TabIndex = 6;
            this.btn_ThemChiTietNhap.Text = "Thêm";
            this.btn_ThemChiTietNhap.Click += new System.EventHandler(this.btn_ThemChiTietNhap_Click);
            // 
            // ThemChiTietNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 180);
            this.Controls.Add(this.btn_ThemChiTietNhap);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "ThemChiTietNhap";
            this.Text = "Thêm chi tiết xuất kho";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.ComboBox comboBox1;
        private MetroFramework.Controls.MetroButton btn_ThemChiTietNhap;
    }
}