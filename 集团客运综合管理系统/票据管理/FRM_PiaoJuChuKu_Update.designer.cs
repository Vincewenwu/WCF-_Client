namespace 集团客运综合管理系统.票据管理
{
    partial class FRM_PiaoJuChuKu_Update
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPiaoJuXinXi = new System.Windows.Forms.DataGridView();
            this.开始票号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.票据出库ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结束票号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.当前票号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.余票数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.发放日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.票据类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQuXiao = new System.Windows.Forms.Button();
            this.rtxtBeiZhu = new System.Windows.Forms.RichTextBox();
            this.cboJieShouYonHu = new System.Windows.Forms.ComboBox();
            this.cboShiYonZhaungTai = new System.Windows.Forms.ComboBox();
            this.btnQueDing = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.使用状态 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiaoJuXinXi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPiaoJuXinXi);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 312);
            this.groupBox1.TabIndex = 169;
            this.groupBox1.TabStop = false;
            // 
            // dgvPiaoJuXinXi
            // 
            this.dgvPiaoJuXinXi.AllowUserToAddRows = false;
            this.dgvPiaoJuXinXi.AllowUserToDeleteRows = false;
            this.dgvPiaoJuXinXi.AllowUserToOrderColumns = true;
            this.dgvPiaoJuXinXi.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPiaoJuXinXi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPiaoJuXinXi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.开始票号,
            this.票据出库ID,
            this.结束票号,
            this.当前票号,
            this.余票数量,
            this.发放日期,
            this.票据类型});
            this.dgvPiaoJuXinXi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPiaoJuXinXi.Location = new System.Drawing.Point(3, 21);
            this.dgvPiaoJuXinXi.Name = "dgvPiaoJuXinXi";
            this.dgvPiaoJuXinXi.RowHeadersVisible = false;
            this.dgvPiaoJuXinXi.RowTemplate.Height = 27;
            this.dgvPiaoJuXinXi.Size = new System.Drawing.Size(571, 288);
            this.dgvPiaoJuXinXi.TabIndex = 167;
            // 
            // 开始票号
            // 
            this.开始票号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.开始票号.DataPropertyName = "BeginTicketMark";
            this.开始票号.HeaderText = "开始票号";
            this.开始票号.Name = "开始票号";
            this.开始票号.ReadOnly = true;
            this.开始票号.Width = 96;
            // 
            // 票据出库ID
            // 
            this.票据出库ID.DataPropertyName = "BillremovalD";
            this.票据出库ID.HeaderText = "票据出库ID";
            this.票据出库ID.Name = "票据出库ID";
            this.票据出库ID.ReadOnly = true;
            this.票据出库ID.Visible = false;
            // 
            // 结束票号
            // 
            this.结束票号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.结束票号.DataPropertyName = "FinishTicketMark";
            this.结束票号.HeaderText = "结束票号";
            this.结束票号.Name = "结束票号";
            this.结束票号.ReadOnly = true;
            this.结束票号.Width = 96;
            // 
            // 当前票号
            // 
            this.当前票号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.当前票号.DataPropertyName = "CurrentTicketMark";
            this.当前票号.HeaderText = "当前票号";
            this.当前票号.Name = "当前票号";
            this.当前票号.ReadOnly = true;
            this.当前票号.Width = 96;
            // 
            // 余票数量
            // 
            this.余票数量.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.余票数量.DataPropertyName = "SurplusQuantity";
            this.余票数量.HeaderText = "余票数量";
            this.余票数量.Name = "余票数量";
            this.余票数量.ReadOnly = true;
            this.余票数量.Width = 96;
            // 
            // 发放日期
            // 
            this.发放日期.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.发放日期.DataPropertyName = "RemovaDate";
            this.发放日期.HeaderText = "发放日期";
            this.发放日期.Name = "发放日期";
            this.发放日期.ReadOnly = true;
            this.发放日期.Width = 96;
            // 
            // 票据类型
            // 
            this.票据类型.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.票据类型.DataPropertyName = "BiIITypeMC";
            this.票据类型.HeaderText = "票据类型";
            this.票据类型.Name = "票据类型";
            this.票据类型.ReadOnly = true;
            this.票据类型.Width = 96;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQuXiao);
            this.groupBox2.Controls.Add(this.rtxtBeiZhu);
            this.groupBox2.Controls.Add(this.cboJieShouYonHu);
            this.groupBox2.Controls.Add(this.cboShiYonZhaungTai);
            this.groupBox2.Controls.Add(this.btnQueDing);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.使用状态);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(575, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 309);
            this.groupBox2.TabIndex = 170;
            this.groupBox2.TabStop = false;
            // 
            // btnQuXiao
            // 
            this.btnQuXiao.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnQuXiao.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuXiao.Location = new System.Drawing.Point(186, 226);
            this.btnQuXiao.Name = "btnQuXiao";
            this.btnQuXiao.Size = new System.Drawing.Size(113, 39);
            this.btnQuXiao.TabIndex = 176;
            this.btnQuXiao.Text = "取 消";
            this.btnQuXiao.UseVisualStyleBackColor = false;
            this.btnQuXiao.Click += new System.EventHandler(this.btnQuXiao_Click);
            // 
            // rtxtBeiZhu
            // 
            this.rtxtBeiZhu.Location = new System.Drawing.Point(126, 120);
            this.rtxtBeiZhu.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtBeiZhu.Name = "rtxtBeiZhu";
            this.rtxtBeiZhu.Size = new System.Drawing.Size(173, 69);
            this.rtxtBeiZhu.TabIndex = 175;
            this.rtxtBeiZhu.Text = "";
            // 
            // cboJieShouYonHu
            // 
            this.cboJieShouYonHu.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboJieShouYonHu.FormattingEnabled = true;
            this.cboJieShouYonHu.Location = new System.Drawing.Point(126, 23);
            this.cboJieShouYonHu.Name = "cboJieShouYonHu";
            this.cboJieShouYonHu.Size = new System.Drawing.Size(173, 28);
            this.cboJieShouYonHu.TabIndex = 173;
            // 
            // cboShiYonZhaungTai
            // 
            this.cboShiYonZhaungTai.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboShiYonZhaungTai.FormattingEnabled = true;
            this.cboShiYonZhaungTai.Location = new System.Drawing.Point(126, 69);
            this.cboShiYonZhaungTai.Name = "cboShiYonZhaungTai";
            this.cboShiYonZhaungTai.Size = new System.Drawing.Size(173, 28);
            this.cboShiYonZhaungTai.TabIndex = 172;
            // 
            // btnQueDing
            // 
            this.btnQueDing.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnQueDing.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQueDing.Location = new System.Drawing.Point(35, 226);
            this.btnQueDing.Name = "btnQueDing";
            this.btnQueDing.Size = new System.Drawing.Size(113, 39);
            this.btnQueDing.TabIndex = 170;
            this.btnQueDing.Text = "确 定";
            this.btnQueDing.UseVisualStyleBackColor = false;
            this.btnQueDing.Click += new System.EventHandler(this.btnQueDing_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(27, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 174;
            this.label4.Text = "备    注:";
            // 
            // 使用状态
            // 
            this.使用状态.AutoSize = true;
            this.使用状态.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.使用状态.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.使用状态.Location = new System.Drawing.Point(27, 74);
            this.使用状态.Name = "使用状态";
            this.使用状态.Size = new System.Drawing.Size(95, 19);
            this.使用状态.TabIndex = 171;
            this.使用状态.Text = "使用状态:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(27, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 169;
            this.label7.Text = "接收用户:";
            // 
            // FRM_PiaoJuChuKu_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(901, 318);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRM_PiaoJuChuKu_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改票据管理";
            this.Load += new System.EventHandler(this.FRM_PiaoJuChuKu_Update_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiaoJuXinXi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPiaoJuXinXi;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开始票号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 票据出库ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结束票号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 当前票号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 余票数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 发放日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 票据类型;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnQuXiao;
        private System.Windows.Forms.RichTextBox rtxtBeiZhu;
        private System.Windows.Forms.ComboBox cboJieShouYonHu;
        private System.Windows.Forms.ComboBox cboShiYonZhaungTai;
        private System.Windows.Forms.Button btnQueDing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label 使用状态;
        private System.Windows.Forms.Label label7;
    }
}