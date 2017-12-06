namespace 集团客运综合管理系统
{
    partial class faceDetect
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.获取样本图片 = new System.Windows.Forms.Button();
            this.fullname = new System.Windows.Forms.TextBox();
            this.sampleBox = new System.Windows.Forms.PictureBox();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.recognizerType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sampleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "姓名：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(568, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 24);
            this.button4.TabIndex = 17;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(440, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 24);
            this.button3.TabIndex = 18;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // 获取样本图片
            // 
            this.获取样本图片.Location = new System.Drawing.Point(471, 192);
            this.获取样本图片.Name = "获取样本图片";
            this.获取样本图片.Size = new System.Drawing.Size(91, 24);
            this.获取样本图片.TabIndex = 16;
            this.获取样本图片.Text = "保存样本图片";
            this.获取样本图片.UseVisualStyleBackColor = true;
            this.获取样本图片.Click += new System.EventHandler(this.获取样本图片_Click);
            // 
            // fullname
            // 
            this.fullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullname.Location = new System.Drawing.Point(487, 165);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(104, 21);
            this.fullname.TabIndex = 15;
            this.fullname.TextChanged += new System.EventHandler(this.fullname_TextChanged);
            // 
            // sampleBox
            // 
            this.sampleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sampleBox.Location = new System.Drawing.Point(441, 15);
            this.sampleBox.Name = "sampleBox";
            this.sampleBox.Size = new System.Drawing.Size(150, 144);
            this.sampleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sampleBox.TabIndex = 14;
            this.sampleBox.TabStop = false;
            this.sampleBox.Click += new System.EventHandler(this.sampleBox_Click);
            // 
            // picShow
            // 
            this.picShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picShow.Location = new System.Drawing.Point(16, 14);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(415, 329);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShow.TabIndex = 13;
            this.picShow.TabStop = false;
            this.picShow.Click += new System.EventHandler(this.picShow_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // recognizerType
            // 
            this.recognizerType.FormattingEnabled = true;
            this.recognizerType.Items.AddRange(new object[] {
            "EigenFaceRecognizer",
            "FisherFaceRecognizer",
            "LBPHFaceRecognizer"});
            this.recognizerType.Location = new System.Drawing.Point(441, 225);
            this.recognizerType.Name = "recognizerType";
            this.recognizerType.Size = new System.Drawing.Size(149, 20);
            this.recognizerType.TabIndex = 24;
            this.recognizerType.Text = "EigenFaceRecognizer";
            this.recognizerType.SelectedIndexChanged += new System.EventHandler(this.recognizerType_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "设置识别类";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "版  本：V 1.0（2016-6-7）";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "E-MAIL：leiyue_yao@163.com";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "作  者：姚磊岳";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // faceDetect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 356);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.获取样本图片);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.sampleBox);
            this.Controls.Add(this.picShow);
            this.Controls.Add(this.recognizerType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "faceDetect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "faceDetect";
            ((System.ComponentModel.ISupportInitialize)(this.sampleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button 获取样本图片;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.PictureBox sampleBox;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox recognizerType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
    }
}