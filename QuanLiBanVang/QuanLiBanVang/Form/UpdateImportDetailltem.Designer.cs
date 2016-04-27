namespace QuanLiBanVang.Form
{
    partial class UpdateImportDetailltem
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textEditGiaMua = new DevExpress.XtraEditors.TextEdit();
            this.textEditSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEditSP = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditLoaiSP = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGiaMua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLoaiSP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textEditGiaMua);
            this.groupControl1.Controls.Add(this.textEditSoLuong);
            this.groupControl1.Controls.Add(this.comboBoxEditSP);
            this.groupControl1.Controls.Add(this.comboBoxEditLoaiSP);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(287, 215);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Chi tiết";
            // 
            // textEditGiaMua
            // 
            this.textEditGiaMua.Location = new System.Drawing.Point(128, 157);
            this.textEditGiaMua.Name = "textEditGiaMua";
            this.textEditGiaMua.Size = new System.Drawing.Size(100, 20);
            this.textEditGiaMua.TabIndex = 11;
            // 
            // textEditSoLuong
            // 
            this.textEditSoLuong.Location = new System.Drawing.Point(128, 117);
            this.textEditSoLuong.Name = "textEditSoLuong";
            this.textEditSoLuong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditSoLuong.Size = new System.Drawing.Size(100, 20);
            this.textEditSoLuong.TabIndex = 12;
            // 
            // comboBoxEditSP
            // 
            this.comboBoxEditSP.Location = new System.Drawing.Point(128, 77);
            this.comboBoxEditSP.Name = "comboBoxEditSP";
            this.comboBoxEditSP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditSP.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEditSP.TabIndex = 9;
            // 
            // comboBoxEditLoaiSP
            // 
            this.comboBoxEditLoaiSP.Location = new System.Drawing.Point(128, 37);
            this.comboBoxEditLoaiSP.Name = "comboBoxEditLoaiSP";
            this.comboBoxEditLoaiSP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditLoaiSP.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEditLoaiSP.TabIndex = 10;
            this.comboBoxEditLoaiSP.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditLoaiSP_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá mua : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số Lượng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sản Phẩm :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loại SP :";
            // 
            // UpdateImportDetailltem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 271);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "UpdateImportDetailltem";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.UpdateImportDetailltem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGiaMua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLoaiSP.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textEditGiaMua;
        private DevExpress.XtraEditors.TextEdit textEditSoLuong;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditSP;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditLoaiSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}