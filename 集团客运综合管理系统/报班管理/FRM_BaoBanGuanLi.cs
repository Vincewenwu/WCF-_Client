using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 集团客运综合管理系统.报班管理
{
    public partial class FRM_BaoBanGuanLi : Form
    {
        public FRM_BaoBanGuanLi()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.ClassesManage.FRM_BaoBanGuanLi.FRM_BaoBanGuanLiClient myFRM_BaoBanGuanLiClient
            = new BLL集团客运综合管理.ClassesManage.FRM_BaoBanGuanLi.FRM_BaoBanGuanLiClient();
        DataTable dts;
        DataTable dte;
        public static AutoCompleteStringCollection fCollectionCheLiangBianHao;
        public static DataSet dsPublic;
        static DataTable mydt;
        #region 自动完成查询条件
        public void mCreatePublicDatasetAndCollection()
        {
            if (fCollectionCheLiangBianHao != null)
            {
                fCollectionCheLiangBianHao.Clear();
            }
            if (mydt != null)
            {
                mydt.Clear();
            }
            fCollectionCheLiangBianHao = new AutoCompleteStringCollection();
            mydt = myFRM_BaoBanGuanLiClient.SelectCheLiangBianHao().Tables[0];
            foreach (DataRow dr in mydt.Rows)
            {
                fCollectionCheLiangBianHao.Add(dr["VehicleNumber"].ToString().Trim());
            }
            txtCheLiangBianHao.ImeMode = ImeMode.KatakanaHalf;
            txtCheLiangBianHao.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCheLiangBianHao.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCheLiangBianHao.AutoCompleteCustomSource = fCollectionCheLiangBianHao;
        }
        #endregion 

        #region Lood事件
        private void FRM_BaoBanGuanLi_Load(object sender, EventArgs e)
        {
            mCreatePublicDatasetAndCollection();
        }
        #endregion

        //public void ChaXunBaoBanXinXi()
        //{
        //    string VehicleNumber = txtCheLiangBianHao.Text.ToString().Trim();
        //    dts = myFRM_BaoBanGuanLiClient.SelectBaoBanXinXiByChePaiHao(VehicleNumber).Tables[0];
        //    txtChePaiHao.Text = dts.Rows[0]["VehiclePaiNumber"].ToString().Trim();
        //    txtDaiBanCheLiang.Text = dts.Rows[0]["VehiclePaiNumber"].ToString().Trim();
        //    txtBanCi.Text = dts.Rows[0]["FrequencyMC"].ToString().Trim();
        //    txtXianLu.Text = dts.Rows[0]["LineMC"].ToString().Trim();

        //    txtJinYingXianLu.Text = dts.Rows[0]["BusinessLine"].ToString().Trim();
        //    txtXianLuPaiHao.Text = dts.Rows[0]["LineNumber"].ToString().Trim();
        //    txtYingYunZhengHao.Text = dts.Rows[0]["OperationOfTheNumber"].ToString().Trim();
        //    txtErJiWeiHu.Text = dts.Rows[0]["CompleteMaintenance"].ToString().Trim();
        //    txtChunJianJiLu.Text = dts.Rows[0]["SpringRecords"].ToString().Trim();
        //    txtDengJiPingDing.Text = dts.Rows[0]["Rating"].ToString().Trim();
        //    txtYeHuaQiZheng.Text = dts.Rows[0]["LiquefiedPetroleumGasCard"].ToString().Trim();
        //    txtShenYanJiLu.Text = dts.Rows[0]["InspectionRecords"].ToString().Trim();
        //    txtFuKaHao.Text = dts.Rows[0]["AttachedCardNumber"].ToString().Trim();
        //    ritBeiZhu.Text = dts.Rows[0]["Comment"].ToString().Trim();

        //    txtQiShiZhangBianHao.Text = dts.Rows[0]["ShiFaZhanBianHao"].ToString().Trim();
        //    txtShiFaZhang.Text = dts.Rows[0]["ShiFaZhan"].ToString().Trim();
        //    txtShanCheZhangBianHao.Text = dts.Rows[0]["ShiFaZhanBianHao"].ToString().Trim();
        //    txtShanCheZhang.Text = dts.Rows[0]["ShiFaZhan"].ToString().Trim();
        //    txtZhongDianZhangBianHao.Text = dts.Rows[0]["ZhonDianZhanBianHao"].ToString().Trim();
        //    txtZhongDianZhang.Text = dts.Rows[0]["ZhonDianZhan"].ToString().Trim();
        //    txtFaCheShiJian.Text = dts.Rows[0]["DepartureTime"].ToString().Trim();
        //    txtZuoWei.Text = dts.Rows[0]["Seating"].ToString().Trim();
        //    txtShouPiaoCheXing.Text = dts.Rows[0]["QuasiDrivingTypeMC"].ToString().Trim();

        //    txtXingMing.Text = dts.Rows[0]["DriverMC"].ToString().Trim();
        //    txtDianHua.Text = dts.Rows[0]["ContactPhone"].ToString().Trim();
        //    txtJiaShiZhengHao.Text = dts.Rows[0]["DrivingLicenseNo"].ToString().Trim();
        //    txtZhunJiaCheXing.Text = dts.Rows[0]["QuasiDrivingTypeMC"].ToString().Trim();
        //    txtConYeZiGeZheng.Text = dts.Rows[0]["Certificate"].ToString().Trim();
        //    txtJiaShiYuanBianHai.Text = dts.Rows[0]["DriverNumber"].ToString().Trim();
        //    txtJiaZhengShengYanQi.Text = dts.Rows[0]["DrivingLicence"].ToString().Trim();
        //    txtShangGangZhengYouXiaoQi.Text = dts.Rows[0]["licensePeriod"].ToString().Trim();

        //    txtXingMing1.Text = dts.Rows[0]["FuJiaShi"].ToString().Trim();
        //    txtDianHua1.Text = dts.Rows[0]["LianXiDianHua"].ToString().Trim();
        //    txtJiaShiZhengHao1.Text = dts.Rows[0]["JiaShiZhengHao"].ToString().Trim();
        //    txtZhunJiaCheXing1.Text = dts.Rows[0]["ZhunJiaCheXing"].ToString().Trim();
        //    txtConYeZiGeZheng1.Text = dts.Rows[0]["ConYeZhiGeZheng"].ToString().Trim();
        //    txtJiaShiYuanBianHao1.Text = dts.Rows[0]["FuJiaShiBianHao"].ToString().Trim();
        //    txtJiaZhengShenYanQi1.Text = dts.Rows[0]["JiaZhengShengYanQi"].ToString().Trim();
        //    txtShanGangZhengYouXiaoQi1.Text = dts.Rows[0]["ShanGanYouXiaoQi"].ToString().Trim();

        //    txtBaoDanHao.Text = dts.Rows[0]["PolicyOfInsuranceMC"].ToString().Trim();
        //    txtJianDan.Text = dts.Rows[0]["BookbuildingDate"].ToString().Trim();
        //    txtChengBaoGonSi.Text = dts.Rows[0]["UnderwriteCompanyMC"].ToString().Trim();
        //    txtJiaoQiangXian.Text = dts.Rows[0]["Drivenvehicle"].ToString().Trim();
        //    txtJiaoQiangXian2.Text = dts.Rows[0]["Drivenvehicle"].ToString().Trim();
        //    txtShangYeXian.Text = dts.Rows[0]["CommercialUnderwritingExecutive"].ToString().Trim();
        //    txtShangYeXian2.Text = dts.Rows[0]["CommercialUnderwritingExecutive"].ToString().Trim();
        //    txtChengYunRenXian.Text = dts.Rows[0]["Bearingonetransportrisk"].ToString().Trim();
        //    txtChengYunRenXian2.Text = dts.Rows[0]["Bearingonetransportrisk"].ToString().Trim();

        //    txtCheShuDangWei.Text = dts.Rows[0]["CarBelongToTheUnitMC"].ToString().Trim();
        //    txtZuoWei2.Text = dts.Rows[0]["Seating"].ToString().Trim();
        //    txtZhaiZhong.Text = dts.Rows[0]["Loadheaver"].ToString().Trim();
        //    txtCheXing.Text = dts.Rows[0]["QuasiDrivingTypeMC"].ToString().Trim();
        //    txtZhenJiaShiBianHao.Text = dts.Rows[0]["DriverNumber"].ToString().Trim();
        //    txtZhenJiaShi.Text = dts.Rows[0]["DriverMC"].ToString().Trim();
        //    txtFuJiaShi.Text = dts.Rows[0]["FuJiaShi"].ToString().Trim();
        //    txtFuJiShiBianHao.Text = dts.Rows[0]["FuJiaShiBianHao"].ToString().Trim();

        //    int DriverID = Convert.ToInt32(dts.Rows[0]["DriverID"].ToString().Trim());
        //    byte[] mybyte = new byte[0];
        //    mybyte = myFRM_BaoBanGuanLiClient.SelectJiaShiYuanXianPian(DriverID);
        //    MemoryStream ms = new MemoryStream(mybyte);
        //    picTuPian1.SizeMode = PictureBoxSizeMode.StretchImage;
        //    picTuPian1.Image = Image.FromStream(ms);

        //    int FuJiaShiYuanID = Convert.ToInt32(dts.Rows[0]["FuJiaShiYuan"].ToString().Trim());
        //    byte[] mysbyte = new byte[0];
        //    mysbyte = myFRM_BaoBanGuanLiClient.SelectJiaShiYuanXianPian(FuJiaShiYuanID);
        //    MemoryStream mse = new MemoryStream(mysbyte);
        //    picTuPian2.SizeMode = PictureBoxSizeMode.StretchImage;
        //    picTuPian2.Image = Image.FromStream(mse);
        //    if (dts != null)
        //    {
        //        labDuKaNeiYong.Text = "读卡成功！";
        //    }
        //    else
        //    {
        //        labDuKaNeiYong.Text = "读卡失败！";
        //    }
        //}

        #region 通过车牌号查询报班信息
        private void btnDuKa_Click(object sender, EventArgs e)
        {
            string VehicleNumber = txtCheLiangBianHao.Text.ToString().Trim();
            dts = myFRM_BaoBanGuanLiClient.SelectBaoBanXinXiByChePaiHao(VehicleNumber).Tables[0];
            txtChePaiHao.Text = dts.Rows[0]["VehiclePaiNumber"].ToString().Trim();
            txtDaiBanCheLiang.Text = dts.Rows[0]["VehiclePaiNumber"].ToString().Trim();
            txtBanCi.Text = dts.Rows[0]["FrequencyMC"].ToString().Trim();
            txtXianLu.Text = dts.Rows[0]["LineMC"].ToString().Trim();

            txtJinYingXianLu.Text = dts.Rows[0]["BusinessLine"].ToString().Trim();
            txtXianLuPaiHao.Text = dts.Rows[0]["LineNumber"].ToString().Trim();
            txtYingYunZhengHao.Text = dts.Rows[0]["OperationOfTheNumber"].ToString().Trim();
            txtErJiWeiHu.Text = dts.Rows[0]["CompleteMaintenance"].ToString().Trim();
            txtChunJianJiLu.Text = dts.Rows[0]["SpringRecords"].ToString().Trim();
            txtDengJiPingDing.Text = dts.Rows[0]["Rating"].ToString().Trim();
            txtYeHuaQiZheng.Text = dts.Rows[0]["LiquefiedPetroleumGasCard"].ToString().Trim();
            txtShenYanJiLu.Text = dts.Rows[0]["InspectionRecords"].ToString().Trim();
            txtFuKaHao.Text = dts.Rows[0]["AttachedCardNumber"].ToString().Trim();
            ritBeiZhu.Text = dts.Rows[0]["Comment"].ToString().Trim();

            txtQiShiZhangBianHao.Text = dts.Rows[0]["ShiFaZhanBianHao"].ToString().Trim();
            txtShiFaZhang.Text = dts.Rows[0]["ShiFaZhan"].ToString().Trim();
            txtShanCheZhangBianHao.Text = dts.Rows[0]["ShiFaZhanBianHao"].ToString().Trim();
            txtShanCheZhang.Text = dts.Rows[0]["ShiFaZhan"].ToString().Trim();
            txtZhongDianZhangBianHao.Text = dts.Rows[0]["ZhonDianZhanBianHao"].ToString().Trim();
            txtZhongDianZhang.Text = dts.Rows[0]["ZhonDianZhan"].ToString().Trim();
            txtFaCheShiJian.Text = dts.Rows[0]["DepartureTime"].ToString().Trim();
            txtZuoWei.Text = dts.Rows[0]["Seating"].ToString().Trim();
            txtShouPiaoCheXing.Text = dts.Rows[0]["QuasiDrivingTypeMC"].ToString().Trim();

            txtXingMing.Text = dts.Rows[0]["DriverMC"].ToString().Trim();
            txtDianHua.Text = dts.Rows[0]["ContactPhone"].ToString().Trim();
            txtJiaShiZhengHao.Text = dts.Rows[0]["DrivingLicenseNo"].ToString().Trim();
            txtZhunJiaCheXing.Text = dts.Rows[0]["QuasiDrivingTypeMC"].ToString().Trim();
            txtConYeZiGeZheng.Text = dts.Rows[0]["Certificate"].ToString().Trim();
            txtJiaShiYuanBianHai.Text = dts.Rows[0]["DriverNumber"].ToString().Trim();
            txtJiaZhengShengYanQi.Text = dts.Rows[0]["DrivingLicence"].ToString().Trim();
            txtShangGangZhengYouXiaoQi.Text = dts.Rows[0]["licensePeriod"].ToString().Trim();

            txtXingMing1.Text = dts.Rows[0]["FuJiaShi"].ToString().Trim();
            txtDianHua1.Text = dts.Rows[0]["LianXiDianHua"].ToString().Trim();
            txtJiaShiZhengHao1.Text = dts.Rows[0]["JiaShiZhengHao"].ToString().Trim();
            txtZhunJiaCheXing1.Text = dts.Rows[0]["ZhunJiaCheXing"].ToString().Trim();
            txtConYeZiGeZheng1.Text = dts.Rows[0]["ConYeZhiGeZheng"].ToString().Trim();
            txtJiaShiYuanBianHao1.Text = dts.Rows[0]["FuJiaShiBianHao"].ToString().Trim();
            txtJiaZhengShenYanQi1.Text = dts.Rows[0]["JiaZhengShengYanQi"].ToString().Trim();
            txtShanGangZhengYouXiaoQi1.Text = dts.Rows[0]["ShanGanYouXiaoQi"].ToString().Trim();

            txtBaoDanHao.Text = dts.Rows[0]["PolicyOfInsuranceMC"].ToString().Trim();
            txtJianDan.Text = dts.Rows[0]["BookbuildingDate"].ToString().Trim();
            txtChengBaoGonSi.Text = dts.Rows[0]["UnderwriteCompanyMC"].ToString().Trim();
            txtJiaoQiangXian.Text = dts.Rows[0]["Drivenvehicle"].ToString().Trim();
            txtJiaoQiangXian2.Text = dts.Rows[0]["Drivenvehicle"].ToString().Trim();
            txtShangYeXian.Text = dts.Rows[0]["CommercialUnderwritingExecutive"].ToString().Trim();
            txtShangYeXian2.Text = dts.Rows[0]["CommercialUnderwritingExecutive"].ToString().Trim();
            txtChengYunRenXian.Text = dts.Rows[0]["Bearingonetransportrisk"].ToString().Trim();
            txtChengYunRenXian2.Text = dts.Rows[0]["Bearingonetransportrisk"].ToString().Trim();

            txtCheShuDangWei.Text = dts.Rows[0]["CarBelongToTheUnitMC"].ToString().Trim();
            txtZuoWei2.Text = dts.Rows[0]["Seating"].ToString().Trim();
            txtZhaiZhong.Text = dts.Rows[0]["Loadheaver"].ToString().Trim();
            txtCheXing.Text = dts.Rows[0]["QuasiDrivingTypeMC"].ToString().Trim();
            txtZhenJiaShiBianHao.Text = dts.Rows[0]["DriverNumber"].ToString().Trim();
            txtZhenJiaShi.Text = dts.Rows[0]["DriverMC"].ToString().Trim();
            txtFuJiaShi.Text = dts.Rows[0]["FuJiaShi"].ToString().Trim();
            txtFuJiShiBianHao.Text = dts.Rows[0]["FuJiaShiBianHao"].ToString().Trim();

            int DriverID = Convert.ToInt32(dts.Rows[0]["DriverID"].ToString().Trim());
            byte[] mybyte = new byte[0];
            mybyte = myFRM_BaoBanGuanLiClient.SelectJiaShiYuanXianPian(DriverID);
            MemoryStream ms = new MemoryStream(mybyte);
            picTuPian1.SizeMode = PictureBoxSizeMode.StretchImage;
            picTuPian1.Image = Image.FromStream(ms);

            int FuJiaShiYuanID = Convert.ToInt32(dts.Rows[0]["FuJiaShiYuan"].ToString().Trim());
            byte[] mysbyte = new byte[0];
            mysbyte = myFRM_BaoBanGuanLiClient.SelectJiaShiYuanXianPian(FuJiaShiYuanID);
            MemoryStream mse = new MemoryStream(mysbyte);
            picTuPian2.SizeMode = PictureBoxSizeMode.StretchImage;
            picTuPian2.Image = Image.FromStream(mse);
            if (dts != null)
            {
                labDuKaNeiYong.Text = "读卡成功！";
            }
            else
            {
                labDuKaNeiYong.Text = "读卡失败！";
            }
        }
        #endregion

        #region 关闭窗体
        private void btnQuXiao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region 新增车辆报班信息
        private void btnBaoCun_Click(object sender, EventArgs e)
        {
            int FrequencyID = Convert.ToInt32(dts.Rows[0]["FrequencyID"].ToString().Trim());
            bool WhetherNnSchedule = Convert.ToBoolean(radZhengDian.Checked);
            bool WhetherLate = Convert.ToBoolean(chkDaiBanFou.Checked);
            bool StayClassVehicleNo = Convert.ToBoolean(chkDaiBanFou.Checked);
            string Comment = ricBeiZhu2.Text.ToString().Trim();
            int result = myFRM_BaoBanGuanLiClient.InsertBaoBanXinXi(FrequencyID,
                WhetherNnSchedule,WhetherLate, StayClassVehicleNo, Comment);
            if (result != 0)
            {
                int VehicleID = Convert.ToInt32(dts.Rows[0]["VehicleID"].ToString().Trim());
                int ZhuangTai = myFRM_BaoBanGuanLiClient.UpdateVehicleState(VehicleID);
                if (ZhuangTai > 0)
                {
                    MessageBox.Show("OK!");
                    txtChePaiHao.Text = "";
                    txtDaiBanCheLiang.Text = "";
                    txtBanCi.Text = "";
                    txtXianLu.Text = "";
                    txtFuJiaShi.Text = "";
                    txtFuJiShiBianHao.Text = "";
                    ritBeiZhu.Text = "";

                    txtJinYingXianLu.Text = "";
                    txtXianLuPaiHao.Text = "";
                    txtYingYunZhengHao.Text = "";
                    txtErJiWeiHu.Text = "";
                    txtChunJianJiLu.Text = "";
                    txtDengJiPingDing.Text = "";
                    txtYeHuaQiZheng.Text = "";
                    txtShenYanJiLu.Text = "";
                    txtFuKaHao.Text = "";
                    ritBeiZhu.Text = "";

                    txtQiShiZhangBianHao.Text = "";
                    txtShiFaZhang.Text = "";
                    txtShanCheZhangBianHao.Text = "";
                    txtShanCheZhang.Text = "";
                    txtZhongDianZhangBianHao.Text = "";
                    txtZhongDianZhang.Text = "";
                    txtFaCheShiJian.Text = "";
                    txtZuoWei.Text = "";
                    txtShouPiaoCheXing.Text = "";

                    txtXingMing.Text = "";
                    txtDianHua.Text = "";
                    txtJiaShiZhengHao.Text = "";
                    txtZhunJiaCheXing.Text = "";
                    txtConYeZiGeZheng.Text = "";
                    txtJiaShiYuanBianHai.Text = "";
                    txtJiaZhengShenYanQi1.Text = "";
                    txtShangGangZhengYouXiaoQi.Text = "";

                    txtXingMing1.Text = "";
                    txtDianHua1.Text = "";
                    txtJiaShiZhengHao1.Text = "";
                    txtZhunJiaCheXing1.Text = "";
                    txtConYeZiGeZheng1.Text = "";
                    txtJiaShiYuanBianHao1.Text = "";
                    txtJiaZhengShenYanQi1.Text = "";
                    txtShanGangZhengYouXiaoQi1.Text = "";
                    txtJiaZhengShenYanQi1.Text = "";

                    txtBaoDanHao.Text = "";
                    txtJianDan.Text = "";
                    txtChengBaoGonSi.Text = "";
                    txtJiaoQiangXian.Text = "";
                    txtJiaoQiangXian2.Text = "";
                    txtShangYeXian.Text = "";
                    txtShangYeXian2.Text = "";
                    txtChengYunRenXian.Text = "";
                    txtChengYunRenXian2.Text = "";

                    txtCheShuDangWei.Text = "";
                    txtZuoWei2.Text = "";
                    txtZhaiZhong.Text = "";
                    txtCheXing.Text = "";
                    txtZhenJiaShiBianHao.Text = "";
                    txtZhenJiaShi.Text = "";
                    labDuKaNeiYong.Text = "";
                }
                else
                {
                    MessageBox.Show("ON!");
                }
            }
            else
            {
                MessageBox.Show("此行没数据!");
            }


        }
        #endregion
        
    }
}
