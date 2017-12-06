namespace 集团客运综合管理系统.票据管理
{
    partial class FRM_PiaoJuRuKu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PiaoJuRuKu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tosXinZeng = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlpShanChu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlpTuiChu = new System.Windows.Forms.ToolStripButton();
            this.dgvPiaoJuXinXi = new System.Windows.Forms.DataGridView();
            this.票据入库ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.开始票号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结束票号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.当前票号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入库数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.库存量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入库日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.票据类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.操作员名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiaoJuXinXi)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tosXinZeng,
            this.toolStripSeparator1,
            this.tlpShanChu,
            this.toolStripSeparator3,
            this.tlpTuiChu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(849, 27);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tosXinZeng
            // 
            this.tosXinZeng.Image = ((System.Drawing.Image)(resources.GetObject("tosXinZeng.Image")));
            this.tosXinZeng.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tosXinZeng.Name = "tosXinZeng";
            this.tosXinZeng.Size = new System.Drawing.Size(60, 24);
            this.tosXinZeng.Text = "新 增";
            this.tosXinZeng.Click += new System.EventHandler(this.tosXinZeng_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tlpShanChu
            // 
            this.tlpShanChu.Image = ((System.Drawing.Image)(resources.GetObject("tlpShanChu.Image")));
            this.tlpShanChu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlpShanChu.Name = "tlpShanChu";
            this.tlpShanChu.Size = new System.Drawing.Size(64, 24);
            this.tlpShanChu.Text = "删  除";
            this.tlpShanChu.Click += new System.EventHandler(this.tlpShanChu_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tlpTuiChu
            // 
            this.tlpTuiChu.Image = ((System.Drawing.Image)(resources.GetObject("tlpTuiChu.Image")));
            this.tlpTuiChu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlpTuiChu.Name = "tlpTuiChu";
            this.tlpTuiChu.Size = new System.Drawing.Size(64, 24);
            this.tlpTuiChu.Text = "退  出";
            this.tlpTuiChu.Click += new System.EventHandler(this.tlpTuiChu_Click);
            // 
            // dgvPiaoJuXinXi
            // 
            this.dgvPiaoJuXinXi.AllowUserToAddRows = false;
            this.dgvPiaoJuXinXi.AllowUserToDeleteRows = false;
            this.dgvPiaoJuXinXi.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPiaoJuXinXi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPiaoJuXinXi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.票据入库ID,
            this.开始票号,
            this.结束票号,
            this.当前票号,
            this.入库数量,
            this.库存量,
            this.入库日期,
            this.票据类型,
            this.操作员名称,
            this.备注});
            this.dgvPiaoJuXinXi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPiaoJuXinXi.Location = new System.Drawing.Point(0, 27);
            this.dgvPiaoJuXinXi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPiaoJuXinXi.Name = "dgvPiaoJuXinXi";
            this.dgvPiaoJuXinXi.RowTemplate.Height = 27;
            this.dgvPiaoJuXinXi.Size = new System.Drawing.Size(849, 335);
            this.dgvPiaoJuXinXi.TabIndex = 35;
            // 
            // 票据入库ID
            // 
            this.票据入库ID.DataPropertyName = "BiIIEnterlibraryID";
            this.票据入库ID.HeaderText = "票据入库ID";
            this.票据入库ID.Name = "票据入库ID";
            this.票据入库ID.Visible = false;
            // 
            // 开始票号
            // 
            this.开始票号.DataPropertyName = "BeginTicketMark";
            this.开始票号.HeaderText = "开始票号";
            this.开始票号.Name = "开始票号";
            this.开始票号.Width = 96;
            // 
            // 结束票号
            // 
            this.结束票号.DataPropertyName = "FinishTicketMark";
            this.结束票号.HeaderText = "结束票号";
            this.结束票号.Name = "结束票号";
            this.结束票号.Width = 96;
            // 
            // 当前票号
            // 
            this.当前票号.DataPropertyName = "CurrentTicketMark";
            this.当前票号.HeaderText = "当前票号";
            this.当前票号.Name = "当前票号";
            this.当前票号.Width = 96;
            // 
            // 入库数量
            // 
            this.入库数量.DataPropertyName = "EnterlibraryQuantity";
            this.入库数量.HeaderText = "入库数量";
            this.入库数量.Name = "入库数量";
            this.入库数量.Width = 96;
            // 
            // 库存量
            // 
            this.库存量.DataPropertyName = "Inventory";
            this.库存量.HeaderText = "库存量";
            this.库存量.Name = "库存量";
            // 
            // 入库日期
            // 
            this.入库日期.DataPropertyName = "EnterlibraryDate";
            this.入库日期.HeaderText = "入库日期";
            this.入库日期.Name = "入库日期";
            // 
            // 票据类型
            // 
            this.票据类型.DataPropertyName = "BiIITypeMC";
            this.票据类型.HeaderText = "票据类型";
            this.票据类型.Name = "票据类型";
            // 
            // 操作员名称
            // 
            this.操作员名称.DataPropertyName = "UserMC";
            this.操作员名称.HeaderText = "操作员名称";
            this.操作员名称.Name = "操作员名称";
            this.操作员名称.Width = 120;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "Comment";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            // 
            // FRM_PiaoJuRuKu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(849, 362);
            this.Controls.Add(this.dgvPiaoJuXinXi);
            this.Controls.Add(this.toolStrip1);
            this.Location = new System.Drawing.Point(279, 104);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FRM_PiaoJuRuKu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "票据入库管理";
            this.Load += new System.EventHandler(this.FRM_PiaoJuRuKu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiaoJuXinXi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tosXinZeng;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tlpShanChu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tlpTuiChu;
        private System.Windows.Forms.DataGridView dgvPiaoJuXinXi;
        private System.Windows.Forms.DataGridViewTextBoxColumn 票据入库ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开始票号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结束票号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 当前票号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入库数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 库存量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入库日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 票据类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 操作员名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
    }
}