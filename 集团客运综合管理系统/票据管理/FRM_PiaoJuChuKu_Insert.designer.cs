namespace 集团客运综合管理系统.票据管理
{
    partial class FRM_PiaoJuChuKu_Insert
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPiaoJuKuCun = new System.Windows.Forms.DataGridView();
            this.开始票号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.票据类型ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.票据入库ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结束票号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.当前票号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.库存量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.票据类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboShiYonZhaungTai = new System.Windows.Forms.ComboBox();
            this.使用状态 = new System.Windows.Forms.Label();
            this.txtJieShuPiaoHao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxtBeiZhu = new System.Windows.Forms.RichTextBox();
            this.btnQuXiao = new System.Windows.Forms.Button();
            this.btnQueDing = new System.Windows.Forms.Button();
            this.txtLingYongShuLiang = new System.Windows.Forms.TextBox();
            this.txtKaiShiPiaoHao = new System.Windows.Forms.TextBox();
            this.txtPiaoJuLeiXing = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJieShouYonHu = new System.Windows.Forms.TextBox();
            this.txtJieShouYonHuID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiaoJuKuCun)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPiaoJuKuCun);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(433, 250);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "票据库存";
            // 
            // dgvPiaoJuKuCun
            // 
            this.dgvPiaoJuKuCun.AllowUserToAddRows = false;
            this.dgvPiaoJuKuCun.AllowUserToDeleteRows = false;
            this.dgvPiaoJuKuCun.AllowUserToOrderColumns = true;
            this.dgvPiaoJuKuCun.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPiaoJuKuCun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPiaoJuKuCun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.开始票号,
            this.票据类型ID,
            this.票据入库ID,
            this.结束票号,
            this.当前票号,
            this.库存量,
            this.票据类型});
            this.dgvPiaoJuKuCun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPiaoJuKuCun.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPiaoJuKuCun.Location = new System.Drawing.Point(2, 16);
            this.dgvPiaoJuKuCun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPiaoJuKuCun.Name = "dgvPiaoJuKuCun";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPiaoJuKuCun.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPiaoJuKuCun.RowHeadersVisible = false;
            this.dgvPiaoJuKuCun.RowTemplate.Height = 27;
            this.dgvPiaoJuKuCun.Size = new System.Drawing.Size(429, 232);
            this.dgvPiaoJuKuCun.TabIndex = 0;
            this.dgvPiaoJuKuCun.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPiaoJuKuCun_CellContentClick);
            this.dgvPiaoJuKuCun.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPiaoJuKuCun_CellFormatting);
            // 
            // 开始票号
            // 
            this.开始票号.DataPropertyName = "BeginTicketMark";
            this.开始票号.HeaderText = "开始票号";
            this.开始票号.Name = "开始票号";
            this.开始票号.Width = 96;
            // 
            // 票据类型ID
            // 
            this.票据类型ID.DataPropertyName = "BiIITypeID";
            this.票据类型ID.HeaderText = "票据类型ID";
            this.票据类型ID.Name = "票据类型ID";
            this.票据类型ID.Visible = false;
            // 
            // 票据入库ID
            // 
            this.票据入库ID.DataPropertyName = "BiIIEnterlibraryID";
            this.票据入库ID.HeaderText = "票据入库ID";
            this.票据入库ID.Name = "票据入库ID";
            this.票据入库ID.Visible = false;
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
            // 库存量
            // 
            this.库存量.DataPropertyName = "Inventory";
            this.库存量.HeaderText = "库存量";
            this.库存量.Name = "库存量";
            this.库存量.Width = 81;
            // 
            // 票据类型
            // 
            this.票据类型.DataPropertyName = "BiIITypeMC";
            this.票据类型.HeaderText = "票据类型";
            this.票据类型.Name = "票据类型";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.cboShiYonZhaungTai);
            this.groupBox2.Controls.Add(this.使用状态);
            this.groupBox2.Controls.Add(this.txtJieShuPiaoHao);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rtxtBeiZhu);
            this.groupBox2.Controls.Add(this.btnQuXiao);
            this.groupBox2.Controls.Add(this.btnQueDing);
            this.groupBox2.Controls.Add(this.txtLingYongShuLiang);
            this.groupBox2.Controls.Add(this.txtKaiShiPiaoHao);
            this.groupBox2.Controls.Add(this.txtPiaoJuLeiXing);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtJieShouYonHu);
            this.groupBox2.Controls.Add(this.txtJieShouYonHuID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(431, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(245, 247);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // cboShiYonZhaungTai
            // 
            this.cboShiYonZhaungTai.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboShiYonZhaungTai.FormattingEnabled = true;
            this.cboShiYonZhaungTai.Location = new System.Drawing.Point(94, 144);
            this.cboShiYonZhaungTai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboShiYonZhaungTai.Name = "cboShiYonZhaungTai";
            this.cboShiYonZhaungTai.Size = new System.Drawing.Size(132, 24);
            this.cboShiYonZhaungTai.TabIndex = 165;
            // 
            // 使用状态
            // 
            this.使用状态.AutoSize = true;
            this.使用状态.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.使用状态.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.使用状态.Location = new System.Drawing.Point(21, 148);
            this.使用状态.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.使用状态.Name = "使用状态";
            this.使用状态.Size = new System.Drawing.Size(75, 15);
            this.使用状态.TabIndex = 164;
            this.使用状态.Text = "使用状态:";
            // 
            // txtJieShuPiaoHao
            // 
            this.txtJieShuPiaoHao.BackColor = System.Drawing.SystemColors.Window;
            this.txtJieShuPiaoHao.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJieShuPiaoHao.Location = new System.Drawing.Point(94, 118);
            this.txtJieShuPiaoHao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJieShuPiaoHao.Name = "txtJieShuPiaoHao";
            this.txtJieShuPiaoHao.ReadOnly = true;
            this.txtJieShuPiaoHao.Size = new System.Drawing.Size(131, 24);
            this.txtJieShuPiaoHao.TabIndex = 149;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(21, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 148;
            this.label5.Text = "结束票号:";
            // 
            // rtxtBeiZhu
            // 
            this.rtxtBeiZhu.Location = new System.Drawing.Point(94, 172);
            this.rtxtBeiZhu.Name = "rtxtBeiZhu";
            this.rtxtBeiZhu.Size = new System.Drawing.Size(131, 35);
            this.rtxtBeiZhu.TabIndex = 147;
            this.rtxtBeiZhu.Text = "";
            // 
            // btnQuXiao
            // 
            this.btnQuXiao.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnQuXiao.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuXiao.Location = new System.Drawing.Point(140, 211);
            this.btnQuXiao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuXiao.Name = "btnQuXiao";
            this.btnQuXiao.Size = new System.Drawing.Size(85, 31);
            this.btnQuXiao.TabIndex = 56;
            this.btnQuXiao.Text = "取 消";
            this.btnQuXiao.UseVisualStyleBackColor = false;
            this.btnQuXiao.Click += new System.EventHandler(this.btnQuXiao_Click);
            // 
            // btnQueDing
            // 
            this.btnQueDing.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnQueDing.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQueDing.Location = new System.Drawing.Point(24, 211);
            this.btnQueDing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQueDing.Name = "btnQueDing";
            this.btnQueDing.Size = new System.Drawing.Size(85, 31);
            this.btnQueDing.TabIndex = 55;
            this.btnQueDing.Text = "确 定";
            this.btnQueDing.UseVisualStyleBackColor = false;
            this.btnQueDing.Click += new System.EventHandler(this.btnQueDing_Click);
            // 
            // txtLingYongShuLiang
            // 
            this.txtLingYongShuLiang.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLingYongShuLiang.Location = new System.Drawing.Point(94, 92);
            this.txtLingYongShuLiang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLingYongShuLiang.Name = "txtLingYongShuLiang";
            this.txtLingYongShuLiang.Size = new System.Drawing.Size(131, 24);
            this.txtLingYongShuLiang.TabIndex = 53;
            this.txtLingYongShuLiang.TextChanged += new System.EventHandler(this.txtLingYongShuLiang_TextChanged);
            this.txtLingYongShuLiang.Validated += new System.EventHandler(this.txtLingYongShuLiang_Validated);
            // 
            // txtKaiShiPiaoHao
            // 
            this.txtKaiShiPiaoHao.BackColor = System.Drawing.SystemColors.Window;
            this.txtKaiShiPiaoHao.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtKaiShiPiaoHao.Location = new System.Drawing.Point(94, 66);
            this.txtKaiShiPiaoHao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKaiShiPiaoHao.Name = "txtKaiShiPiaoHao";
            this.txtKaiShiPiaoHao.ReadOnly = true;
            this.txtKaiShiPiaoHao.Size = new System.Drawing.Size(131, 24);
            this.txtKaiShiPiaoHao.TabIndex = 52;
            // 
            // txtPiaoJuLeiXing
            // 
            this.txtPiaoJuLeiXing.BackColor = System.Drawing.SystemColors.Window;
            this.txtPiaoJuLeiXing.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPiaoJuLeiXing.Location = new System.Drawing.Point(94, 41);
            this.txtPiaoJuLeiXing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPiaoJuLeiXing.Name = "txtPiaoJuLeiXing";
            this.txtPiaoJuLeiXing.ReadOnly = true;
            this.txtPiaoJuLeiXing.Size = new System.Drawing.Size(131, 24);
            this.txtPiaoJuLeiXing.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(20, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 50;
            this.label4.Text = "备    注:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(21, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 49;
            this.label3.Text = "领用数量:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 48;
            this.label2.Text = "开始票号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "票据类型:";
            // 
            // txtJieShouYonHu
            // 
            this.txtJieShouYonHu.BackColor = System.Drawing.SystemColors.Window;
            this.txtJieShouYonHu.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJieShouYonHu.Location = new System.Drawing.Point(145, 15);
            this.txtJieShouYonHu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJieShouYonHu.Name = "txtJieShouYonHu";
            this.txtJieShouYonHu.ReadOnly = true;
            this.txtJieShouYonHu.Size = new System.Drawing.Size(81, 24);
            this.txtJieShouYonHu.TabIndex = 46;
            // 
            // txtJieShouYonHuID
            // 
            this.txtJieShouYonHuID.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJieShouYonHuID.Location = new System.Drawing.Point(94, 15);
            this.txtJieShouYonHuID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJieShouYonHuID.Name = "txtJieShouYonHuID";
            this.txtJieShouYonHuID.Size = new System.Drawing.Size(46, 24);
            this.txtJieShouYonHuID.TabIndex = 45;
            this.txtJieShouYonHuID.TextChanged += new System.EventHandler(this.txtJieShouYonHuID_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(7, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 44;
            this.label7.Text = "接收用户ID:";
            // 
            // FRM_PiaoJuChuKu_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(676, 254);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FRM_PiaoJuChuKu_Insert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加票据管理";
            this.Load += new System.EventHandler(this.FRM_PiaoJuChuKu_Insert_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiaoJuKuCun)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPiaoJuKuCun;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnQuXiao;
        private System.Windows.Forms.Button btnQueDing;
        private System.Windows.Forms.TextBox txtLingYongShuLiang;
        private System.Windows.Forms.TextBox txtKaiShiPiaoHao;
        private System.Windows.Forms.TextBox txtPiaoJuLeiXing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJieShouYonHu;
        private System.Windows.Forms.TextBox txtJieShouYonHuID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtxtBeiZhu;
        private System.Windows.Forms.TextBox txtJieShuPiaoHao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboShiYonZhaungTai;
        private System.Windows.Forms.Label 使用状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开始票号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 票据类型ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 票据入库ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结束票号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 当前票号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 库存量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 票据类型;
    }
}