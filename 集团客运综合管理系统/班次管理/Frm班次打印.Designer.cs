namespace 集团客运综合管理系统.班次管理
{
    partial class Frm班次打印
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
            this.tSPDaoChu = new System.Windows.Forms.Button();
            this.dgvSiJi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiJi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSiJi);
            this.groupBox1.Location = new System.Drawing.Point(0, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 292);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // tSPDaoChu
            // 
            this.tSPDaoChu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tSPDaoChu.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tSPDaoChu.Location = new System.Drawing.Point(597, 299);
            this.tSPDaoChu.Name = "tSPDaoChu";
            this.tSPDaoChu.Size = new System.Drawing.Size(79, 26);
            this.tSPDaoChu.TabIndex = 3;
            this.tSPDaoChu.Text = "导出";
            this.tSPDaoChu.UseVisualStyleBackColor = false;
            this.tSPDaoChu.Click += new System.EventHandler(this.tSPDaoChu_Click);
            // 
            // dgvSiJi
            // 
            this.dgvSiJi.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvSiJi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSiJi.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSiJi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSiJi.Location = new System.Drawing.Point(3, 17);
            this.dgvSiJi.Name = "dgvSiJi";
            this.dgvSiJi.RowTemplate.Height = 23;
            this.dgvSiJi.Size = new System.Drawing.Size(673, 272);
            this.dgvSiJi.TabIndex = 0;
            // 
            // Frm班次打印
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(678, 324);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tSPDaoChu);
            this.Name = "Frm班次打印";
            this.Text = "Frm班次打印";
            this.Load += new System.EventHandler(this.Frm班次打印_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiJi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tSPDaoChu;
        private System.Windows.Forms.DataGridView dgvSiJi;
    }
}