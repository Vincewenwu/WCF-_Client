namespace 集团客运综合管理系统.班次管理
{
    partial class Frm添加途径站点
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
            this.dgvtujinStation = new System.Windows.Forms.DataGridView();
            this.选择 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.StationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationMC1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationNunber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnnewStopsinroute = new System.Windows.Forms.Button();
            this.btnnewstation = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtujinStation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvtujinStation
            // 
            this.dgvtujinStation.AllowUserToAddRows = false;
            this.dgvtujinStation.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvtujinStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtujinStation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.选择,
            this.StationID,
            this.StationMC,
            this.StationMC1,
            this.StationNunber});
            this.dgvtujinStation.Location = new System.Drawing.Point(1, 45);
            this.dgvtujinStation.Name = "dgvtujinStation";
            this.dgvtujinStation.RowTemplate.Height = 23;
            this.dgvtujinStation.Size = new System.Drawing.Size(373, 259);
            this.dgvtujinStation.TabIndex = 0;
            // 
            // 选择
            // 
            this.选择.DataPropertyName = "选择";
            this.选择.HeaderText = "选择";
            this.选择.Name = "选择";
            this.选择.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.选择.Width = 30;
            // 
            // StationID
            // 
            this.StationID.DataPropertyName = "StationID";
            this.StationID.HeaderText = "StationID";
            this.StationID.Name = "StationID";
            this.StationID.Visible = false;
            // 
            // StationMC
            // 
            this.StationMC.DataPropertyName = "StationMC";
            this.StationMC.HeaderText = "站点名称";
            this.StationMC.Name = "StationMC";
            // 
            // StationMC1
            // 
            this.StationMC1.DataPropertyName = "StationMC1";
            this.StationMC1.HeaderText = "简称加缩写";
            this.StationMC1.Name = "StationMC1";
            // 
            // StationNunber
            // 
            this.StationNunber.DataPropertyName = "StationNunber";
            this.StationNunber.HeaderText = "站点编码";
            this.StationNunber.Name = "StationNunber";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(82, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "温馨提示： 请准确新增站点";
            // 
            // btnnewStopsinroute
            // 
            this.btnnewStopsinroute.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnnewStopsinroute.Location = new System.Drawing.Point(225, 308);
            this.btnnewStopsinroute.Name = "btnnewStopsinroute";
            this.btnnewStopsinroute.Size = new System.Drawing.Size(100, 30);
            this.btnnewStopsinroute.TabIndex = 2;
            this.btnnewStopsinroute.Text = "确 定(&C)";
            this.btnnewStopsinroute.UseVisualStyleBackColor = true;
            this.btnnewStopsinroute.Click += new System.EventHandler(this.btnnewStopsinroute_Click);
            // 
            // btnnewstation
            // 
            this.btnnewstation.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnnewstation.Location = new System.Drawing.Point(41, 308);
            this.btnnewstation.Name = "btnnewstation";
            this.btnnewstation.Size = new System.Drawing.Size(100, 30);
            this.btnnewstation.TabIndex = 3;
            this.btnnewstation.Text = "新增站点(&B)";
            this.btnnewstation.UseVisualStyleBackColor = true;
            this.btnnewstation.Click += new System.EventHandler(this.btnnewstation_Click);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.BackColor = System.Drawing.Color.Snow;
            this.textBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(40, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 23);
            this.textBox1.TabIndex = 4;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelect.Location = new System.Drawing.Point(249, 14);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 27);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "查找(&A)";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Location = new System.Drawing.Point(1, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 48);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // Frm添加途径站点
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(375, 365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnnewstation);
            this.Controls.Add(this.btnnewStopsinroute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvtujinStation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm添加途径站点";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm添加途径站点";
            this.Load += new System.EventHandler(this.Frm添加途径站点_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtujinStation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtujinStation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnewStopsinroute;
        private System.Windows.Forms.Button btnnewstation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 选择;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationMC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationNunber;
    }
}