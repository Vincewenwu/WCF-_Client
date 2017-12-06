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
    public partial class FRM_JiaShiYuanGuanLi_Update : Form
    {
        public FRM_JiaShiYuanGuanLi_Update()
        {
            InitializeComponent();
        }
        public FRM_JiaShiYuanGuanLi_Update(int DriverID)
        {
            InitializeComponent();
            DDriverID = DriverID;
        }
        int DDriverID = 0;
        byte[] TuPian;
        BLL集团客运综合管理.VehicleManage.FRM_JiaShiYuanGuanLi_Update.FRM_JiaShiYuanGuanLi_UpdateClient myFRM_JiaShiYuanGuanLi_UpdateClient =
           new BLL集团客运综合管理.VehicleManage.FRM_JiaShiYuanGuanLi_Update.FRM_JiaShiYuanGuanLi_UpdateClient();

        #region Load事件
        private void FRM_JiaShiYuanGuanLi_Update_Load(object sender, EventArgs e)
        {
            DataTable dtJiGouZuZi = myFRM_JiaShiYuanGuanLi_UpdateClient.SelectOrganization().Tables[0];
            cboJiGouZuZhi.DataSource = dtJiGouZuZi;
            cboJiGouZuZhi.DisplayMember = "OrganizationMC";
            cboJiGouZuZhi.ValueMember = "OrganizationID";
            DataTable dtZhunJiaCheXing = myFRM_JiaShiYuanGuanLi_UpdateClient.SelectQuasiDrivingType().Tables[0];
            cboZhunJiaCheXing.DataSource = dtZhunJiaCheXing;
            cboZhunJiaCheXing.DisplayMember = "QuasiDrivingTypeMC";
            cboZhunJiaCheXing.ValueMember = "QuasiDrivingTypeID";
            DataTable dtDriver = myFRM_JiaShiYuanGuanLi_UpdateClient.SelectJiaShiYuanXinXiByDriverID(DDriverID).Tables[0];
            txtXingMing.Text = dtDriver.Rows[0]["DriverMC"].ToString().Trim();
            txtXingBie.Text = dtDriver.Rows[0]["Sex"].ToString().Trim();
            txtLiangXiDianHua.Text = dtDriver.Rows[0]["ContactPhone"].ToString().Trim();
            txtShengFenZhengHao.Text = dtDriver.Rows[0]["Identification"].ToString().Trim();
            txtJiaShiZhengHao.Text = dtDriver.Rows[0]["DrivingLicenseNo"].ToString().Trim();
            txtConYeZhiGeZheng.Text = dtDriver.Rows[0]["Certificate"].ToString().Trim();
            txtJiaShiCheLiangBianHao.Text = dtDriver.Rows[0]["DriverVehicleNumber"].ToString().Trim();
            rtxtBeiZhu.Text = dtDriver.Rows[0]["Comment"].ToString().Trim();
            txtJiaShiYuanBianHao.Text = dtDriver.Rows[0]["DriverNumber"].ToString().Trim();
            txtJiaLing.Text = dtDriver.Rows[0]["DriveAge"].ToString().Trim();
            dtpShangGanYouXiaoQi.Value = Convert.ToDateTime(dtDriver.Rows[0]["licensePeriod"].ToString().Trim());
            dtpJiaZhengShengYanQi.Value = Convert.ToDateTime(dtDriver.Rows[0]["DrivingLicence"].ToString().Trim());
            dtpConYeZiGeShengYangQi.Value = Convert.ToDateTime(dtDriver.Rows[0]["CertificateLicence"].ToString().Trim());

            byte[] mybyte = new byte[0];
            mybyte = myFRM_JiaShiYuanGuanLi_UpdateClient.SelectJiaShiYuanTuPian(DDriverID);
            string ff = mybyte.ToString().Trim();
            MemoryStream ms = new MemoryStream(mybyte);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromStream(ms);
        }
        #endregion

        #region  按钮事件

        #region  打开路径选择图片并转成二进制
        private void btnDaKai_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = " 请选择图片";
            openfile.Filter = "Login图片 (*.jpg;*.bmp;*png)|*.jpeg;*.jpg;*.bmp;*.png|AllFiles(*.*)|*.*";//内容格式
            if (DialogResult.OK == openfile.ShowDialog())//打开文件 ==》选择内容
            {
                Bitmap bmp = new Bitmap(openfile.FileName);
                pictureBox1.Image = bmp;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;//打开图片
                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length);
                ms.Close();
                TuPian = arr;
            }
        }
        #endregion

        #region 修改驾驶员信息
        private void btnBaoCun_Click(object sender, EventArgs e)
        {
            int QuasiDrivingTypeID = Convert.ToInt32(cboZhunJiaCheXing.SelectedValue);
            int OrganizationID = Convert.ToInt32(cboJiGouZuZhi.SelectedValue);
            string ContactPhone = txtLiangXiDianHua.Text.ToString().Trim();
            int DriveAge = Convert.ToInt32(txtJiaLing.Text.ToString().Trim());
            string DrivingLicenseNo = txtJiaShiZhengHao.Text.ToString().Trim();
            string DriverNumber = txtJiaShiYuanBianHao.Text.ToString().Trim();
            string Certificate = txtConYeZhiGeZheng.Text.ToString().Trim();
            DateTime DrivingLicence = Convert.ToDateTime(dtpJiaZhengShengYanQi.Text.ToString().Trim());
            DateTime licensePeriod = Convert.ToDateTime(dtpShangGanYouXiaoQi.Text.ToString().Trim());
            string DriverVehicleNumber = txtJiaShiCheLiangBianHao.Text.ToString().Trim();
            DateTime CertificateLicence = Convert.ToDateTime(dtpConYeZiGeShengYangQi.Text.ToString().Trim());
            string Comment = rtxtBeiZhu.Text.ToString().Trim();
            string DriverMC = txtXingMing.Text.ToString().Trim();
            string Sex = txtXingBie.Text.ToString().Trim();
            string Identification = txtShengFenZhengHao.Text.ToString().Trim();
            int DriverID = DDriverID;
            int result = myFRM_JiaShiYuanGuanLi_UpdateClient.UpdateDriverXinXi(
                QuasiDrivingTypeID, OrganizationID, ContactPhone, DriveAge, DrivingLicenseNo, DriverNumber,
                Certificate, DrivingLicence, licensePeriod, DriverVehicleNumber, CertificateLicence, 
                Comment, TuPian, DriverID, DriverMC, Sex, Identification);
            if (result > 0)
            {
                MessageBox.Show("OK！");
            }
            else
            {
                MessageBox.Show("NO！");
            }
        }
        #endregion

        #region 关闭窗体
        private void btnFanHui_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion


        #endregion

        #region 验证手机号码
        public bool IsHandset(string str_handset)
        {
            return System.Text.RegularExpressions.Regex.////使用正则表达式判断是否匹配
                IsMatch(str_handset, @"^[1]+[3,8,5]+\d{9}$");
        }
        private void txtLiangXiDianHua_Validated(object sender, EventArgs e)
        {
            if (!IsHandset(txtLiangXiDianHua.Text))
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
        private void txtShengFenZhengHao_Validated(object sender, EventArgs e)
        {
            if (!IsIDcard(txtShengFenZhengHao.Text))
            {
                MessageBox.Show("请输入18位或15位身份证号码！");
            }
            else
            { }
        }

        #endregion

    }
}
