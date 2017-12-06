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
    public partial class Frm车辆安全检查窗口 : Form
    {
        public Frm车辆安全检查窗口()
        {
            InitializeComponent();
        }
        string PlateNumber = "";
        int VehicleID1;
        int cheshudanweiID = 0;
        int VehicleTypeID = 0;
        bool YON;
        string Comments1 = "";
        BLL集团客运综合管理.进站检查.Jinzhanjiancha.JinzhanjianchaClient myJinzhanjianchaClient = new BLL集团客运综合管理.进站检查.Jinzhanjiancha.JinzhanjianchaClient();
        public static AutoCompleteStringCollection fCollectionZhanDian;
        //AutoCompleteStringCollection功能等同控件AutoCompleteCustomSource的集合属性，但性能更快。
        public static AutoCompleteStringCollection fCollectioCheCi;
        public static int VehicleID;
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
            mydt = myJinzhanjianchaClient.CarSaveCheak_Selectchelaing().Tables[0];
            dsPublic.Tables.Add(mydt.Copy());
            dsPublic.Tables[0].TableName = "Station";
            //添加 "站点"表的数据到AutoCompleteStringCollection对象“fCollectionZhanDian”（站点）集合中
            foreach (DataRow dr in mydt.Rows)
            {
                fCollectionZhanDian.Add(dr["VehiclePaiNumber"].ToString().Trim());
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
            foreach (Control txtControl in groupBox3.Controls)
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
        private void Frm车辆安全检查窗口_Load(object sender, EventArgs e)
        {
            mCreatePublicDatasetAndCollection();
            AutoCompleteControl();
            DataTable dt=myJinzhanjianchaClient.selectanquanjianxianmghu().Tables[0];
            dataGridView1.DataSource = dt;

            DataTable dtt = myJinzhanjianchaClient.CarSaveCheak_selectjichayuan().Tables[0];
            cboanjianyuan.DataSource = dtt;
            cboanjianyuan.DisplayMember = "UserMC";
            cboanjianyuan.ValueMember = "UserID";
            DataTable dttt = myJinzhanjianchaClient.CarSaveCheak_selectjichayuan().Tables[0];
            cbodiannaochaozuoyuan .DataSource = dttt;
            cbodiannaochaozuoyuan.DisplayMember = "UserMC";
            cbodiannaochaozuoyuan.ValueMember = "UserID";
            if (mydt.Rows.Count == 0)
            {
                MessageBox.Show("没有合适的车辆");
            }

        }

        private void btnanqunjiancha_Click(object sender, EventArgs e)
        {
            int myint = 0;
            if (txtchepihao .Text !="" &&txtchexing .Text !="" && txtjiashiyuanpianming .Text !="" &&
                 txtjichazhan .Text !="" &&cboanjianyuan .Text !="" &&cbodiannaochaozuoyuan .Text !="") 
              { 
              int UserTypeID = Convert.ToInt32(cbodiannaochaozuoyuan.SelectedValue);
                int CreateUserID = 1;
                int DeleteUserID = 1;
                string TheDriverSignature = txtjiashiyuanpianming.Text;
                int CompetaterID = Convert.ToInt32(cboanjianyuan.SelectedValue);
                DateTime Youxiaodate = dateTimePicker1.Value;
                if (radioButton1.Checked)
                {
                    YON = radioButton1.Checked;
                }
                if (radioButton3.Checked)
                {
                    YON = radioButton3.Checked;
                }
                int CarriageInspectionShedID = myJinzhanjianchaClient.insectjianchadan(VehicleID1, UserTypeID, cheshudanweiID,
                    CreateUserID, DeleteUserID, TheDriverSignature, PlateNumber,
                    VehicleTypeID, CompetaterID, Youxiaodate, YON);
                foreach (DataGridViewRow dgv in dataGridView1.Rows)
                {
                    int InspectionItemID = Convert.ToInt32(dgv.Cells["InspectionItemID"].Value);
                    bool YON = Convert.ToBoolean(dgv.Cells["结果"].Value);
                    if (dgv.Cells["备注"].Value == null)
                    {
                        Comments1 = "正常";
                    }
                    if (dgv.Cells["备注"].Value != null)
                    {
                        Comments1 = dgv.Cells["备注"].Value.ToString();
                    }
                     myint = myJinzhanjianchaClient.INSERTInspectionItemmingxi(CarriageInspectionShedID, InspectionItemID, YON, Comments1);
                    
                }
                if (myint > 0)
                {
                    int inn = myJinzhanjianchaClient.CarSaveCheak_updatechelaingzhuangtai(VehicleID1);
                    if (inn > 0)
                    {
                        MessageBox.Show("检查成功");

                    }
                }
            } else { MessageBox.Show("请填好相关数据"); }
        }

        private void btchelingxinixi_Click(object sender, EventArgs e)//查询车辆信息
        {
             PlateNumber = txtchepihao.Text.Trim();
            DataTable dt = myJinzhanjianchaClient.SelectCheLiangXinXiOnchepaihao(PlateNumber).Tables [0];
            try { 
            VehicleID1 = (int)dt.Rows[0][0];
            DataTable DTT=  myJinzhanjianchaClient.SELECTCEXINGONCHEPIHAO(VehicleID1).Tables [0];
            txtchexing .Text = DTT.Rows[0][0].ToString();
             VehicleTypeID=Convert .ToInt32 ( DTT.Rows[0][2].ToString());
            DataTable jichazhan = myJinzhanjianchaClient.CarSaveCheak_selectcheshudanwei(VehicleID1).Tables[0];
            txtjichazhan.Text = jichazhan.Rows[0][1].ToString();
             cheshudanweiID=Convert .ToInt32 ( jichazhan.Rows[0][2].ToString());
            }catch { MessageBox.Show("请填好数据"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 查询检查单_Click(object sender, EventArgs e)
        {
            Frm车辆检查单 myFrm车辆检查单 = new Frm车辆检查单();
            myFrm车辆检查单.ShowDialog();
        }
    }
}
