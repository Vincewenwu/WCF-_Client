using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 集团客运综合管理系统.车辆管理
{
    public partial class FRM_CheLiangGuangLi_Insert : Form
    {
        public FRM_CheLiangGuangLi_Insert()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.VehicleManage.FRM_CheLiangGuangLi_Insert.FRM_CheLiangGuangLi_InsertClient myFRM_CheLiangGuangLi_InsertClient =
            new BLL集团客运综合管理.VehicleManage.FRM_CheLiangGuangLi_Insert.FRM_CheLiangGuangLi_InsertClient();
        public static AutoCompleteStringCollection fCollectionGongGong;
        static DataTable mydt;
        int CreateUserID = 1025;
        int DeleteUserID = 1;
        DateTime CreateTime = DateTime.Now;
        DateTime LogicalDeleteTime = DateTime.Now;
        DataTable dtJiaShiYuan;
        DataTable dtFuJiaShiYuanYi;
        DataTable dtFuJiaShiYuanEr;
        #region 自动完成查询条件
        public void mCreatePublicDatasetAndCollection()
        {
            if (fCollectionGongGong != null)
            {
                fCollectionGongGong.Clear();
            }
            if (mydt != null)
            {
                mydt.Clear();
            }
            fCollectionGongGong = new AutoCompleteStringCollection();
            mydt = myFRM_CheLiangGuangLi_InsertClient.SelectDriverNumber().Tables[0];
            foreach (DataRow dr in mydt.Rows)
            {
                fCollectionGongGong.Add(dr["DriverNumber"].ToString().Trim());
            }
            txtZhengJiaShiBianHao.ImeMode = ImeMode.KatakanaHalf;
            txtZhengJiaShiBianHao.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtZhengJiaShiBianHao.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtZhengJiaShiBianHao.AutoCompleteCustomSource = fCollectionGongGong;
            txtFuJiaShiYiBianHao.ImeMode = ImeMode.KatakanaHalf;
            txtFuJiaShiYiBianHao.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtFuJiaShiYiBianHao.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtFuJiaShiYiBianHao.AutoCompleteCustomSource = fCollectionGongGong;
            txtFuJiaShiErBianHao.ImeMode = ImeMode.KatakanaHalf;
            txtFuJiaShiErBianHao.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtFuJiaShiErBianHao.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtFuJiaShiErBianHao.AutoCompleteCustomSource = fCollectionGongGong;
        }
        #endregion

        #region 联想自动查询
        public static int mReturnSurfaceLandID(string DriverNumber)
        {
            try
            {
                DataTable newDt;
                var queryZhanDian =
                        from myVar in mydt.AsEnumerable()
                        where (string)myVar["DriverNumber"] == DriverNumber
                        select myVar;
                newDt = queryZhanDian.CopyToDataTable<DataRow>();
                return Convert.ToInt32(newDt.Rows[0]["DriverNumber"]);
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        #region Load事件
        private void FRM_CheLiangGuangLi_Insert_Load(object sender, EventArgs e)
        {
            mCreatePublicDatasetAndCollection();
            DataTable dtCheShuDanWei = myFRM_CheLiangGuangLi_InsertClient.SelectCheShuDangWei().Tables[0];
            cboCheShuDanWei.DataSource = dtCheShuDanWei;
            cboCheShuDanWei.DisplayMember = "CarBelongToTheUnitMC";
            cboCheShuDanWei.ValueMember = "CarBelongToTheUnitID";
            DataTable dtChengBaoGonShi = myFRM_CheLiangGuangLi_InsertClient.SelectChengBaoGonSi().Tables[0];
            cboChengBaoGonShi.DataSource = dtChengBaoGonShi;
            cboChengBaoGonShi.DisplayMember = "UnderwriteCompanyMC";
            cboChengBaoGonShi.ValueMember = "UnderwriteCompanyID";
            DataTable dtCheLiangXingHao = myFRM_CheLiangGuangLi_InsertClient.SelectCheLiangLeiXing().Tables[0];
            cboCheLiangXingHao.DataSource = dtCheLiangXingHao;
            cboCheLiangXingHao.DisplayMember = "VehicleTypeMC";
            cboCheLiangXingHao.ValueMember = "VehicleTypeID";
        }
        #endregion
        
        #region 查询驾驶员通过驾驶员编号
        private void txtZhengJiaShiBianHao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string DriverNumber = txtZhengJiaShiBianHao.Text;
                dtJiaShiYuan = myFRM_CheLiangGuangLi_InsertClient.SelectJiaShiYuanByDriverNumber(DriverNumber).Tables[0];
                txtZhengJiaShi.Text = dtJiaShiYuan.Rows[0]["DriverMC"].ToString().Trim();
            }
            catch { }
        }

        private void txtFuJiaShiYiBianHao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string DriverNumber = txtFuJiaShiYiBianHao.Text;
                dtFuJiaShiYuanYi = myFRM_CheLiangGuangLi_InsertClient.SelectJiaShiYuanByDriverNumber(DriverNumber).Tables[0];
                txtFuJiaShiYi.Text = dtFuJiaShiYuanYi.Rows[0]["DriverMC"].ToString().Trim();
            }
            catch { }

        }

        private void txtFuJiaShiErBianHao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string DriverNumber = txtFuJiaShiErBianHao.Text;
                dtFuJiaShiYuanEr = myFRM_CheLiangGuangLi_InsertClient.SelectJiaShiYuanByDriverNumber(DriverNumber).Tables[0];
                txtFuJiaShiEr.Text = dtFuJiaShiYuanEr.Rows[0]["DriverMC"].ToString().Trim();
            }
            catch { }
        }
        #endregion

        #region 按钮事件
        private void btnQuXiao_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region 新增车辆信息
        private void btnQueDing_Click(object sender, EventArgs e)
        {
            int XiWei = 0;
            string VehicleHostMC = txtXinMing.Text.ToString().Trim();
            string Address = txtDiZi.Text.ToString().Trim();
            string ContactPhone = txtLianXiDianHua.Text.ToString().Trim();
            string Identification = txtShenFenZheng.Text.ToString().Trim();
            int CheZhu = myFRM_CheLiangGuangLi_InsertClient.InsertCheZhu(
                CreateUserID,DeleteUserID,VehicleHostMC,Address,
                ContactPhone,Identification,CreateTime,LogicalDeleteTime);
            string BusinessLine = txtJingYinXianLu.Text.ToString().Trim();
            string LineNumber = txtXianLuPaiHao.Text.ToString().Trim();
            string AttachedCardNumber = txtFuKaHao.Text.ToString().Trim();
            string OperationOfTheNumber = txtYingYunZhengHao.Text.ToString().Trim();
            DateTime Validity = Convert.ToDateTime(dateYouXiaoQi.Text.ToString().Trim());
            DateTime SpringRecords = Convert.ToDateTime(dateChunJianJiLu.Text.ToString().Trim());
            DateTime InspectionRecords = Convert.ToDateTime(dateShengYanJiLu.Text.ToString().Trim());
            DateTime CompleteMaintenance = Convert.ToDateTime(dateErJiWeiHu.Text.ToString().Trim());
            DateTime Rating = Convert.ToDateTime(dateDengJiPingDing.Text.ToString().Trim());
            DateTime TravelCard = Convert.ToDateTime(dateYouXiaoQi.Text.ToString().Trim());
            DateTime MonthMaintainSun = Convert.ToDateTime(dateYueWeiHuRi.Text.ToString().Trim());
            DateTime LiquefiedPetroleumGasCard = Convert.ToDateTime(dateYeHuaQiZheng.Text.ToString().Trim());
            int CheLiangZhengJian = myFRM_CheLiangGuangLi_InsertClient.InsertCheLiangZhengJianXingXi(
                CreateUserID, DeleteUserID, BusinessLine, LineNumber, AttachedCardNumber, OperationOfTheNumber,
                Validity, SpringRecords, InspectionRecords, CompleteMaintenance, Rating,
                TravelCard, MonthMaintainSun, LiquefiedPetroleumGasCard, CreateTime, LogicalDeleteTime);
            int UnderwriteCompanyID = Convert.ToInt32(cboChengBaoGonShi.SelectedValue);
            string PolicyOfInsuranceMC = txtBaoXianDan.Text.ToString().Trim();
            DateTime BookbuildingDate = Convert.ToDateTime(dateJianDangRiQi.Text.ToString().Trim());
            DateTime Drivenvehicle = Convert.ToDateTime(dateJiaoQianXian.Text.ToString().Trim());
            DateTime CommercialUnderwritingExecutive = Convert.ToDateTime(dateShangYeXian.Text.ToString().Trim());
            DateTime Bearingonetransportrisk = Convert.ToDateTime(dateChengYunRenXian.Text.ToString().Trim());
            int BaoXian = myFRM_CheLiangGuangLi_InsertClient.InsertBaoXian(
                UnderwriteCompanyID, CreateUserID, DeleteUserID, PolicyOfInsuranceMC,
                BookbuildingDate, Drivenvehicle, CommercialUnderwritingExecutive,
                Bearingonetransportrisk, CreateTime, LogicalDeleteTime);
            if(CheLiangZhengJian != 0 || BaoXian != 0 || CheZhu!=0)
            {
                int VehicleTypeID = Convert.ToInt32(cboCheLiangXingHao.SelectedValue);
                int CarBelongToTheUnitID = Convert.ToInt32(cboCheShuDanWei.SelectedValue);
                int VehicleStateID = 1;
                int DriverID = Convert.ToInt32(dtJiaShiYuan.Rows[0]["DriverID"].ToString());
                int DriverAssistantID = Convert.ToInt32(dtFuJiaShiYuanYi.Rows[0]["DriverID"].ToString());
                string VehicleNumber = txtCheLiangBianHao.Text.ToString().Trim();
                string VehiclePaiNumber = txtChePaiHao.Text.ToString().Trim();
                DateTime RegisterDate = Convert.ToDateTime(dateDengJiRiQi.Text.ToString().Trim());
                string Seating = Convert.ToString(txtZuoWeiShu.Text.ToString().Trim());
                string Loadheaver = txtZaiZhong.Text.ToString().Trim();
                bool SafeInspectNo = Convert.ToBoolean(radBuAnJian.Checked);
                bool EverySkySafeInspect = Convert.ToBoolean(radMeiCiBaoBanAnJian.Checked);
                bool OneSkySafeInspectOneNext = Convert.ToBoolean(radYiTianAnJianYiCi.Checked);
                string Comment = txtBeiZhu.Text.ToString().Trim();
                int CheLiang = myFRM_CheLiangGuangLi_InsertClient.InsertCheLiangXinXi(
                    CheZhu, VehicleTypeID, CarBelongToTheUnitID, VehicleStateID,
                    BaoXian, CheLiangZhengJian, DriverID, DriverAssistantID,
                    CreateUserID, DeleteUserID, VehicleNumber, VehiclePaiNumber, RegisterDate,
                    Seating, Loadheaver, SafeInspectNo, EverySkySafeInspect, OneSkySafeInspectOneNext,
                    Comment, CreateTime, LogicalDeleteTime);
                if (CheLiang > 0)
                {
                    int z = Convert.ToInt32(txtZuoWeiShu.Text.ToString().Trim());
                    for(int i=0;i< z; i++)
                    {
                       
                        int SeatsTypeID = 1;
                        int SeatsStateID = 2;
                        int SeatNoMC = i+1;
                        bool UseNo = true;
                        XiWei = myFRM_CheLiangGuangLi_InsertClient.InsertXiWei(
                            CheLiang, SeatsTypeID, SeatsStateID, SeatNoMC, UseNo,
                            CreateUserID, DeleteUserID);
                    }
                    if (XiWei > 0)
                    {
                        MessageBox.Show("OK!");
                    }
                    else
                    {
                        MessageBox.Show("No!");
                    }
                }
            }
        }
        #endregion

        #endregion

        #region 验证手机号码
        public bool IsHandset(string str_handset)
        {
            return System.Text.RegularExpressions.Regex.////使用正则表达式判断是否匹配
                IsMatch(str_handset, @"^[1]+[3,8,5]+\d{9}$");
        }
        private void txtLianXiDianHua_Validated(object sender, EventArgs e)
        {
            if (!IsHandset(txtLianXiDianHua.Text))
            {
                MessageBox.Show("请输入开头为18-13-15的11位电话号码！");
            }
            else
            { }
        }
        #endregion

        #region  验证身份证号码
        public bool IsIDcard(string str_idcard)
        {
            return System.Text.RegularExpressions.Regex.//使用正则表达式判断是否匹配
                IsMatch(str_idcard, @"(^\d{18}$)|(^\d{15}$)");
        }
        private void txtShenFenZheng_Validated(object sender, EventArgs e)
        {
            if (!IsIDcard(txtShenFenZheng.Text))
            {
                MessageBox.Show("请输入18位或15位身份证号码！");
            }
            else
            { }
        }



        #endregion
        public bool IsNumber(string str_number)
        {
            return System.Text.RegularExpressions.Regex.//使用正则表达式判断是否匹配
                IsMatch(str_number, @"^[0-9]*$");
        }
        private void txtZuoWeiShu_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumber(txtZuoWeiShu .Text.Trim()))//验证输入是否为数字
            { MessageBox.Show("只充许输入数字!!!", "提示"); txtZuoWeiShu .Text = ""; }//弹出消息对话框 
        }
    }
}
