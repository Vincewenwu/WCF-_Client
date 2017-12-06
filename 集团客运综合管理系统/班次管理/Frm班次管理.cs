using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 集团客运综合管理系统.业务窗口
{
    public partial class Frm班次管理 : Form
    {
        public Frm班次管理()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.FrequencyManager.FrequencyListManager.FrequencyListManagerClient myFrequencyListManagerClient
             = new BLL集团客运综合管理.FrequencyManager.FrequencyListManager.FrequencyListManagerClient();
        public static int  FrequencyID;
        public static int i;
        public static AutoCompleteStringCollection fCollectionZhanDian;
        int LineID = 0;
        DataTable satation;
        int YeShu=1;
        int zuidayema=0;
        int YeMa=10;
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
            foreach (Control txtControl in this .Controls)
            {
                if (txtControl.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    (txtControl as TextBox).ImeMode = ImeMode.KatakanaHalf;
                    (txtControl as TextBox).AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    (txtControl as TextBox).AutoCompleteSource = AutoCompleteSource.CustomSource;
                    (txtControl as TextBox).AutoCompleteCustomSource = fCollectionZhanDian;
                }
            }
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
            mydt = myFrequencyListManagerClient .selectbancimingcheng().Tables[0];
            dsPublic.Tables.Add(mydt.Copy());
            dsPublic.Tables[0].TableName = "FrequencyMC";
            //添加 "站点"表的数据到AutoCompleteStringCollection对象“fCollectionZhanDian”（站点）集合中
            foreach (DataRow dr in mydt.Rows)
            {
                fCollectionZhanDian.Add(dr["FrequencyMC"].ToString().Trim());
                //如果把数据直接追加到   txtZhanDian的AutoCompleteCustomSource中速度就很慢。 
                // txtZhanDian.AutoCompleteCustomSource.Add(dr["站点MC1"].ToString().Trim());

            }
        }
        private void btnxinzengbanci_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Frm新增班次窗口 myFrm新增班次窗口 = new Frm新增班次窗口();
            myFrm新增班次窗口.ShowDialog();
           
          
        }

        private void btnxiugaibanci_Click(object sender, EventArgs e)
        {
            if (dgvFrequencyInfornation .Rows .Count !=0)
            {
                FrequencyID = Convert.ToInt32(dgvFrequencyInfornation.CurrentRow.Cells["FrequencyIDD"].Value);
                if (FrequencyID != 0)
                {
                    this.Visible = false;
                    Frm修改班次窗口 myFrm修改班次窗口 = new Frm修改班次窗口();
                    myFrm修改班次窗口.ShowDialog();
                }
            }else { MessageBox.Show("请新增班次"); }
              }

        private void btnbancigudingyuliu_Click(object sender, EventArgs e)
        {
            Frm添加班次固定预留窗口 myFrm添加班次固定预留窗口 = new Frm添加班次固定预留窗口();
               myFrm添加班次固定预留窗口.ShowDialog();
        }

        private void btnbancichangting_Click(object sender, EventArgs e)
        {
             Frm班次长停窗口 myFrm班次长停窗口 = new Frm班次长停窗口();
              myFrm班次长停窗口.ShowDialog();
        }

        private void Frm班次管理_Load(object sender, EventArgs e)//显示所有车辆
        {       
            DataTable selectbanbiao = myFrequencyListManagerClient.selectbanbiao().Tables[0];
            mCreatePublicDatasetAndCollection();
            AutoCompleteControl();
            DataTable dtFrequency = myFrequencyListManagerClient.SelectFrequency(YeShu, YeMa).Tables[0];
            dgvFrequencyInfornation.DataSource = dtFrequency;
            DataTable dt = myFrequencyListManagerClient.selectzhongshu().Tables[0];
            int zuidashu = dt.Rows.Count;
             zuidayema = zuidashu/YeMa;
            if (zuidashu%YeMa>0)
            {
                zuidayema= zuidayema+1;
            }
            lbzuidayema.Text = zuidayema.ToString();
            lbdangqianyema.Text = YeShu.ToString();
            foreach (DataGridViewRow dgv in dgvFrequencyInfornation.Rows )
            {
                string riqi = dgv.Cells["CirculationDate"].Value.ToString ();
                string I = DateTime.Now.ToShortDateString();
                string Z = I.Remove(0);
                if (riqi != I)
                {
                    string CirculationDate = DateTime.Now.ToShortDateString();
                    int my = myFrequencyListManagerClient.UpdateallFrequency(CirculationDate);
                    if (my > 0)
                    {
                        MessageBox.Show("今天班次日期已经更新");
                        dgvFrequencyInfornation.DataSource = dtFrequency.Copy();
                        
                    }
                    break;
                }
                else { MessageBox.Show("已是最新日期"); }
                break;

            }
          DataTable yonghu=myFrequencyListManagerClient.selectyonghuandleixing(FRM_Login .dengluyonghuID).Tables[0];
            label3.Text = yonghu.Rows[0]["UserMC"].ToString ();
            label7.Text = yonghu.Rows[0]["UserTypeMC"].ToString();
        }

        private void btndeleteFrequency_Click(object sender, EventArgs e)//删除班次
        {
            if (dgvFrequencyInfornation .Rows .Count !=0)
            {
                FrequencyID = Convert.ToInt32(dgvFrequencyInfornation.CurrentRow.Cells["FrequencyIDD"].Value);
                int myint = myFrequencyListManagerClient.UPDATErequency(FrequencyID);
                if (MessageBox.Show("是否删除", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (myint > 0)
                    {
                        MessageBox.Show("删除成功啦");
                        SYS_PublicStaticClass.PublicStaticObject.Frm班次管理 = new Frm班次管理();
                        SYS_PublicStaticClass.PublicStaticObject.Frm班次管理.ShowDialog();

                    }
                }
                else
                {
                    MessageBox.Show("你已取消删除");
                }

            }
            else
            {
                MessageBox.Show("没有可以删除的班次");
            }


        }
        private void dgvVehicleInfornation_CellClick(object sender, DataGridViewCellEventArgs e)//点击显示该车辆对应的停靠点
        {

            FrequencyID = Convert.ToInt32(dgvVehicleInfornation.CurrentRow.Cells["FrequencyIDDD"].Value);
            DataTable dt1 = myFrequencyListManagerClient.SelectBelong(FrequencyID).Tables[0];//查询车辆所属单位
            laCarBelongToTheUnitMC.Text = dt1.Rows[0]["CarBelongToTheUnitMC"].ToString();
            DataTable satation = myFrequencyListManagerClient.SelectTuJinnewStaion(FrequencyID).Tables[0];
            dgvStopsinroute.DataSource = satation;

            satation = myFrequencyListManagerClient.SelectTuJinnewStaion(FrequencyID).Tables[0];
            dataGridView3.DataSource = satation;
        }

        private void btnnewtujinstaion_Click(object sender, EventArgs e)//增加途径站
        {
            //if (BIT == 2)
            //    {
                    if (dgvStopsinroute.Rows.Count == 0)
                    {
                        i = 0;
                        SYS_PublicStaticClass.PublicStaticObject.Frm添加途径站点 = new 班次管理.Frm添加途径站点();
                        SYS_PublicStaticClass.PublicStaticObject.Frm添加途径站点.ShowDialog();
                    }
                    else
                    {
                        i = 1;
                        SYS_PublicStaticClass.PublicStaticObject.Frm添加途径站点 = new 班次管理.Frm添加途径站点();
                        SYS_PublicStaticClass.PublicStaticObject.Frm添加途径站点.ShowDialog();
                    }
                //}
                //else
                //{
                //    foreach (DataGridViewRow dgvr in dataGridView3.Rows)
                //    {
                //        int StaionID = Convert.ToInt32(dgvr.Cells["StaionIDD"].Value.ToString());
                //        int CreateUserID = 1;
                //        int DeleteUserID = 1;
                //        string StopsinrouteMC = dgvr.Cells["StopsinrouteMCC"].Value.ToString();
                //        int Standingorder = Convert.ToInt32(dgvr.Cells["StandingorderR"].Value.ToString());
                //        string StationNunber = dgvr.Cells["StationNunberR"].Value.ToString();
                //        bool Whetherdock = Convert.ToBoolean(dgvr.Cells["Whetherdockk"].Value);
                //        DateTime CreateTime = Convert.ToDateTime(DateTime.Now.ToString());
                //        int2 = myFrequencyListManagerClient.IntsertStopsinroute(FrequencyID, StaionID, CreateUserID, DeleteUserID,
                //                                           StopsinrouteMC, Standingorder, StationNunber, Whetherdock, CreateTime);
                //    }
                //    if (int2 == 1)
                //{    
                //    DataTable dt = myFrequencyListManagerClient.SelectagainUpdatetujinStation(FrequencyID).Tables[0];
                //    dataGridView4.DataSource = dt;
                //    foreach (DataGridViewRow dgvr4 in dataGridView4.Rows)
                //        {
                //            int StaionID = Convert.ToInt32(dgvr4.Cells["StaionID4"].Value.ToString());
                //            int CreateUserID = 1;
                //            int DeleteUserID = 1;
                //            string StopsinrouteMC =dgvr4.Cells["StopsinrouteMC4"].Value.ToString();
                //            int Standingorder = Convert.ToInt32(dgvr4.Cells["Standingorder4"].Value.ToString());
                //            string StationNunber = dgvr4.Cells["StationNunber4"].Value.ToString();
                //            bool Whetherdock = Convert.ToBoolean(dgvr4.Cells["Whetherdock4"].Value.ToString());
                //            DateTime CreateTime = Convert.ToDateTime(DateTime.Now.ToString().ToString());
                //            int StopsinrouteID = Convert.ToInt32(dgvr4.Cells["StopsinrouteID4"].Value.ToString());
                //        int kilometer = 0;
                //            myin = myFrequencyListManagerClient.UpdateTuJinStation(FrequencyID, StaionID, CreateUserID, DeleteUserID, StopsinrouteMC,
                //                                     Standingorder, StationNunber, Whetherdock, CreateTime, StopsinrouteID, kilometer);

                //        } if (myin == 1)
                //        {
                //            MessageBox.Show("复制途径站点成功");
                //        }
                //    }
                //    else
                //    {
                //        MessageBox.Show("复制途径站点失败");
                //    }
                //}
        }
        private void dgvFrequencyInfornation_CellClick(object sender, DataGridViewCellEventArgs e)//点击显示车辆和站点信息
        {
            LineID = Convert.ToInt32(dgvFrequencyInfornation.CurrentRow.Cells["LineIDD"].Value);
            DataTable dt = myFrequencyListManagerClient.SelectOnFrequencyID(LineID).Tables[0];
            dgvVehicleInfornation.DataSource = dt;
            dgvStopsinroute.DataSource =null ;
            dgvInsectTickec.DataSource = null;
       try
            {
                FrequencyID = Convert.ToInt32(dgvVehicleInfornation.CurrentRow.Cells["FrequencyIDDD"].Value);
                DataTable dt1 = myFrequencyListManagerClient.SelectBelong(FrequencyID).Tables[0];//查询车辆所属单位
                laCarBelongToTheUnitMC.Text = dt1.Rows[0]["CarBelongToTheUnitMC"].ToString();
                satation = myFrequencyListManagerClient.SelectTuJinnewStaion(FrequencyID).Tables[0];
                dataGridView3.DataSource = satation;
            }
            catch { MessageBox.Show("请选择别的车辆"); }   
        }
        private void tsbShangYiYe_Click(object sender, EventArgs e)//上一页
        {
            if (YeShu > 1)
            {
                YeShu--;
                DataTable dtFenYe = myFrequencyListManagerClient .SelectFrequency(YeShu, YeMa).Tables[0];
                dgvFrequencyInfornation.DataSource = dtFenYe;
                lbdangqianyema.Text = YeShu.ToString();
               // SheZhiSuoDingAnNiu();
            }
            else
            {
                MessageBox.Show("已经是首页!!!");
            }
        }

        private void tsbXiaYiYe_Click(object sender, EventArgs e)//下一页
        {
            if (YeShu <  zuidayema)
            {
                YeShu++;
                DataTable dtFenYe = myFrequencyListManagerClient.SelectFrequency(YeShu, YeMa).Tables[0];
                dgvFrequencyInfornation.DataSource = dtFenYe;
                lbdangqianyema.Text = YeShu.ToString();
               // SheZhiSuoDingAnNiu();
            }
            else
            {
                MessageBox.Show("已经是尾页!!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStopsinroute.Rows.Count != 0)
            {
                SYS_PublicStaticClass.PublicStaticObject.Frm修改途径站窗口 = new 班次管理.Frm修改途径站窗口();
                SYS_PublicStaticClass.PublicStaticObject.Frm修改途径站窗口.ShowDialog();
            }
            else
            {
                MessageBox.Show("请新增途径站点");
            }


            
        }

        private void dgvStopsinroute_CellClick(object sender, DataGridViewCellEventArgs e)//显示与计算有关票价信息
        {try {
                int StartingStationID = Convert.ToInt32(dgvStopsinroute.Rows[e.RowIndex].Cells["StaionID"].Value);
                DataTable dt = myFrequencyListManagerClient.SelectStationtickprice(FrequencyID, StartingStationID).Tables[0];
                dgvInsectTickec.DataSource = dt;
            }
            catch { MessageBox.Show("点击出错"); }
               
        }
        private void InsectTicketPrice_Click(object sender, EventArgs e)//添加票价,3个foreach组合他们的票价条件,如果重新生成票会把之前的删掉，再录入，同时会修改车辆状态
        {
            int myii = myFrequencyListManagerClient.DeleteTicketPriceOnFrequencyID(FrequencyID);
            if (myii ==0)
            {
                #region            
                int CountSuccess = 0;
                //DataTable SelectSeatType = myFrequencyListManagerClient.SelectSeatTypeID().Tables[0];
                //dataGridView1.DataSource = SelectSeatType;
                //foreach (DataGridViewRow dgvr in dataGridView1.Rows)
                //{
                int SeatsTypeID = 2;//默认坐的

                    DataTable TicketPriceTypeID1 = myFrequencyListManagerClient.SelectTicketPriceTypeID().Tables[0];
                    dataGridView2.DataSource = TicketPriceTypeID1;
                    foreach (DataGridViewRow dgvr1 in dataGridView2.Rows)
                    {         
                        int TicketPriceTypeID = Convert.ToInt32(dgvr1.Cells["TicketPriceTypeID"].Value);
                        DataTable dt = myFrequencyListManagerClient.selecttujinzhandian(FrequencyID).Tables[0];
                        dgvInsectTickec.DataSource = dt;
                        foreach (DataGridViewRow dgv in dgvInsectTickec.Rows)
                        { 
                                decimal TicketPrice = 0;
                                int StartingStationID = Convert.ToInt32(dgv.Cells["starstationID"].Value);
                                int TerminalStationID = Convert.ToInt32(dgv.Cells["endstationID"].Value);

                                int CreateUserID = 1;
                                int DeleteUserID = 1;
                                int starKM = Convert.ToInt32(dgv.Cells["starKM"].Value);
                                int endKM = Convert.ToInt32(dgv.Cells["endKM"].Value);
                                int KM1 = endKM - starKM;
                                int KM = Math.Abs(KM1);//转变为绝对值
                                DateTime CreateTime = Convert.ToDateTime(DateTime.Now.ToString());

                                if (TicketPriceTypeID == 1)
                                {
                                        #region          
                                        if (KM == 0)
                                        {
                                            TicketPrice = 0;
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice / 10;

                                        }
                                        else { }
                                        if (0 < KM && KM < 100)
                                        {
                                            TicketPrice = Convert.ToDecimal(KM * 0.05861);
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice / 10;
                                            TicketPrice = TicketPrice + Convert.ToDecimal(200 * 0.05861);

                                        }
                                        else { }
                                        if (100 <= KM && KM < 300)
                                        {
                                            TicketPrice = Convert.ToDecimal(200 * 0.05861);
                                            KM = KM - 200;
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.052749);
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice / 10;//到这里是变动价格
                                            TicketPrice = TicketPrice + Convert.ToDecimal(200 * 0.05861);//再重新加回来原来的基础价格
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.052749);

                                        }
                                        else { }
                                        if (300 <= KM && KM < 500)
                                        {
                                            TicketPrice = Convert.ToDecimal(200 * 0.05861);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(500 * 0.052749);
                                            KM = KM - 500;
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.046888);
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice / 10;
                                            TicketPrice = TicketPrice + Convert.ToDecimal(200 * 0.05861);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(500 * 0.052749);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.046888);
                                        }
                                        else { }
                                        if (500 <= KM && KM < 1000)
                                        {
                                            TicketPrice = Convert.ToDecimal(200 * 0.05861);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(500 * 0.052749);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(1000 * 0.046888);
                                            KM = KM - 1000;
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.041027);
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice / 10;
                                            TicketPrice = TicketPrice + Convert.ToDecimal(200 * 0.05861);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(500 * 0.052749);
                                            TicketPrice = TicketPrice + TicketPrice + Convert.ToDecimal(1000 * 0.046888);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.041027);
                                        }
                                        else { }
                                        if (1000 <= KM && KM < 1500)
                                        {
                                            TicketPrice = Convert.ToDecimal(200 * 0.05861);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(500 * 0.052749);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(1000 * 0.046888);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(1500 * 0.041027);
                                            KM = KM - 1500;
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.035166);
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice / 10;
                                            TicketPrice = TicketPrice + Convert.ToDecimal(200 * 0.05861);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(500 * 0.052749);
                                            TicketPrice = TicketPrice + TicketPrice + Convert.ToDecimal(1000 * 0.046888);
                                            TicketPrice = TicketPrice + TicketPrice + Convert.ToDecimal(1500 * 0.041027);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.035166);
                                        }
                                        else { }
                                        if (KM > 1500)
                                        {
                                            TicketPrice = Convert.ToDecimal(KM * 0.029305);
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice / 10;
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.029305);
                                        }
                                        else { }
                                        #endregion
                                }
                                else
                                {}
                                if (TicketPriceTypeID == 3)
                                {
                                    TicketPrice = 0;
                                }
                                else
                                { }
                                if (TicketPriceTypeID == 2)
                                {
                                        #region          
                                        if (KM == 0)
                                        {
                                            TicketPrice = 0;
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice / 10;
                                            TicketPrice = TicketPrice / 2;

                                        }
                                        else { }
                                        if (0 < KM && KM < 100)
                                        {
                                            TicketPrice = Convert.ToDecimal(KM * 0.05861);
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice / 10;
                                            TicketPrice = TicketPrice / 2;
                                            TicketPrice = TicketPrice + Convert.ToDecimal(200 * 0.05861);

                                        }
                                        else { }
                                        if (100 <= KM && KM < 300)
                                        {
                                            TicketPrice = Convert.ToDecimal(200 * 0.05861);
                                            KM = KM - 200;
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.052749);
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice / 10;//到这里是变动价格
                                            TicketPrice = TicketPrice / 2;
                                            TicketPrice = TicketPrice + Convert.ToDecimal(200 * 0.05861);//再重新加回来原来的基础价格
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.052749);

                                        }
                                        else { }
                                        if (300 <= KM && KM < 500)
                                        {
                                            TicketPrice = Convert.ToDecimal(200 * 0.05861);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(500 * 0.052749);
                                            KM = KM - 500;
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.046888);
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice / 10;
                                            TicketPrice = TicketPrice / 2;
                                            TicketPrice = TicketPrice + Convert.ToDecimal(200 * 0.05861);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(500 * 0.052749);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.046888);
                                        }
                                        else { }
                                        if (500 <= KM && KM < 1000)
                                        {
                                            TicketPrice = Convert.ToDecimal(200 * 0.05861);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(500 * 0.052749);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(1000 * 0.046888);
                                            KM = KM - 1000;
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.041027);
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice / 10;
                                            TicketPrice = TicketPrice / 2;
                                            TicketPrice = TicketPrice + Convert.ToDecimal(200 * 0.05861);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(500 * 0.052749);
                                            TicketPrice = TicketPrice + TicketPrice + Convert.ToDecimal(1000 * 0.046888);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.041027);
                                        }
                                        else { }
                                        if (1000 <= KM && KM < 1500)
                                        {
                                            TicketPrice = Convert.ToDecimal(200 * 0.05861);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(500 * 0.052749);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(1000 * 0.046888);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(1500 * 0.041027);
                                            KM = KM - 1500;
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.035166);
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice / 10;
                                            TicketPrice = TicketPrice / 2;
                                            TicketPrice = TicketPrice + Convert.ToDecimal(200 * 0.05861);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(500 * 0.052749);
                                            TicketPrice = TicketPrice + TicketPrice + Convert.ToDecimal(1000 * 0.046888);
                                            TicketPrice = TicketPrice + TicketPrice + Convert.ToDecimal(1500 * 0.041027);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.035166);
                                        }
                                        else { }
                                        if (KM > 1500)
                                        {
                                            TicketPrice = Convert.ToDecimal(KM * 0.029305);
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice / 10;
                                            TicketPrice = TicketPrice / 2;
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.029305);
                                        }
                                      
                                        #endregion
                                }
                                else { }
                                if (TicketPriceTypeID == 4)
                                {
                                        #region          
                                        if (KM == 0)
                                        {
                                            TicketPrice = 0;
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice / 10;
                                            TicketPrice = TicketPrice / Convert.ToDecimal(1.2);
                                        }
                                        else { }
                                        if (0 < KM && KM < 100)
                                        {
                                            TicketPrice = Convert.ToDecimal(KM * 0.05861);
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice / 10;
                                            TicketPrice = TicketPrice / Convert.ToDecimal(1.2);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(200 * 0.05861);

                                        }
                                        else { }
                                        if (100 <= KM && KM < 300)
                                        {
                                            TicketPrice = Convert.ToDecimal(200 * 0.05861);
                                            KM = KM - 200;
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.052749);
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice / 10;//到这里是变动价格
                                            TicketPrice = TicketPrice / Convert.ToDecimal(1.2);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(200 * 0.05861);//再重新加回来原来的基础价格
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.052749);

                                        }
                                        else { }
                                        if (300 <= KM && KM < 500)
                                        {
                                            TicketPrice = Convert.ToDecimal(200 * 0.05861);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(500 * 0.052749);
                                            KM = KM - 500;
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.046888);
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice / 10;
                                            TicketPrice = TicketPrice / Convert.ToDecimal(1.2);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(200 * 0.05861);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(500 * 0.052749);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.046888);
                                        }
                                        else { }
                                        if (500 <= KM && KM < 1000)
                                        {
                                            TicketPrice = Convert.ToDecimal(200 * 0.05861);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(500 * 0.052749);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(1000 * 0.046888);
                                            KM = KM - 1000;
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.041027);
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice / 10;
                                            TicketPrice = TicketPrice / Convert.ToDecimal(1.2);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(200 * 0.05861);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(500 * 0.052749);
                                            TicketPrice = TicketPrice + TicketPrice + Convert.ToDecimal(1000 * 0.046888);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.041027);
                                        }
                                        else { }
                                        if (1000 <= KM && KM < 1500)
                                        {
                                            TicketPrice = Convert.ToDecimal(200 * 0.05861);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(500 * 0.052749);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(1000 * 0.046888);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(1500 * 0.041027);
                                            KM = KM - 1500;
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.035166);
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice / 10;
                                            TicketPrice = TicketPrice / Convert.ToDecimal(1.2);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(200 * 0.05861);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(500 * 0.052749);
                                            TicketPrice = TicketPrice + TicketPrice + Convert.ToDecimal(1000 * 0.046888);
                                            TicketPrice = TicketPrice + TicketPrice + Convert.ToDecimal(1500 * 0.041027);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.035166);
                                        }
                                        else { }
                                        if (KM > 1500)
                                        {
                                            TicketPrice = Convert.ToDecimal(KM * 0.029305);
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice * 2;
                                            TicketPrice = TicketPrice / 10;
                                            TicketPrice = TicketPrice / Convert.ToDecimal(1.2);
                                            TicketPrice = TicketPrice + Convert.ToDecimal(KM * 0.029305);
                                        }
                                        else { }
                                        #endregion
                                }
                                else { }
                                CountSuccess += myFrequencyListManagerClient.InsectCaculateprice(FrequencyID, StartingStationID, TerminalStationID, SeatsTypeID,
                                                                                      TicketPriceTypeID, CreateUserID, DeleteUserID, TicketPrice, CreateTime);
                            
                       // }
                    }
                }
                if (CountSuccess > 0)//CountSuccess == CountMingXi &&
                {
                  
                     MessageBox.Show("success"); 
                }
                else
                {
                    MessageBox.Show("bit");
                }
                #endregion
            }
            else
            {
                MessageBox.Show("删除数据失败");
            }


        }

        private void btnshanchushuju_Click(object sender, EventArgs e)
        {
            
          }

        private void button30_Click(object sender, EventArgs e)//删除该班次对应的车辆信息，同时修改状态
        {
            if (dgvInsectTickec.Rows.Count != 0)
            {
                int myii = myFrequencyListManagerClient.DeleteTicketPriceOnFrequencyID(FrequencyID);
                if (myii > 0)
                {
                    DataTable dtt = myFrequencyListManagerClient.SeleectFrequencyIDtoVehicleID(FrequencyID).Tables[0];
                    int VehicleID = Convert.ToInt32(dtt.Rows[0]["VehicleID"]);
                    int myint = myFrequencyListManagerClient.UpdateVehicleStateOnFrequencyID(VehicleID);
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            else
            {
                MessageBox.Show("没有改站点对应的票价信息");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)//定位车辆
        {
            int row = dgvFrequencyInfornation .Rows.Count;//得到总行数  
            int cell = dgvFrequencyInfornation.Rows[1].Cells.Count;//得到总列数  
            for (int i = 0; i < row; i++)//得到总行数并在之内循环  
            {
                for (int j = 0; j < dgvFrequencyInfornation.Rows[i].Cells.Count; j++)//得到总列数并在之内循环  
                {
                    if (dgvFrequencyInfornation.Rows[i].Cells[j].Value == null)
                    {
                        continue;
                    }//遇到没有对应的就跳出
                    if (txtSelectFrequencyMC.Text == dgvFrequencyInfornation.Rows[i].Cells[j].Value.ToString())
                    {   //对比TexBox中的值是否与dgvtujinStation中的值相同（上面这句）  
                        this.dgvFrequencyInfornation.CurrentCell = dgvFrequencyInfornation.Rows[i].Cells[j];
                        this.dgvFrequencyInfornation.BeginEdit(true);
                        return;
                    }

                }
            }
        }

        private void dgvVehicleInfornation_Click(object sender, EventArgs e)
        {
           
        }

        private void tSPDaoChu_Click(object sender, EventArgs e)
        {
            SYS_PublicStaticClass.PublicStaticObject.Frm班次打印 = new 班次管理.Frm班次打印();
            SYS_PublicStaticClass.PublicStaticObject.Frm班次打印.ShowDialog();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            int myint = 0;
            foreach (DataGridViewRow dgv in dgvStopsinroute.Rows )
            {
                int StopsinrouteID =Convert .ToInt32 ( dgv.Cells["StopsinrouteID"].Value);
                myint = myFrequencyListManagerClient.DELETEtujinzhandian(StopsinrouteID);
            }
            if (myint > 0)
            {
                MessageBox.Show("删除成功");
                DataTable satation = myFrequencyListManagerClient.SelectTuJinnewStaion(FrequencyID).Tables[0];
                dgvStopsinroute.DataSource = satation;
            }
        
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

#endregion