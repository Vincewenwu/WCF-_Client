using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 集团客运综合管理系统.调度管理
{
    public partial class 调度报班 : Form
    {
        public 调度报班()
        {
            InitializeComponent();
        }

        BLL集团客运综合管理.DispatchingManagement .DispatchingManagement.DispatchingmanagementClient   myDispatchingManagementClient
               = new BLL集团客运综合管理.DispatchingManagement.DispatchingManagement.DispatchingmanagementClient();
        ArrayList list = new ArrayList();
        DataTable dt;
        int FrequencyID1 = 0;
        DataTable xiwei;
        int tr = 0; int fa = 0;
        int SeatsStateID = 0;
        int SeatsxuanpiaoID = 0;
        string  SeatNoMC ;
        int a = 0;
        int 席位状态ID = 0;
        public static int 班次ID = 0;
        private void 坐位状态ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }
        private void Frm调度报班_Load(object sender, EventArgs e)
        {
            label13.Text = FRM_Login.用户名称;
            cbopiaojieleixing.DataSource = myDispatchingManagementClient.selectpiaojialeixing().Tables [0];
            cbopiaojieleixing.ValueMember = "TicketPriceTypeID";
            cbopiaojieleixing.DisplayMember = "TicketPriceTypeMC";
            int i = 0;
            DataTable dt = myDispatchingManagementClient.SelectFrequencyOnVehicleState().Tables[0];
            dgvFrequencyList.DataSource = dt;
            foreach (DataGridViewRow dgv in dgvFrequencyList.Rows)
            {
                i = i + 1;
                if (Convert .ToString (dgv.Cells["VehicleStateID"].Value)== "1")
                {
                    int z = i - 1;
                    dgvFrequencyList.Rows[z].DefaultCellStyle.BackColor = Color.Red;
                }continue;
            }
                DataTable dt1 = myDispatchingManagementClient.Selectjianpiaokou().Tables[0];
                cbojianpiaokou.DataSource = dt1;
                cbojianpiaokou.DisplayMember = "TicketEntranceMC";
                cbojianpiaokou.ValueMember = "TicketEntranceID";

                DataTable car = myDispatchingManagementClient.Selectcbocarbelong().Tables[0];
                cbocarbelongTo.DataSource = car;
                cbocarbelongTo.DisplayMember = "CarBelongToTheUnitMC";
                cbocarbelongTo.ValueMember = "CarBelongToTheUnitID";
        }

        private void toolbaobanchelaingxinxi_Click(object sender, EventArgs e)//报班车辆信息
        {
          
            label16.Visible = true;
            label16.Text = "报班车辆";
            dgvFrequencyList.Visible = false;
            dgvbaobancheliangxinxi.Visible = true;
            btnfanhui.Visible = true;
            string d = DateTime.Now.ToString();
            string 当前时间 = d.Remove(9);
            DateTime d1 = Convert.ToDateTime(d);
            int t1 = d1.Hour; 
            int t2 = d1.Minute;
            string DepartureTimef = t2.ToString();
            if (t1<10)
            {
               string  t11 = "0" + t1;
                string DepartureTimes = t11.ToString();
                DataTable dt = myDispatchingManagementClient.SelectBanCheLiangXinXi(DepartureTimes, DepartureTimef).Tables[0];
                dgvbaobancheliangxinxi.DataSource = dt;
            }else
            {
                string DepartureTimes = t1.ToString();
                DataTable dt = myDispatchingManagementClient.SelectBanCheLiangXinXi(DepartureTimes, DepartureTimef).Tables[0];
                dgvbaobancheliangxinxi.DataSource = dt;
            }
          
          
          
            if (dgvbaobancheliangxinxi.Rows.Count != 0)
            {
                MessageBox.Show("请开班");
            }
            else
            {
                MessageBox.Show("没有按规定时间到达的车辆");
            } 
        }
        private void btnfanhui_Click(object sender, EventArgs e)//返回键
        {
            dgvFrequencyList.Visible = true ;
            dgvbaobancheliangxinxi.Visible = false;
            btnfanhui.Visible = false ;
            btnkaiban.Visible = false;
            label16.Visible = false;
            btnxiugai.Visible = false;
            dgvxiugaijianpiaokou.Visible = false;
            btntingban.Visible = false;
            cbojianpiaokou.Visible = false;
            lajianpiaokou.Visible = false;
            btnpiaokou.Visible = false;
           // btnpiliangtingban.Visible = false;
            广播.Visible = false;
        }
        private void btndaibancheliangxinxi_Click(object sender, EventArgs e)//待班车辆信息
        {
            label16.Visible = true;
            label16.Text="待班车辆";
            dgvFrequencyList.Visible =false;
            dgvbaobancheliangxinxi.Visible =true;
            btnfanhui.Visible =true;
            DataTable dt=myDispatchingManagementClient.Selectdaibancheliangxinxi().Tables[0];
            dgvbaobancheliangxinxi.DataSource = dt;
        }

        private void btngenggaidaibancheliang_Click(object sender, EventArgs e)
        {

        }

        private void btnpiliangkaiban_Click(object sender, EventArgs e)//批量开班
        {
            label16.Visible = true;
            label16.Text = "批量开班";
            dgvFrequencyList.Visible = false;
            dgvbaobancheliangxinxi.Visible = true;
            btnfanhui.Visible = true;
            string d = DateTime.Now.ToString();
            string 当前时间 = d.Remove(9);
            DateTime d1 = Convert.ToDateTime(d);
            string  t1 = d1.Hour.ToString (); 
            string  t2 = d1.Minute.ToString();
         
            string DepartureTimef = t2.ToString();
            string t11 = t1.Length.ToString(); 
            if (t11=="1")
            {
                string t12 = "0" + t1;
                string DepartureTimes = t12.ToString();
                DataTable dt = myDispatchingManagementClient.SelectkaibanCheLiangXinXi(DepartureTimes, DepartureTimef).Tables[0];
                dgvbaobancheliangxinxi.DataSource = dt;
            }
            else
            {
                string DepartureTimes = t1.ToString();
                DataTable dt = myDispatchingManagementClient.SelectBanCheLiangXinXi(DepartureTimes, DepartureTimef).Tables[0];
                dgvbaobancheliangxinxi.DataSource = dt;
            }

            if (dgvbaobancheliangxinxi.Rows.Count == 0)
            {
                MessageBox.Show("没有报班信息");
            }
            else { btnkaiban.Visible = true; }

        }

        private void btnkaiban_Click(object sender, EventArgs e)//修改报班为开班
        {
                int myint = 0;
                foreach (DataGridViewRow dgv in dgvbaobancheliangxinxi.Rows)
                {
                    if (Convert.ToBoolean(dgv.Cells["选择班次"].Value) == true)
                    {
                        int VehicleID = Convert.ToInt32(dgv.Cells["VehicleID"].Value.ToString());
                        myint = myDispatchingManagementClient.UpdateVehicleStateOnFrequency(VehicleID);

                    }
                }
                if (myint > 0)
                { MessageBox.Show("开班成功"); }else { MessageBox.Show("开办不成功"); }
        }
        private void btnpiliangtingban_Click(object sender, EventArgs e)//批量停班
        {
           
        }
        private void btntingban_Click(object sender, EventArgs e)
        {
            int success = 0;
            int count = 0;
            count = count + 1; 
            foreach (DataGridViewRow dgv in dgvFrequencyList.Rows)
            {
                if (Convert.ToBoolean(dgv.Cells["选择"].Value) == true)
                {
                    int VehicleID = Convert.ToInt32(dgv.Cells["VehicleID1"].Value.ToString());
                    success += myDispatchingManagementClient.Updatecheliangitbgban(VehicleID);
                }
            }
            if (count ==success)
            {
                MessageBox.Show("停班成功");
                btntingban.Visible = false;
                DataTable dt = myDispatchingManagementClient.SelectFrequencyOnVehicleState().Tables[0];
                dgvFrequencyList.DataSource = dt;
            }
            else { MessageBox.Show("停班不成功");
                btnfanhui.Visible = true;
                btnfanhui_Click(null ,null );
            }

        }

        private void btndayingbaobandan_Click(object sender, EventArgs e)
        {
            调度管理.Frm报班调度报表 myFrm报班调度报表 = new Frm报班调度报表();
            myFrm报班调度报表.ShowDialog();
        }

        private void btngenggaijianpaiokou_Click(object sender, EventArgs e)//更改检票口
        {
            MessageBox.Show("请选择一行数据");
                btnxiugai.Visible = true;
        }

        private void btnxiugai_Click(object sender, EventArgs e)//修改检票口只识别第一个被选中的
        {

            foreach (DataGridViewRow dgv in dgvFrequencyList.Rows)
            {
                if (Convert.ToBoolean(dgv.Cells["选择"].Value) == true)
                {
                    tr = tr + 1;
                }
                if (Convert.ToBoolean(dgv.Cells["选择"].Value) == false)
                {
                    fa = fa + 1;
                }
            }
            if (tr == 1)
            {
                cbojianpiaokou.Visible = true;
                lajianpiaokou.Visible = true;
                btnpiaokou.Visible = true;

                foreach (DataGridViewRow dgv in dgvFrequencyList.Rows)
                {
                    if (Convert.ToBoolean(dgv.Cells["选择"].Value) == true)
                    {
                        btnfanhui.Visible = true;
                        dgvFrequencyList.Visible = false;
                        dgvxiugaijianpiaokou.Visible = true;
                        btnxiugai.Visible = false;
                        FrequencyID1 = Convert.ToInt32(dgvFrequencyList.CurrentRow.Cells["FrequencyID"].Value);
                        dt = myDispatchingManagementClient.SelectFrequencyOnjianpiaokou(FrequencyID1).Tables[0];
                        DataRow dr = dt.NewRow();
                        dr["CirculationDate"] = dgvFrequencyList.CurrentRow.Cells["发车日期"].Value;
                        dr["FrequencyMC"] = dgvFrequencyList.CurrentRow.Cells["班次"].Value;
                        dr["LineMC"] = dgvFrequencyList.CurrentRow.Cells["线路名称"].Value;
                        dr["VehiclePaiNumber"] = dgvFrequencyList.CurrentRow.Cells["线路名称"].Value;
                        dr["DepartureTime"] = dgvFrequencyList.CurrentRow.Cells["发车时间"].Value;
                        dr["endStaion"] = dgvFrequencyList.CurrentRow.Cells["终点站"].Value;
                        dr["VehicleStateMC"] = dgvFrequencyList.CurrentRow.Cells["车辆状态"].Value;
                        dr["TicketEntranceMC"] = dgvFrequencyList.CurrentRow.Cells["检票口"].Value;
                        dr["Seating"] = dgvFrequencyList.CurrentRow.Cells["座位数"].Value;
                        dt.Rows.Add(dr);
                    }
                }
                if (dt != null)
                {
                    dgvxiugaijianpiaokou.DataSource = dt.Copy();
                    dgvxiugaijianpiaokou.Rows.RemoveAt(1);
                }
                else { MessageBox.Show("请选择一行数据"); }
            }
            else
            {
                MessageBox.Show("请选择一行数据吧");

            }
        }
        private void btnpiaokou_Click(object sender, EventArgs e)//修改检票口
        {
            int TicketEntranceID =Convert .ToInt32 ( cbojianpiaokou.SelectedValue);
            int myint = myDispatchingManagementClient.UpdateJIanPiaoKou(FrequencyID1, TicketEntranceID);
            if (myint>0)
            {
                MessageBox.Show("修改成功");
                btnfanhui_Click(null,null);
                DataTable dt = myDispatchingManagementClient.SelectFrequencyOnVehicleState().Tables[0];
                dgvFrequencyList.DataSource = dt;
            }

        }

        private void dgvFrequencyList_CellClick(object sender, DataGridViewCellEventArgs e)//为车属单位赋值和显示座位信息
        {
            int FrequencyID2 = Convert.ToInt32(dgvFrequencyList.CurrentRow.Cells["FrequencyID"].Value);
            DataTable BELONG = myDispatchingManagementClient.SelectCarBeLong(FrequencyID2).Tables[0];
            label15.Text = BELONG.Rows[0][1].ToString();
           // txtyunshijian .Text   = dgvbaobancheliangxinxi.CurrentRow.Cells["发车时间1"].Value.ToString ();
            xiwei = new DataTable();
            if (flppicture .Controls.Count ==0)
            {
                xiwei = myDispatchingManagementClient.Selelctxiweizhaungtai(FrequencyID2).Tables[0];
                for (int i = 0; i < xiwei.Rows.Count; i++)
                {
                    PictureBox pb = new PictureBox();
                    pb.Size = new Size(30, 27);
                    pb.Tag = xiwei.Rows[i];
                     席位状态ID = (int)xiwei.Rows[i]["SeatsStateID"];
                    switch (席位状态ID)
                    {
                        case 1: pb.BackgroundImage = Properties.Resources.已售; break;
                        case 2: pb.BackgroundImage = Properties.Resources.待卖; break;
                        case 3: pb.BackgroundImage = Properties.Resources.报废; break;
                        case 4: pb.BackgroundImage = Properties.Resources.退票新;break;
                        case 7: pb.BackgroundImage = Properties.Resources.已检; break;
                        case 8: pb.BackgroundImage = Properties.Resources.留票; break;
                    }
                    pb.BackgroundImageLayout = ImageLayout.Stretch;
                    pb.Paint += new PaintEventHandler(pb_paint);
                    pb.MouseEnter += new EventHandler(pb_MouseEnter);
                    pb.MouseLeave += new EventHandler(pb_MouseLeave);
                    pb.MouseClick += new MouseEventHandler(pb_MouseClick);
                    flppicture.Controls.Add(pb);
                }
            }else
            {
                flppicture.Controls.Clear();
                xiwei = myDispatchingManagementClient.Selelctxiweizhaungtai(FrequencyID2).Tables[0];
                for (int i = 0; i < xiwei.Rows.Count; i++)
                {
                    PictureBox pb = new PictureBox();
                    pb.Size = new Size(30, 27);
                    pb.Tag = xiwei.Rows[i];
                     席位状态ID = (int)xiwei.Rows[i]["SeatsStateID"];
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
                    flppicture.Controls.Add(pb);
                }
            }
        }
        private void cbocarbelongTo_SelectionChangeCommitted(object sender, EventArgs e)//车属单位发生变化是给班次赋值
        {
             int CarBelongToTheUnitID = Convert.ToInt32(cbocarbelongTo.SelectedValue);
            DataTable dt = myDispatchingManagementClient.SelectBanCiOnDioaDuZhan(CarBelongToTheUnitID).Tables[0];
            cbobanci.DataSource = dt;
            cbobanci.ValueMember = "FrequencyID";
            cbobanci.DisplayMember = "FrequencyMC";
            txtcheliang.Text = "";
            txtendstaion.Text = "";
            txtchelaingzhuangtai.Text = "";
        }

        private void cbobanci_SelectionChangeCommitted(object sender, EventArgs e)//为车辆赋值
        {
            int FrequencyID = Convert.ToInt32(cbobanci.SelectedValue);
            DataTable dt = myDispatchingManagementClient.SelectCheLiangOnBanCi(FrequencyID).Tables[0];
            txtcheliang.Text = dt.Rows[0]["VehiclePaiNumber"].ToString();
          DataTable DT1= myDispatchingManagementClient .SelectdendsTaionOnFrequencyID(FrequencyID).Tables[0];
            txtendstaion .Text = DT1.Rows[0][0].ToString();
            DataTable DT2= myDispatchingManagementClient.Selectcheliangzhuangtai(FrequencyID).Tables[0];
            txtchelaingzhuangtai .Text = DT2.Rows[0][0].ToString();
            flppicture.Controls.Clear();
            dgvzhandianhepiaojia.DataSource = null;
        }

        private void btnchaxunpiaojia_Click(object sender, EventArgs e)//查询票价
        {
            if (flppicture.Controls .Count ==0)
            {try
                {
                    int FrequencyID = Convert.ToInt32(cbobanci.SelectedValue);
                    DataTable dt = myDispatchingManagementClient.Selectdiyigezhandian(FrequencyID).Tables[0];
                    int StationID1 = Convert.ToInt32(dt.Rows[0][2]);
                    DataTable MYDT = myDispatchingManagementClient.Selectzhandianpiaojia(FrequencyID, StationID1).Tables[0];
                    dgvzhandianhepiaojia.DataSource = MYDT;
                    if (dgvzhandianhepiaojia.Rows.Count > 0)
                    { }
                    else
                    {
                        MessageBox.Show("没有该数据");
                    }
                    xiwei = new DataTable();
                    xiwei = myDispatchingManagementClient.Selelctxiweizhaungtai(FrequencyID).Tables[0];
                    for (int i = 0; i < xiwei.Rows.Count; i++)
                    {
                        PictureBox pb = new PictureBox();
                        pb.Size = new Size(30, 27);
                        pb.Tag = xiwei.Rows[i];
                         席位状态ID = (int)xiwei.Rows[i]["SeatsStateID"];
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
                        flppicture.Controls.Add(pb);
                    }
                }catch { MessageBox.Show("请选择右上角的选项");}
               
            }else
            { 
                    MessageBox.Show("已经有数据啦");
            }
                
        }
        #region 车辆图片点击事件
        void pb_MouseClick(object sender, MouseEventArgs e)
        {
            cbopiaojieleixing.Visible = true;
            PictureBox pb = sender as PictureBox;//将sender转换成PictureBox
            DataRow dr = (DataRow)pb.Tag;//获取pb绑定的数据行
            SeatsStateID = Convert.ToInt32(dr["SeatsStateID"]);
            SeatsxuanpiaoID = Convert.ToInt32(dr["SeatsID"]);
            SeatNoMC = dr["SeatNoMC"].ToString();
            foreach (Control c in flppicture.Controls)//遍历flp中的控件(flp中的PictureBox)
            {
                PictureBox pbc = c as PictureBox;
                DataRow drc = (DataRow)pbc.Tag;
                if (drc["SeatNoMC"].ToString() != SeatNoMC.ToString())
                //判断每个PictureBox的配载发车单ID是否跟当前点击的PictureBox的配载发车单ID相等，
                //若不等则清除边框
                {
                    Pen pen = new Pen(flppicture.BackColor, 4);
                    Graphics g = flppicture.CreateGraphics();
                    Rectangle 矩形 = new Rectangle();
                    矩形.X = pbc.Location.X - 1;
                    矩形.Y = pbc.Location.Y - 1;
                    矩形.Width = pbc.Size.Width + 4;
                    矩形.Height = pbc.Size.Height + 4;
                    g.DrawRectangle(pen, 矩形);
                }
            }
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
                    Pen pen = new Pen(flppicture.BackColor, 4);
                    Graphics g = flppicture.CreateGraphics();
                    Rectangle 矩形 = new Rectangle();
                    矩形.X = pb.Location.X - 2;
                    矩形.Y = pb.Location.Y - 2;
                    矩形.Width = pb.Size.Width + 4;
                    矩形.Height = pb.Size.Height + 4;
                    g.DrawRectangle(pen, 矩形);
                }
            }
            else
            {
                PictureBox pb = sender as PictureBox;
                DataRow dr = (DataRow)pb.Tag;
                string SeatNoMC1 = 1.ToString();
                if (dr["SeatNoMC"].ToString() != SeatNoMC1.ToString())
                {
                    pb.Cursor = Cursors.Hand;
                    Pen pen = new Pen(flppicture.BackColor, 4);
                    Graphics g = flppicture.CreateGraphics();
                    Rectangle 矩形 = new Rectangle();
                    矩形.X = pb.Location.X - 2;
                    矩形.Y = pb.Location.Y - 2;
                    矩形.Width = pb.Size.Width + 4;
                    矩形.Height = pb.Size.Height + 4;
                    g.DrawRectangle(pen, 矩形);
                }
            }

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
            PointF 字符串坐标 = new PointF(15, 1);
            g.DrawString(司机名称, 字体样式, SystemBrushes.ActiveCaptionText, 字符串坐标);
        }
        #endregion
        #region 鼠标点击车辆图片事件
        void pb_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.Cursor = Cursors.Hand;
            Pen pen = new Pen(Color.Red, 4);
            Graphics g = flppicture.CreateGraphics();
            Rectangle 矩形 = new Rectangle();
            矩形.X = pb.Location.X - 2;
            矩形.Y = pb.Location.Y - 2;
            矩形.Width = pb.Size.Width + 4;
            矩形.Height = pb.Size.Height + 4;
            g.DrawRectangle(pen, 矩形);
        }
        #endregion
        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (dgvbaobancheliangxinxi.Rows.Count > 0)
            {
                if (txtyunshijian.Text != null || txtxinshijian.Text != null)
                {
                    int FrequencyID = Convert.ToInt32(dgvbaobancheliangxinxi.CurrentRow.Cells["FrequencyIDU"].Value);
                    string DepartureTime = txtxinshijian.Text;
                    int myint = myDispatchingManagementClient.updatetime(FrequencyID, DepartureTime);
                    if (myint > 0)
                    {
                        MessageBox.Show("修改成功");
                        toolbaobanchelaingxinxi_Click(null, null);
                    }

                    else
                    {
                        MessageBox.Show("没有车辆选择");
                    }
                }
                else
                {
                    MessageBox.Show("请选择对应的时间");
                }
            }
        }
        private void dgvbaobancheliangxinxi_CellClick(object sender, DataGridViewCellEventArgs e)
        {try
            {
                txtyunshijian.Text = dgvbaobancheliangxinxi.CurrentRow.Cells["DepartureTime"].Value.ToString();
                DataTable dtt = myDispatchingManagementClient.Selectpiaojiazuidariqi().Tables[0];
           //     labzuidariqi.Text = dtt.Rows[0][0].ToString();
                dgvFrequencyList_CellClick(null, null);
            }catch { MessageBox.Show("别乱按"); }
          
        }

        private void btnliuwei_Click(object sender, EventArgs e)
        {
         if (SeatsStateID == 2)
        { 
               DataTable dttt = myDispatchingManagementClient .Selectzuidapiohaodiaodu().Tables[0];
            if (dttt.Rows.Count == 0)
            {
                a = 0;
            }
            else
            {
                a = dttt.Rows.Count;
            }
            string d = DateTime.Now.ToString();
            string shijian = DateTime.Now.ToShortTimeString();
            //  int CreateUserID = 1;
            //  int DeleteUserID = 1;
            // string TicketMark = Convert.ToString(a + 1);
            //  DateTime TicketingDate = Convert.ToDateTime(d.Remove(9));
            //DateTime TicketingDateTime = Convert.ToDateTime(shijian);
            // DateTime CreateTime = Convert.ToDateTime(DateTime.Now.ToString());
            int SeatsID = SeatsxuanpiaoID;
            // int TicketPriceTypeID =Convert .ToInt32 ( cbopiaojieleixing.SelectedValue);
            int  i= myDispatchingManagementClient .Updatexiweizhaungtaiweibaofeidiaodu(SeatsID);
            //  int FrequencyID2 = Convert.ToInt32(dgvFrequencyList.CurrentRow.Cells["FrequencyID"].Value);
         //   int  z= myDispatchingManagementClient .Insectdingpiaoxinxidiaodu(FrequencyID2, SeatsID, CreateUserID, DeleteUserID, TicketMark, TicketingDate, TicketingDateTime, CreateTime, TicketPriceTypeID);
            if (i>0)
            {  
                MessageBox.Show("留票成功");
            }
            }else 
            { MessageBox.Show("请选择空的席位"); }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           // toolbaobanchelaingxinxi_Click(null,null );
        }
        private void 广播催客ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnkaiban.Visible = false;
            label16.Visible = true;
            label16.Text = "广播催客";
            广播.Visible = true;
            dgvFrequencyList.Visible = false;
            dgvbaobancheliangxinxi.Visible = true;
            btnfanhui.Visible = true;
            string d = DateTime.Now.ToString();
            string 当前时间 = d.Remove(9);
            DateTime d1 = Convert.ToDateTime(d);
            string t1 = d1.Hour.ToString();
            string t2 = d1.Minute.ToString();

            string DepartureTimef = t2.ToString();
            string t11 = t1.Length.ToString();
            if (t11 == "1")
            {
                string t12 = "0" + t1;
                string DepartureTimes = t12.ToString();
                DataTable dt = myDispatchingManagementClient.SelectkaibanCheLiangXinXi(DepartureTimes, DepartureTimef).Tables[0];
                dgvbaobancheliangxinxi.DataSource = dt;
            }
            else
            {
                string DepartureTimes = t1.ToString();
                DataTable dt = myDispatchingManagementClient.SelectBanCheLiangXinXi(DepartureTimes, DepartureTimef).Tables[0];
                dgvbaobancheliangxinxi.DataSource = dt;
            }
            if (dgvbaobancheliangxinxi.Rows.Count != 0)
            { }
            else {
                MessageBox.Show("暂时没有可车辆用于现在的广播催客功能");
            }
        }
        private void 班次催客ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvbaobancheliangxinxi.Rows.Count != 0)
            {
                foreach (DataGridViewRow dgv in dgvbaobancheliangxinxi.Rows)
                {
                    if (Convert.ToBoolean(dgv.Cells["选择班次"].Value) == true)
                    {
                        班次ID = Convert.ToInt32(dgv.Cells["FrequencyIDU"].Value);
                        Frm班次催客 myFrm班次催客 = new Frm班次催客();
                        myFrm班次催客.ShowDialog();
                    }
                    continue;
                }
            }
            else
            { MessageBox.Show("没有对应的数据"); }
        }

        private void btnpiliangtingban_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("请选择车辆");
            btntingban.Visible = true;
            btnfanhui.Visible = true;
        }

        private void 报班表导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void flppicture_Click(object sender, EventArgs e)
        {
          //  cbopiaojieleixing.Visible = true;
        }

        private void flppicture_MouseLeave(object sender, EventArgs e)
        {
           // cbopiaojieleixing.Visible = false;
        }

        private void groupBox5_DragLeave(object sender, EventArgs e)
        {
           
        }

        private void btndingpiao(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Frm订票窗口 my = new Frm订票窗口();
            my.ShowDialog();
        }
    }
}
