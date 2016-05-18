namespace QuanLiBanVang
{
    partial class DanhSachKH
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButtonThoat = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonXoa = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSua = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonThem = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlDSKH = new DevExpress.XtraGrid.GridControl();
            this.gridViewDSKH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDSKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDSKH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButtonThoat);
            this.groupControl1.Controls.Add(this.simpleButtonXoa);
            this.groupControl1.Controls.Add(this.simpleButtonSua);
            this.groupControl1.Controls.Add(this.simpleButtonThem);
            this.groupControl1.Controls.Add(this.gridControlDSKH);
            this.groupControl1.Location = new System.Drawing.Point(14, 41);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(594, 343);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Danh sách";
            // 
            // simpleButtonThoat
            // 
            this.simpleButtonThoat.Location = new System.Drawing.Point(504, 310);
            this.simpleButtonThoat.Name = "simpleButtonThoat";
            this.simpleButtonThoat.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonThoat.TabIndex = 4;
            this.simpleButtonThoat.Text = "Thoát";
            this.simpleButtonThoat.Click += new System.EventHandler(this.simpleButtonThoat_Click);
            // 
            // simpleButtonXoa
            // 
            this.simpleButtonXoa.Location = new System.Drawing.Point(504, 81);
            this.simpleButtonXoa.Name = "simpleButtonXoa";
            this.simpleButtonXoa.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonXoa.TabIndex = 3;
            this.simpleButtonXoa.Text = "Xoá";
            this.simpleButtonXoa.Click += new System.EventHandler(this.simpleButtonXoa_Click);
            // 
            // simpleButtonSua
            // 
            this.simpleButtonSua.Location = new System.Drawing.Point(504, 52);
            this.simpleButtonSua.Name = "simpleButtonSua";
            this.simpleButtonSua.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonSua.TabIndex = 2;
            this.simpleButtonSua.Text = "Sửa";
            this.simpleButtonSua.Click += new System.EventHandler(this.simpleButtonSua_Click);
            // 
            // simpleButtonThem
            // 
            this.simpleButtonThem.Location = new System.Drawing.Point(504, 23);
            this.simpleButtonThem.Name = "simpleButtonThem";
            this.simpleButtonThem.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonThem.TabIndex = 1;
            this.simpleButtonThem.Text = "Thêm";
            this.simpleButtonThem.Click += new System.EventHandler(this.simpleButtonThem_Click);
            // 
            // gridControlDSKH
            // 
            this.gridControlDSKH.Location = new System.Drawing.Point(5, 23);
            this.gridControlDSKH.MainView = this.gridViewDSKH;
            this.gridControlDSKH.Name = "gridControlDSKH";
            this.gridControlDSKH.Size = new System.Drawing.Size(480, 310);
            this.gridControlDSKH.TabIndex = 0;
            this.gridControlDSKH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDSKH});
            // 
            // gridViewDSKH
            // 
            this.gridViewDSKH.GridControl = this.gridControlDSKH;
            this.gridViewDSKH.Name = "gridViewDSKH";
            this.gridViewDSKH.OptionsBehavior.Editable = false;
            this.gridViewDSKH.OptionsView.ShowGroupPanel = false;
            this.gridViewDSKH.OptionsView.ShowIndicator = false;
            this.gridViewDSKH.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridViewDSKH_CustomUnboundColumnData);
            this.gridViewDSKH.DoubleClick += new System.EventHandler(this.gridViewDSKH_DoubleClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(183, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(229, 24);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Danh sách khách hàng";
            // 
            // DanhSachKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 394);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "DanhSachKH";
            this.Text = "Danh sách khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDSKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDSKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThoat;
        private DevExpress.XtraEditors.SimpleButton simpleButtonXoa;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSua;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThem;
        private DevExpress.XtraGrid.GridControl gridControlDSKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDSKH;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}