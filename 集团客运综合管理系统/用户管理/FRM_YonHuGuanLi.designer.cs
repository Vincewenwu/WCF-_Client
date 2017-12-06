namespace 集团客运综合管理系统.用户管理
{
    partial class FRM_YonHuGuanLi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_YonHuGuanLi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvYongHuXinXi = new System.Windows.Forms.DataGridView();
            this.用户编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车站编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.所属车站 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsXingZen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsXiuGai = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbShanChu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbTuiChu = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYongHuBianHao = new System.Windows.Forms.TextBox();
            this.cboYongHuLeiXin = new System.Windows.Forms.ComboBox();
            this.cboSuoShuCheZhan = new System.Windows.Forms.ComboBox();
            this.txtYonHuXingMing = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYongHuXinXi)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvYongHuXinXi);
            this.groupBox1.Location = new System.Drawing.Point(1, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(624, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvYongHuXinXi
            // 
            this.dgvYongHuXinXi.AllowUserToAddRows = false;
            this.dgvYongHuXinXi.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvYongHuXinXi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYongHuXinXi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.用户编码,
            this.用户ID,
            this.用户姓名,
            this.用户类型,
            this.车站编号,
            this.所属车站,
            this.备注});
            this.dgvYongHuXinXi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvYongHuXinXi.Location = new System.Drawing.Point(2, 16);
            this.dgvYongHuXinXi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvYongHuXinXi.Name = "dgvYongHuXinXi";
            this.dgvYongHuXinXi.RowTemplate.Height = 27;
            this.dgvYongHuXinXi.Size = new System.Drawing.Size(620, 311);
            this.dgvYongHuXinXi.TabIndex = 1;
            this.dgvYongHuXinXi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYongHuXinXi_CellContentClick);
            // 
            // 用户编码
            // 
            this.用户编码.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.用户编码.DataPropertyName = "UserCoding";
            this.用户编码.HeaderText = "用户编码";
            this.用户编码.Name = "用户编码";
            this.用户编码.ReadOnly = true;
            this.用户编码.Width = 78;
            // 
            // 用户ID
            // 
            this.用户ID.DataPropertyName = "UserID";
            this.用户ID.HeaderText = "用户ID";
            this.用户ID.Name = "用户ID";
            this.用户ID.ReadOnly = true;
            this.用户ID.Visible = false;
            this.用户ID.Width = 82;
            // 
            // 用户姓名
            // 
            this.用户姓名.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.用户姓名.DataPropertyName = "UserMC";
            this.用户姓名.HeaderText = "用户姓名";
            this.用户姓名.Name = "用户姓名";
            this.用户姓名.ReadOnly = true;
            this.用户姓名.Width = 78;
            // 
            // 用户类型
            // 
            this.用户类型.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.用户类型.DataPropertyName = "UserTypeMC";
            this.用户类型.HeaderText = "用户类型";
            this.用户类型.Name = "用户类型";
            this.用户类型.ReadOnly = true;
            this.用户类型.Width = 78;
            // 
            // 车站编号
            // 
            this.车站编号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.车站编号.DataPropertyName = "CarStanNumber";
            this.车站编号.HeaderText = "车站编号";
            this.车站编号.Name = "车站编号";
            this.车站编号.ReadOnly = true;
            this.车站编号.Width = 78;
            // 
            // 所属车站
            // 
            this.所属车站.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.所属车站.DataPropertyName = "CarStandMC";
            this.所属车站.HeaderText = "所属车站";
            this.所属车站.Name = "所属车站";
            this.所属车站.ReadOnly = true;
            this.所属车站.Width = 78;
            // 
            // 备注
            // 
            this.备注.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.备注.DataPropertyName = "Comments";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            this.备注.Width = 54;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.tlsXingZen,
            this.toolStripSeparator1,
            this.tlsXiuGai,
            this.toolStripSeparator4,
            this.tsbShanChu,
            this.toolStripSeparator2,
            this.tsbTuiChu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(849, 27);
            this.toolStrip1.TabIndex = 67;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tlsXingZen
            // 
            this.tlsXingZen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tlsXingZen.Image = ((System.Drawing.Image)(resources.GetObject("tlsXingZen.Image")));
            this.tlsXingZen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsXingZen.Name = "tlsXingZen";
            this.tlsXingZen.Size = new System.Drawing.Size(56, 24);
            this.tlsXingZen.Text = "新增";
            this.tlsXingZen.Click += new System.EventHandler(this.tlsXingZen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tlsXiuGai
            // 
            this.tlsXiuGai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tlsXiuGai.Image = ((System.Drawing.Image)(resources.GetObject("tlsXiuGai.Image")));
            this.tlsXiuGai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsXiuGai.Name = "tlsXiuGai";
            this.tlsXiuGai.Size = new System.Drawing.Size(56, 24);
            this.tlsXiuGai.Text = "修改";
            this.tlsXiuGai.Click += new System.EventHandler(this.tlsXiuGai_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbShanChu
            // 
            this.tsbShanChu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsbShanChu.Image = ((System.Drawing.Image)(resources.GetObject("tsbShanChu.Image")));
            this.tsbShanChu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShanChu.Name = "tsbShanChu";
            this.tsbShanChu.Size = new System.Drawing.Size(56, 24);
            this.tsbShanChu.Text = "删除";
            this.tsbShanChu.Click += new System.EventHandler(this.tsbShanChu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbTuiChu
            // 
            this.tsbTuiChu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsbTuiChu.Image = ((System.Drawing.Image)(resources.GetObject("tsbTuiChu.Image")));
            this.tsbTuiChu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTuiChu.Name = "tsbTuiChu";
            this.tsbTuiChu.Size = new System.Drawing.Size(56, 24);
            this.tsbTuiChu.Text = "退出";
            this.tsbTuiChu.Click += new System.EventHandler(this.tsbTuiChu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "用户编号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(8, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "用户类型:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(8, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "所属车站:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "用户姓名:";
            // 
            // txtYongHuBianHao
            // 
            this.txtYongHuBianHao.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYongHuBianHao.Location = new System.Drawing.Point(86, 24);
            this.txtYongHuBianHao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtYongHuBianHao.Name = "txtYongHuBianHao";
            this.txtYongHuBianHao.Size = new System.Drawing.Size(128, 24);
            this.txtYongHuBianHao.TabIndex = 13;
            this.txtYongHuBianHao.TextChanged += new System.EventHandler(this.txtYongHuBianHao_TextChanged);
            // 
            // cboYongHuLeiXin
            // 
            this.cboYongHuLeiXin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboYongHuLeiXin.FormattingEnabled = true;
            this.cboYongHuLeiXin.Location = new System.Drawing.Point(86, 107);
            this.cboYongHuLeiXin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboYongHuLeiXin.Name = "cboYongHuLeiXin";
            this.cboYongHuLeiXin.Size = new System.Drawing.Size(128, 24);
            this.cboYongHuLeiXin.TabIndex = 16;
            this.cboYongHuLeiXin.SelectedIndexChanged += new System.EventHandler(this.cboYongHuLeiXin_SelectedIndexChanged);
            // 
            // cboSuoShuCheZhan
            // 
            this.cboSuoShuCheZhan.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboSuoShuCheZhan.FormattingEnabled = true;
            this.cboSuoShuCheZhan.Location = new System.Drawing.Point(86, 150);
            this.cboSuoShuCheZhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSuoShuCheZhan.Name = "cboSuoShuCheZhan";
            this.cboSuoShuCheZhan.Size = new System.Drawing.Size(128, 24);
            this.cboSuoShuCheZhan.TabIndex = 18;
            this.cboSuoShuCheZhan.SelectedIndexChanged += new System.EventHandler(this.cboSuoShuCheZhan_SelectedIndexChanged);
            // 
            // txtYonHuXingMing
            // 
            this.txtYonHuXingMing.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYonHuXingMing.Location = new System.Drawing.Point(86, 66);
            this.txtYonHuXingMing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtYonHuXingMing.Name = "txtYonHuXingMing";
            this.txtYonHuXingMing.Size = new System.Drawing.Size(128, 24);
            this.txtYonHuXingMing.TabIndex = 20;
            this.txtYonHuXingMing.TextChanged += new System.EventHandler(this.txtYonHuXingMing_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtYonHuXingMing);
            this.groupBox2.Controls.Add(this.cboSuoShuCheZhan);
            this.groupBox2.Controls.Add(this.cboYongHuLeiXin);
            this.groupBox2.Controls.Add(this.txtYongHuBianHao);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(629, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(220, 329);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            // 
            // FRM_YonHuGuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(849, 362);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FRM_YonHuGuanLi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.FRM_YonHuGuanLi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYongHuXinXi)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvYongHuXinXi;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlsXingZen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tlsXiuGai;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbShanChu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbTuiChu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYongHuBianHao;
        private System.Windows.Forms.ComboBox cboYongHuLeiXin;
        private System.Windows.Forms.ComboBox cboSuoShuCheZhan;
        private System.Windows.Forms.TextBox txtYonHuXingMing;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车站编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 所属车站;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
    }
}