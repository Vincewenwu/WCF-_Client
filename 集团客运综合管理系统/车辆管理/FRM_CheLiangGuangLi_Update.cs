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
    public partial class FRM_CheLiangGuangLi_Update : Form
    {
        public FRM_CheLiangGuangLi_Update()
        {
            InitializeComponent();
        }
        public FRM_CheLiangGuangLi_Update(int VehicleID)
        {
            InitializeComponent();
            VVehicleID = VehicleID;
        }
        int VVehicleID = 0;
        BLL集团客运综合管理.VehicleManage.FRM_CheLiangGuangLi_Update.FRM_CheLiangGuangLi_UpdateClient myFRM_CheLiangGuangLi_UpdateClient =
            new BLL集团客运综合管理.VehicleManage.FRM_CheLiangGuangLi_Update.FRM_CheLiangGuangLi_UpdateClient();
        public static AutoCompleteStringCollection fCollectionGongGong;
        static DataTable mydt;
        DataTable dtJiaShiYuan;
        DataTable dtFuJiaShiYuanYi;
        DataTable dtFuJiaShiYuanEr;
        DataTable dtCheLiangXinXi;
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
            mydt = myFRM_CheLiangGuangLi_UpdateClient.SelectDriverNumber().Tables[0];
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
        private void FRM_CheLiangGuangLi_Update_Load(object sender, EventArgs e)
        {
            mCreatePublicDatasetAndCollection();
            DataTable dtCheShuDanWei = myFRM_CheLiangGuangLi_UpdateClient.SelectCheShuDangWei().Tables[0];
            cboCheShuDanWei.DataSource = dtCheShuDanWei;
            cboCheShuDanWei.DisplayMember = "CarBelongToTheUnitMC";
            cboCheShuDanWei.ValueMember = "CarBelongToTheUnitID";
            DataTable dtChengBaoGonShi = myFRM_CheLiangGuangLi_UpdateClient.SelectChengBaoGonSi().Tables[0];
            cboChengBaoGonShi.DataSource = dtChengBaoGonShi;
            cboChengBaoGonShi.DisplayMember = "UnderwriteCompanyMC";
            cboChengBaoGonShi.ValueMember = "UnderwriteCompanyID";
            DataTable dtCheLiangXingHao = myFRM_CheLiangGuangLi_UpdateClient.SelectCheLiangLeiXing().Tables[0];
            cboCheLiangXingHao.DataSource = dtCheLiangXingHao;
            cboCheLiangXingHao.DisplayMember = "VehicleTypeMC";
            cboCheLiangXingHao.ValueMember = "VehicleTypeID";

            dtCheLiangXinXi = myFRM_CheLiangGuangLi_UpdateClient.SelectCheLiangXinXiByVehicleID(VVehicleID).Tables[0];
            txtCheLiangBianHao.Text = dtCheLiangXinXi.Rows[0]["VehicleNumber"].ToString().Trim();
            txtChePaiHao.Text = dtCheLiangXinXi.Rows[0]["VehiclePaiNumber"].ToString().Trim();
            dateDengJiRiQi.Value = Convert.ToDateTime(dtCheLiangXinXi.Rows[0]["RegisterDate"].ToString().Trim());
            txtZuoWeiShu.Text = dtCheLiangXinXi.Rows[0]["Seating"].ToString().Trim();
            txtZaiZhong.Text = dtCheLiangXinXi.Rows[0]["Loadheaver"].ToString().Trim();

            txtXinMing.Text = dtCheLiangXinXi.Rows[0]["VehicleHostMC"].ToString().Trim();
            txtLianXiDianHua.Text = dtCheLiangXinXi.Rows[0]["ContactPhone"].ToString().Trim();
            txtDiZi.Text = dtCheLiangXinXi.Rows[0]["Address"].ToString().Trim();
            txtShenFenZheng.Text = dtCheLiangXinXi.Rows[0]["Identification"].ToString().Trim();

            txtZhengJiaShi.Text = dtCheLiangXinXi.Rows[0]["DriverMC"].ToString().Trim();
            txtZhengJiaShiBianHao.Text = dtCheLiangXinXi.Rows[0]["DriverNumber"].ToString().Trim();
            txtFuJiaShiYi.Text = dtCheLiangXinXi.Rows[0]["FuJiaShiYuanYi"].ToString().Trim();
            txtFuJiaShiYiBianHao.Text = dtCheLiangXinXi.Rows[0]["FuJiaShiYuanBianHaoYi"].ToString().Trim();

            txtBaoXianDan.Text = dtCheLiangXinXi.Rows[0]["PolicyOfInsuranceMC"].ToString().Trim();
            dateJianDangRiQi.Value = Convert.ToDateTime(dtCheLiangXinXi.Rows[0]["BookbuildingDate"].ToString().Trim());
            dateJiaoQianXian.Value = Convert.ToDateTime(dtCheLiangXinXi.Rows[0]["Drivenvehicle"].ToString().Trim());
            dateChengYunRenXian.Value = Convert.ToDateTime(dtCheLiangXinXi.Rows[0]["Bearingonetransportrisk"].ToString().Trim());
            dateShangYeXian.Value = Convert.ToDateTime(dtCheLiangXinXi.Rows[0]["CommercialUnderwritingExecutive"].ToString().Trim());

            txtJingYinXianLu.Text = dtCheLiangXinXi.Rows[0]["BusinessLine"].ToString().Trim();
            txtFuKaHao.Text = dtCheLiangXinXi.Rows[0]["AttachedCardNumber"].ToString().Trim();
            txtXianLuPaiHao.Text = dtCheLiangXinXi.Rows[0]["LineNumber"].ToString().Trim();
            txtYingYunZhengHao.Text = dtCheLiangXinXi.Rows[0]["OperationOfTheNumber"].ToString().Trim();
            dateChunJianJiLu.Value = Convert.ToDateTime(dtCheLiangXinXi.Rows[0]["SpringRecords"].ToString().Trim());
            dateShengYanJiLu.Value = Convert.ToDateTime(dtCheLiangXinXi.Rows[0]["InspectionRecords"].ToString().Trim());
            dateErJiWeiHu.Value = Convert.ToDateTime(dtCheLiangXinXi.Rows[0]["CompleteMaintenance"].ToString().Trim());
            dateDengJiPingDing.Value = Convert.ToDateTime(dtCheLiangXinXi.Rows[0]["Rating"].ToString().Trim());
            dateYouXiaoQi.Value = Convert.ToDateTime(dtCheLiangXinXi.Rows[0]["Validity"].ToString().Trim());
            dateYueWeiHuRi.Value = Convert.ToDateTime(dtCheLiangXinXi.Rows[0]["MonthMaintainSun"].ToString().Trim());
            dateYeHuaQiZheng.Value = Convert.ToDateTime(dtCheLiangXinXi.Rows[0]["LiquefiedPetroleumGasCard"].ToString().Trim());
            txtBeiZhu.Text = dtCheLiangXinXi.Rows[0]["Comment"].ToString().Trim();

            radBuAnJian.Checked = Convert.ToBoolean(dtCheLiangXinXi.Rows[0]["SafeInspectNo"].ToString().Trim());
            radMeiCiBaoBanAnJian.Checked = Convert.ToBoolean(dtCheLiangXinXi.Rows[0]["EverySkySafeInspect"].ToString().Trim());
            radYiTianAnJianYiCi.Checked = Convert.ToBoolean(dtCheLiangXinXi.Rows[0]["OneSkySafeInspectOneNext"].ToString().Trim());
        }
        #endregion

        #region 修改车辆信息
        private void btnQueDing_Click(object sender, EventArgs e)
        {
            string VehicleHostMC = txtXinMing.Text.ToString().Trim();
            string Address = txtDiZi.Text.ToString().Trim();
            string ContactPhone = txtLianXiDianHua.Text.ToString().Trim();
            string Identification = txtShenFenZheng.Text.ToString().Trim();
            int VehicleHostID = Convert.ToInt32(dtCheLiangXinXi.Rows[0]["VehicleHostID"].ToString().Trim());
            int CheZhu = myFRM_CheLiangGuangLi_UpdateClient.UpdateCheZhuXinXi(
                VehicleHostMC, Address, ContactPhone, Identification, VehicleHostID);
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
            int VehicleLicenseID = Convert.ToInt32(dtCheLiangXinXi.Rows[0]["VehicleLicenseID"].ToString().Trim());
            int CheLiangZhengJian = myFRM_CheLiangGuangLi_UpdateClient.UpdateZhengJianXinXi(
                BusinessLine, LineNumber, AttachedCardNumber, OperationOfTheNumber,
                Validity, SpringRecords, InspectionRecords, CompleteMaintenance, Rating,
                TravelCard, MonthMaintainSun, LiquefiedPetroleumGasCard, VehicleLicenseID);
            int UnderwriteCompanyID = Convert.ToInt32(cboChengBaoGonShi.SelectedValue);
            string PolicyOfInsuranceMC = txtBaoXianDan.Text.ToString().Trim();
            DateTime BookbuildingDate = Convert.ToDateTime(dateJianDangRiQi.Text.ToString().Trim());
            DateTime Drivenvehicle = Convert.ToDateTime(dateJiaoQianXian.Text.ToString().Trim());
            DateTime CommercialUnderwritingExecutive = Convert.ToDateTime(dateShangYeXian.Text.ToString().Trim());
            DateTime Bearingonetransportrisk = Convert.ToDateTime(dateChengYunRenXian.Text.ToString().Trim());
            int PolicyOfInsuranceID = Convert.ToInt32(dtCheLiangXinXi.Rows[0]["PolicyOfInsuranceID"].ToString().Trim());
            int BaoXian = myFRM_CheLiangGuangLi_UpdateClient.UpdateBaoXianXinXi(
                UnderwriteCompanyID, PolicyOfInsuranceMC, BookbuildingDate, Drivenvehicle,
                CommercialUnderwritingExecutive, Bearingonetransportrisk, PolicyOfInsuranceID);
            if (CheLiangZhengJian != 0 && BaoXian != 0 && CheZhu != 0)
            {
                int VehicleTypeID = Convert.ToInt32(cboCheLiangXingHao.SelectedValue);
                int CarBelongToTheUnitID = Convert.ToInt32(cboCheShuDanWei.SelectedValue);
                int DriverID = Convert.ToInt32(dtJiaShiYuan.Rows[0]["DriverID"].ToString());
                int DriverAssistantID = Convert.ToInt32(dtFuJiaShiYuanYi.Rows[0]["DriverID"].ToString());
                string VehicleNumber = txtCheLiangBianHao.Text.ToString().Trim();
                string VehiclePaiNumber = txtChePaiHao.Text.ToString().Trim();
                DateTime RegisterDate = Convert.ToDateTime(dateDengJiRiQi.Text.ToString().Trim());
                string Loadheaver = txtZaiZhong.Text.ToString().Trim();
                bool SafeInspectNo = Convert.ToBoolean(radBuAnJian.Checked);
                bool EverySkySafeInspect = Convert.ToBoolean(radMeiCiBaoBanAnJian.Checked);
                bool OneSkySafeInspectOneNext = Convert.ToBoolean(radYiTianAnJianYiCi.Checked);
                string Comment = txtBeiZhu.Text.ToString().Trim();
                int CheLiang = myFRM_CheLiangGuangLi_UpdateClient.UpdateCheLiangXinXi(
                    VehicleTypeID, CarBelongToTheUnitID, DriverID, DriverAssistantID, VehiclePaiNumber, VehicleNumber,
                     RegisterDate, SafeInspectNo, EverySkySafeInspect, OneSkySafeInspectOneNext,
                    Comment, VVehicleID,Loadheaver);
                if (CheLiang > 0)
                {
                    MessageBox.Show("OK!");
                }
                else
                {
                    MessageBox.Show("NO!");
                }
            }
        }
        #endregion

        #region 查询驾驶员通过驾驶员编号
        private void txtZhengJiaShiBianHao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string DriverNumber = txtZhengJiaShiBianHao.Text;
                dtJiaShiYuan = myFRM_CheLiangGuangLi_UpdateClient.SelectJiaShiYuanByDriverNumber(DriverNumber).Tables[0];
                txtZhengJiaShi.Text = dtJiaShiYuan.Rows[0]["DriverMC"].ToString().Trim();
            }
            catch { }
        }

        private void txtFuJiaShiYiBianHao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string DriverNumber = txtFuJiaShiYiBianHao.Text;
                dtFuJiaShiYuanYi = myFRM_CheLiangGuangLi_UpdateClient.SelectJiaShiYuanByDriverNumber(DriverNumber).Tables[0];
                txtFuJiaShiYi.Text = dtFuJiaShiYuanYi.Rows[0]["DriverMC"].ToString().Trim();
            }
            catch { }
        }

        private void txtFuJiaShiErBianHao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string DriverNumber = txtFuJiaShiErBianHao.Text;
                dtFuJiaShiYuanEr = myFRM_CheLiangGuangLi_UpdateClient.SelectJiaShiYuanByDriverNumber(DriverNumber).Tables[0];
                txtFuJiaShiEr.Text = dtFuJiaShiYuanEr.Rows[0]["DriverMC"].ToString().Trim();
            }
            catch { }
        }
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

        private void btnQuXiao_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
