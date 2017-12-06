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
    public partial class Frm新增班次窗口 : Form
    {
        public Frm新增班次窗口()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.FrequencyManager.NEWFrequencyInsect.NEWFrequencyInsectClient myNEWFrequencyInsectClient
            = new BLL集团客运综合管理.FrequencyManager.NEWFrequencyInsect.NEWFrequencyInsectClient();
     
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
            mydt = myNEWFrequencyInsectClient .StationSelect ().Tables[0];
            dsPublic.Tables.Add(mydt.Copy());
            dsPublic.Tables[0].TableName = "Station";
            //添加 "站点"表的数据到AutoCompleteStringCollection对象“fCollectionZhanDian”（站点）集合中
            foreach (DataRow dr in mydt.Rows)
            {
                fCollectionZhanDian.Add(dr["StationMC1"].ToString().Trim());
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
            foreach (Control txtControl in grpCheCi.Controls)
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
        private void Frm新增班次窗口_Load(object sender, EventArgs e)
        {
             mCreatePublicDatasetAndCollection();
            AutoCompleteControl();
            dtpShiJian.Value = Convert.ToDateTime(DateTime.Now.ToString());

            cboLine.DataSource = myNEWFrequencyInsectClient.LineSelect().Tables[0];
            cboLine.DisplayMember = "LineMC";
            cboLine.ValueMember = "LineID";
            cboVehicle.DataSource = myNEWFrequencyInsectClient.VehicleSelect().Tables[0];
            cboVehicle.DisplayMember = "VehiclePaiNumber";
            cboVehicle.ValueMember = "VehicleID";
            cboTicketEntrance.DataSource = myNEWFrequencyInsectClient.TicketEntranceSelect().Tables[0];
            cboTicketEntrance.DisplayMember = "TicketEntranceMC";
            cboTicketEntrance.ValueMember = "TicketEntranceID";

        }
        public bool IsNumber(string str_number)
        {
            return System.Text.RegularExpressions.Regex.//使用正则表达式判断是否匹配
                IsMatch(str_number, @"^[0-9]*$");
        }

        private void btnNEW_Click(object sender, EventArgs e)
        {
            if (txtstarstaion.Text!=""&& txtendstaion.Text!=""&& cboTicketEntrance.SelectedValue!=null && txtFrequencyMC.Text!=""&& txtDepartureTime.Text!=""
                       && txtBeginningDays.Text!=""&& txtClassNumber.Text!=""&& txtStopClassDays.Text!=""&& rtxtBeiZhu.Text!="")
            {
                string d = dtpShiJian.Value.ToString();
                string D = DateTime.Now.ToString();
                DateTime d1 =Convert .ToDateTime (d);
                DateTime D1 = Convert.ToDateTime(D);
                int t1 = d1.Year * 365 * 24 * 60 * 60 + d1.Month * 30 * 24 * 60 * 60 + d1.Day * 24 * 60 * 60 + d1.Hour * 3600 + d1.Minute * 60 + d1.Second + 500;
                int t2 = D1.Year * 365 * 24 * 60 * 60 + D1.Month * 30 * 24 * 60 * 60 + D1.Day * 24 * 60 * 60 + D1.Hour * 3600 + D1.Minute * 60 + D1.Second;
                if (t1<=t2)
                { MessageBox.Show("当前时间不能小于今天"); }
                else
                {
                string strZhanDian = txtstarstaion.Text.Trim().ToString();
                string strZhanDian1 = txtendstaion.Text.Trim().ToString();
                 VehicleID = Convert.ToInt32(cboVehicle.SelectedValue);
               int   LineID = Convert.ToInt32(cboLine.SelectedValue);
                int StartingStationID = mReturnZhanDianID(strZhanDian);
                int TerminalStationID = mReturnZhanDianID(strZhanDian1);
                int TicketEntranceID = Convert.ToInt32(cboTicketEntrance.SelectedValue);
                int CreateUserID = 1;
                int DeleteUserID = 1;
                string FrequencyMC = txtFrequencyMC.Text.ToString();
                string DepartureTime = txtDepartureTime.Text.ToString();
                string CirculationDate = d.Remove(9);
                int BeginningDays = Convert.ToInt32(txtBeginningDays.Text);
                int ClassNumber = Convert.ToInt32(txtClassNumber.Text);
                int StopClassDays = Convert.ToInt32(txtStopClassDays.Text);
                bool Generate = Convert.ToBoolean(checkBox1.Checked);
                bool WhetherToPas = Convert.ToBoolean(checkBox2.Checked);
                string Comments = rtxtBeiZhu.Text;
                DateTime CreateTime = dtpShiJian.Value;
                bool ListState = Convert.ToBoolean(1);
                int myint = myNEWFrequencyInsectClient.FrequencyInsect(VehicleID, LineID, StartingStationID, TerminalStationID, TicketEntranceID, CreateUserID, DeleteUserID, FrequencyMC,
                     DepartureTime, CirculationDate, BeginningDays, ClassNumber, StopClassDays, Generate, WhetherToPas, Comments,
                     CreateTime, ListState);
                if (myint > 0)
                   {
                        int mtit= myNEWFrequencyInsectClient.UpdateVehicleState( VehicleID);
                        if (mtit>0)
                        {
                            MessageBox.Show("新增成功");
                            SYS_PublicStaticClass.PublicStaticObject.Frm班次管理 = new Frm班次管理();
                            SYS_PublicStaticClass.PublicStaticObject.Frm班次管理.ShowDialog();
                        }
                   
                   }else
                    {
                        MessageBox.Show("新增不成功");
                    }
                }
            }
            else
            {
                MessageBox.Show("请填完整数据");
            }
            
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            txtBeginningDays.Text = "";
            txtClassNumber .Text = "";
            txtDepartureTime .Text = "";
            txtendstaion .Text = "";
            txtFrequencyMC .Text = "";
            txtstarstaion .Text = "";
            txtStopClassDays.Text = "";
            cboLine.Text  = "";
            cboTicketEntrance .Text  = "";
            cboVehicle .Text  = "";
            rtxtBeiZhu.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;

        }

        private void butStation_Click(object sender, EventArgs e)
        {
            SYS_PublicStaticClass.PublicStaticObject.Frm新增站点 = new 班次管理.Frm新增站点();
            SYS_PublicStaticClass.PublicStaticObject.Frm新增站点.ShowDialog();
            mCreatePublicDatasetAndCollection();
            AutoCompleteControl();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butLine_Click(object sender, EventArgs e)//新增线路
        {         
            SYS_PublicStaticClass.PublicStaticObject.Frm新增线路  = new 班次管理.Frm新增线路 ();
            SYS_PublicStaticClass.PublicStaticObject.Frm新增线路 .ShowDialog();
            cboLine.DataSource = myNEWFrequencyInsectClient.LineSelect().Tables[0];
            cboLine.DisplayMember = "LineMC";
            cboLine.ValueMember = "LineID";

        }

        private void txtBeginningDays_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumber(txtBeginningDays.Text.Trim()))//验证输入是否为数字
            { MessageBox.Show("只充许输入数字!!!", "提示"); txtBeginningDays.Text = ""; }//弹出消息对话框
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SYS_PublicStaticClass.PublicStaticObject.Frm班次管理 = new Frm班次管理();
            SYS_PublicStaticClass.PublicStaticObject.Frm班次管理.ShowDialog();
        }

        private void txtClassNumber_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumber(txtClassNumber .Text.Trim()))//验证输入是否为数字
            { MessageBox.Show("只充许输入数字!!!", "提示"); txtBeginningDays.Text = ""; }//弹出消息对话框
        }

        private void txtStopClassDays_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumber(txtStopClassDays .Text.Trim()))//验证输入是否为数字
            { MessageBox.Show("只充许输入数字!!!", "提示"); txtStopClassDays.Text = ""; }//弹出消息对话框
        }
        public bool shijian(string str_number)
        {
            return System.Text.RegularExpressions.Regex.//使用正则表达式判断是否匹配
                IsMatch(str_number, @"^[0-2]*$");
        }
        private void txtDepartureTime_MouseLeave(object sender, EventArgs e)
        {
            string shi = txtDepartureTime.Text.Remove(2);
            if (shijian(shi))
            {
                MessageBox.Show("fg ");
            }

        }
    }
}
