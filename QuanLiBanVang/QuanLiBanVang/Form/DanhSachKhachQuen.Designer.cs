namespace QuanLiBanVang.Form
{
    partial class DanhSachKhachQuen
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButtonThoat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.contextMenuStripGridControl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextMenuStripGridControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStripGridControl;
            this.gridControl1.Location = new System.Drawing.Point(12, 49);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(600, 349);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // simpleButtonThoat
            // 
            this.simpleButtonThoat.Location = new System.Drawing.Point(530, 404);
            this.simpleButtonThoat.Name = "simpleButtonThoat";
            this.simpleButtonThoat.Size = new System.Drawing.Size(82, 25);
            this.simpleButtonThoat.TabIndex = 1;
            this.simpleButtonThoat.Text = "Thoát";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(267, 29);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Danh sách khách quen";
            // 
            // contextMenuStripGridControl
            // 
            this.contextMenuStripGridControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chọnToolStripMenuItem});
            this.contextMenuStripGridControl.Name = "contextMenuStripGridControl";
            this.contextMenuStripGridControl.Size = new System.Drawing.Size(104, 26);
            // 
            // chọnToolStripMenuItem
            // 
            this.chọnToolStripMenuItem.Name = "chọnToolStripMenuItem";
            this.chọnToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.chọnToolStripMenuItem.Text = "Chọn";
            this.chọnToolStripMenuItem.Click += new System.EventHandler(this.chọnToolStripMenuItem_Click);
            // 
            // DanhSachKhachQuen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButtonThoat);
            this.Controls.Add(this.gridControl1);
            this.Name = "DanhSachKhachQuen";
            this.Text = "Khách quen";
            this.Load += new System.EventHandler(this.DanhSachKhachQuen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextMenuStripGridControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThoat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGridControl;
        private System.Windows.Forms.ToolStripMenuItem chọnToolStripMenuItem;
    }
}