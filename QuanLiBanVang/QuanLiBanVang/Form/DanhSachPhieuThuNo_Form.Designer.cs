namespace QuanLiBanVang.Form
{
    partial class DanhSachPhieuThuNo_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachPhieuThuNo_Form));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditKhachHang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlDanhSachPhieuNo = new DevExpress.XtraGrid.GridControl();
            this.gridViewDanhSachPhieuNo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlPhieuBanHang = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStripGridPhieuBanHang = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemPhiếuNợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpPhiếuNợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewDanhSachPhieuBanHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButtonThoat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSachPhieuNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhSachPhieuNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhieuBanHang)).BeginInit();
            this.contextMenuStripGridPhieuBanHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhSachPhieuBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.comboBoxEditKhachHang);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Location = new System.Drawing.Point(12, 42);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(566, 73);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Điều kiện lọc";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Khách hàng :";
            // 
            // comboBoxEditKhachHang
            // 
            this.comboBoxEditKhachHang.Location = new System.Drawing.Point(78, 37);
            this.comboBoxEditKhachHang.Name = "comboBoxEditKhachHang";
            this.comboBoxEditKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditKhachHang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditKhachHang.Size = new System.Drawing.Size(197, 20);
            this.comboBoxEditKhachHang.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(281, 33);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(73, 27);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Xem";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.gridControlDanhSachPhieuNo);
            this.groupControl2.Controls.Add(this.gridControlPhieuBanHang);
            this.groupControl2.Location = new System.Drawing.Point(12, 121);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(566, 446);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Chi tiết";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.labelControl4.Location = new System.Drawing.Point(9, 237);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(95, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Phiếu nợ tương ứng";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.labelControl3.Location = new System.Drawing.Point(9, 33);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Phiếu bán";
            // 
            // gridControlDanhSachPhieuNo
            // 
            this.gridControlDanhSachPhieuNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlDanhSachPhieuNo.Location = new System.Drawing.Point(9, 256);
            this.gridControlDanhSachPhieuNo.MainView = this.gridViewDanhSachPhieuNo;
            this.gridControlDanhSachPhieuNo.Name = "gridControlDanhSachPhieuNo";
            this.gridControlDanhSachPhieuNo.Size = new System.Drawing.Size(552, 179);
            this.gridControlDanhSachPhieuNo.TabIndex = 0;
            this.gridControlDanhSachPhieuNo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDanhSachPhieuNo});
            // 
            // gridViewDanhSachPhieuNo
            // 
            this.gridViewDanhSachPhieuNo.GridControl = this.gridControlDanhSachPhieuNo;
            this.gridViewDanhSachPhieuNo.Name = "gridViewDanhSachPhieuNo";
            this.gridViewDanhSachPhieuNo.OptionsView.ShowGroupPanel = false;
            // 
            // gridControlPhieuBanHang
            // 
            this.gridControlPhieuBanHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlPhieuBanHang.ContextMenuStrip = this.contextMenuStripGridPhieuBanHang;
            this.gridControlPhieuBanHang.Location = new System.Drawing.Point(9, 52);
            this.gridControlPhieuBanHang.MainView = this.gridViewDanhSachPhieuBanHang;
            this.gridControlPhieuBanHang.Name = "gridControlPhieuBanHang";
            this.gridControlPhieuBanHang.Size = new System.Drawing.Size(552, 179);
            this.gridControlPhieuBanHang.TabIndex = 0;
            this.gridControlPhieuBanHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDanhSachPhieuBanHang});
            // 
            // contextMenuStripGridPhieuBanHang
            // 
            this.contextMenuStripGridPhieuBanHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemPhiếuNợToolStripMenuItem,
            this.lậpPhiếuNợToolStripMenuItem});
            this.contextMenuStripGridPhieuBanHang.Name = "contextMenuStripGridPhieuBanHang";
            this.contextMenuStripGridPhieuBanHang.Size = new System.Drawing.Size(149, 48);
            // 
            // xemPhiếuNợToolStripMenuItem
            // 
            this.xemPhiếuNợToolStripMenuItem.Name = "xemPhiếuNợToolStripMenuItem";
            this.xemPhiếuNợToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.xemPhiếuNợToolStripMenuItem.Text = "Xem phiếu nợ";
            this.xemPhiếuNợToolStripMenuItem.Click += new System.EventHandler(this.xemPhiếuNợToolStripMenuItem_Click);
            // 
            // lậpPhiếuNợToolStripMenuItem
            // 
            this.lậpPhiếuNợToolStripMenuItem.Name = "lậpPhiếuNợToolStripMenuItem";
            this.lậpPhiếuNợToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.lậpPhiếuNợToolStripMenuItem.Text = "Lập phiếu nợ";
            this.lậpPhiếuNợToolStripMenuItem.Click += new System.EventHandler(this.lậpPhiếuNợToolStripMenuItem_Click);
            // 
            // gridViewDanhSachPhieuBanHang
            // 
            this.gridViewDanhSachPhieuBanHang.GridControl = this.gridControlPhieuBanHang;
            this.gridViewDanhSachPhieuBanHang.Name = "gridViewDanhSachPhieuBanHang";
            this.gridViewDanhSachPhieuBanHang.OptionsView.ShowGroupPanel = false;
            // 
            // simpleButtonThoat
            // 
            this.simpleButtonThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonThoat.Location = new System.Drawing.Point(494, 573);
            this.simpleButtonThoat.Name = "simpleButtonThoat";
            this.simpleButtonThoat.Size = new System.Drawing.Size(87, 27);
            this.simpleButtonThoat.TabIndex = 1;
            this.simpleButtonThoat.Text = "Thoát";
            this.simpleButtonThoat.Click += new System.EventHandler(this.simpleButtonThoat_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(569, 24);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Danh sách phiếu nợ";
            // 
            // DanhSachPhieuThuNo_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 608);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.simpleButtonThoat);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "DanhSachPhieuThuNo_Form";
            this.Text = "Danh sách phiếu nợ";
            this.Load += new System.EventHandler(this.DanhSachPhieuThuNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSachPhieuNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhSachPhieuNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhieuBanHang)).EndInit();
            this.contextMenuStripGridPhieuBanHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhSachPhieuBanHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditKhachHang;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControlDanhSachPhieuNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDanhSachPhieuNo;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThoat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGridPhieuBanHang;
        private System.Windows.Forms.ToolStripMenuItem xemPhiếuNợToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpPhiếuNợToolStripMenuItem;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gridControlPhieuBanHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDanhSachPhieuBanHang;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}