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
    public partial class Frm修改班次窗口 : Form
    {
        public Frm修改班次窗口()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.FrequencyManager.NEWFrequencyUpdate.NEWFrequencyUpdateClient myNEWFrequencyUpdateClient
            = new BLL集团客运综合管理.FrequencyManager.NEWFrequencyUpdate.NEWFrequencyUpdateClient();
        int FrequencyID = 0;
        public static AutoCompleteStringCollection fCollectionZhanDian;
        //AutoCompleteStringCollection功能等同控件AutoCompleteCustomSource的集合属性，但性能更快。
        public static AutoCompleteStringCollection fCollectioCheCi;

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
            mydt = myNEWFrequencyUpdateClient.StationSelect1().Tables[0];
            dsPublic.Tables.Add(mydt.Copy());
            dsPublic.Tables[0].TableName = "Station";
            //添加 "站点"表的数据到AutoCompleteStringCollection对象“fCollectionZhanDian”（站点）集合中
            foreach (DataRow dr in mydt.Rows)
            {
                fCollectionZhanDian.Add(dr["StationMC1"].ToString().Trim());
                //如果把数据直接追加到   txtZhanDian的AutoCompleteCustomSource中速度就很慢。 
                // txtZhanDian.AutoCompleteCustomSource.Add(dr["站点MC1"].ToString().Trim());

            }

           // 添加 DataTable对象 "车次"，到DataSet之对象 dsPublic中，在dsPublic中编号为1
            mydt = myNEWFrequencyUpdateClient.VehicleSelect().Tables[0];
            dsPublic.Tables.Add(mydt.Copy());
            dsPublic.Tables[1].TableName = "车次";

            //添加 "车次"表的数据到AutoCompleteStringCollection对象“fCollectioCheCi”（车次）集合中
            foreach (DataRow dr in mydt.Rows)
            {
                fCollectioCheCi.Add(dr["VehiclePaiNumber"].ToString().Trim());
            }
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
            

            #endregion

        }
        public static int mReturnZhanDianID(string strStation)
        //根据“站点MC”，返回该名称对应的“站点ID”
        {
            try
            {
                DataTable newDt;
                var queryStation = //把myVar赋值给queryZhanDian，二者都是临时var对象。
                        from myVar in dsPublic.Tables["Station"].AsEnumerable()//把“站点”赋值给myVar
                        where (string)myVar["StationMC1"] == strStation//查询实参为“strZhanDian”的“站点”数据，
                        select myVar; //保存到myVar中，并赋值给queryZhanDian
                //把临时var对象queryZhanDian赋值给DataTable对象newDt
                newDt = queryStation.CopyToDataTable<DataRow>();
                //获取并返回newDt的“站点ID”
                return Convert.ToInt32(newDt.Rows[0]["StationID"]);
            }
            catch
            {
                return 0;
            }
        }
        private void btnNEW_Click(object sender, EventArgs e)//修改保存
        {
            if (FrequencyID>0 )
         {   if (MessageBox .Show ("是否修改","提示",MessageBoxButtons.YesNo )==DialogResult.Yes )
                {
                    string strStation = txtstarstaion.Text.Trim().ToString();
                    string strStation1 = txtendstaion.Text.Trim().ToString();
                    int VehicleID = Convert.ToInt32(cboVehicle.SelectedValue);
                    int LineID = Convert.ToInt32(cboLine.SelectedValue);
                    int StartingStationID = mReturnZhanDianID(strStation);
                    int TerminalStationID = mReturnZhanDianID(strStation1);
                    int TicketEntranceID = Convert.ToInt32(cboTicketEntrance.SelectedValue);
                    int CreateUserID = 1;
                    int DeleteUserID = 1;
                    string FrequencyMC = txtFrequencyMC.Text;
                    string DepartureTime = txtDepartureTime.Text;
                    string s = dtpCreateTime.Value.ToString();
                    string CirculationDate = s.Remove(9);
                    int BeginningDays = Convert.ToInt32(txtBeginningDays.Text);
                    int ClassNumber = Convert.ToInt32(txtClassNumber.Text);
                    int StopClassDays = Convert.ToInt32(txtStopClassDays.Text);
                    bool Generate = Convert.ToBoolean(checkBox1.Checked);
                    bool WhetherToPas = Convert.ToBoolean(checkBox2.Checked);
                    string Comments = rtxtBeiZhu.Text;
                    DateTime CreateTime = dtpCreateTime.Value;
                    int myint = myNEWFrequencyUpdateClient.FrequencyUPDATE(VehicleID, LineID, StartingStationID, TerminalStationID, TicketEntranceID,
                                                                     CreateUserID, DeleteUserID, FrequencyMC, DepartureTime, CirculationDate, BeginningDays,
                                                                     ClassNumber, StopClassDays, Generate, WhetherToPas, Comments, CreateTime, FrequencyID);
                    if (myint != 0)
                    {
                        this.Visible = false;
                        MessageBox.Show("修改成功啦");
                        SYS_PublicStaticClass.PublicStaticObject.Frm班次管理 = new Frm班次管理();
                        SYS_PublicStaticClass.PublicStaticObject.Frm班次管理.ShowDialog();

                    }

                }
                else
                {
                    MessageBox.Show("你已取消修改");
                }

            }
            else
            {

            }
        }
        public bool IsNumber(string str_number)
        {
            return System.Text.RegularExpressions.Regex.//使用正则表达式判断是否匹配
                IsMatch(str_number, @"^[0-9]*$");
        }

        private void Frm修改班次窗口_Load(object sender, EventArgs e)//load修改之前赋初始值
        {
            mCreatePublicDatasetAndCollection();
            AutoCompleteControl();

            cboLine.DataSource = myNEWFrequencyUpdateClient .LineSelect().Tables[0];
            cboLine.DisplayMember = "LineMC";
            cboLine.ValueMember = "LineID";

            cboVehicle.DataSource = myNEWFrequencyUpdateClient .VehicleSelect().Tables[0];
            cboVehicle.DisplayMember = "PlateNumber";
            cboVehicle.ValueMember = "VehicleID";

            cboTicketEntrance.DataSource = myNEWFrequencyUpdateClient .TicketEntranceSelect().Tables[0];
            cboTicketEntrance.DisplayMember = "TicketEntranceMC";
            cboTicketEntrance.ValueMember = "TicketEntranceID";

            FrequencyID = 业务窗口.Frm班次管理.FrequencyID;// Frm班次管理.FrequencyID;
          DataTable dt=  myNEWFrequencyUpdateClient.SelectFrequencyTIAO(FrequencyID).Tables[0];
        
            txtBeginningDays.Text = dt.Rows[0]["BeginningDays"].ToString ();
            txtClassNumber .Text = dt.Rows[0]["ClassNumber"].ToString();
            txtDepartureTime .Text = dt.Rows[0]["DepartureTime"].ToString();
            string StationMC = dt.Rows[0]["endStaion"].ToString();
              string StationMC1 = dt.Rows[0]["starStaion"].ToString();
            txtFrequencyMC.Text = dt.Rows[0]["FrequencyMC"].ToString();
            txtStopClassDays .Text = dt.Rows[0]["StopClassDays"].ToString();
            rtxtBeiZhu.Text= dt.Rows[0]["Comments"].ToString();
            cboLine.SelectedValue = dt.Rows[0]["LineID"].ToString();
            cboTicketEntrance .SelectedValue = dt.Rows[0]["TicketEntranceID"];
            cboVehicle.SelectedValue = dt.Rows[0]["VehicleID"];
            checkBox1 .Checked =Convert .ToBoolean ( dt.Rows[0]["Generate"]);
            checkBox2.Checked = Convert.ToBoolean(dt.Rows[0]["WhetherToPas"]);

            #region   自动填充数据要给真实的值，不能给缩写值，不然查不了     
            DataTable mydt = myNEWFrequencyUpdateClient.StationSelectTIAO(StationMC).Tables[0];
            txtstarstaion.Text = mydt.Rows[0]["StationMC1"].ToString();
            DataTable mydt1 = myNEWFrequencyUpdateClient.StationSelectTIAO(StationMC1).Tables[0];
            txtendstaion.Text = mydt1.Rows[0]["StationMC1"].ToString();
            #endregion


        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SYS_PublicStaticClass.PublicStaticObject.Frm班次管理 = new Frm班次管理();
            SYS_PublicStaticClass.PublicStaticObject.Frm班次管理.ShowDialog();
        }

        private void txtClassNumber_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumber(txtClassNumber.Text.Trim()))//验证输入是否为数字
            { MessageBox.Show("只充许输入数字!!!", "提示"); txtClassNumber.Text = ""; }//弹出消息对话框
        }

        private void txtBeginningDays_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumber(txtBeginningDays.Text.Trim()))//验证输入是否为数字
            { MessageBox.Show("只充许输入数字!!!", "提示"); txtBeginningDays.Text = ""; }//弹出消息对话框
        }

        private void txtStopClassDays_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumber(txtStopClassDays .Text.Trim()))//验证输入是否为数字
            { MessageBox.Show("只充许输入数字!!!", "提示"); txtStopClassDays.Text = ""; }//弹出消息对话框
        }
    }
}
