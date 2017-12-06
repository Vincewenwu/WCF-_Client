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
    public partial class FRM_JiaShiYuanGuanLi_Insert : Form
    {
        public FRM_JiaShiYuanGuanLi_Insert()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.VehicleManage.FRM_JiaShiYuanGuanLi_Insert.FRM_JiaShiYuanGuanLi_InsertClient myFRM_JiaShiYuanGuanLi_InsertClient =
            new BLL集团客运综合管理.VehicleManage.FRM_JiaShiYuanGuanLi_Insert.FRM_JiaShiYuanGuanLi_InsertClient();
        
        byte[] TuPian;
        
        #region Load事件
        private void FRM_JiaShiYuanGuanLi_Insert_Load(object sender, EventArgs e)
        {
            DataTable dtJiGouZuZi = myFRM_JiaShiYuanGuanLi_InsertClient.SelectOrganization().Tables[0];
            cboJiGouZuZhi.DataSource = dtJiGouZuZi;
            cboJiGouZuZhi.DisplayMember = "OrganizationMC";
            cboJiGouZuZhi.ValueMember = "OrganizationID";
            DataTable dtZhunJiaCheXing = myFRM_JiaShiYuanGuanLi_InsertClient.SelectQuasiDrivingType().Tables[0];
            cboZhunJiaCheXing.DataSource = dtZhunJiaCheXing;
            cboZhunJiaCheXing.DisplayMember = "QuasiDrivingTypeMC";
            cboZhunJiaCheXing.ValueMember = "QuasiDrivingTypeID";
        }
        #endregion

        #region 按钮事件
        private void btnDaKai_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = " 请选择图片";
            openfile.Filter = "Login图片 (*.jpg;*.bmp;*png)|*.jpeg;*.jpg;*.bmp;*.png|AllFiles(*.*)|*.*";//内容格式
            if (DialogResult.OK == openfile.ShowDialog())//打开文件 ==》选择内容
            {
                Bitmap bmp = new Bitmap(openfile.FileName);
                ptuXianPian.Image = bmp;
                ptuXianPian.SizeMode = PictureBoxSizeMode.StretchImage;//打开图片
                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length);
                ms.Close();
                TuPian = arr;
            }
        }
        private void btnBaoCun_Click(object sender, EventArgs e)
        {
            int QuasiDrivingTypeID = (int)cboZhunJiaCheXing.SelectedValue;
            int OrganizationID = (int)cboJiGouZuZhi.SelectedValue;
            int CreateUserID = 1025;
            int DeleteUserID = 1;
            string DriverMC = txtXingMing.Text.ToString().Trim();
            string Sex = txtXingBie.Text.ToString().Trim();
            string Identification = txtShengFenZhengHao.Text.ToString().Trim();
            string ContactPhone = txtLiangXiDianHua.Text.ToString().Trim();
            int DriveAge = Convert.ToInt32(txtJiaLing.Text.ToString().Trim());
            string DrivingLicenseNo = txtJiaShiZhengHao.Text.ToString().Trim();
            string DriverNumber = txtJiaShiYuanBianHao.Text.ToString().Trim();
            string Certificate = txtConYeZhiGeZheng.Text.ToString().Trim();
            DateTime DrivingLicence = Convert.ToDateTime(dateJiaZhengShengYanQi.Text.ToString().Trim());
            DateTime licensePeriod = Convert.ToDateTime(dateShangGanYouXiaoQi.Text.ToString().Trim());
            string DriverVehicleNumber = txtJiaShiCheLiangBianHao.Text.ToString().Trim();
            DateTime CertificateLicence = Convert.ToDateTime(dateConYeZiGeShengYangQi.Text.ToString().Trim());
            string Comment = rtxtBeiZhu.Text.ToString().Trim();
            bool JobON =false;
            DateTime CreateTime = DateTime.Now;
            DateTime LogicalDeleteTime = DateTime.Now;
            int result = myFRM_JiaShiYuanGuanLi_InsertClient.InsertJiaShiYuanXinXi(
            QuasiDrivingTypeID, OrganizationID, CreateUserID, DeleteUserID,
            DriverMC, Sex, Identification, ContactPhone, DriveAge, DrivingLicenseNo,
            DriverNumber, Certificate, DrivingLicence, licensePeriod,
            DriverVehicleNumber, CertificateLicence, TuPian, Comment, JobON,
            CreateTime, LogicalDeleteTime);
            if (result > 0)
            {
                MessageBox.Show("OK！");
            }
            else
            {
                MessageBox.Show("NO！");
            }
        }
        private void btnQingChu_Click(object sender, EventArgs e)
        {
        }
        private void btnFanHui_Click(object sender, EventArgs e)
        {
            Close();
        }
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
