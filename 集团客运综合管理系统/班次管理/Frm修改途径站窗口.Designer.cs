namespace 集团客运综合管理系统.班次管理
{
    partial class Frm修改途径站窗口
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
            this.btnnewStopsinroute = new System.Windows.Forms.Button();
            this.SelectUpdatetujinStation = new System.Windows.Forms.DataGridView();
            this.StopsinrouteMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Standingorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationNunber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Whetherdock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StopsinrouteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometer1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SelectUpdatetujinStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnnewStopsinroute
            // 
            this.btnnewStopsinroute.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnnewStopsinroute.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnnewStopsinroute.Location = new System.Drawing.Point(153, 285);
            this.btnnewStopsinroute.Name = "btnnewStopsinroute";
            this.btnnewStopsinroute.Size = new System.Drawing.Size(82, 30);
            this.btnnewStopsinroute.TabIndex = 3;
            this.btnnewStopsinroute.Text = "确定(&A)";
            this.btnnewStopsinroute.UseVisualStyleBackColor = false;
            this.btnnewStopsinroute.Click += new System.EventHandler(this.btnnewStopsinroute_Click);
            // 
            // SelectUpdatetujinStation
            // 
            this.SelectUpdatetujinStation.AllowUserToAddRows = false;
            this.SelectUpdatetujinStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectUpdatetujinStation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StopsinrouteMC,
            this.Standingorder,
            this.StationNunber,
            this.kilometer,
            this.Whetherdock,
            this.StopsinrouteID});
            this.SelectUpdatetujinStation.Location = new System.Drawing.Point(3, 39);
            this.SelectUpdatetujinStation.Name = "SelectUpdatetujinStation";
            this.SelectUpdatetujinStation.RowTemplate.Height = 23;
            this.SelectUpdatetujinStation.Size = new System.Drawing.Size(406, 240);
            this.SelectUpdatetujinStation.TabIndex = 4;
            this.SelectUpdatetujinStation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectUpdatetujinStation_CellClick);
            // 
            // StopsinrouteMC
            // 
            this.StopsinrouteMC.DataPropertyName = "StopsinrouteMC";
            this.StopsinrouteMC.HeaderText = "StopsinrouteMC";
            this.StopsinrouteMC.Name = "StopsinrouteMC";
            // 
            // Standingorder
            // 
            this.Standingorder.DataPropertyName = "Standingorder";
            this.Standingorder.HeaderText = "Standingorder";
            this.Standingorder.Name = "Standingorder";
            this.Standingorder.Width = 60;
            // 
            // StationNunber
            // 
            this.StationNunber.DataPropertyName = "StationNunber";
            this.StationNunber.HeaderText = "StationNunber";
            this.StationNunber.Name = "StationNunber";
            this.StationNunber.Width = 60;
            // 
            // kilometer
            // 
            this.kilometer.DataPropertyName = "kilometer";
            this.kilometer.HeaderText = "kilometer";
            this.kilometer.Name = "kilometer";
            this.kilometer.Width = 70;
            // 
            // Whetherdock
            // 
            this.Whetherdock.DataPropertyName = "Whetherdock";
            this.Whetherdock.HeaderText = "Whetherdock";
            this.Whetherdock.Name = "Whetherdock";
            this.Whetherdock.Width = 80;
            // 
            // StopsinrouteID
            // 
            this.StopsinrouteID.DataPropertyName = "StopsinrouteID";
            this.StopsinrouteID.HeaderText = "StopsinrouteID";
            this.StopsinrouteID.Name = "StopsinrouteID";
            this.StopsinrouteID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "温馨提示：请修改好正确的站序号、和站点之间的距离";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.kilometer1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.Location = new System.Drawing.Point(3, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(406, 240);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StopsinrouteMC";
            this.dataGridViewTextBoxColumn1.HeaderText = "途径站点";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Standingorder";
            this.dataGridViewTextBoxColumn2.HeaderText = "站序";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StationNunber";
            this.dataGridViewTextBoxColumn3.HeaderText = "站点编码";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // kilometer1
            // 
            this.kilometer1.DataPropertyName = "kilometer";
            this.kilometer1.HeaderText = "公里";
            this.kilometer1.Name = "kilometer1";
            this.kilometer1.Width = 70;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Whetherdock";
            this.dataGridViewTextBoxColumn5.HeaderText = "是否";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "StopsinrouteID";
            this.dataGridViewTextBoxColumn6.HeaderText = "StopsinrouteID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // Frm修改途径站窗口
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(411, 321);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectUpdatetujinStation);
            this.Controls.Add(this.btnnewStopsinroute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm修改途径站窗口";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改途径站窗口";
            this.Load += new System.EventHandler(this.Frm修改途径站窗口_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectUpdatetujinStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnnewStopsinroute;
        private System.Windows.Forms.DataGridView SelectUpdatetujinStation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StopsinrouteMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Standingorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationNunber;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Whetherdock;
        private System.Windows.Forms.DataGridViewTextBoxColumn StopsinrouteID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}