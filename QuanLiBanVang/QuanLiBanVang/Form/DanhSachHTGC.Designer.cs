namespace QuanLiBanVang
{
    partial class DanhSachHTGC
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
            this.gridControlDS = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonEdit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlDS);
            this.groupControl1.Controls.Add(this.simpleButton4);
            this.groupControl1.Controls.Add(this.simpleButtonDel);
            this.groupControl1.Controls.Add(this.simpleButtonEdit);
            this.groupControl1.Controls.Add(this.simpleButtonAdd);
            this.groupControl1.Location = new System.Drawing.Point(11, 41);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(333, 343);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Danh sách";
            // 
            // gridControlDS
            // 
            this.gridControlDS.Location = new System.Drawing.Point(5, 23);
            this.gridControlDS.MainView = this.gridView1;
            this.gridControlDS.Name = "gridControlDS";
            this.gridControlDS.Size = new System.Drawing.Size(231, 315);
            this.gridControlDS.TabIndex = 5;
            this.gridControlDS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlDS;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView1_CustomUnboundColumnData_1);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(242, 308);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 4;
            this.simpleButton4.Text = "Thoát";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButtonDel
            // 
            this.simpleButtonDel.Location = new System.Drawing.Point(242, 81);
            this.simpleButtonDel.Name = "simpleButtonDel";
            this.simpleButtonDel.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonDel.TabIndex = 3;
            this.simpleButtonDel.Text = "Xoá";
            this.simpleButtonDel.Click += new System.EventHandler(this.simpleButtonDel_Click);
            // 
            // simpleButtonEdit
            // 
            this.simpleButtonEdit.Location = new System.Drawing.Point(242, 52);
            this.simpleButtonEdit.Name = "simpleButtonEdit";
            this.simpleButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonEdit.TabIndex = 2;
            this.simpleButtonEdit.Text = "Sửa";
            this.simpleButtonEdit.Click += new System.EventHandler(this.simpleButtonEdit_Click);
            // 
            // simpleButtonAdd
            // 
            this.simpleButtonAdd.Location = new System.Drawing.Point(242, 23);
            this.simpleButtonAdd.Name = "simpleButtonAdd";
            this.simpleButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonAdd.TabIndex = 1;
            this.simpleButtonAdd.Text = "Thêm";
            this.simpleButtonAdd.Click += new System.EventHandler(this.simpleButtonAdd_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(16, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(300, 24);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Danh sách hình thức gia công";
            // 
            // DanhSachHTGC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 391);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "DanhSachHTGC";
            this.Text = "Danh sách hình thức gia công";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAdd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlDS;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}