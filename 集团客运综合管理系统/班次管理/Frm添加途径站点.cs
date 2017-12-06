using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 集团客运综合管理系统.班次管理
{
    public partial class Frm添加途径站点 : Form
    {
        public Frm添加途径站点()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.FrequencyManager.FrequencyListManager.FrequencyListManagerClient myFrequencyListManagerClient
            = new BLL集团客运综合管理.FrequencyManager.FrequencyListManager.FrequencyListManagerClient();
     
        int FrequencyID = 业务窗口.Frm班次管理.FrequencyID;
        int int1;
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
            // txtFrequencyMC.AutoCompleteCustomSource = fCollectioCheCi;

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
            mydt = myFrequencyListManagerClient.SelectTuJinStaionMoHu().Tables[0];
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
            //添加 DataTable对象 "车次"，到DataSet之对象 dsPublic中，在dsPublic中编号为1
            //mydt = myNEWFrequencyInsectClient .VehicleSelect().Tables[0];
            //dsPublic.Tables.Add(mydt.Copy());
            //dsPublic.Tables[1].TableName = "车次";

            ////添加 "车次"表的数据到AutoCompleteStringCollection对象“fCollectioCheCi”（车次）集合中
            //foreach (DataRow dr in mydt.Rows)
            //{
            //    fCollectioCheCi.Add(dr["PlateNumber"].ToString().Trim());
            //}
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
        private void btnnewstation_Click(object sender, EventArgs e)
        {
            SYS_PublicStaticClass.PublicStaticObject.Frm新增站点 = new Frm新增站点();
            SYS_PublicStaticClass.PublicStaticObject.Frm新增站点.ShowDialog();
        }

      

        private void btnnewStopsinroute_Click(object sender, EventArgs e)
        {
            int b = 业务窗口.Frm班次管理.i;
            if (b==0)
            {
                int a = 0;
                foreach (DataGridViewRow dgvr in dgvtujinStation.Rows)
                {
                    if (Convert.ToBoolean(dgvr.Cells["选择"].Value) == true)
                    {
                        a += 1;
                        int StaionID = Convert.ToInt32(dgvr.Cells["StationID"].Value.ToString());
                        int CreateUserID = 1;
                        int DeleteUserID = 1;
                        string StopsinrouteMC = dgvr.Cells["StationMC"].Value.ToString();
                        int Standingorder = a;
                        string StationNunber = dgvr.Cells["StationNunber"].Value.ToString();
                        bool Whetherdock = Convert.ToBoolean(1);
                        DateTime CreateTime = Convert.ToDateTime(DateTime.Now.ToString());
                        int1 = myFrequencyListManagerClient.IntsertStopsinroute(FrequencyID, StaionID, CreateUserID, DeleteUserID,
                                                           StopsinrouteMC, Standingorder, StationNunber, Whetherdock, CreateTime);
                    }
                }
                if (int1 > 0)
                {
                    this.Visible = false;
                    MessageBox.Show("success made the new station");
                }
            }
          if(b==1)
            {
               DataTable dt= myFrequencyListManagerClient.SelectMAXStaionxuhao(FrequencyID).Tables[0];
                int a =Convert .ToInt32 ( dt.Rows[0]["Standingorder"]);
                foreach (DataGridViewRow dgvr in dgvtujinStation.Rows)
                {
                    if (Convert.ToBoolean(dgvr.Cells["选择"].Value) == true)
                    {
                        a += 1;
                        int StaionID = Convert.ToInt32(dgvr.Cells["StationID"].Value.ToString());
                        int CreateUserID = 1;
                        int DeleteUserID = 1;
                        string StopsinrouteMC = dgvr.Cells["StationMC"].Value.ToString();
                        int Standingorder = a;
                        string StationNunber = dgvr.Cells["StationNunber"].Value.ToString();
                        bool Whetherdock = Convert.ToBoolean(1);
                        DateTime CreateTime = Convert.ToDateTime(DateTime.Now.ToString());
                        int1 = myFrequencyListManagerClient.IntsertStopsinroute(FrequencyID, StaionID, CreateUserID, DeleteUserID,
                                                           StopsinrouteMC, Standingorder, StationNunber, Whetherdock, CreateTime);
                    }
                }
                if (int1 > 0)
                {
                    this.Visible = false;
                    MessageBox.Show("success made the new station");
                }

            }

        }
        private void Frm添加途径站点_Load(object sender, EventArgs e)
        {
            mCreatePublicDatasetAndCollection();
            AutoCompleteControl();
            DataTable dt=myFrequencyListManagerClient.SelectTuJinStaion().Tables[0];
            dgvtujinStation.DataSource = dt;

        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            int row = dgvtujinStation.Rows.Count;//得到总行数  
            int cell = dgvtujinStation.Rows[1].Cells.Count;//得到总列数  
            for (int i = 0; i < row; i++)//得到总行数并在之内循环  
            {
                for (int j = 0; j < dgvtujinStation.Rows[i].Cells.Count; j++)//得到总列数并在之内循环  
                {
                    if (dgvtujinStation.Rows[i].Cells[j].Value == null)
                    {
                        continue;
                    }//遇到没有对应的就跳出
                    if (textBox1.Text==dgvtujinStation.Rows[i].Cells[j].Value.ToString())
                    {   //对比TexBox中的值是否与dgvtujinStation中的值相同（上面这句）  
                        this.dgvtujinStation.CurrentCell = dgvtujinStation.Rows[i].Cells[j];
                        this.dgvtujinStation.BeginEdit(true);
                        return;
                    }

                }
            }
        }
    }
} 
