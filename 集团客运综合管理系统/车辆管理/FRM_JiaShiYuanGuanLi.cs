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

namespace 集团客运综合管理系统.车辆管理
{
    public partial class FRM_JiaShiYuanGuanLi : Form
    {
        public FRM_JiaShiYuanGuanLi()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.VehicleManage.FRM_JiaShiYuanGuanLi.FRM_JiaShiYuanGuanLiClient myFRM_JiaShiYuanGuanLiClient =
            new BLL集团客运综合管理.VehicleManage.FRM_JiaShiYuanGuanLi.FRM_JiaShiYuanGuanLiClient();
        public static AutoCompleteStringCollection fCollectionGongGong;
        static DataTable mydt;
        public static string PicName = "";
        int DriverID = 0;
        public void CreatePublicDatasetAndCollection()
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
            mydt = myFRM_JiaShiYuanGuanLiClient.SelectJiaShiYuanBianHao().Tables[0];
            foreach (DataRow dr in mydt.Rows)
            {
                fCollectionGongGong.Add(dr["DriverNumber"].ToString().Trim());
            }
            txtJiaShiYuanBianHao.ImeMode = ImeMode.KatakanaHalf;
            txtJiaShiYuanBianHao.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtJiaShiYuanBianHao.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtJiaShiYuanBianHao.AutoCompleteCustomSource = fCollectionGongGong;
        }

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
        private void FRM_JiaShiYuanGuanLi_Load(object sender, EventArgs e)
        {
            CreatePublicDatasetAndCollection();
            dgvJiaShiYuanXinXi.DataSource = myFRM_JiaShiYuanGuanLiClient.SelectJiaShiYuanXinXi().Tables[0];
            DataTable dtJiaShiYuan = myFRM_JiaShiYuanGuanLiClient.SelectJiaShiYuanMingCheng().Tables[0];
            cboJiaShiYuan.DataSource = dtJiaShiYuan;
            cboJiaShiYuan.DisplayMember = "DriverMC";
            cboJiaShiYuan.ValueMember = "DriverID";
        }
        #endregion

        #region 查询驾驶员信息通过驾驶员编号
        private void txtJiaShiYuanBianHao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string DriverNumber = txtJiaShiYuanBianHao.Text;
                DataTable dt = myFRM_JiaShiYuanGuanLiClient.
                    SelectJiaShiYuanXinXiByJiaShiYuanBianHao(DriverNumber).Tables[0];
                dgvJiaShiYuanXinXi.DataSource = dt;
            }
            catch { }
        }
        #endregion

        #region  下拉框自动查询
        private void cboJiaShiYuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int DriverID = Convert.ToInt32(cboJiaShiYuan.SelectedValue);
                dgvJiaShiYuanXinXi.DataSource = myFRM_JiaShiYuanGuanLiClient.
                    SelectJiaShiYuanXinXiByJiaShiYuanID(DriverID).Tables[0];
            }
            catch { }
        }
        #endregion

        #region 按钮事件

        #region 实例化窗体
        private void btnXinZeng_Click(object sender, EventArgs e)
        {
            SYS_PublicStaticClass.PublicStaticObject.FRM_JiaShiYuanGuanLi_Insert = new FRM_JiaShiYuanGuanLi_Insert();
            SYS_PublicStaticClass.PublicStaticObject.FRM_JiaShiYuanGuanLi_Insert.ShowDialog();
            dgvJiaShiYuanXinXi.DataSource = myFRM_JiaShiYuanGuanLiClient.SelectJiaShiYuanXinXi().Tables[0];
        }

        private void btnXiuGai_Click(object sender, EventArgs e)
        {
            int DriverID = Convert.ToInt32(dgvJiaShiYuanXinXi.CurrentRow.Cells["驾驶员ID"].Value.ToString());
            SYS_PublicStaticClass.PublicStaticObject.FRM_JiaShiYuanGuanLi_Update = new FRM_JiaShiYuanGuanLi_Update(DriverID);
            SYS_PublicStaticClass.PublicStaticObject.FRM_JiaShiYuanGuanLi_Update.ShowDialog();
            dgvJiaShiYuanXinXi.DataSource = myFRM_JiaShiYuanGuanLiClient.SelectJiaShiYuanXinXi().Tables[0];
        }
        private void btnDaYin_Click(object sender, EventArgs e)
        {
            SYS_PublicStaticClass.PublicStaticObject.FRM_JiaShiYuanXinXi = new FRM_JiaShiYuanXinXi();
            SYS_PublicStaticClass.PublicStaticObject.FRM_JiaShiYuanXinXi.ShowDialog();
        }
        #endregion

        #region 删除驾驶员ID
        private void btnShanChu_Click(object sender, EventArgs e)
        {
            int DriverID = Convert.ToInt32(dgvJiaShiYuanXinXi.CurrentRow.Cells["驾驶员ID"].Value);
            int result=myFRM_JiaShiYuanGuanLiClient.DeleteJiaShiYuanXinXi(DriverID);
            dgvJiaShiYuanXinXi.DataSource = myFRM_JiaShiYuanGuanLiClient.SelectJiaShiYuanXinXi().Tables[0];
        }
        #endregion

        #region 关闭窗体
        private void btnTuiChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
        

        #endregion

        #region dgv单击事件
        private void dgvJiaShiYuanXinXi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvJiaShiYuanXinXi.DataSource = myFRM_JiaShiYuanGuanLiClient.SelectJiaShiYuanXinXi().Tables[0];
        }
        #endregion

        private void dgvJiaShiYuanXinXi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvJiaShiYuanXinXi.CurrentRow != null)
            {
                DriverID = Convert.ToInt32(dgvJiaShiYuanXinXi.CurrentRow.Cells["驾驶员ID"].Value);
                DataTable dt = myFRM_JiaShiYuanGuanLiClient.SelectJiaShiYuanXiangXiXinXiByJiaShiYuanID(DriverID).Tables[0];
                txtXinMing.Text = dt.Rows[0]["DriverMC"].ToString().Trim();
                txtXinBie.Text = dt.Rows[0]["Sex"].ToString().Trim();
                txtLianXiDianHua.Text = dt.Rows[0]["ContactPhone"].ToString().Trim();
                txtShenFenZhengHao.Text = dt.Rows[0]["Identification"].ToString().Trim();
                txtJiaShiZhenHao.Text = dt.Rows[0]["DrivingLicenseNo"].ToString().Trim();
                txtZhunJiaCheXing.Text = dt.Rows[0]["QuasiDrivingTypeMC"].ToString().Trim();
                txtJiGouZuZhi.Text = dt.Rows[0]["OrganizationMC"].ToString().Trim();
                txtConYeZiGeZhen.Text = dt.Rows[0]["Certificate"].ToString().Trim();
                txtJiaShiCheLianBianHao.Text = dt.Rows[0]["DriverVehicleNumber"].ToString().Trim();
                rtxtBeiZhu.Text = dt.Rows[0]["Comment"].ToString().Trim();
                dtpShanGangYouXiaoQi.Value = Convert.ToDateTime(dt.Rows[0]["licensePeriod"].ToString().Trim());
                dtpJiaZhenShenYanQi.Value = Convert.ToDateTime(dt.Rows[0]["DrivingLicence"].ToString().Trim());
                dtpConYeZiGeShenYanQi.Value = Convert.ToDateTime(dt.Rows[0]["CertificateLicence"].ToString().Trim());

                byte[] mybyte = new byte[0];
                mybyte = myFRM_JiaShiYuanGuanLiClient.SelectJiaShiYuanTuPian(DriverID);
                MemoryStream ms = new MemoryStream(mybyte);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromStream(ms);
            }
        }
    }
}
