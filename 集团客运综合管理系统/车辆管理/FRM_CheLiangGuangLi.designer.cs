namespace 集团客运综合管理系统.车辆管理
{
    partial class FRM_CheLiangGuangLi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CheLiangGuangLi));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlsXingZenCheLiang = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsXiuGaiCheLiang = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbShanChuCheLiang = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvCheLiangXinXi = new System.Windows.Forms.DataGridView();
            this.车辆ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.证件信息ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.保险ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车主ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车辆编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车牌号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.登记日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.座位数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.载重 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCheShuDanWei = new System.Windows.Forms.TextBox();
            this.radYiTianAnJianYiCi = new System.Windows.Forms.RadioButton();
            this.txtCheLiangXinHao = new System.Windows.Forms.TextBox();
            this.txtDenJiRiQi = new System.Windows.Forms.TextBox();
            this.radMeiCiBaoBanAnJian = new System.Windows.Forms.RadioButton();
            this.txtZuoWeiShu = new System.Windows.Forms.TextBox();
            this.radBuAnJian = new System.Windows.Forms.RadioButton();
            this.txtChePaiHao = new System.Windows.Forms.TextBox();
            this.txtZaiZhong = new System.Windows.Forms.TextBox();
            this.txtBeiZhu = new System.Windows.Forms.TextBox();
            this.txtDiZi = new System.Windows.Forms.TextBox();
            this.txtFuJiaShiYi = new System.Windows.Forms.TextBox();
            this.txtLianXiDianHua = new System.Windows.Forms.TextBox();
            this.txtFuJiaShiYiBianHao = new System.Windows.Forms.TextBox();
            this.txtShenFenZheng = new System.Windows.Forms.TextBox();
            this.txtZhengJiaShiBianHao = new System.Windows.Forms.TextBox();
            this.txtXinMing = new System.Windows.Forms.TextBox();
            this.txtZhengJiaShi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCheLiangBianHao1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtChePaiHao1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheLiangXinXi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsXingZenCheLiang,
            this.toolStripSeparator1,
            this.tlsXiuGaiCheLiang,
            this.toolStripSeparator3,
            this.tsbShanChuCheLiang,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(962, 27);
            this.toolStrip1.TabIndex = 66;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlsXingZenCheLiang
            // 
            this.tlsXingZenCheLiang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tlsXingZenCheLiang.Image = ((System.Drawing.Image)(resources.GetObject("tlsXingZenCheLiang.Image")));
            this.tlsXingZenCheLiang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsXingZenCheLiang.Name = "tlsXingZenCheLiang";
            this.tlsXingZenCheLiang.Size = new System.Drawing.Size(56, 24);
            this.tlsXingZenCheLiang.Text = "新增";
            this.tlsXingZenCheLiang.Click += new System.EventHandler(this.tlsXingZenCheLiang_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tlsXiuGaiCheLiang
            // 
            this.tlsXiuGaiCheLiang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tlsXiuGaiCheLiang.Image = ((System.Drawing.Image)(resources.GetObject("tlsXiuGaiCheLiang.Image")));
            this.tlsXiuGaiCheLiang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsXiuGaiCheLiang.Name = "tlsXiuGaiCheLiang";
            this.tlsXiuGaiCheLiang.Size = new System.Drawing.Size(56, 24);
            this.tlsXiuGaiCheLiang.Text = "修改";
            this.tlsXiuGaiCheLiang.Click += new System.EventHandler(this.tlsXiuGaiCheLiang_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbShanChuCheLiang
            // 
            this.tsbShanChuCheLiang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsbShanChuCheLiang.Image = ((System.Drawing.Image)(resources.GetObject("tsbShanChuCheLiang.Image")));
            this.tsbShanChuCheLiang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShanChuCheLiang.Name = "tsbShanChuCheLiang";
            this.tsbShanChuCheLiang.Size = new System.Drawing.Size(56, 24);
            this.tsbShanChuCheLiang.Text = "删除";
            this.tsbShanChuCheLiang.Click += new System.EventHandler(this.tsbShanChuCheLiang_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // dgvCheLiangXinXi
            // 
            this.dgvCheLiangXinXi.AllowUserToAddRows = false;
            this.dgvCheLiangXinXi.AllowUserToDeleteRows = false;
            this.dgvCheLiangXinXi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCheLiangXinXi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCheLiangXinXi.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCheLiangXinXi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheLiangXinXi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.车辆ID,
            this.证件信息ID,
            this.保险ID,
            this.车主ID,
            this.车辆编号,
            this.车牌号,
            this.登记日期,
            this.座位数,
            this.载重,
            this.备注});
            this.dgvCheLiangXinXi.Location = new System.Drawing.Point(1, 24);
            this.dgvCheLiangXinXi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCheLiangXinXi.Name = "dgvCheLiangXinXi";
            this.dgvCheLiangXinXi.ReadOnly = true;
            this.dgvCheLiangXinXi.RowTemplate.Height = 27;
            this.dgvCheLiangXinXi.Size = new System.Drawing.Size(500, 409);
            this.dgvCheLiangXinXi.TabIndex = 67;
            this.dgvCheLiangXinXi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheLiangXinXi_CellClick);
            this.dgvCheLiangXinXi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheLiangXinXi_CellContentClick);
            // 
            // 车辆ID
            // 
            this.车辆ID.DataPropertyName = "VehicleID";
            this.车辆ID.HeaderText = "车辆ID";
            this.车辆ID.Name = "车辆ID";
            this.车辆ID.ReadOnly = true;
            this.车辆ID.Visible = false;
            this.车辆ID.Width = 82;
            // 
            // 证件信息ID
            // 
            this.证件信息ID.DataPropertyName = "VehicleLicenseID";
            this.证件信息ID.HeaderText = "证件信息ID";
            this.证件信息ID.Name = "证件信息ID";
            this.证件信息ID.ReadOnly = true;
            this.证件信息ID.Visible = false;
            this.证件信息ID.Width = 112;
            // 
            // 保险ID
            // 
            this.保险ID.DataPropertyName = "PolicyOfInsuranceID";
            this.保险ID.HeaderText = "保险ID";
            this.保险ID.Name = "保险ID";
            this.保险ID.ReadOnly = true;
            this.保险ID.Visible = false;
            this.保险ID.Width = 82;
            // 
            // 车主ID
            // 
            this.车主ID.DataPropertyName = "VehicleHostID";
            this.车主ID.HeaderText = "车主ID";
            this.车主ID.Name = "车主ID";
            this.车主ID.ReadOnly = true;
            this.车主ID.Visible = false;
            this.车主ID.Width = 82;
            // 
            // 车辆编号
            // 
            this.车辆编号.DataPropertyName = "VehicleNumber";
            this.车辆编号.HeaderText = "车辆编号";
            this.车辆编号.Name = "车辆编号";
            this.车辆编号.ReadOnly = true;
            this.车辆编号.Width = 78;
            // 
            // 车牌号
            // 
            this.车牌号.DataPropertyName = "VehiclePaiNumber";
            this.车牌号.HeaderText = "车牌号";
            this.车牌号.Name = "车牌号";
            this.车牌号.ReadOnly = true;
            this.车牌号.Width = 66;
            // 
            // 登记日期
            // 
            this.登记日期.DataPropertyName = "RegisterDate";
            this.登记日期.HeaderText = "登记日期";
            this.登记日期.Name = "登记日期";
            this.登记日期.ReadOnly = true;
            this.登记日期.Width = 78;
            // 
            // 座位数
            // 
            this.座位数.DataPropertyName = "Seating";
            this.座位数.HeaderText = "座位数";
            this.座位数.Name = "座位数";
            this.座位数.ReadOnly = true;
            this.座位数.Width = 66;
            // 
            // 载重
            // 
            this.载重.DataPropertyName = "Loadheaver";
            this.载重.HeaderText = "载重";
            this.载重.Name = "载重";
            this.载重.ReadOnly = true;
            this.载重.Width = 54;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "Comment";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            this.备注.Width = 54;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCheShuDanWei);
            this.groupBox1.Controls.Add(this.radYiTianAnJianYiCi);
            this.groupBox1.Controls.Add(this.txtCheLiangXinHao);
            this.groupBox1.Controls.Add(this.txtDenJiRiQi);
            this.groupBox1.Controls.Add(this.radMeiCiBaoBanAnJian);
            this.groupBox1.Controls.Add(this.txtZuoWeiShu);
            this.groupBox1.Controls.Add(this.radBuAnJian);
            this.groupBox1.Controls.Add(this.txtChePaiHao);
            this.groupBox1.Controls.Add(this.txtZaiZhong);
            this.groupBox1.Controls.Add(this.txtBeiZhu);
            this.groupBox1.Controls.Add(this.txtDiZi);
            this.groupBox1.Controls.Add(this.txtFuJiaShiYi);
            this.groupBox1.Controls.Add(this.txtLianXiDianHua);
            this.groupBox1.Controls.Add(this.txtFuJiaShiYiBianHao);
            this.groupBox1.Controls.Add(this.txtShenFenZheng);
            this.groupBox1.Controls.Add(this.txtZhengJiaShiBianHao);
            this.groupBox1.Controls.Add(this.txtXinMing);
            this.groupBox1.Controls.Add(this.txtZhengJiaShi);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(505, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(456, 345);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            // 
            // txtCheShuDanWei
            // 
            this.txtCheShuDanWei.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCheShuDanWei.Location = new System.Drawing.Point(78, 103);
            this.txtCheShuDanWei.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCheShuDanWei.Name = "txtCheShuDanWei";
            this.txtCheShuDanWei.Size = new System.Drawing.Size(147, 24);
            this.txtCheShuDanWei.TabIndex = 132;
            // 
            // radYiTianAnJianYiCi
            // 
            this.radYiTianAnJianYiCi.AutoSize = true;
            this.radYiTianAnJianYiCi.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radYiTianAnJianYiCi.Location = new System.Drawing.Point(246, 214);
            this.radYiTianAnJianYiCi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radYiTianAnJianYiCi.Name = "radYiTianAnJianYiCi";
            this.radYiTianAnJianYiCi.Size = new System.Drawing.Size(115, 19);
            this.radYiTianAnJianYiCi.TabIndex = 130;
            this.radYiTianAnJianYiCi.TabStop = true;
            this.radYiTianAnJianYiCi.Text = "一天安检一次";
            this.radYiTianAnJianYiCi.UseVisualStyleBackColor = true;
            // 
            // txtCheLiangXinHao
            // 
            this.txtCheLiangXinHao.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCheLiangXinHao.Location = new System.Drawing.Point(78, 76);
            this.txtCheLiangXinHao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCheLiangXinHao.Name = "txtCheLiangXinHao";
            this.txtCheLiangXinHao.Size = new System.Drawing.Size(147, 24);
            this.txtCheLiangXinHao.TabIndex = 118;
            // 
            // txtDenJiRiQi
            // 
            this.txtDenJiRiQi.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDenJiRiQi.Location = new System.Drawing.Point(78, 49);
            this.txtDenJiRiQi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDenJiRiQi.Name = "txtDenJiRiQi";
            this.txtDenJiRiQi.Size = new System.Drawing.Size(147, 24);
            this.txtDenJiRiQi.TabIndex = 109;
            // 
            // radMeiCiBaoBanAnJian
            // 
            this.radMeiCiBaoBanAnJian.AutoSize = true;
            this.radMeiCiBaoBanAnJian.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radMeiCiBaoBanAnJian.Location = new System.Drawing.Point(108, 214);
            this.radMeiCiBaoBanAnJian.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radMeiCiBaoBanAnJian.Name = "radMeiCiBaoBanAnJian";
            this.radMeiCiBaoBanAnJian.Size = new System.Drawing.Size(115, 19);
            this.radMeiCiBaoBanAnJian.TabIndex = 129;
            this.radMeiCiBaoBanAnJian.TabStop = true;
            this.radMeiCiBaoBanAnJian.Text = "每次报班安检";
            this.radMeiCiBaoBanAnJian.UseVisualStyleBackColor = true;
            // 
            // txtZuoWeiShu
            // 
            this.txtZuoWeiShu.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZuoWeiShu.Location = new System.Drawing.Point(78, 130);
            this.txtZuoWeiShu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtZuoWeiShu.Name = "txtZuoWeiShu";
            this.txtZuoWeiShu.Size = new System.Drawing.Size(147, 24);
            this.txtZuoWeiShu.TabIndex = 106;
            // 
            // radBuAnJian
            // 
            this.radBuAnJian.AutoSize = true;
            this.radBuAnJian.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radBuAnJian.Location = new System.Drawing.Point(10, 214);
            this.radBuAnJian.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radBuAnJian.Name = "radBuAnJian";
            this.radBuAnJian.Size = new System.Drawing.Size(70, 19);
            this.radBuAnJian.TabIndex = 128;
            this.radBuAnJian.TabStop = true;
            this.radBuAnJian.Text = "不安检";
            this.radBuAnJian.UseVisualStyleBackColor = true;
            // 
            // txtChePaiHao
            // 
            this.txtChePaiHao.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtChePaiHao.Location = new System.Drawing.Point(78, 22);
            this.txtChePaiHao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChePaiHao.Name = "txtChePaiHao";
            this.txtChePaiHao.Size = new System.Drawing.Size(147, 24);
            this.txtChePaiHao.TabIndex = 105;
            // 
            // txtZaiZhong
            // 
            this.txtZaiZhong.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZaiZhong.Location = new System.Drawing.Point(78, 158);
            this.txtZaiZhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtZaiZhong.Name = "txtZaiZhong";
            this.txtZaiZhong.Size = new System.Drawing.Size(147, 24);
            this.txtZaiZhong.TabIndex = 107;
            // 
            // txtBeiZhu
            // 
            this.txtBeiZhu.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBeiZhu.Location = new System.Drawing.Point(78, 185);
            this.txtBeiZhu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBeiZhu.Name = "txtBeiZhu";
            this.txtBeiZhu.Size = new System.Drawing.Size(374, 24);
            this.txtBeiZhu.TabIndex = 127;
            // 
            // txtDiZi
            // 
            this.txtDiZi.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDiZi.Location = new System.Drawing.Point(304, 103);
            this.txtDiZi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiZi.Name = "txtDiZi";
            this.txtDiZi.Size = new System.Drawing.Size(147, 24);
            this.txtDiZi.TabIndex = 117;
            // 
            // txtFuJiaShiYi
            // 
            this.txtFuJiaShiYi.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFuJiaShiYi.Location = new System.Drawing.Point(352, 158);
            this.txtFuJiaShiYi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFuJiaShiYi.Name = "txtFuJiaShiYi";
            this.txtFuJiaShiYi.Size = new System.Drawing.Size(100, 24);
            this.txtFuJiaShiYi.TabIndex = 125;
            // 
            // txtLianXiDianHua
            // 
            this.txtLianXiDianHua.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLianXiDianHua.Location = new System.Drawing.Point(304, 76);
            this.txtLianXiDianHua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLianXiDianHua.Name = "txtLianXiDianHua";
            this.txtLianXiDianHua.Size = new System.Drawing.Size(147, 24);
            this.txtLianXiDianHua.TabIndex = 116;
            // 
            // txtFuJiaShiYiBianHao
            // 
            this.txtFuJiaShiYiBianHao.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFuJiaShiYiBianHao.Location = new System.Drawing.Point(304, 158);
            this.txtFuJiaShiYiBianHao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFuJiaShiYiBianHao.Name = "txtFuJiaShiYiBianHao";
            this.txtFuJiaShiYiBianHao.Size = new System.Drawing.Size(44, 24);
            this.txtFuJiaShiYiBianHao.TabIndex = 124;
            // 
            // txtShenFenZheng
            // 
            this.txtShenFenZheng.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtShenFenZheng.Location = new System.Drawing.Point(304, 49);
            this.txtShenFenZheng.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtShenFenZheng.Name = "txtShenFenZheng";
            this.txtShenFenZheng.Size = new System.Drawing.Size(147, 24);
            this.txtShenFenZheng.TabIndex = 115;
            // 
            // txtZhengJiaShiBianHao
            // 
            this.txtZhengJiaShiBianHao.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZhengJiaShiBianHao.Location = new System.Drawing.Point(304, 131);
            this.txtZhengJiaShiBianHao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtZhengJiaShiBianHao.Name = "txtZhengJiaShiBianHao";
            this.txtZhengJiaShiBianHao.Size = new System.Drawing.Size(44, 24);
            this.txtZhengJiaShiBianHao.TabIndex = 121;
            // 
            // txtXinMing
            // 
            this.txtXinMing.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXinMing.Location = new System.Drawing.Point(304, 22);
            this.txtXinMing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtXinMing.Name = "txtXinMing";
            this.txtXinMing.Size = new System.Drawing.Size(147, 24);
            this.txtXinMing.TabIndex = 114;
            // 
            // txtZhengJiaShi
            // 
            this.txtZhengJiaShi.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZhengJiaShi.Location = new System.Drawing.Point(352, 130);
            this.txtZhengJiaShi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtZhengJiaShi.Name = "txtZhengJiaShi";
            this.txtZhengJiaShi.Size = new System.Drawing.Size(100, 24);
            this.txtZhengJiaShi.TabIndex = 122;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(230, 25);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 15);
            this.label12.TabIndex = 110;
            this.label12.Text = "姓    名:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(230, 106);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 15);
            this.label13.TabIndex = 111;
            this.label13.Text = "地    址:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(230, 134);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 15);
            this.label16.TabIndex = 120;
            this.label16.Text = "正 驾 驶:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(231, 79);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 15);
            this.label14.TabIndex = 112;
            this.label14.Text = "联系电话:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(230, 162);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 15);
            this.label17.TabIndex = 123;
            this.label17.Text = "副驾驶一:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(230, 52);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 15);
            this.label15.TabIndex = 113;
            this.label15.Text = "身 份 证:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 131;
            this.label1.Text = "车属单位:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(5, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 108;
            this.label4.Text = "车辆型号:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(4, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 101;
            this.label5.Text = "座 位 数:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 161);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 102;
            this.label6.Text = "载    重:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(4, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 100;
            this.label3.Text = "车 牌 号:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label32.Location = new System.Drawing.Point(2, 188);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(77, 15);
            this.label32.TabIndex = 126;
            this.label32.Text = "备    注:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(5, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 99;
            this.label2.Text = "登记日期:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCheLiangBianHao1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtChePaiHao1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(505, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(456, 59);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "模糊查询";
            // 
            // txtCheLiangBianHao1
            // 
            this.txtCheLiangBianHao1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCheLiangBianHao1.Location = new System.Drawing.Point(80, 22);
            this.txtCheLiangBianHao1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCheLiangBianHao1.Name = "txtCheLiangBianHao1";
            this.txtCheLiangBianHao1.Size = new System.Drawing.Size(147, 24);
            this.txtCheLiangBianHao1.TabIndex = 109;
            this.txtCheLiangBianHao1.TextChanged += new System.EventHandler(this.txtCheLiangBianHao1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 108;
            this.label7.Text = "车辆编号:";
            // 
            // txtChePaiHao1
            // 
            this.txtChePaiHao1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtChePaiHao1.Location = new System.Drawing.Point(304, 22);
            this.txtChePaiHao1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChePaiHao1.Name = "txtChePaiHao1";
            this.txtChePaiHao1.Size = new System.Drawing.Size(147, 24);
            this.txtChePaiHao1.TabIndex = 106;
            this.txtChePaiHao1.TextChanged += new System.EventHandler(this.txtChePaiHao1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(231, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 107;
            this.label8.Text = "车 牌 号:";
            // 
            // FRM_CheLiangGuangLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(962, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCheLiangXinXi);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FRM_CheLiangGuangLi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRM_CheLiangGuangLi_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheLiangXinXi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlsXingZenCheLiang;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tlsXiuGaiCheLiang;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbShanChuCheLiang;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dgvCheLiangXinXi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFuJiaShiYi;
        private System.Windows.Forms.TextBox txtFuJiaShiYiBianHao;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtZhengJiaShi;
        private System.Windows.Forms.TextBox txtZhengJiaShiBianHao;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCheLiangXinHao;
        private System.Windows.Forms.TextBox txtDiZi;
        private System.Windows.Forms.TextBox txtLianXiDianHua;
        private System.Windows.Forms.TextBox txtShenFenZheng;
        private System.Windows.Forms.TextBox txtXinMing;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDenJiRiQi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtZaiZhong;
        private System.Windows.Forms.TextBox txtZuoWeiShu;
        private System.Windows.Forms.TextBox txtChePaiHao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBeiZhu;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.RadioButton radYiTianAnJianYiCi;
        private System.Windows.Forms.RadioButton radMeiCiBaoBanAnJian;
        private System.Windows.Forms.RadioButton radBuAnJian;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtChePaiHao1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCheShuDanWei;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCheLiangBianHao1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车辆ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 证件信息ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 保险ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车主ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车辆编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车牌号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 登记日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 座位数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 载重;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
    }
}