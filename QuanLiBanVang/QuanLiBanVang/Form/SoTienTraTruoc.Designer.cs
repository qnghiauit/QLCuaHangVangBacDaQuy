namespace QuanLiBanVang.Form
{
    partial class SoTienTraTruoc
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
            this.textEditSoTienTraTruoc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoTienTraTruoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditSoTienTraTruoc
            // 
            this.textEditSoTienTraTruoc.Location = new System.Drawing.Point(75, 40);
            this.textEditSoTienTraTruoc.Name = "textEditSoTienTraTruoc";
            this.textEditSoTienTraTruoc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditSoTienTraTruoc.Size = new System.Drawing.Size(228, 20);
            this.textEditSoTienTraTruoc.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(10, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Trả trước :";
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(228, 68);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 28);
            this.buttonThoat.TabIndex = 2;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(147, 68);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 28);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Tiếp";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // SoTienTraTruoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 108);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditSoTienTraTruoc);
            this.Name = "SoTienTraTruoc";
            this.Text = "Trả trước";
            this.Load += new System.EventHandler(this.SoTienTraTruoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoTienTraTruoc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEditSoTienTraTruoc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonNext;

    }
}