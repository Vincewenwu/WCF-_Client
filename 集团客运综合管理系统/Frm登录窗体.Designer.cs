namespace 集团客运综合管理系统
{
    partial class Frm登录窗体
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm登录窗体));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtYanZhengMa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MiMa = new System.Windows.Forms.TextBox();
            this.cbo_YongHuMing = new System.Windows.Forms.ComboBox();
            this.btn_QvXiao = new System.Windows.Forms.Button();
            this.btn_DengLu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(637, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // txtYanZhengMa
            // 
            this.txtYanZhengMa.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYanZhengMa.Location = new System.Drawing.Point(190, 242);
            this.txtYanZhengMa.Name = "txtYanZhengMa";
            this.txtYanZhengMa.Size = new System.Drawing.Size(193, 26);
            this.txtYanZhengMa.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(125, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "验证码:";
            // 
            // txt_MiMa
            // 
            this.txt_MiMa.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_MiMa.Location = new System.Drawing.Point(191, 203);
            this.txt_MiMa.Name = "txt_MiMa";
            this.txt_MiMa.PasswordChar = '*';
            this.txt_MiMa.Size = new System.Drawing.Size(271, 26);
            this.txt_MiMa.TabIndex = 26;
            // 
            // cbo_YongHuMing
            // 
            this.cbo_YongHuMing.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_YongHuMing.FormattingEnabled = true;
            this.cbo_YongHuMing.Location = new System.Drawing.Point(190, 158);
            this.cbo_YongHuMing.Name = "cbo_YongHuMing";
            this.cbo_YongHuMing.Size = new System.Drawing.Size(271, 24);
            this.cbo_YongHuMing.TabIndex = 25;
            // 
            // btn_QvXiao
            // 
            this.btn_QvXiao.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_QvXiao.Location = new System.Drawing.Point(345, 273);
            this.btn_QvXiao.Name = "btn_QvXiao";
            this.btn_QvXiao.Size = new System.Drawing.Size(116, 37);
            this.btn_QvXiao.TabIndex = 24;
            this.btn_QvXiao.Text = "取消(&C)";
            this.btn_QvXiao.UseVisualStyleBackColor = true;
            // 
            // btn_DengLu
            // 
            this.btn_DengLu.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_DengLu.Location = new System.Drawing.Point(190, 273);
            this.btn_DengLu.Name = "btn_DengLu";
            this.btn_DengLu.Size = new System.Drawing.Size(117, 39);
            this.btn_DengLu.TabIndex = 23;
            this.btn_DengLu.Text = "登录(&O)";
            this.btn_DengLu.UseVisualStyleBackColor = true;
            this.btn_DengLu.Click += new System.EventHandler(this.btn_DengLu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(125, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "密   码:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(125, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "用户名:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(389, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 26);
            this.panel1.TabIndex = 29;
            // 
            // Frm登录窗体
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 319);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtYanZhengMa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_MiMa);
            this.Controls.Add(this.cbo_YongHuMing);
            this.Controls.Add(this.btn_QvXiao);
            this.Controls.Add(this.btn_DengLu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm登录窗体";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm登录窗体";
            this.Load += new System.EventHandler(this.Frm登录窗体_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtYanZhengMa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MiMa;
        private System.Windows.Forms.ComboBox cbo_YongHuMing;
        private System.Windows.Forms.Button btn_QvXiao;
        private System.Windows.Forms.Button btn_DengLu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}