namespace 集团客运综合管理系统.检查管理
{
    partial class Frm车辆安全检查窗口
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
            this.button1 = new System.Windows.Forms.Button();
            this.btchelingxinixi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtchepihao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnanqunjiancha = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbodiannaochaozuoyuan = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InspectionItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.检查项目 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.检查内容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结果 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label32 = new System.Windows.Forms.Label();
            this.cboanjianyuan = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtjichazhan = new System.Windows.Forms.TextBox();
            this.txtchexing = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtjiashiyuanpianming = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.查询检查单 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(-127, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "读卡";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btchelingxinixi
            // 
            this.btchelingxinixi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btchelingxinixi.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btchelingxinixi.Location = new System.Drawing.Point(255, 53);
            this.btchelingxinixi.Name = "btchelingxinixi";
            this.btchelingxinixi.Size = new System.Drawing.Size(75, 28);
            this.btchelingxinixi.TabIndex = 1;
            this.btchelingxinixi.Text = "车辆信息";
            this.btchelingxinixi.UseVisualStyleBackColor = false;
            this.btchelingxinixi.Click += new System.EventHandler(this.btchelingxinixi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(47, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "车牌号:";
            // 
            // txtchepihao
            // 
            this.txtchepihao.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtchepihao.Location = new System.Drawing.Point(113, 55);
            this.txtchepihao.Name = "txtchepihao";
            this.txtchepihao.Size = new System.Drawing.Size(135, 24);
            this.txtchepihao.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(306, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "运 营 客 车 例 检 检 查 单";
            // 
            // btnanqunjiancha
            // 
            this.btnanqunjiancha.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnanqunjiancha.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnanqunjiancha.Location = new System.Drawing.Point(588, 511);
            this.btnanqunjiancha.Name = "btnanqunjiancha";
            this.btnanqunjiancha.Size = new System.Drawing.Size(100, 34);
            this.btnanqunjiancha.TabIndex = 9;
            this.btnanqunjiancha.Text = "确定";
            this.btnanqunjiancha.UseVisualStyleBackColor = false;
            this.btnanqunjiancha.Click += new System.EventHandler(this.btnanqunjiancha_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(727, 511);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 34);
            this.button5.TabIndex = 10;
            this.button5.Text = "退出";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.cbodiannaochaozuoyuan);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtjiashiyuanpianming);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.cboanjianyuan);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.txtjichazhan);
            this.groupBox1.Controls.Add(this.txtchexing);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(867, 414);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " 安全检查";
            // 
            // cbodiannaochaozuoyuan
            // 
            this.cbodiannaochaozuoyuan.FormattingEnabled = true;
            this.cbodiannaochaozuoyuan.Location = new System.Drawing.Point(416, 355);
            this.cbodiannaochaozuoyuan.Name = "cbodiannaochaozuoyuan";
            this.cbodiannaochaozuoyuan.Size = new System.Drawing.Size(148, 22);
            this.cbodiannaochaozuoyuan.TabIndex = 58;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InspectionItemID,
            this.检查项目,
            this.检查内容,
            this.结果,
            this.备注});
            this.dataGridView1.Location = new System.Drawing.Point(0, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(861, 294);
            this.dataGridView1.TabIndex = 57;
            // 
            // InspectionItemID
            // 
            this.InspectionItemID.DataPropertyName = "InspectionItemID";
            this.InspectionItemID.HeaderText = "InspectionItemID";
            this.InspectionItemID.Name = "InspectionItemID";
            this.InspectionItemID.Visible = false;
            // 
            // 检查项目
            // 
            this.检查项目.DataPropertyName = "InspectionItemMC";
            this.检查项目.HeaderText = "检查项目";
            this.检查项目.Name = "检查项目";
            this.检查项目.Width = 70;
            // 
            // 检查内容
            // 
            this.检查内容.DataPropertyName = "InspectionItemyqaoqou";
            this.检查内容.HeaderText = "检查内容";
            this.检查内容.Name = "检查内容";
            this.检查内容.Width = 500;
            // 
            // 结果
            // 
            this.结果.HeaderText = "结果";
            this.结果.Name = "结果";
            this.结果.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.结果.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.结果.Width = 40;
            // 
            // 备注
            // 
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.备注.Width = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(646, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 74);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "检查结果";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(652, 381);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(100, 19);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "检查不及格";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "检查及格";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 383);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 24);
            this.dateTimePicker1.TabIndex = 55;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(9, 387);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(105, 15);
            this.label32.TabIndex = 54;
            this.label32.Text = "安检有效日期:";
            // 
            // cboanjianyuan
            // 
            this.cboanjianyuan.FormattingEnabled = true;
            this.cboanjianyuan.Location = new System.Drawing.Point(416, 384);
            this.cboanjianyuan.Name = "cboanjianyuan";
            this.cboanjianyuan.Size = new System.Drawing.Size(148, 22);
            this.cboanjianyuan.TabIndex = 53;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label31.Location = new System.Drawing.Point(350, 387);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(60, 15);
            this.label31.TabIndex = 51;
            this.label31.Text = "安检员:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label30.Location = new System.Drawing.Point(320, 358);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(90, 15);
            this.label30.TabIndex = 50;
            this.label30.Text = "电脑操作员:";
            // 
            // txtjichazhan
            // 
            this.txtjichazhan.Location = new System.Drawing.Point(120, 353);
            this.txtjichazhan.Name = "txtjichazhan";
            this.txtjichazhan.Size = new System.Drawing.Size(148, 24);
            this.txtjichazhan.TabIndex = 49;
            // 
            // txtchexing
            // 
            this.txtchexing.Location = new System.Drawing.Point(120, 323);
            this.txtchexing.Name = "txtchexing";
            this.txtchexing.Size = new System.Drawing.Size(148, 24);
            this.txtchexing.TabIndex = 48;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label29.Location = new System.Drawing.Point(37, 357);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(76, 15);
            this.label29.TabIndex = 47;
            this.label29.Text = "安 检 站:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.Location = new System.Drawing.Point(37, 327);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(77, 15);
            this.label28.TabIndex = 46;
            this.label28.Text = "车    型:";
            // 
            // txtjiashiyuanpianming
            // 
            this.txtjiashiyuanpianming.Location = new System.Drawing.Point(416, 324);
            this.txtjiashiyuanpianming.Name = "txtjiashiyuanpianming";
            this.txtjiashiyuanpianming.Size = new System.Drawing.Size(148, 24);
            this.txtjiashiyuanpianming.TabIndex = 45;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(275, 328);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(135, 15);
            this.label27.TabIndex = 43;
            this.label27.Text = "车主、驾驶员签名:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.查询检查单);
            this.groupBox3.Controls.Add(this.txtchepihao);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btchelingxinixi);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(867, 88);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // 查询检查单
            // 
            this.查询检查单.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.查询检查单.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.查询检查单.Location = new System.Drawing.Point(678, 53);
            this.查询检查单.Name = "查询检查单";
            this.查询检查单.Size = new System.Drawing.Size(75, 28);
            this.查询检查单.TabIndex = 9;
            this.查询检查单.Text = "车辆信息";
            this.查询检查单.UseVisualStyleBackColor = false;
            this.查询检查单.Click += new System.EventHandler(this.查询检查单_Click);
            // 
            // Frm车辆安全检查窗口
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(881, 548);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnanqunjiancha);
            this.Name = "Frm车辆安全检查窗口";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "车辆安全检查窗口";
            this.Load += new System.EventHandler(this.Frm车辆安全检查窗口_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btchelingxinixi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtchepihao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnanqunjiancha;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox cboanjianyuan;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtjichazhan;
        private System.Windows.Forms.TextBox txtchexing;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtjiashiyuanpianming;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbodiannaochaozuoyuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn InspectionItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 检查项目;
        private System.Windows.Forms.DataGridViewTextBoxColumn 检查内容;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 结果;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        private System.Windows.Forms.Button 查询检查单;
    }
}