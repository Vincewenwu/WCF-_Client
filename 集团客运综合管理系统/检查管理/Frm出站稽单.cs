using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 集团客运综合管理系统.检查管理
{
    public partial class Frm出站稽单 : Form
    {
        public Frm出站稽单()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.chuzhanjicha.chezhanjicha.chezhanjichaClient mychezhanjichaClient 
            = new BLL集团客运综合管理.chuzhanjicha.chezhanjicha.chezhanjichaClient();
        DataTable jichazhan;
        int VehicleID1 = 0;
        DataTable 班次人数;
        bool AllPass;
        public static AutoCompleteStringCollection fCollectionZhanDian;
        //AutoCompleteStringCollection功能等同控件AutoCompleteCustomSource的集合属性，但性能更快。
        public static AutoCompleteStringCollection fCollectioCheCi;
        public static int VehicleID;
        public static string  PlateNumber ="";
        //声明“基础数据公共DataSet”：dsPublic
        public static DataSet dsPublic;
        //声明临时DataTable对象：mydt
        static DataTable mydt;
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
            mydt = mychezhanjichaClient .Selectchelaing().Tables[0];
            dsPublic.Tables.Add(mydt.Copy());
            dsPublic.Tables[0].TableName = "Station";
            //添加 "站点"表的数据到AutoCompleteStringCollection对象“fCollectionZhanDian”（站点）集合中
            foreach (DataRow dr in mydt.Rows)
            {
                fCollectionZhanDian.Add(dr["PlateNumber"].ToString().Trim());
                //如果把数据直接追加到   txtZhanDian的AutoCompleteCustomSource中速度就很慢。 
                // txtZhanDian.AutoCompleteCustomSource.Add(dr["站点MC1"].ToString().Trim());

            }

            //添加 DataTable对象 "车次"，到DataSet之对象 dsPublic中，在dsPublic中编号为1
            //mydt = myNEWFrequencyInsectClient .VehicleSelect().Tables[0];
            //dsPublic.Tables.Add(mydt.Copy());
            //dsPublic.Tables[1].TableName = "车次";

            ////添加 "车次"表的数据到AutoCompleteStringCollection对象“fCollectioCheCi”（车次）集合中
            //foreach (DataRow dr in mydt.Rows)
            //{
            //    fCollectioCheCi.Add(dr["PlateNumber"].ToString().Trim());
            //}
        }
        void AutoCompleteControl()
        {
            //遍历本窗体中所有的System.Windows.Forms.TextBox控件
            //技巧：进入窗体的构造方法的InitializeComponent()中可以找到当前窗体控件的完整类名
            #region 初始化文本框的输入法设置：半角；自动搜索数据源
            foreach (Control txtControl in groupBox2.Controls)
            {
                if (txtControl.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    (txtControl as TextBox).ImeMode = ImeMode.KatakanaHalf;
                    (txtControl as TextBox).AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    (txtControl as TextBox).AutoCompleteSource = AutoCompleteSource.CustomSource;
                    (txtControl as TextBox).AutoCompleteCustomSource = fCollectionZhanDian;
                }
            }
            // txtFrequencyMC.AutoCompleteCustomSource = fCollectioCheCi;
        }
        #endregion
       
        private void Frm出站稽单_Load(object sender, EventArgs e)
        { DataTable jichaxianmu = mychezhanjichaClient.selectjichaxianmu().Tables[0];
            dataGridView1.DataSource = jichaxianmu;
            mCreatePublicDatasetAndCollection();
            AutoCompleteControl();
            comboBox1.DataSource = mychezhanjichaClient.selectjichayuan().Tables[0];
            comboBox1.DisplayMember = "UserMC";
            comboBox1.ValueMember = "UserID";
            comboBox3.DataSource = mychezhanjichaClient.selectjichayuan().Tables[0];
            comboBox3.DisplayMember = "UserMC";
            comboBox3.ValueMember = "UserID";
            mydt = mychezhanjichaClient.Selectchelaing().Tables[0];
            if (mydt .Rows .Count ==0)
            {
                MessageBox.Show("没有合适的车辆");
            }
        }

        private void btnchaxunchelainginxi_Click(object sender, EventArgs e)
        {
            
            int z = 0;
             PlateNumber = textBox2.Text.ToString().Trim();
          DataTable dt=  mychezhanjichaClient.SelectchelaingID(PlateNumber).Tables[0];
            try {
                VehicleID1 = (int)dt.Rows[0][0];
                DataTable dtt = mychezhanjichaClient.Selectchelaingxinhao(VehicleID1).Tables[0];
                txtchexing.Text = dtt.Rows[0][0].ToString();
                DataTable retngshu = mychezhanjichaClient.selectbancirenshuertongshu(VehicleID1).Tables[0];
                txtertongshu.Text = retngshu.Rows.Count.ToString();
                 班次人数 = mychezhanjichaClient.selectbancirenshu(VehicleID1).Tables[0];
            
          for (int i = 0; i < 班次人数.Rows.Count; i++)
            {
                int 席位状态ID = (int)班次人数.Rows[i]["SeatsStateID"];
                switch (席位状态ID)
                {
                    case 1: z = z + 1;
                    break;
                }
            }
           
            txtchengkeshuliang.Text = z.ToString ();
             jichazhan = mychezhanjichaClient.selectcheshudanwei(VehicleID1).Tables[0];
            txtjichazhan.Text = jichazhan.Rows[0][1].ToString ();
            }
            catch { MessageBox.Show("请填好数据"); }
        }
        private void btnchuzhangjicha_Click(object sender, EventArgs e)
        {if (textBox2 .Text !=null &&textBox3 .Text !=null &&txtchengkeshuliang .Text !=null &&txtchexing .Text !=null &&txtertongshu .Text !=null &&txtjichazhan .Text !=null && comboBox1 .Text !=null  &&comboBox3 .Text !=null )
            { 
            int count = 0;
            int success = 0;
            int CreateUserID = 1;
            int DeleteUserID = 1;
            int CarBelongToTheUnitID = 0;
            string ComprehensiveResults = "";
            int TheStationInspectionID = 0;
            DateTime CreateTime = Convert.ToDateTime(DateTime.Now.ToString());
            int UserID = 0;
            try {
             CarBelongToTheUnitID=Convert .ToInt32 ( jichazhan.Rows[0][2]);
             UserID=Convert .ToInt32 (comboBox3.SelectedValue);
           
            int TheNumberOfPassengers =Convert .ToInt32 ( txtchengkeshuliang.Text);
            int ChildrenFree = Convert.ToInt32(txtertongshu.Text);
             ComprehensiveResults = textBox3.Text;
             AllPass =Convert.ToBoolean (checkBox6.Checked );
           
           
            TheStationInspectionID=mychezhanjichaClient.INSERTchuzhanxinxi(VehicleID1, CarBelongToTheUnitID, UserID, CreateUserID, DeleteUserID, TheNumberOfPassengers, ChildrenFree,
                    ComprehensiveResults, AllPass, CreateTime);
            }
            catch { MessageBox.Show("请填好相关数据"); }
            if (TheStationInspectionID > 0)
            {
                foreach (DataGridViewRow DGV in dataGridView1.Rows)
                {
                    count = count + 1;
                    int AuditByComparisonNaneID = Convert.ToInt32(DGV.Cells["AuditByComparisoNaneID"].Value);
                    bool YON = Convert.ToBoolean (DGV.Cells["YOR"].FormattedValue );
                  success += mychezhanjichaClient.insectchuzhanmingxi(TheStationInspectionID, CreateUserID, DeleteUserID, AuditByComparisonNaneID, YON, CreateTime);
                }
            }
            if (success>0 && success ==count )
            {
              
               int myint= mychezhanjichaClient.updatechelaingzhuangtai(VehicleID1);
                    int 修改座位 = mychezhanjichaClient.updatechelaingzhuangtaizuowei (VehicleID1);
                        if (myint>0 && 修改座位>0)
                    { MessageBox.Show("可以出发了"); }

            }
            }else { MessageBox.Show("请填好数据"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = mychezhanjichaClient.SELECTJICHAXIANGMUMINGXI(PlateNumber).Tables[0];
            if (dt.Rows.Count!=0)
            {
                Frm出站稽单报表 myFrm出站稽单报表 = new Frm出站稽单报表(); myFrm出站稽单报表.ShowDialog();
            }
            else { MessageBox.Show("请确定再打印"); }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm车辆稽查单 my = new Frm车辆稽查单();
            my.ShowDialog();
        }
    }
}
