namespace QuanLiBanVang.Report
{
    partial class SuaPhieuChi_Form
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
            this.groupControlInfo = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dtpkCreateDate = new DevExpress.XtraEditors.DateEdit();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtContent = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).BeginInit();
            this.groupControlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpkCreateDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpkCreateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Location = new System.Drawing.Point(96, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(186, 33);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "SỬA PHIẾU CHI";
            // 
            // groupControlInfo
            // 
            this.groupControlInfo.Controls.Add(this.txtContent);
            this.groupControlInfo.Controls.Add(this.labelControl5);
            this.groupControlInfo.Controls.Add(this.dtpkCreateDate);
            this.groupControlInfo.Controls.Add(this.txtPrice);
            this.groupControlInfo.Controls.Add(this.labelControl4);
            this.groupControlInfo.Controls.Add(this.labelControl3);
            this.groupControlInfo.Controls.Add(this.labelControl2);
            this.groupControlInfo.Location = new System.Drawing.Point(12, 51);
            this.groupControlInfo.Name = "groupControlInfo";
            this.groupControlInfo.Size = new System.Drawing.Size(396, 156);
            this.groupControlInfo.TabIndex = 1;
            this.groupControlInfo.Text = "Thông tin phiếu chi";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Location = new System.Drawing.Point(237, 64);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(125, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "(Chỉ lập cho ngày hiện tại)";
            // 
            // dtpkCreateDate
            // 
            this.dtpkCreateDate.EditValue = null;
            this.dtpkCreateDate.Location = new System.Drawing.Point(106, 61);
            this.dtpkCreateDate.Name = "dtpkCreateDate";
            this.dtpkCreateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpkCreateDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpkCreateDate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.dtpkCreateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtpkCreateDate.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.dtpkCreateDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtpkCreateDate.Size = new System.Drawing.Size(116, 20);
            this.dtpkCreateDate.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(106, 97);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Mask.EditMask = "\\d{3,10}";
            this.txtPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPrice.Size = new System.Drawing.Size(116, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 100);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Số tiền";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Ngày lập phiếu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Loại chi phí";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(97, 214);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(219, 214);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(106, 24);
            this.txtContent.Name = "txtContent";
            this.txtContent.Properties.MaxLength = 200;
            this.txtContent.Size = new System.Drawing.Size(116, 20);
            this.txtContent.TabIndex = 8;
            // 
            // SuaPhieuChi_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 249);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupControlInfo);
            this.Controls.Add(this.labelControl1);
            this.Name = "SuaPhieuChi_Form";
            this.Text = "Sửa phiếu chi";
            this.Load += new System.EventHandler(this.SuaPhieuChi_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).EndInit();
            this.groupControlInfo.ResumeLayout(false);
            this.groupControlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpkCreateDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpkCreateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControlInfo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtpkCreateDate;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtContent;
    }
}