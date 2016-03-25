namespace QuanLiBanVang.Form
{
    partial class BaoCaoTonKho_Form
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
            this.groupControlInfo = new DevExpress.XtraEditors.GroupControl();
            this.groupControlReport = new DevExpress.XtraEditors.GroupControl();
            this.labelControlFromDate = new DevExpress.XtraEditors.LabelControl();
            this.labelControlToDate = new DevExpress.XtraEditors.LabelControl();
            this.dtpkFromDate = new DevExpress.XtraEditors.DateEdit();
            this.dtpkToDate = new DevExpress.XtraEditors.DateEdit();
            this.btnDisplay = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).BeginInit();
            this.groupControlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpkFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpkFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpkToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpkToDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlInfo
            // 
            this.groupControlInfo.Controls.Add(this.btnDisplay);
            this.groupControlInfo.Controls.Add(this.dtpkToDate);
            this.groupControlInfo.Controls.Add(this.dtpkFromDate);
            this.groupControlInfo.Controls.Add(this.labelControlToDate);
            this.groupControlInfo.Controls.Add(this.labelControlFromDate);
            this.groupControlInfo.Location = new System.Drawing.Point(12, 45);
            this.groupControlInfo.Name = "groupControlInfo";
            this.groupControlInfo.Size = new System.Drawing.Size(696, 81);
            this.groupControlInfo.TabIndex = 0;
            this.groupControlInfo.Text = "Thông tin báo cáo";
            // 
            // groupControlReport
            // 
            this.groupControlReport.Location = new System.Drawing.Point(12, 132);
            this.groupControlReport.Name = "groupControlReport";
            this.groupControlReport.Size = new System.Drawing.Size(696, 319);
            this.groupControlReport.TabIndex = 1;
            this.groupControlReport.Text = "Bảng báo cáo";
            // 
            // labelControlFromDate
            // 
            this.labelControlFromDate.Location = new System.Drawing.Point(5, 43);
            this.labelControlFromDate.Name = "labelControlFromDate";
            this.labelControlFromDate.Size = new System.Drawing.Size(40, 13);
            this.labelControlFromDate.TabIndex = 0;
            this.labelControlFromDate.Text = "Từ ngày";
            // 
            // labelControlToDate
            // 
            this.labelControlToDate.Location = new System.Drawing.Point(254, 43);
            this.labelControlToDate.Name = "labelControlToDate";
            this.labelControlToDate.Size = new System.Drawing.Size(47, 13);
            this.labelControlToDate.TabIndex = 1;
            this.labelControlToDate.Text = "Đến ngày";
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.EditValue = null;
            this.dtpkFromDate.Location = new System.Drawing.Point(91, 40);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpkFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpkFromDate.Size = new System.Drawing.Size(124, 20);
            this.dtpkFromDate.TabIndex = 2;
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.EditValue = null;
            this.dtpkToDate.Location = new System.Drawing.Point(349, 40);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpkToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpkToDate.Size = new System.Drawing.Size(122, 20);
            this.dtpkToDate.TabIndex = 3;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(553, 38);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Xem báo cáo";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Location = new System.Drawing.Point(227, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(232, 33);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "BÁO CÁO TỒN KHO";
            // 
            // BaoCaoTonKho_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 463);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControlReport);
            this.Controls.Add(this.groupControlInfo);
            this.Name = "BaoCaoTonKho_Form";
            this.Text = "BaoCaoTonKho_Form";
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).EndInit();
            this.groupControlInfo.ResumeLayout(false);
            this.groupControlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpkFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpkFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpkToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpkToDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlInfo;
        private DevExpress.XtraEditors.SimpleButton btnDisplay;
        private DevExpress.XtraEditors.DateEdit dtpkToDate;
        private DevExpress.XtraEditors.DateEdit dtpkFromDate;
        private DevExpress.XtraEditors.LabelControl labelControlToDate;
        private DevExpress.XtraEditors.LabelControl labelControlFromDate;
        private DevExpress.XtraEditors.GroupControl groupControlReport;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}