namespace 集团客运综合管理系统.班次管理
{
    partial class Frm新增站点
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
            this.btnnew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstationname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPingYinJianXie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStationNunber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnnew.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnnew.ForeColor = System.Drawing.Color.Black;
            this.btnnew.Location = new System.Drawing.Point(119, 102);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(94, 36);
            this.btnnew.TabIndex = 0;
            this.btnnew.Text = "确定(&A)";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "站点名称:";
            // 
            // txtstationname
            // 
            this.txtstationname.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtstationname.Location = new System.Drawing.Point(119, 12);
            this.txtstationname.Name = "txtstationname";
            this.txtstationname.Size = new System.Drawing.Size(171, 23);
            this.txtstationname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "站点拼音简写:";
            // 
            // txtPingYinJianXie
            // 
            this.txtPingYinJianXie.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPingYinJianXie.Location = new System.Drawing.Point(119, 70);
            this.txtPingYinJianXie.Name = "txtPingYinJianXie";
            this.txtPingYinJianXie.Size = new System.Drawing.Size(171, 23);
            this.txtPingYinJianXie.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(43, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "站点编码:";
            // 
            // txtStationNunber
            // 
            this.txtStationNunber.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStationNunber.Location = new System.Drawing.Point(119, 41);
            this.txtStationNunber.Name = "txtStationNunber";
            this.txtStationNunber.Size = new System.Drawing.Size(171, 23);
            this.txtStationNunber.TabIndex = 8;
            this.txtStationNunber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Frm新增站点
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(316, 148);
            this.Controls.Add(this.txtStationNunber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPingYinJianXie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtstationname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnnew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm新增站点";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增站点";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstationname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPingYinJianXie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStationNunber;
    }
}