using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 集团客运综合管理系统.售票管理
{
    public partial class Frm售票窗口 : Form
    {
        public Frm售票窗口()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.SeaseTicket.TicketSease.TicketSeaseClient myTicketSeaseClient =
            new BLL集团客运综合管理.SeaseTicket.TicketSease.TicketSeaseClient();
      
        DataTable dt;
        DataTable xiwei;
        int FrequencyID = 0;
        int SeatsStateID = 0;
        string SeatNoMC;
        string a = "";
        int SeatsxuanpiaoID = 0;
        int TicketPriceTypeID = 0;
        decimal jiage = 0;
        int 个数 = 0;
        int 开始票号 = 0;
        int 库存量 = 0;

        public static AutoCompleteStringCollection fCollectionZhanDian;
        //AutoCompleteStringCollection功能等同控件AutoCompleteCustomSource的集合属性，但性能更快。
        public static AutoCompleteStringCollection fCollectioCheCi;

        //声明“基础数据公共DataSet”：dsPublic
        public static DataSet dsPublic;
        //声明临时DataTable对象：mydt
        static DataTable mydt;
        void AutoCompleteControl()
        {
            //遍历本窗体中所有的System.Windows.Forms.TextBox控件
            //技巧：进入窗体的构造方法的InitializeComponent()中可以找到当前窗体控件的完整类名
            #region 初始化文本框的输入法设置：半角；自动搜索数据源
            foreach (Control txtControl in groupBox1.Controls)
            {
                if (txtControl.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    (txtControl as TextBox).ImeMode = ImeMode.KatakanaHalf;
                    (txtControl as TextBox).AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    (txtControl as TextBox).AutoCompleteSource = AutoCompleteSource.CustomSource;
                    (txtControl as TextBox).AutoCompleteCustomSource = fCollectionZhanDian;
                }
            }
            #endregion

        }
        public void mCreatePublicDatasetAndCollection()
        //创建公共的dataset和datatable
        {

            //初始化对象：清空数据。
            if (fCollectionZhanDian != null)
            {
                fCollectionZhanDian.Clear();
            }
            if (fCollectioCheCi != null)
            {
                fCollectioCheCi.Clear();
            }
            if (dsPublic != null)
            {
                dsPublic.Tables.Clear();
            }

            if (mydt != null)
            {
                mydt.Clear();
            }

            //创建相关对象
            fCollectionZhanDian = new AutoCompleteStringCollection();
            fCollectioCheCi = new AutoCompleteStringCollection();
            dsPublic = new DataSet();

            //添加 DataTable对象 "站点"，到DataSet之对象 dsPublic中，在dsPublic中编号为0
            mydt = myTicketSeaseClient.SelectStaion().Tables[0];
            dsPublic.Tables.Add(mydt.Copy());
            dsPublic.Tables[0].TableName = "Station";
            //添加 "站点"表的数据到AutoCompleteStringCollection对象“fCollectionZhanDian”（站点）集合中
            foreach (DataRow dr in mydt.Rows)
            {
                fCollectionZhanDian.Add(dr["StationMC1"].ToString().Trim());
                //如果把数据直接追加到   txtZhanDian的AutoCompleteCustomSource中速度就很慢。 
                // txtZhanDian.AutoCompleteCustomSource.Add(dr["站点MC1"].ToString().Trim());

            }
        }
        public static int mReturnZhanDianID(string strZhanDian)
        //根据“站点MC”，返回该名称对应的“站点ID”
        {
            try
            {
                DataTable newDt;
                var queryZhanDian = //把myVar赋值给queryZhanDian，二者都是临时var对象。
                        from myVar in dsPublic.Tables["Station"].AsEnumerable()//把“站点”赋值给myVar
                        where (string)myVar["StationMC1"] == strZhanDian//查询实参为“strZhanDian”的“站点”数据，
                        select myVar; //保存到myVar中，并赋值给queryZhanDian
                //把临时var对象queryZhanDian赋值给DataTable对象newDt
                newDt = queryZhanDian.CopyToDataTable<DataRow>();
                //获取并返回newDt的“站点ID”
                return Convert.ToInt32(newDt.Rows[0]["StationID"]);
            }
            catch
            {
                return 0;
            }
        }
        private void Frm售票窗口_Load(object sender, EventArgs e)
        {
            mCreatePublicDatasetAndCollection();
            AutoCompleteControl();
            //txtQuanPiao.ReadOnly = true;
            //txtBanPiao.ReadOnly = true;
            //txtDaZhePiao.ReadOnly = true;
            //txtretongpiao.ReadOnly = true;
            if (FRM_Login .yonghuleixing == 3)
            { 
            DataTable dt = myTicketSeaseClient.selectgenjuyonghuID(FRM_Login.dengluyonghuID).Tables[0];
            label12.Text = dt.Rows[0]["CurrentTicketMark"].ToString();
            label14.Text = dt.Rows[0]["SurplusQuantity"].ToString();
            }
            else
            {
                label22.Visible = false;label24.Visible = false;
            }
        }

        private void dgvchepiaoxinxi_CellClick(object sender, DataGridViewCellEventArgs e)
        { }
        private void btnqueding_Click(object sender, EventArgs e)//显示车票信息
        {
            if (flowLayoutPanel1.Controls.Count == 0)
            {
                个数 = 0;
                string strZhanDian = txtShiCheZhanMingCheng.Text.Trim();
                string strZhanDian1 = txtZhongCheZhanMingCheng.Text.Trim();
                int StartingStationID = mReturnZhanDianID(strZhanDian);
                int TerminalStationID = mReturnZhanDianID(strZhanDian1);
                try
                {
                    if (txtQuanPiao.Text != "")
                    {
                        string date = dateTimePicker1.Value.ToString();
                        string 给出时间 = date.Remove(9);
                        个数 = Convert.ToInt32(txtQuanPiao.Text);
                        TicketPriceTypeID = 1;
                        int FrequencyID3 = Convert.ToInt32(cbofacheshijian.SelectedValue);
                        dt = myTicketSeaseClient.Selectchepiao(StartingStationID, TerminalStationID, TicketPriceTypeID, 给出时间, FrequencyID3).Tables[0];
                    } else { }
                    if (txtBanPiao.Text != "")
                    {
                        string date = dateTimePicker1.Value.ToString();
                        string 给出时间 = date.Remove(9);
                        个数 = Convert.ToInt32(txtBanPiao.Text);
                        TicketPriceTypeID = 2;
                        int FrequencyID3 = Convert.ToInt32(cbofacheshijian.SelectedValue);
                        dt = myTicketSeaseClient.Selectchepiao(StartingStationID, TerminalStationID, TicketPriceTypeID, 给出时间, FrequencyID3).Tables[0];
                    }
                    else { }
                    if (txtDaZhePiao.Text != "")
                    {
                        string date = dateTimePicker1.Value.ToString();
                        string 给出时间 = date.Remove(9);
                        个数 = Convert.ToInt32(txtDaZhePiao.Text);
                        TicketPriceTypeID = 4;
                        int FrequencyID3 = Convert.ToInt32(cbofacheshijian.SelectedValue);
                        dt = myTicketSeaseClient.Selectchepiao(StartingStationID, TerminalStationID, TicketPriceTypeID, 给出时间, FrequencyID3).Tables[0];
                    }
                    else { }
                    if (txtretongpiao.Text != "")
                    {
                        string date = dateTimePicker1.Value.ToString();
                        string 给出时间 = date.Remove(9);
                        个数 = Convert.ToInt32(txtretongpiao.Text);
                        TicketPriceTypeID = 3;
                        int FrequencyID3 = Convert.ToInt32(cbofacheshijian.SelectedValue);
                        dt = myTicketSeaseClient.Selectchepiao(StartingStationID, TerminalStationID, TicketPriceTypeID, 给出时间, FrequencyID3).Tables[0];
                    } else { }
                    FrequencyID = Convert.ToInt32(dt.Rows[0]["FrequencyID1"]);
                    xiwei = new DataTable();
                    xiwei = myTicketSeaseClient.Selelctticketzhuangtai(FrequencyID).Tables[0];
                    for (int i = 0; i < xiwei.Rows.Count; i++)
                    {
                        PictureBox pb = new PictureBox();
                        pb.Size = new Size(36, 34);
                        pb.Tag = xiwei.Rows[i];
                        int 席位状态ID = (int)xiwei.Rows[i]["SeatsStateID"];
                        switch (席位状态ID)
                        {
                            case 1: pb.BackgroundImage = Properties.Resources.已售; break;
                            case 2: pb.BackgroundImage = Properties.Resources.待卖; break;
                            case 3: pb.BackgroundImage = Properties.Resources.报废; break;
                            case 4: pb.BackgroundImage = Properties.Resources.退票新; break;
                            case 7: pb.BackgroundImage = Properties.Resources.已检; break;
                            case 8: pb.BackgroundImage = Properties.Resources.留票; break;
                        }
                        pb.BackgroundImageLayout = ImageLayout.Stretch;
                        pb.Paint += new PaintEventHandler(pb_paint);
                        pb.MouseEnter += new EventHandler(pb_MouseEnter);
                        pb.MouseLeave += new EventHandler(pb_MouseLeave);
                        pb.MouseClick += new MouseEventHandler(pb_MouseClick);
                        flowLayoutPanel1.Controls.Add(pb);
                    }
                    DataTable dttt = myTicketSeaseClient.selectchelaingdexiwei(FrequencyID, 个数).Tables[0];
                    dgvchepiaoxinxi.DataSource = dttt;
                    DataTable dtpiaojia = myTicketSeaseClient.Selectczhandianandpiaojia(StartingStationID, TerminalStationID, TicketPriceTypeID, FrequencyID).Tables[0];

                    dgvzhandianhepiaojiaxinxi.DataSource = dtpiaojia;
                    label18.Visible = true;
                    label20.Visible = true;
                    label10.Visible = true;
                    label23.Visible = true;
                    label18.Text = dgvchepiaoxinxi.Rows.Count.ToString();
                    jiage = Convert.ToDecimal(dgvzhandianhepiaojiaxinxi.CurrentRow.Cells["TicketPrice"].Value);
                    int xingshu = dgvchepiaoxinxi.Rows.Count;
                    label20.Text = Convert.ToString(xingshu * jiage);
                    label10.Text = Convert.ToString(xingshu * jiage);
                    label23.Text = Convert.ToString(xingshu * jiage);
                }
                catch { MessageBox.Show("请填好相关数据"); }
            }
            else
            {
                MessageBox.Show("已有数据且对应当前站点啦");
            }
        }
        #region 车辆图片点击事件
        void pb_MouseClick(object sender, MouseEventArgs e)
        {


            PictureBox pb = sender as PictureBox;//将sender转换成PictureBox
            DataRow dr = (DataRow)pb.Tag;//获取pb绑定的数据行
            SeatsStateID = Convert.ToInt32(dr["SeatsStateID"]);
            SeatsxuanpiaoID = Convert.ToInt32(dr["SeatsID"]);
            SeatNoMC = dr["SeatNoMC"].ToString();
            foreach (Control c in flowLayoutPanel1.Controls)//遍历flp中的控件(flp中的PictureBox)
            {
                PictureBox pbc = c as PictureBox;
                DataRow drc = (DataRow)pbc.Tag;
                if (drc["SeatNoMC"].ToString() != SeatNoMC.ToString())
                //判断每个PictureBox的配载发车单ID是否跟当前点击的PictureBox的配载发车单ID相等，
                //若不等则清除边框
                {
                    Pen pen = new Pen(flowLayoutPanel1.BackColor, 4);
                    Graphics g = flowLayoutPanel1.CreateGraphics();
                    Rectangle 矩形 = new Rectangle();
                    矩形.X = pbc.Location.X - 1;
                    矩形.Y = pbc.Location.Y - 1;
                    矩形.Width = pbc.Size.Width + 4;
                    矩形.Height = pbc.Size.Height + 4;
                    g.DrawRectangle(pen, 矩形);
                }
            }
            label18.Text = "1";
            label20.Text = Convert.ToString(1 * jiage);
            label10.Text = Convert.ToString(1 * jiage);
            label23.Text = Convert.ToString(1 * jiage);
        }
        #endregion
        #region 鼠标离开车辆图片事件
        void pb_MouseLeave(object sender, EventArgs e)
        {
            if (SeatNoMC != null)
            {
                PictureBox pb = sender as PictureBox;
                DataRow dr = (DataRow)pb.Tag;
                if (dr["SeatNoMC"].ToString() != SeatNoMC.ToString())
                {
                    pb.Cursor = Cursors.Hand;
                    Pen pen = new Pen(flowLayoutPanel1.BackColor, 4);
                    Graphics g = flowLayoutPanel1.CreateGraphics();
                    Rectangle 矩形 = new Rectangle();
                    矩形.X = pb.Location.X - 1;
                    矩形.Y = pb.Location.Y - 1;
                    矩形.Width = pb.Size.Width + 4;
                    矩形.Height = pb.Size.Height + 4;
                    g.DrawRectangle(pen, 矩形);
                }
                }
               // else
            //{
            //    PictureBox pb = sender as PictureBox;
            //    DataRow dr = (DataRow)pb.Tag;
            //    string SeatNoMC1 = 1.ToString();
            //    if (dr["SeatNoMC"].ToString() != SeatNoMC1.ToString())
            //    {
            //        pb.Cursor = Cursors.Hand;
            //        Pen pen = new Pen(flowLayoutPanel1.BackColor, 4);
            //        Graphics g = flowLayoutPanel1.CreateGraphics();
            //        Rectangle 矩形 = new Rectangle();
            //        矩形.X = pb.Location.X - 1;
            //        矩形.Y = pb.Location.Y - 1;
            //        矩形.Width = pb.Size.Width + 4;
            //        矩形.Height = pb.Size.Height + 4;
            //        g.DrawRectangle(pen, 矩形);
            //    }
            //}

        }
        #endregion
        #region 图片绘制文字事件
        void pb_paint(object sender, PaintEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            Graphics g = e.Graphics;
            DataRow dr = (DataRow)pb.Tag;
            string 司机名称 = dr["SeatNoMC"].ToString().Trim();
            Font 字体样式 = new System.Drawing.Font("微软雅黑", 10, FontStyle.Bold);
            PointF 字符串坐标 = new PointF(19, 1);
            g.DrawString(司机名称, 字体样式, SystemBrushes.ActiveCaptionText, 字符串坐标);
        }
        #endregion
        #region 鼠标点击车辆图片事件
        void pb_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.Cursor = Cursors.Hand;
            Pen pen = new Pen(Color.Red, 4);
            Graphics g = flowLayoutPanel1.CreateGraphics();
            Rectangle 矩形 = new Rectangle();
            矩形.X = pb.Location.X - 1;
            矩形.Y = pb.Location.Y - 1;
            矩形.Width = pb.Size.Width + 4;
            矩形.Height = pb.Size.Height + 4;
            g.DrawRectangle(pen, 矩形);
        }
        #endregion

        private void txtShiCheZhanMingCheng_TextChanged(object sender, EventArgs e)//至发生改变是清空FLY的图片
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void txtZhongCheZhanMingCheng_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void btnchushouchepiao_Click(object sender, EventArgs e)//售票
        {
            
                if (dgvchepiaoxinxi.Rows.Count != 0)
                {
                    MessageBox.Show("出票提示" + "\n" + "张数为" + 个数 + "\n" + "班次时间为" + cbofacheshijian.Text + "\n" + "终点站为:" + txtZhongCheZhanMingCheng.Text + "\n" + "价格为:" + label23.Text + "\n");
                    if (MessageBox.Show("是否修改", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int count = 0;
                        int success = 0;

                        int mypiaojia = 0;
                        foreach (DataGridViewRow dgv in dgvchepiaoxinxi.Rows)
                        {
                            DataTable dttt = myTicketSeaseClient.Selectzuidapiohao().Tables[0];
                            string z = dttt.Rows.Count.ToString();
                            int shu = dttt.Rows.Count;
                            if (dttt.Rows.Count == 0)
                            {
                                a = 000000000.ToString();
                            }
                            else
                            {
                                shu = shu + 1;
                                if (z.Length <= 1)
                                {
                                    if (z == "9")
                                    { a = Convert.ToString("0000000" + shu); }
                                    else { a = Convert.ToString("00000000" + shu); }
                                }
                                else { }
                                if (1 < z.Length && z.Length <= 2)
                                {
                                    if (z == "99")
                                    { a = Convert.ToString("000000" + shu); }
                                    else { a = Convert.ToString("0000000" + shu); }

                                }
                                else { }
                                if (2 < z.Length && z.Length <= 3)
                                {
                                    if (z == "999")
                                    { a = Convert.ToString("00000" + shu); }
                                    else { a = Convert.ToString("000000" + shu); }

                                }
                                else { }
                                if (3 < z.Length && z.Length <= 4)
                                {
                                    if (z == "9999")
                                    { a = Convert.ToString("0000" + shu); }
                                    else { a = Convert.ToString("00000" + shu); }

                                }
                                else { }
                                if (4 < z.Length && z.Length <= 5)
                                {
                                    if (z == "99999")
                                    { a = Convert.ToString("000" + shu); }
                                    else { a = Convert.ToString("0000" + shu); }

                                }
                                else { }
                                if (5 < z.Length && z.Length <= 6)
                                {
                                    if (z == "999999")
                                    { a = Convert.ToString("00" + shu); }
                                    else { a = Convert.ToString("000" + shu); }

                                }
                                else { }
                                if (6 < z.Length && z.Length <= 7)
                                {
                                    if (z == "9999999")
                                    { a = Convert.ToString("0" + shu); }
                                    else { a = Convert.ToString("00" + shu); }

                                }
                                else { }
                                if (7 < z.Length && z.Length <= 8)
                                {
                                    if (z == "99999999")
                                    { a = Convert.ToString(shu); }
                                    else { a = Convert.ToString("0" + shu); }

                                }
                                else { }
                                if (8 < z.Length && z.Length <= 9)
                                {
                                    a = Convert.ToString(shu);
                                }
                                else { }
                            }
                            count = count + 1;
                            string d = DateTime.Now.ToString();
                            string shijian = DateTime.Now.ToShortTimeString();
                            int CreateUserID = FRM_Login.dengluyonghuID;
                            int DeleteUserID = 0;
                            string TicketMark = Convert.ToString(a);
                            DateTime TicketingDate = Convert.ToDateTime(d.Remove(9));
                            DateTime TicketingDateTime = Convert.ToDateTime(shijian);
                            DateTime CreateTime = Convert.ToDateTime(DateTime.Now.ToString());
                            int SeatsID = Convert.ToInt32(dgv.Cells["SeatsID"].Value);
                            decimal Howmoney = Convert.ToDecimal(dgvzhandianhepiaojiaxinxi.CurrentRow.Cells["TicketPrice"].Value);
                            success += myTicketSeaseClient.Updatexiweizhaungtai(SeatsID);
                            mypiaojia += myTicketSeaseClient.Insectdingpiaoxinxi(FrequencyID, SeatsID, CreateUserID,
                                DeleteUserID, TicketMark, TicketingDate, TicketingDateTime, CreateTime, TicketPriceTypeID, Howmoney, 3);
                        }
                        if (success > 0 && success == count && count == mypiaojia)
                        {
                            开始票号 = Convert.ToInt32(label12.Text);
                            库存量 = Convert.ToInt32(label14.Text);
                            int CurrentTicketMark = 开始票号 + 个数;
                            int SurplusQuantity = 库存量 - 个数;
                            int myint = myTicketSeaseClient.UPDATEdangqianpiaohao(CurrentTicketMark, SurplusQuantity, FRM_Login.dengluyonghuID);
                            if (myint > 0)
                            {
                                dgvchepiaoxinxi.DataSource = null;
                                flowLayoutPanel1.Controls.Clear();
                                label18.Text = null;
                                label20.Text = null;
                                label23.Text = null;
                                label28.Text = null;
                                label10.Text = null;
                                DataTable dt = myTicketSeaseClient.selectgenjuyonghuID(FRM_Login.dengluyonghuID).Tables[0];
                                label12.Text = dt.Rows[0]["CurrentTicketMark"].ToString();
                                label14.Text = dt.Rows[0]["SurplusQuantity"].ToString();
                                MessageBox.Show("出票成功");
                            }


                        }
                    }
                    else { MessageBox.Show("你已取消出票"); }
                }
                else
                { MessageBox.Show("请选择站点了啦啦啦啦"); }
       
               


        }

        private void txtQuanPiao_TextChanged(object sender, EventArgs e)//清空fly的图片
        {
            if (!IsNumber(txtQuanPiao.Text.Trim()))//验证输入是否为数字
            { MessageBox.Show("只充许输入数字!!!", "提示"); txtQuanPiao.Text = ""; }//弹出消息对话框
            else
            {
                dgvchepiaoxinxi.DataSource = null;
                flowLayoutPanel1.Controls.Clear();
                label18.Text = null;
                label20.Text = null;
                label23.Text = null;
                label28.Text = null;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtshoukuan.Text != null)
            {
                label28.Visible = true;
                // label28.Text =Convert .ToString ( Convert .ToInt32 ( txtshoukuan.Text) -Convert .ToInt32 ( label23.Text));
                int i = Convert.ToInt32(txtshoukuan.Text);
                decimal z = Convert.ToDecimal(label23.Text);
                label28.Text = (i - z).ToString();
            }
            else { MessageBox.Show("请输入收款值"); }
        }

        private void button1_Click(object sender, EventArgs e)//座位选择
        {
            if (dgvchepiaoxinxi.Rows .Count !=0) {
    
                    if (Convert.ToInt32(label12.Text) > 1)
                    {
                        if (SeatsStateID == 2)
                        {
                            if (dgvchepiaoxinxi.Rows.Count != 0)
                            {
                                MessageBox.Show("出票提示" + "\n" + "当前座位号是:" + SeatNoMC + "\n" + "班次时间为" + cbofacheshijian.Text + "\n" + "终点站为:" + txtZhongCheZhanMingCheng.Text + "\n" + "价格为:" + label23.Text + "\n");
                                if (MessageBox.Show("是否出票", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    int count = 0;
                                    int success = 0;
                                    int mypiaojia = 0;
                                    DataTable dttt = myTicketSeaseClient.Selectzuidapiohao().Tables[0];
                                    string z = dttt.Rows.Count.ToString();
                                    int shu = dttt.Rows.Count;
                                    if (dttt.Rows.Count == 0)
                                    {
                                        a = 000000000.ToString();
                                    }
                                    else
                                    {
                                        shu = shu + 1;
                                        if (z.Length <= 1)
                                        {
                                            if (z == "9")
                                            { a = Convert.ToString("0000000" + shu); }
                                            else { a = Convert.ToString("00000000" + shu); }
                                        }
                                        else { }
                                        if (1 < z.Length && z.Length <= 2)
                                        {
                                            if (z == "99")
                                            { a = Convert.ToString("000000" + shu); }
                                            else { a = Convert.ToString("0000000" + shu); }

                                        }
                                        else { }
                                        if (2 < z.Length && z.Length <= 3)
                                        {
                                            if (z == "999")
                                            { a = Convert.ToString("00000" + shu); }
                                            else { a = Convert.ToString("000000" + shu); }

                                        }
                                        else { }
                                        if (3 < z.Length && z.Length <= 4)
                                        {
                                            if (z == "9999")
                                            { a = Convert.ToString("0000" + shu); }
                                            else { a = Convert.ToString("00000" + shu); }

                                        }
                                        else { }
                                        if (4 < z.Length && z.Length <= 5)
                                        {
                                            if (z == "99999")
                                            { a = Convert.ToString("000" + shu); }
                                            else { a = Convert.ToString("0000" + shu); }

                                        }
                                        else { }
                                        if (5 < z.Length && z.Length <= 6)
                                        {
                                            if (z == "999999")
                                            { a = Convert.ToString("00" + shu); }
                                            else { a = Convert.ToString("000" + shu); }

                                        }
                                        else { }
                                        if (6 < z.Length && z.Length <= 7)
                                        {
                                            if (z == "9999999")
                                            { a = Convert.ToString("0" + shu); }
                                            else { a = Convert.ToString("00" + shu); }

                                        }
                                        else { }
                                        if (7 < z.Length && z.Length <= 8)
                                        {
                                            if (z == "99999999")
                                            { a = Convert.ToString(shu); }
                                            else { a = Convert.ToString("0" + shu); }

                                        }
                                        else { }
                                        if (8 < z.Length && z.Length <= 9)
                                        {
                                            a = Convert.ToString(shu);
                                        }
                                        else { }

                                    }
                                    count = count + 1;
                                    string d = DateTime.Now.ToString();
                                    string shijian = DateTime.Now.ToShortTimeString();
                                    int CreateUserID = FRM_Login.dengluyonghuID;
                                    int DeleteUserID = 0;
                                    string TicketMark = Convert.ToString(a);
                                    DateTime TicketingDate = Convert.ToDateTime(d.Remove(9));
                                    DateTime TicketingDateTime = Convert.ToDateTime(shijian);
                                    DateTime CreateTime = Convert.ToDateTime(DateTime.Now.ToString());
                                    int SeatsID = SeatsxuanpiaoID;
                                    decimal Howmoney = Convert.ToDecimal(dgvzhandianhepiaojiaxinxi.CurrentRow.Cells["TicketPrice"].Value);
                                    success += myTicketSeaseClient.Updatexiweizhaungtai(SeatsID);
                                    mypiaojia += myTicketSeaseClient.Insectdingpiaoxinxi(FrequencyID, SeatsID, CreateUserID, DeleteUserID,
                                        TicketMark, TicketingDate, TicketingDateTime, CreateTime, TicketPriceTypeID, Howmoney, 3);

                                    if (success > 0 && success == count && count == mypiaojia)
                                    {
                                        开始票号 = Convert.ToInt32(label12.Text);
                                        库存量 = Convert.ToInt32(label14.Text);
                                        int CurrentTicketMark = 开始票号 + 个数;
                                        int SurplusQuantity = 库存量 - 个数;
                                        int myint = myTicketSeaseClient.UPDATEdangqianpiaohao(CurrentTicketMark, SurplusQuantity, FRM_Login.dengluyonghuID);
                                        if (myint > 0)
                                        {
                                            dgvchepiaoxinxi.DataSource = null;
                                            flowLayoutPanel1.Controls.Clear();
                                            label18.Text = null;
                                            label20.Text = null;
                                            label23.Text = null;
                                            label28.Text = null;
                                            btnqueding_Click(null, null);
                                            DataTable dt = myTicketSeaseClient.selectgenjuyonghuID(FRM_Login.dengluyonghuID).Tables[0];
                                            label12.Text = dt.Rows[0]["CurrentTicketMark"].ToString();
                                            label14.Text = dt.Rows[0]["SurplusQuantity"].ToString();
                                            MessageBox.Show("出票成功");
                                        }

                                    }
                                }
                                else { MessageBox.Show("你已取消买票"); }
                            }
                            else
                            {
                                MessageBox.Show("请选择站点了啦啦啦啦");
                            }
                        }
                        else
                        {
                            MessageBox.Show("请选择空的席位");
                        }
                    }
                    else { MessageBox.Show("请新增票据"); }
              
               
            }else { MessageBox.Show("请填完整数据"); }
            
        }
        private void btnfeipiao_Click(object sender, EventArgs e)//废票
        {
            
                if (SeatsStateID == 1 || SeatsStateID == 7 || SeatsStateID == 4)
                {
                    DataTable feipiao = myTicketSeaseClient.selectfeipiaoxinxi(SeatsxuanpiaoID).Tables[0];
                    string dangqianpiaohao = feipiao.Rows[0]["TicketMark"].ToString();
                    string fabanshijian = feipiao.Rows[0]["DepartureTime"].ToString();
                    decimal jiage = Convert.ToDecimal(feipiao.Rows[0]["Howmoney"]);
                    string dangqianbancimingc = feipiao.Rows[0]["FrequencyMC"].ToString();
                    string dangqianxiweizhuangtai = feipiao.Rows[0]["SeatsStateMC"].ToString();
                    string dangqianxiweileixing = feipiao.Rows[0]["SeatsTypeMC"].ToString();
                    MessageBox.Show("废票提示" + "\n" + "当前座位号是:" + dangqianpiaohao + "\n" + "班次时间为:" + fabanshijian + "\n" + "终点站为:" + txtZhongCheZhanMingCheng.Text + "\n" + "价格为:" + jiage + "\n"
                                         + "当前班次名称:" + dangqianbancimingc + "\n" + "当前席位状态:" + dangqianxiweizhuangtai + "\n" + "当前席位类型:" + dangqianxiweileixing);
                    if (MessageBox.Show("是否废票", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int SeatsStateIDup = 3;
                        int myin = myTicketSeaseClient.Updatexiweizhaungtaiweibaofei(SeatsxuanpiaoID, SeatsStateIDup);
                        if (myin > 0)
                        {
                            try
                            {
                                DataTable dt = myTicketSeaseClient.SelectpiaojiaID(SeatsxuanpiaoID).Tables[0];

                                int TicketingInformationID = Convert.ToInt32(dt.Rows[0][0]);
                                int 废票价格 = Convert.ToInt32(jiage);
                                int myt1 = myTicketSeaseClient.DELETETicketingInformation(TicketingInformationID, 3, 1, 废票价格);
                                dgvchepiaoxinxi.DataSource = null;
                                flowLayoutPanel1.Controls.Clear();
                                label18.Text = null;
                                label20.Text = null;
                                label23.Text = null;
                                label28.Text = null;
                                flowLayoutPanel1.Controls.Clear();
                                btnqueding_Click(null, null);
                                MessageBox.Show("报废成功");
                            }
                            catch { MessageBox.Show("报废成功"); }
                        }
                        else
                        { MessageBox.Show("废票失败"); }
                    }
                    else { MessageBox.Show("你已取消废票"); }
                }
                else { MessageBox.Show("请选择已买或已检的票"); }
          
        }

        private void btntuipiao_Click(object sender, EventArgs e)//退票
        {
           
                if (SeatsStateID == 1)
                {
                    MessageBox.Show("退票信息提示" + "\n" + "当前座位号是:" + SeatNoMC + "\n" + "班次时间为" + cbofacheshijian.Text + "\n" + "终点站为:" + txtZhongCheZhanMingCheng.Text + "\n" + "价格为:" + label23.Text + "\n");
                    if (MessageBox.Show("是否退票", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int SeatsStateIDup = 4;
                        int myin = myTicketSeaseClient.Updatexiweizhaungtaiweibaofei(SeatsxuanpiaoID, SeatsStateIDup);
                        if (myin > 0)
                        {
                            if (txttuipiaoshouxifei.Text != "")
                            {
                                DataTable dt = myTicketSeaseClient.SelectpiaojiaID(SeatsxuanpiaoID).Tables[0];
                                int Tuipiaoshouxufei = Convert.ToInt32(txttuipiaoshouxifei.Text);
                                int TicketingInformationID = Convert.ToInt32(dt.Rows[0][0]);
                                int myt1 = myTicketSeaseClient.DELETETicketingInformationtuipiao(TicketingInformationID, 4, Tuipiaoshouxufei, 2);
                                dgvchepiaoxinxi.DataSource = null;
                                flowLayoutPanel1.Controls.Clear();
                                label18.Text = null;
                                label20.Text = null;
                                label23.Text = null;
                                label28.Text = null;
                                flowLayoutPanel1.Controls.Clear();
                                btnqueding_Click(null, null);
                                txttuipiaoshouxifei.Text = null;
                                MessageBox.Show("退票成功");
                            }
                            else { MessageBox.Show("请填退票手续费"); }

                        }
                        else
                        { MessageBox.Show("退票成功"); }
                    }
                }
                else
                { MessageBox.Show("请选择已买或已检的票"); }
         
        
    }
        private void cbofacheshijian_Click(object sender, EventArgs e)
        {
            string strZhanDian = txtShiCheZhanMingCheng.Text.Trim();
            string strZhanDian1 = txtZhongCheZhanMingCheng.Text.Trim();
            int StartingStationID = mReturnZhanDianID(strZhanDian);
            int TerminalStationID = mReturnZhanDianID(strZhanDian1);
            string date = dateTimePicker1.Value.ToString();
            string 给出时间 = date.Remove(9);
            int TicketPriceTypeID = 1;
            DataTable dt=  myTicketSeaseClient.Selectbancionshijian (StartingStationID, TerminalStationID, TicketPriceTypeID, 给出时间).Tables[0];
            cbofacheshijian.DataSource = dt;
            cbofacheshijian.DisplayMember = "DepartureTime";
            cbofacheshijian.ValueMember = "FrequencyID";
        }

        private void cbofacheshijian_SelectedIndexChanged(object sender, EventArgs e)//cbo时间的值发生改变时
        {
            dgvchepiaoxinxi.DataSource = null;
            flowLayoutPanel1.Controls.Clear();
            label18.Text = null;
            label20.Text = null;
            label23.Text = null;
            label28.Text = null;
        }
        private void txtQuanPiao_Click(object sender, EventArgs e)//点击之后为可写
        {
            dgvchepiaoxinxi.DataSource = null;
            flowLayoutPanel1.Controls.Clear();
            label18.Text = null;
            label20.Text = null;
            label23.Text = null;
            label28.Text = null;

            txtBanPiao.Text = "";
            txtDaZhePiao.Text = "";
            txtretongpiao.Text = "";
        }

        private void txtBanPiao_Click(object sender, EventArgs e)//点击之后为可写
        {
            //if (!IsNumber(txtshoukuan.Text.Trim()))//验证输入是否为数字
            //{ MessageBox.Show("只充许输入数字!!!", "提示"); }//弹出消息对话框 
        
            //else
            //{    dgvchepiaoxinxi.DataSource = null;
            //    flowLayoutPanel1.Controls.Clear();
            //    label18.Text = null;
            //    label20.Text = null;
            //    label23.Text = null;
            //    label28.Text = null;

            //    txtQuanPiao.Text = "";
            //    txtDaZhePiao.Text = "";
            //    txtretongpiao.Text = "";
            //}
        }

        private void txtDaZhePiao_Click(object sender, EventArgs e)//点击之后为可写
        {
            //if (!IsNumber(txtshoukuan.Text.Trim()))//验证输入是否为数字
            //{ MessageBox.Show("只充许输入数字!!!", "提示"); }//弹出消息对话框
            //else
            //{
            //    dgvchepiaoxinxi.DataSource = null;
            //    flowLayoutPanel1.Controls.Clear();
            //    label18.Text = null;
            //    label20.Text = null;
            //    label23.Text = null;
            //    label28.Text = null;
            //    txtQuanPiao.Text = "";
            //    txtBanPiao.Text = "";
            //    txtretongpiao.Text = "";
            //}
        }

        private void txtretongpiao_Click(object sender, EventArgs e)//点击之后为可写
        {
            //if (!IsNumber(txtshoukuan.Text.Trim()))//验证输入是否为数字
            //{ MessageBox.Show("只充许输入数字!!!", "提示"); }//弹出消息对话框
            //else
            //{
            //    dgvchepiaoxinxi.DataSource = null;
            //    flowLayoutPanel1.Controls.Clear();
            //    label18.Text = null;
            //    label20.Text = null;
            //    label23.Text = null;
            //    label28.Text = null;
            //    txtQuanPiao.Text = "";
            //    txtBanPiao.Text = "";
            //    txtDaZhePiao.Text = "";
            //}
        }

        private void btnxiaoyan_Click(object sender, EventArgs e)//留票校验
        {

            if (Convert.ToInt32(label12.Text) > 1)
            {
                if (SeatsStateID == 8)
                {
                    if (dgvchepiaoxinxi.Rows.Count != 0)
                    {
                        int count = 0;
                        int success = 0;

                        int mypiaojia = 0;
                        DataTable dttt = myTicketSeaseClient.Selectzuidapiohao().Tables[0];
                        string z = dttt.Rows.Count.ToString();
                        int shu = dttt.Rows.Count;
                        if (dttt.Rows.Count == 0)
                        {
                            a = 000000000.ToString();
                        }
                        else
                        {
                            shu = shu + 1;
                            if (z.Length <= 1)
                            {
                                if (z == "9")
                                { a = Convert.ToString("0000000" + shu); }
                                else { a = Convert.ToString("00000000" + shu); }
                            }
                            else { }
                            if (1 < z.Length && z.Length <= 2)
                            {
                                if (z == "99")
                                { a = Convert.ToString("000000" + shu); }
                                else { a = Convert.ToString("0000000" + shu); }

                            }
                            else { }
                            if (2 < z.Length && z.Length <= 3)
                            {
                                if (z == "999")
                                { a = Convert.ToString("00000" + shu); }
                                else { a = Convert.ToString("000000" + shu); }

                            }
                            else { }
                            if (3 < z.Length && z.Length <= 4)
                            {
                                if (z == "9999")
                                { a = Convert.ToString("0000" + shu); }
                                else { a = Convert.ToString("00000" + shu); }

                            }
                            else { }
                            if (4 < z.Length && z.Length <= 5)
                            {
                                if (z == "99999")
                                { a = Convert.ToString("000" + shu); }
                                else { a = Convert.ToString("0000" + shu); }

                            }
                            else { }
                            if (5 < z.Length && z.Length <= 6)
                            {
                                if (z == "999999")
                                { a = Convert.ToString("00" + shu); }
                                else { a = Convert.ToString("000" + shu); }

                            }
                            else { }
                            if (6 < z.Length && z.Length <= 7)
                            {
                                if (z == "9999999")
                                { a = Convert.ToString("0" + shu); }
                                else { a = Convert.ToString("00" + shu); }

                            }
                            else { }
                            if (7 < z.Length && z.Length <= 8)
                            {
                                if (z == "99999999")
                                { a = Convert.ToString(shu); }
                                else { a = Convert.ToString("0" + shu); }

                            }
                            else { }
                            if (8 < z.Length && z.Length <= 9)
                            {
                                a = Convert.ToString(shu);
                            }
                            else { }
                        }
                        count = count + 1;
                        string d = DateTime.Now.ToString();
                        string shijian = DateTime.Now.ToShortTimeString();
                        int CreateUserID = FRM_Login.dengluyonghuID;
                        int DeleteUserID = 0;
                        string TicketMark = Convert.ToString(a);
                        DateTime TicketingDate = Convert.ToDateTime(d.Remove(9));
                        DateTime TicketingDateTime = Convert.ToDateTime(shijian);
                        DateTime CreateTime = Convert.ToDateTime(DateTime.Now.ToString());
                        int SeatsID = SeatsxuanpiaoID;
                        decimal Howmoney = Convert.ToDecimal(dgvzhandianhepiaojiaxinxi.CurrentRow.Cells["TicketPrice"].Value);
                        success += myTicketSeaseClient.Updatexiweizhaungtai(SeatsID);
                        mypiaojia += myTicketSeaseClient.Insectdingpiaoxinxi(FrequencyID, SeatsID, CreateUserID, DeleteUserID,
                            TicketMark, TicketingDate, TicketingDateTime, CreateTime, TicketPriceTypeID, Howmoney, 3);
                        if (success > 0 && success == count && count == mypiaojia)
                        {
                            开始票号 = Convert.ToInt32(label12.Text);
                            库存量 = Convert.ToInt32(label14.Text);
                            int CurrentTicketMark = 开始票号 + 个数;
                            int SurplusQuantity = 库存量 - 个数;
                            int myint = myTicketSeaseClient.UPDATEdangqianpiaohao(CurrentTicketMark, SurplusQuantity, FRM_Login.dengluyonghuID);
                            if (myint > 0)
                            {
                                if (txtyanzhengma.Text != null)
                                {
                                    string DingPiaoYanZhengMa = txtyanzhengma.Text.Trim(); ;
                                    DataTable dt3 = myTicketSeaseClient.selectyanzhengma(DingPiaoYanZhengMa).Tables[0];
                                    if (dt3.Rows.Count > 0)
                                    {
                                        bool ShiFou = Convert.ToBoolean(0);
                                        string DingPiaoYanZhengMaID = txtyanzhengma.Text.Trim();
                                        int myyanzhenma = myTicketSeaseClient.updateyanzhengma(ShiFou, DingPiaoYanZhengMaID);
                                        dgvchepiaoxinxi.DataSource = null;
                                        flowLayoutPanel1.Controls.Clear();
                                        label18.Text = null;
                                        label20.Text = null;
                                        label23.Text = null;
                                        label28.Text = null;
                                        btnqueding_Click(null, null);
                                        DataTable dt = myTicketSeaseClient.selectgenjuyonghuID(FRM_Login.dengluyonghuID).Tables[0];
                                        label12.Text = dt.Rows[0]["CurrentTicketMark"].ToString();
                                        label14.Text = dt.Rows[0]["SurplusQuantity"].ToString();
                                        MessageBox.Show("出票成功");
                                    }
                                    else { MessageBox.Show("验证码不正确"); }
                                }
                                else
                                {
                                    MessageBox.Show("请输入验证码");
                                }
                            }
                        }
                        else
                        { MessageBox.Show("请选择站点了啦啦啦啦"); }
                    }
                    else {  }
                }
                else { MessageBox.Show("请选择留票的座位"); }
            }
            else
            {
                MessageBox.Show("请新增票据");
            }
            }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnshoupiaochaxun_Click(object sender, EventArgs e)
        {
            chpiaophao myFrm售票查询 = new chpiaophao();
            myFrm售票查询.ShowDialog();
        }

        private void txtshoukuan_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumber(txtshoukuan .Text.Trim()))//验证输入是否为数字
            { MessageBox.Show("只充许输入数字!!!", "提示"); txtshoukuan.Text = ""; }//弹出消息对话框
         //   else { MessageBox.Show("输入信息正确!!!!!", "提示"); }//弹出消息对话框

        }
        public bool IsNumber(string str_number)
        {
            return System.Text.RegularExpressions.Regex.//使用正则表达式判断是否匹配
                IsMatch(str_number, @"^[0-9]*$");
        }

        private void txtBanPiao_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumber(txtBanPiao .Text.Trim()))//验证输入是否为数字
            { MessageBox.Show("只充许输入数字!!!", "提示"); txtBanPiao.Text = ""; }//弹出消息对话框 

            else
            {
                dgvchepiaoxinxi.DataSource = null;
                flowLayoutPanel1.Controls.Clear();
                label18.Text = null;
                label20.Text = null;
                label23.Text = null;
                label28.Text = null;

                txtQuanPiao.Text = "";
                txtDaZhePiao.Text = "";
                txtretongpiao.Text = "";
            }
        }

        private void txtDaZhePiao_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumber(txtDaZhePiao .Text.Trim()))//验证输入是否为数字
            { MessageBox.Show("只充许输入数字!!!", "提示"); txtDaZhePiao.Text = ""; }//弹出消息对话框
            else
            {
                dgvchepiaoxinxi.DataSource = null;
                flowLayoutPanel1.Controls.Clear();
                label18.Text = null;
                label20.Text = null;
                label23.Text = null;
                label28.Text = null;
                txtQuanPiao.Text = "";
                txtBanPiao.Text = "";
                txtretongpiao.Text = "";
            }
        }

        private void txtretongpiao_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumber(txtshoukuan.Text.Trim()))//验证输入是否为数字
            { MessageBox.Show("只充许输入数字!!!", "提示"); txtshoukuan.Text = ""; }//弹出消息对话框
            else
            {
                dgvchepiaoxinxi.DataSource = null;
                flowLayoutPanel1.Controls.Clear();
                label18.Text = null;
                label20.Text = null;
                label23.Text = null;
                label28.Text = null;
                txtQuanPiao.Text ="";
                txtBanPiao.Text ="";
                txtDaZhePiao.Text = "";
            }
        }

        private void txttuipiaoshouxifei_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumber(txttuipiaoshouxifei .Text.Trim()))//验证输入是否为数字
            { MessageBox.Show("只充许输入数字!!!", "提示"); txttuipiaoshouxifei.Text = ""; }//弹出消息对话框
                                                                           //   else { MessageBox.Show("输入信息正确!!!!!", "提示"); }//弹出消息对话框
        }
    }
}

