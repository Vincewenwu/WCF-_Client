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
    public partial class FRM_CheLiangGuangLi : Form
    {
        public FRM_CheLiangGuangLi()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.VehicleManage.FRM_CheLiangGuangLi.FRM_CheLiangGuangLiClient myFRM_CheLiangGuangLiClient
            = new BLL集团客运综合管理.VehicleManage.FRM_CheLiangGuangLi.FRM_CheLiangGuangLiClient();
        public static AutoCompleteStringCollection fCollectionGongGong;
        static DataTable mydt;
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
            mydt = myFRM_CheLiangGuangLiClient.SelectCheLiangBianHao().Tables[0];
            foreach (DataRow dr in mydt.Rows)
            {
                fCollectionGongGong.Add(dr["VehicleNumber"].ToString().Trim());
            }
            txtCheLiangBianHao1.ImeMode = ImeMode.KatakanaHalf;
            txtCheLiangBianHao1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCheLiangBianHao1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCheLiangBianHao1.AutoCompleteCustomSource = fCollectionGongGong;
            foreach (DataRow dr in mydt.Rows)
            {
                fCollectionGongGong.Add(dr["VehiclePaiNumber"].ToString().Trim());
            }
            txtChePaiHao1.ImeMode = ImeMode.KatakanaHalf;
            txtChePaiHao1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtChePaiHao1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtChePaiHao1.AutoCompleteCustomSource = fCollectionGongGong;
        }
        #endregion

        #region 联想自动查询
        public static int mReturnSurfaceLandID1(string VehicleNumber)
        {
            try
            {
                DataTable newDt;
                var queryZhanDian =
                        from myVar in mydt.AsEnumerable()
                        where (string)myVar["VehicleNumber"] == VehicleNumber
                        select myVar;
                newDt = queryZhanDian.CopyToDataTable<DataRow>();
                return Convert.ToInt32(newDt.Rows[0]["VehicleNumber"]);
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        #region 联想自动查询
        public static int mReturnSurfaceLandID2(string VehiclePaiNumber)
        {
            try
            {
                DataTable newDt;
                var queryZhanDian =
                        from myVar in mydt.AsEnumerable()
                        where (string)myVar["VehiclePaiNumber"] == VehiclePaiNumber
                        select myVar;
                newDt = queryZhanDian.CopyToDataTable<DataRow>();
                return Convert.ToInt32(newDt.Rows[0]["VehiclePaiNumber"]);
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        #region Lood事件
        private void FRM_CheLiangGuangLi_Load(object sender, EventArgs e)
        {
            mCreatePublicDatasetAndCollection();
            dgvCheLiangXinXi.DataSource = myFRM_CheLiangGuangLiClient.SelectCheLiangXinXi().Tables[0];
        }
        #endregion

        #region 查询车辆信息

        #endregion

        #region 实例化窗体
        private void tlsXingZenCheLiang_Click(object sender, EventArgs e)
        {
            SYS_PublicStaticClass.PublicStaticObject.FRM_CheLiangGuangLi_Insert = new FRM_CheLiangGuangLi_Insert();
            SYS_PublicStaticClass.PublicStaticObject.FRM_CheLiangGuangLi_Insert.ShowDialog();
            dgvCheLiangXinXi.DataSource = myFRM_CheLiangGuangLiClient.SelectCheLiangXinXi().Tables[0];
        }

        private void tlsXiuGaiCheLiang_Click(object sender, EventArgs e)
        {
            int VehicleID = Convert.ToInt32(dgvCheLiangXinXi.CurrentRow.Cells["车辆ID"].Value);
            SYS_PublicStaticClass.PublicStaticObject.FRM_CheLiangGuangLi_Update = new FRM_CheLiangGuangLi_Update
                (VehicleID);
            SYS_PublicStaticClass.PublicStaticObject.FRM_CheLiangGuangLi_Update.ShowDialog();
            dgvCheLiangXinXi.DataSource = myFRM_CheLiangGuangLiClient.SelectCheLiangXinXi().Tables[0];
        }
        #endregion

        #region 删除车辆信息
        private void tsbShanChuCheLiang_Click(object sender, EventArgs e)
        {
            int Count = 0;
            int VehicleHostID = Convert.ToInt32(dgvCheLiangXinXi.CurrentRow.Cells["车主ID"].Value);
            int CheZhu = myFRM_CheLiangGuangLiClient.DeleteCheZhuXinXi(VehicleHostID);
            int PolicyOfInsuranceID = Convert.ToInt32(dgvCheLiangXinXi.CurrentRow.Cells["保险ID"].Value);
            int BaoXian = myFRM_CheLiangGuangLiClient.DeleteBaoXianXinXi(PolicyOfInsuranceID);
            int VehicleLicenseID = Convert.ToInt32(dgvCheLiangXinXi.CurrentRow.Cells["证件信息ID"].Value);
            int ZhengJian = myFRM_CheLiangGuangLiClient.DeleteCheLiangZhengJianXinXi(VehicleLicenseID);
            if(CheZhu > 0 && BaoXian > 0 && ZhengJian > 0)
            {
                int VehicleID = Convert.ToInt32(dgvCheLiangXinXi.CurrentRow.Cells["车辆ID"].Value);
                int CheLiang = myFRM_CheLiangGuangLiClient.DeleteCheLiangXinXi(VehicleID);
                if (CheLiang > 0)
                {
                    Count += myFRM_CheLiangGuangLiClient.DeleteXiWei(VehicleID);
                }
                if (Count > 0)
                {
                    MessageBox.Show("OK");
                    dgvCheLiangXinXi.DataSource = myFRM_CheLiangGuangLiClient.SelectCheLiangXinXi().Tables[0];
                    dgvCheLiangXinXi_CellClick(null, null);
                }
                else
                {
                    MessageBox.Show("NO!");
                }
            }
        }
        #endregion

        #region 查询车辆信息通过车牌号
        private void txtChePaiHao1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string VehiclePaiNumber = txtChePaiHao1.Text.ToString().Trim();
                DataTable dtChePaiHao = myFRM_CheLiangGuangLiClient.SelectCheLiangXinXiByVehiclePaiNumber
                    (VehiclePaiNumber).Tables[0];
                dgvCheLiangXinXi.DataSource = dtChePaiHao;
            }
            catch { }
        }
        #endregion

        #region 查询车辆信息通过车辆编号
        private void txtCheLiangBianHao1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string VehicleNumber = txtCheLiangBianHao1.Text.ToString().Trim();
                DataTable dtCheLiangBianHao = myFRM_CheLiangGuangLiClient.SelectCheLiangXinXiByVehicleNumber
                    (VehicleNumber).Tables[0];
                dgvCheLiangXinXi.DataSource = dtCheLiangBianHao;
            }
            catch { }
        }
        #endregion

        #region dgv单击车辆明细信息
        private void dgvCheLiangXinXi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCheLiangXinXi.CurrentRow != null)
            {
                int VehicleID = Convert.ToInt32(dgvCheLiangXinXi.CurrentRow.Cells["车辆ID"].Value);
                DataTable dt = myFRM_CheLiangGuangLiClient.SelectCheLiangMingXiXinXi(VehicleID).Tables[0];
                txtChePaiHao.Text = dt.Rows[0]["VehiclePaiNumber"].ToString().Trim();
                txtDenJiRiQi.Text = dt.Rows[0]["RegisterDate"].ToString().Trim();
                txtCheLiangXinHao.Text = dt.Rows[0]["VehicleTypeMC"].ToString().Trim();
                txtCheShuDanWei.Text = dt.Rows[0]["CarBelongToTheUnitMC"].ToString().Trim();
                txtZuoWeiShu.Text = dt.Rows[0]["Seating"].ToString().Trim();
                txtZaiZhong.Text = dt.Rows[0]["Loadheaver"].ToString().Trim();
                txtXinMing.Text = dt.Rows[0]["VehicleHostMC"].ToString().Trim();
                txtLianXiDianHua.Text = dt.Rows[0]["ContactPhone"].ToString().Trim();
                txtDiZi.Text = dt.Rows[0]["Address"].ToString().Trim();
                txtShenFenZheng.Text = dt.Rows[0]["Identification"].ToString().Trim();
                txtZhengJiaShi.Text = dt.Rows[0]["DriverMC"].ToString().Trim();
                txtZhengJiaShiBianHao.Text = dt.Rows[0]["DriverNumber"].ToString().Trim();
                txtFuJiaShiYi.Text = dt.Rows[0]["FuJiaShiYi"].ToString().Trim();
                txtFuJiaShiYiBianHao.Text = dt.Rows[0]["FuJiaShiBianHaoYi"].ToString().Trim();
                txtBeiZhu.Text = dt.Rows[0]["Comment"].ToString().Trim();
                radBuAnJian.Checked = Convert.ToBoolean(dt.Rows[0]["SafeInspectNo"].ToString().Trim());
                radMeiCiBaoBanAnJian.Checked = Convert.ToBoolean(dt.Rows[0]["EverySkySafeInspect"].ToString().Trim());
                radYiTianAnJianYiCi.Checked = Convert.ToBoolean(dt.Rows[0]["OneSkySafeInspectOneNext"].ToString().Trim());
            }
        }
        #endregion

        private void dgvCheLiangXinXi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCheLiangXinXi.DataSource = myFRM_CheLiangGuangLiClient.SelectCheLiangXinXi().Tables[0];
        }
    }
}
