namespace 集团客运综合管理系统.车辆管理
{
    partial class FRM_JiaShiYuanXinXi
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
            this.cry_JiaShiYuanXinXi = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cry_JiaShiYuanXinXi
            // 
            this.cry_JiaShiYuanXinXi.ActiveViewIndex = -1;
            this.cry_JiaShiYuanXinXi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cry_JiaShiYuanXinXi.Cursor = System.Windows.Forms.Cursors.Default;
            this.cry_JiaShiYuanXinXi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cry_JiaShiYuanXinXi.Location = new System.Drawing.Point(0, 0);
            this.cry_JiaShiYuanXinXi.Name = "cry_JiaShiYuanXinXi";
            this.cry_JiaShiYuanXinXi.Size = new System.Drawing.Size(1282, 753);
            this.cry_JiaShiYuanXinXi.TabIndex = 0;
            // 
            // FRM_JiaShiYuanXinXi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.cry_JiaShiYuanXinXi);
            this.Name = "FRM_JiaShiYuanXinXi";
            this.Text = "驾驶员信息";
            this.Load += new System.EventHandler(this.FRM_JiaShiYuanXinXi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cry_JiaShiYuanXinXi;
    }
}