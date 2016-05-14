namespace QuanLiBanVang
{
    partial class NhapCTGiaCongSP_Form
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
            this.gridControlCTGCSP = new DevExpress.XtraGrid.GridControl();
            this.gridViewCTGCSP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCTGCSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTGCSP)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlCTGCSP
            // 
            this.gridControlCTGCSP.Location = new System.Drawing.Point(31, 62);
            this.gridControlCTGCSP.MainView = this.gridViewCTGCSP;
            this.gridControlCTGCSP.Name = "gridControlCTGCSP";
            this.gridControlCTGCSP.Size = new System.Drawing.Size(315, 288);
            this.gridControlCTGCSP.TabIndex = 11;
            this.gridControlCTGCSP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCTGCSP});
            // 
            // gridViewCTGCSP
            // 
            this.gridViewCTGCSP.GridControl = this.gridControlCTGCSP;
            this.gridViewCTGCSP.Name = "gridViewCTGCSP";
            this.gridViewCTGCSP.OptionsView.ShowGroupPanel = false;
            this.gridViewCTGCSP.OptionsView.ShowIndicator = false;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Location = new System.Drawing.Point(33, 23);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(313, 24);
            this.labelControl10.TabIndex = 19;
            this.labelControl10.Text = "CHI TIẾT GIA CÔNG SẢN PHẨM";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(298, 356);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 20;
            this.simpleButton1.Text = "Cập nhật";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // CTGiaCongSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 391);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.gridControlCTGCSP);
            this.Name = "CTGiaCongSP";
            this.Text = "CTGiaCongSP";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCTGCSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTGCSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCTGCSP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCTGCSP;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}