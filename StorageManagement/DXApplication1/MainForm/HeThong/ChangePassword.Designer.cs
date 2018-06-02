namespace MainForm.HeThong
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Change = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_confirm_pass = new DevExpress.XtraEditors.TextEdit();
            this.txb_new_pass = new DevExpress.XtraEditors.TextEdit();
            this.txb_cur_pass = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txb_confirm_pass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_new_pass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_cur_pass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Change);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.txb_confirm_pass);
            this.panelControl1.Controls.Add(this.txb_new_pass);
            this.panelControl1.Controls.Add(this.txb_cur_pass);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1003, 504);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_Change
            // 
            this.btn_Change.Image = ((System.Drawing.Image)(resources.GetObject("btn_Change.Image")));
            this.btn_Change.Location = new System.Drawing.Point(340, 382);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(120, 40);
            this.btn_Change.TabIndex = 37;
            this.btn_Change.Text = "Thay đổi";
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(362, 76);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(176, 19);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "THAY ĐỔI MẬT KHẨU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(144, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Xác nhận mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(144, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(144, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mật khẩu hiện tại";
            // 
            // txb_confirm_pass
            // 
            this.txb_confirm_pass.Location = new System.Drawing.Point(340, 271);
            this.txb_confirm_pass.Name = "txb_confirm_pass";
            this.txb_confirm_pass.Properties.UseSystemPasswordChar = true;
            this.txb_confirm_pass.Size = new System.Drawing.Size(198, 20);
            this.txb_confirm_pass.TabIndex = 5;
            // 
            // txb_new_pass
            // 
            this.txb_new_pass.Location = new System.Drawing.Point(340, 217);
            this.txb_new_pass.Name = "txb_new_pass";
            this.txb_new_pass.Properties.UseSystemPasswordChar = true;
            this.txb_new_pass.Size = new System.Drawing.Size(198, 20);
            this.txb_new_pass.TabIndex = 4;
            // 
            // txb_cur_pass
            // 
            this.txb_cur_pass.Location = new System.Drawing.Point(340, 166);
            this.txb_cur_pass.Name = "txb_cur_pass";
            this.txb_cur_pass.Properties.UseSystemPasswordChar = true;
            this.txb_cur_pass.Size = new System.Drawing.Size(198, 20);
            this.txb_cur_pass.TabIndex = 3;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ChangePassword";
            this.Size = new System.Drawing.Size(1003, 504);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txb_confirm_pass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_new_pass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_cur_pass.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txb_confirm_pass;
        private DevExpress.XtraEditors.TextEdit txb_new_pass;
        private DevExpress.XtraEditors.TextEdit txb_cur_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_Change;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
