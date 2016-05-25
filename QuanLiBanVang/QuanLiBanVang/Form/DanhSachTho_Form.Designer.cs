namespace QuanLiBanVang
{
    partial class DanhSachTho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachTho));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButtonXoa = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSua = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonThem = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlDSTho = new DevExpress.XtraGrid.GridControl();
            this.gridViewDSTho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButtonThoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDSTho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDSTho)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(681, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Danh sách thợ";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.simpleButtonXoa);
            this.groupControl1.Controls.Add(this.simpleButtonSua);
            this.groupControl1.Controls.Add(this.simpleButtonThem);
            this.groupControl1.Controls.Add(this.gridControlDSTho);
            this.groupControl1.Location = new System.Drawing.Point(12, 41);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(681, 378);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin";
            // 
            // simpleButtonXoa
            // 
            this.simpleButtonXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonXoa.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonXoa.Image")));
            this.simpleButtonXoa.Location = new System.Drawing.Point(580, 94);
            this.simpleButtonXoa.Name = "simpleButtonXoa";
            this.simpleButtonXoa.Size = new System.Drawing.Size(87, 27);
            this.simpleButtonXoa.TabIndex = 3;
            this.simpleButtonXoa.Text = "Xoá";
            this.simpleButtonXoa.Click += new System.EventHandler(this.simpleButtonXoa_Click);
            // 
            // simpleButtonSua
            // 
            this.simpleButtonSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonSua.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSua.Image")));
            this.simpleButtonSua.Location = new System.Drawing.Point(580, 61);
            this.simpleButtonSua.Name = "simpleButtonSua";
            this.simpleButtonSua.Size = new System.Drawing.Size(87, 27);
            this.simpleButtonSua.TabIndex = 2;
            this.simpleButtonSua.Text = "Sửa";
            this.simpleButtonSua.Click += new System.EventHandler(this.simpleButtonSua_Click);
            // 
            // simpleButtonThem
            // 
            this.simpleButtonThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonThem.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonThem.Image")));
            this.simpleButtonThem.Location = new System.Drawing.Point(580, 28);
            this.simpleButtonThem.Name = "simpleButtonThem";
            this.simpleButtonThem.Size = new System.Drawing.Size(87, 27);
            this.simpleButtonThem.TabIndex = 1;
            this.simpleButtonThem.Text = "Thêm";
            this.simpleButtonThem.Click += new System.EventHandler(this.simpleButtonThem_Click);
            // 
            // gridControlDSTho
            // 
            this.gridControlDSTho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlDSTho.Location = new System.Drawing.Point(14, 28);
            this.gridControlDSTho.MainView = this.gridViewDSTho;
            this.gridControlDSTho.Name = "gridControlDSTho";
            this.gridControlDSTho.Size = new System.Drawing.Size(560, 335);
            this.gridControlDSTho.TabIndex = 0;
            this.gridControlDSTho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDSTho});
            // 
            // gridViewDSTho
            // 
            this.gridViewDSTho.GridControl = this.gridControlDSTho;
            this.gridViewDSTho.Name = "gridViewDSTho";
            this.gridViewDSTho.OptionsBehavior.Editable = false;
            this.gridViewDSTho.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewDSTho.OptionsView.ShowGroupPanel = false;
            this.gridViewDSTho.OptionsView.ShowIndicator = false;
            this.gridViewDSTho.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridViewDSTho_CustomUnboundColumnData);
            this.gridViewDSTho.DoubleClick += new System.EventHandler(this.gridViewDSTho_DoubleClick);
            // 
            // simpleButtonThoat
            // 
            this.simpleButtonThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonThoat.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonThoat.Image")));
            this.simpleButtonThoat.Location = new System.Drawing.Point(606, 425);
            this.simpleButtonThoat.Name = "simpleButtonThoat";
            this.simpleButtonThoat.Size = new System.Drawing.Size(87, 27);
            this.simpleButtonThoat.TabIndex = 4;
            this.simpleButtonThoat.Text = "Thoát";
            this.simpleButtonThoat.Click += new System.EventHandler(this.simpleButtonThoat_Click);
            // 
            // DanhSachTho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 464);
            this.Controls.Add(this.simpleButtonThoat);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "DanhSachTho";
            this.Text = "Danh sách thợ";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDSTho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDSTho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThoat;
        private DevExpress.XtraEditors.SimpleButton simpleButtonXoa;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSua;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThem;
        private DevExpress.XtraGrid.GridControl gridControlDSTho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDSTho;
    }
}