namespace QuanLiBanVang.Report
{
    partial class DanhSachPhieuChi_Form
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
            this.groupControlBillList = new DevExpress.XtraEditors.GroupControl();
            this.dgvListPayment = new DevExpress.XtraGrid.GridControl();
            this.dgvPaymentBill = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlBillList)).BeginInit();
            this.groupControlBillList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentBill)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Location = new System.Drawing.Point(110, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(279, 33);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "DANH SÁCH PHIẾU CHI";
            // 
            // groupControlBillList
            // 
            this.groupControlBillList.Controls.Add(this.dgvListPayment);
            this.groupControlBillList.Location = new System.Drawing.Point(12, 51);
            this.groupControlBillList.Name = "groupControlBillList";
            this.groupControlBillList.Size = new System.Drawing.Size(416, 246);
            this.groupControlBillList.TabIndex = 1;
            this.groupControlBillList.Text = "Danh sách";
            // 
            // dgvListPayment
            // 
            this.dgvListPayment.Location = new System.Drawing.Point(5, 23);
            this.dgvListPayment.MainView = this.dgvPaymentBill;
            this.dgvListPayment.Name = "dgvListPayment";
            this.dgvListPayment.Size = new System.Drawing.Size(406, 218);
            this.dgvListPayment.TabIndex = 0;
            this.dgvListPayment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvPaymentBill});
            // 
            // dgvPaymentBill
            // 
            this.dgvPaymentBill.GridControl = this.dgvListPayment;
            this.dgvPaymentBill.Name = "dgvPaymentBill";
            this.dgvPaymentBill.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvPaymentBill.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvPaymentBill.OptionsBehavior.Editable = false;
            this.dgvPaymentBill.OptionsCustomization.AllowColumnMoving = false;
            this.dgvPaymentBill.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgvPaymentBill.OptionsSelection.MultiSelect = true;
            this.dgvPaymentBill.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.dgvPaymentBill_CustomUnboundColumnData);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(441, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(441, 118);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Location = new System.Drawing.Point(441, 173);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Location = new System.Drawing.Point(441, 236);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DanhSachPhieuChi_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 322);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupControlBillList);
            this.Controls.Add(this.labelControl1);
            this.Name = "DanhSachPhieuChi_Form";
            this.Text = "DanhSachPhieuChi_Form";
            this.Load += new System.EventHandler(this.DanhSachPhieuChi_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlBillList)).EndInit();
            this.groupControlBillList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControlBillList;
        private DevExpress.XtraGrid.GridControl dgvListPayment;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvPaymentBill;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnExit;
    }
}