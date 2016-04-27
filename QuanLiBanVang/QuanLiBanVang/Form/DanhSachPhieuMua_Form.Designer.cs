namespace QuanLiBanVang.Report
{
    partial class DanhSachPhieuMua_Form
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
            this.groupControlListBuyBill = new DevExpress.XtraEditors.GroupControl();
            this.dgvListBuyBill = new DevExpress.XtraGrid.GridControl();
            this.dgvBuyBill = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlListBuyBill)).BeginInit();
            this.groupControlListBuyBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBuyBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyBill)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlListBuyBill
            // 
            this.groupControlListBuyBill.Controls.Add(this.dgvListBuyBill);
            this.groupControlListBuyBill.Location = new System.Drawing.Point(12, 51);
            this.groupControlListBuyBill.Name = "groupControlListBuyBill";
            this.groupControlListBuyBill.Size = new System.Drawing.Size(530, 235);
            this.groupControlListBuyBill.TabIndex = 0;
            this.groupControlListBuyBill.Text = "Danh sách";
            // 
            // dgvListBuyBill
            // 
            this.dgvListBuyBill.Location = new System.Drawing.Point(5, 23);
            this.dgvListBuyBill.MainView = this.dgvBuyBill;
            this.dgvListBuyBill.Name = "dgvListBuyBill";
            this.dgvListBuyBill.Size = new System.Drawing.Size(512, 200);
            this.dgvListBuyBill.TabIndex = 0;
            this.dgvListBuyBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvBuyBill});
            // 
            // dgvBuyBill
            // 
            this.dgvBuyBill.GridControl = this.dgvListBuyBill;
            this.dgvBuyBill.Name = "dgvBuyBill";
            this.dgvBuyBill.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvBuyBill.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvBuyBill.OptionsBehavior.Editable = false;
            this.dgvBuyBill.OptionsCustomization.AllowColumnMoving = false;
            this.dgvBuyBill.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgvBuyBill.OptionsSelection.MultiSelect = true;
            this.dgvBuyBill.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Location = new System.Drawing.Point(150, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(217, 33);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "PHIẾU MUA HÀNG";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(56, 292);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Nhập";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(177, 292);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Location = new System.Drawing.Point(294, 292);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Location = new System.Drawing.Point(408, 292);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            // 
            // DanhSachPhieuMua_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 321);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControlListBuyBill);
            this.Name = "DanhSachPhieuMua_Form";
            this.Text = "DanhSachPhieuMua_Form";
            this.Load += new System.EventHandler(this.DanhSachPhieuMua_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlListBuyBill)).EndInit();
            this.groupControlListBuyBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBuyBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlListBuyBill;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl dgvListBuyBill;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvBuyBill;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnExit;
    }
}