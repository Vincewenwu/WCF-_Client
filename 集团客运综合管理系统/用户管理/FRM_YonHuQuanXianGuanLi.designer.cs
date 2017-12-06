namespace 集团客运综合管理系统.用户管理
{
    partial class FRM_YonHuQuanXianGuanLi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvYonHuLeiXing = new System.Windows.Forms.DataGridView();
            this.用户类型ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.btnQuXiao = new System.Windows.Forms.Button();
            this.btnTuiChu = new System.Windows.Forms.Button();
            this.btnBaoCun = new System.Windows.Forms.Button();
            this.btnXiuGai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYonHuLeiXing)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvYonHuLeiXing);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户权限类型";
            // 
            // dgvYonHuLeiXing
            // 
            this.dgvYonHuLeiXing.AllowUserToAddRows = false;
            this.dgvYonHuLeiXing.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvYonHuLeiXing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvYonHuLeiXing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvYonHuLeiXing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYonHuLeiXing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.用户类型ID,
            this.用户类型,
            this.备注});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvYonHuLeiXing.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvYonHuLeiXing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvYonHuLeiXing.Location = new System.Drawing.Point(3, 21);
            this.dgvYonHuLeiXing.Name = "dgvYonHuLeiXing";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvYonHuLeiXing.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvYonHuLeiXing.RowTemplate.Height = 27;
            this.dgvYonHuLeiXing.Size = new System.Drawing.Size(374, 357);
            this.dgvYonHuLeiXing.TabIndex = 9;
            // 
            // 用户类型ID
            // 
            this.用户类型ID.DataPropertyName = "UserTypeID";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.用户类型ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.用户类型ID.HeaderText = "用户类型ID";
            this.用户类型ID.Name = "用户类型ID";
            this.用户类型ID.Visible = false;
            // 
            // 用户类型
            // 
            this.用户类型.DataPropertyName = "UserTypeMC";
            this.用户类型.HeaderText = "用户类型";
            this.用户类型.Name = "用户类型";
            // 
            // 备注
            // 
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(0, 427);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "车站选择";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.treeView1.CheckBoxes = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.Location = new System.Drawing.Point(3, 21);
            this.treeView1.Name = "treeView1";
            this.treeView1.PathSeparator = "`";
            this.treeView1.Size = new System.Drawing.Size(374, 200);
            this.treeView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.treeView);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(386, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 648);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "选择权限";
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.CheckBoxes = true;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView.Location = new System.Drawing.Point(3, 21);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(400, 624);
            this.treeView.TabIndex = 4;
            // 
            // btnQuXiao
            // 
            this.btnQuXiao.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnQuXiao.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuXiao.Location = new System.Drawing.Point(190, 387);
            this.btnQuXiao.Name = "btnQuXiao";
            this.btnQuXiao.Size = new System.Drawing.Size(92, 34);
            this.btnQuXiao.TabIndex = 12;
            this.btnQuXiao.Text = "取消";
            this.btnQuXiao.UseVisualStyleBackColor = false;
            // 
            // btnTuiChu
            // 
            this.btnTuiChu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTuiChu.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTuiChu.Location = new System.Drawing.Point(284, 387);
            this.btnTuiChu.Name = "btnTuiChu";
            this.btnTuiChu.Size = new System.Drawing.Size(92, 34);
            this.btnTuiChu.TabIndex = 11;
            this.btnTuiChu.Text = "退出";
            this.btnTuiChu.UseVisualStyleBackColor = false;
            // 
            // btnBaoCun
            // 
            this.btnBaoCun.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBaoCun.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBaoCun.Location = new System.Drawing.Point(96, 387);
            this.btnBaoCun.Name = "btnBaoCun";
            this.btnBaoCun.Size = new System.Drawing.Size(92, 34);
            this.btnBaoCun.TabIndex = 10;
            this.btnBaoCun.Text = "保存";
            this.btnBaoCun.UseVisualStyleBackColor = false;
            // 
            // btnXiuGai
            // 
            this.btnXiuGai.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXiuGai.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnXiuGai.Location = new System.Drawing.Point(2, 387);
            this.btnXiuGai.Name = "btnXiuGai";
            this.btnXiuGai.Size = new System.Drawing.Size(92, 34);
            this.btnXiuGai.TabIndex = 9;
            this.btnXiuGai.Text = "修改";
            this.btnXiuGai.UseVisualStyleBackColor = false;
            // 
            // FRM_YonHuQuanXianGuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(791, 653);
            this.Controls.Add(this.btnQuXiao);
            this.Controls.Add(this.btnTuiChu);
            this.Controls.Add(this.btnBaoCun);
            this.Controls.Add(this.btnXiuGai);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRM_YonHuQuanXianGuanLi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户权限管理";
            this.Load += new System.EventHandler(this.FRM_YonHuQuanXianGuanLi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYonHuLeiXing)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvYonHuLeiXing;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户类型ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button btnQuXiao;
        private System.Windows.Forms.Button btnTuiChu;
        private System.Windows.Forms.Button btnBaoCun;
        private System.Windows.Forms.Button btnXiuGai;
    }
}