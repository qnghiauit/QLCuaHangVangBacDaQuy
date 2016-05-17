namespace QuanLiBanVang.Form
{
    partial class DanhSachPhieuThuNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachPhieuThuNo));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditKhachHang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlDanhSachPhieuNo = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlPhieuBanHang = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStripGridPhieuBanHang = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemPhiếuNợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpPhiếuNợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButtonThoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSachPhieuNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhieuBanHang)).BeginInit();
            this.contextMenuStripGridPhieuBanHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.comboBoxEditKhachHang);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(884, 94);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Lọc";
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
            this.comboBoxEditKhachHang.Size = new System.Drawing.Size(197, 20);
            this.comboBoxEditKhachHang.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButton1.Location = new System.Drawing.Point(281, 30);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(88, 33);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Xem";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Location = new System.Drawing.Point(12, 112);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(884, 407);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Chi tiết";
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl4.Controls.Add(this.gridControlDanhSachPhieuNo);
            this.groupControl4.Location = new System.Drawing.Point(7, 206);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(872, 201);
            this.groupControl4.TabIndex = 0;
            this.groupControl4.Text = "Phiếu nợ tương ứng";
            // 
            // gridControlDanhSachPhieuNo
            // 
            this.gridControlDanhSachPhieuNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDanhSachPhieuNo.Location = new System.Drawing.Point(2, 20);
            this.gridControlDanhSachPhieuNo.MainView = this.gridView2;
            this.gridControlDanhSachPhieuNo.Name = "gridControlDanhSachPhieuNo";
            this.gridControlDanhSachPhieuNo.Size = new System.Drawing.Size(868, 179);
            this.gridControlDanhSachPhieuNo.TabIndex = 0;
            this.gridControlDanhSachPhieuNo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlDanhSachPhieuNo;
            this.gridView2.Name = "gridView2";
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.gridControlPhieuBanHang);
            this.groupControl3.Location = new System.Drawing.Point(5, 23);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(874, 177);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Phiếu bán";
            // 
            // gridControlPhieuBanHang
            // 
            this.gridControlPhieuBanHang.ContextMenuStrip = this.contextMenuStripGridPhieuBanHang;
            this.gridControlPhieuBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPhieuBanHang.Location = new System.Drawing.Point(2, 20);
            this.gridControlPhieuBanHang.MainView = this.gridView1;
            this.gridControlPhieuBanHang.Name = "gridControlPhieuBanHang";
            this.gridControlPhieuBanHang.Size = new System.Drawing.Size(870, 155);
            this.gridControlPhieuBanHang.TabIndex = 0;
            this.gridControlPhieuBanHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlPhieuBanHang;
            this.gridView1.Name = "gridView1";
            // 
            // simpleButtonThoat
            // 
            this.simpleButtonThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonThoat.Location = new System.Drawing.Point(808, 525);
            this.simpleButtonThoat.Name = "simpleButtonThoat";
            this.simpleButtonThoat.Size = new System.Drawing.Size(88, 31);
            this.simpleButtonThoat.TabIndex = 1;
            this.simpleButtonThoat.Text = "Thoát";
            this.simpleButtonThoat.Click += new System.EventHandler(this.simpleButtonThoat_Click);
            // 
            // DanhSachPhieuThuNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 568);
            this.Controls.Add(this.simpleButtonThoat);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "DanhSachPhieuThuNo";
            this.Text = "Danh sách phiếu nợ";
            this.Load += new System.EventHandler(this.DanhSachPhieuThuNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSachPhieuNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhieuBanHang)).EndInit();
            this.contextMenuStripGridPhieuBanHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditKhachHang;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl gridControlDanhSachPhieuNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridControlPhieuBanHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThoat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGridPhieuBanHang;
        private System.Windows.Forms.ToolStripMenuItem xemPhiếuNợToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpPhiếuNợToolStripMenuItem;
    }
}