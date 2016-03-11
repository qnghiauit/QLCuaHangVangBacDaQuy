namespace QuanLiBanVang.Form
{
    partial class NhapNhanVien_Form
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
            this.cboPosition = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.rdoGender = new DevExpress.XtraEditors.RadioGroup();
            this.dtpkBirth = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.groupControlAccountInfo = new DevExpress.XtraEditors.GroupControl();
            this.cboGroupUser = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).BeginInit();
            this.groupControlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpkBirth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpkBirth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAccountInfo)).BeginInit();
            this.groupControlAccountInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboGroupUser.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Location = new System.Drawing.Point(99, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(282, 33);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "TÀI KHOẢN NHÂN VIÊN";
            // 
            // groupControlInfo
            // 
            this.groupControlInfo.Controls.Add(this.cboPosition);
            this.groupControlInfo.Controls.Add(this.labelControl9);
            this.groupControlInfo.Controls.Add(this.rdoGender);
            this.groupControlInfo.Controls.Add(this.dtpkBirth);
            this.groupControlInfo.Controls.Add(this.labelControl8);
            this.groupControlInfo.Controls.Add(this.txtPhone);
            this.groupControlInfo.Controls.Add(this.txtAddress);
            this.groupControlInfo.Controls.Add(this.labelControl7);
            this.groupControlInfo.Controls.Add(this.txtName);
            this.groupControlInfo.Controls.Add(this.labelControl6);
            this.groupControlInfo.Controls.Add(this.labelControl5);
            this.groupControlInfo.Controls.Add(this.labelControl2);
            this.groupControlInfo.Location = new System.Drawing.Point(12, 51);
            this.groupControlInfo.Name = "groupControlInfo";
            this.groupControlInfo.Size = new System.Drawing.Size(492, 227);
            this.groupControlInfo.TabIndex = 1;
            this.groupControlInfo.Text = "Thông tin nhân viên";
            // 
            // cboPosition
            // 
            this.cboPosition.Location = new System.Drawing.Point(104, 194);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPosition.Size = new System.Drawing.Size(145, 20);
            this.cboPosition.TabIndex = 15;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(5, 197);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(40, 13);
            this.labelControl9.TabIndex = 14;
            this.labelControl9.Text = "Chức vụ";
            // 
            // rdoGender
            // 
            this.rdoGender.EditValue = true;
            this.rdoGender.Location = new System.Drawing.Point(104, 97);
            this.rdoGender.Name = "rdoGender";
            this.rdoGender.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Nam"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Nữ")});
            this.rdoGender.Size = new System.Drawing.Size(145, 28);
            this.rdoGender.TabIndex = 13;
            // 
            // dtpkBirth
            // 
            this.dtpkBirth.EditValue = null;
            this.dtpkBirth.Location = new System.Drawing.Point(104, 63);
            this.dtpkBirth.Name = "dtpkBirth";
            this.dtpkBirth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpkBirth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpkBirth.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.dtpkBirth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtpkBirth.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.dtpkBirth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtpkBirth.Size = new System.Drawing.Size(145, 20);
            this.dtpkBirth.TabIndex = 12;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(6, 66);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(47, 13);
            this.labelControl8.TabIndex = 11;
            this.labelControl8.Text = "Ngày sinh";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(104, 161);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Mask.EditMask = "[0-9]{1,20}";
            this.txtPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPhone.Size = new System.Drawing.Size(145, 20);
            this.txtPhone.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(104, 131);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Mask.EditMask = "(\\p{L}|[0-9]|\\s){1,100}";
            this.txtAddress.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtAddress.Size = new System.Drawing.Size(145, 20);
            this.txtAddress.TabIndex = 9;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(6, 134);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(32, 13);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "Địa chỉ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 29);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Mask.EditMask = "(\\p{L}|\\s){1,70}";
            this.txtName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtName.Size = new System.Drawing.Size(145, 20);
            this.txtName.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 164);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(62, 13);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Số điện thoại";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 104);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Giới tính";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Họ và tên";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Tên đăng nhập";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 71);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(104, 33);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.Mask.EditMask = "(\\p{L}|[0-9]){1,20}";
            this.txtUsername.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtUsername.Size = new System.Drawing.Size(145, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(104, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Mask.EditMask = "([a-z]|[A-Z]|[0-9]){1,20}";
            this.txtPassword.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(145, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // groupControlAccountInfo
            // 
            this.groupControlAccountInfo.Controls.Add(this.cboGroupUser);
            this.groupControlAccountInfo.Controls.Add(this.labelControl10);
            this.groupControlAccountInfo.Controls.Add(this.labelControl3);
            this.groupControlAccountInfo.Controls.Add(this.labelControl4);
            this.groupControlAccountInfo.Controls.Add(this.txtUsername);
            this.groupControlAccountInfo.Controls.Add(this.txtPassword);
            this.groupControlAccountInfo.Location = new System.Drawing.Point(12, 284);
            this.groupControlAccountInfo.Name = "groupControlAccountInfo";
            this.groupControlAccountInfo.Size = new System.Drawing.Size(492, 140);
            this.groupControlAccountInfo.TabIndex = 2;
            this.groupControlAccountInfo.Text = "Thông tin tài khoản";
            // 
            // cboGroupUser
            // 
            this.cboGroupUser.Location = new System.Drawing.Point(104, 102);
            this.cboGroupUser.Name = "cboGroupUser";
            this.cboGroupUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboGroupUser.Size = new System.Drawing.Size(145, 20);
            this.cboGroupUser.TabIndex = 9;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(5, 105);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(27, 13);
            this.labelControl10.TabIndex = 8;
            this.labelControl10.Text = "Nhóm";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(123, 430);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(282, 430);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            // 
            // NhapNhanVien_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 466);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupControlAccountInfo);
            this.Controls.Add(this.groupControlInfo);
            this.Controls.Add(this.labelControl1);
            this.Name = "NhapNhanVien_Form";
            this.Text = "Tạo tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).EndInit();
            this.groupControlInfo.ResumeLayout(false);
            this.groupControlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpkBirth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpkBirth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAccountInfo)).EndInit();
            this.groupControlAccountInfo.ResumeLayout(false);
            this.groupControlAccountInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboGroupUser.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControlInfo;
        private DevExpress.XtraEditors.ComboBoxEdit cboPosition;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.RadioGroup rdoGender;
        private DevExpress.XtraEditors.DateEdit dtpkBirth;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.GroupControl groupControlAccountInfo;
        private DevExpress.XtraEditors.ComboBoxEdit cboGroupUser;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}