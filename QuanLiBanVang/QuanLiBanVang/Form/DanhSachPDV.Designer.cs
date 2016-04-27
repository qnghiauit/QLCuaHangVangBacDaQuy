namespace QuanLiBanVang
{
    partial class DanhSachPDV
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
            this.gridControlDSPDV = new DevExpress.XtraGrid.GridControl();
            this.gridViewDSPDV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButtonThoat = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonEdit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDSPDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDSPDV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlDSPDV);
            this.groupControl1.Controls.Add(this.simpleButtonThoat);
            this.groupControl1.Controls.Add(this.simpleButtonDel);
            this.groupControl1.Controls.Add(this.simpleButtonEdit);
            this.groupControl1.Controls.Add(this.simpleButtonAdd);
            this.groupControl1.Location = new System.Drawing.Point(12, 41);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(663, 441);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Danh sách";
            // 
            // gridControlDSPDV
            // 
            this.gridControlDSPDV.Location = new System.Drawing.Point(5, 23);
            this.gridControlDSPDV.MainView = this.gridViewDSPDV;
            this.gridControlDSPDV.Name = "gridControlDSPDV";
            this.gridControlDSPDV.Size = new System.Drawing.Size(572, 349);
            this.gridControlDSPDV.TabIndex = 5;
            this.gridControlDSPDV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDSPDV});
            // 
            // gridViewDSPDV
            // 
            this.gridViewDSPDV.GridControl = this.gridControlDSPDV;
            this.gridViewDSPDV.Name = "gridViewDSPDV";
            this.gridViewDSPDV.OptionsBehavior.Editable = false;
            this.gridViewDSPDV.OptionsBehavior.ReadOnly = true;
            this.gridViewDSPDV.OptionsView.ShowGroupPanel = false;
            this.gridViewDSPDV.OptionsView.ShowIndicator = false;
            this.gridViewDSPDV.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridViewDSPDV_CustomUnboundColumnData);
            this.gridViewDSPDV.DoubleClick += new System.EventHandler(this.gridViewDSPDV_DoubleClick);
            // 
            // simpleButtonThoat
            // 
            this.simpleButtonThoat.Location = new System.Drawing.Point(583, 308);
            this.simpleButtonThoat.Name = "simpleButtonThoat";
            this.simpleButtonThoat.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonThoat.TabIndex = 4;
            this.simpleButtonThoat.Text = "Thoát";
            this.simpleButtonThoat.Click += new System.EventHandler(this.simpleButtonThoat_Click);
            // 
            // simpleButtonDel
            // 
            this.simpleButtonDel.Location = new System.Drawing.Point(583, 81);
            this.simpleButtonDel.Name = "simpleButtonDel";
            this.simpleButtonDel.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonDel.TabIndex = 3;
            this.simpleButtonDel.Text = "Xoá";
            this.simpleButtonDel.Click += new System.EventHandler(this.simpleButtonDel_Click);
            // 
            // simpleButtonEdit
            // 
            this.simpleButtonEdit.Location = new System.Drawing.Point(583, 52);
            this.simpleButtonEdit.Name = "simpleButtonEdit";
            this.simpleButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonEdit.TabIndex = 2;
            this.simpleButtonEdit.Text = "Sửa";
            this.simpleButtonEdit.Click += new System.EventHandler(this.simpleButtonEdit_Click);
            // 
            // simpleButtonAdd
            // 
            this.simpleButtonAdd.Location = new System.Drawing.Point(583, 23);
            this.simpleButtonAdd.Name = "simpleButtonAdd";
            this.simpleButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonAdd.TabIndex = 1;
            this.simpleButtonAdd.Text = "Thêm";
            this.simpleButtonAdd.Click += new System.EventHandler(this.simpleButtonAdd_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(172, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(248, 24);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Danh sách phiếu dịch vụ";
            // 
            // DanhSachPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 494);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "DanhSachPDV";
            this.Text = "DanhSachPDV";
            this.Load += new System.EventHandler(this.DanhSachPDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDSPDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDSPDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlDSPDV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDSPDV;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThoat;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAdd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}