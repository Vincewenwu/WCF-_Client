using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 集团客运综合管理系统.用户管理
{
    public partial class FRM_YonHuGuanLi_Update : Form
    {
        public FRM_YonHuGuanLi_Update()
        {
            InitializeComponent();
        }
        public FRM_YonHuGuanLi_Update(int YonHuID)
        {
            InitializeComponent();
            YYonHuID = YonHuID;
        }
        int YYonHuID = 0;
        BLL集团客运综合管理.UserManager.FRM_YonHuGuanLi.FRM_YonHuGuanLiClient myFRM_YonHuGuanLiClient =
           new BLL集团客运综合管理.UserManager.FRM_YonHuGuanLi.FRM_YonHuGuanLiClient();
        BLL集团客运综合管理.UserManager.FRM_YonHuGuanLi_Update.FRM_YonHuGuanLi_UpdateClient myFRM_YonHuGuanLi_UpdateClient =
            new BLL集团客运综合管理.UserManager.FRM_YonHuGuanLi_Update.FRM_YonHuGuanLi_UpdateClient();
        private void FRM_YonHuGuanLi_Update_Load(object sender, EventArgs e)
        {
            DataTable dtYonHu = myFRM_YonHuGuanLi_UpdateClient.SelectYuanGongXinXi(YYonHuID).Tables[0];
            txtYonHuBianHao.Text = dtYonHu.Rows[0]["UserCoding"].ToString().Trim();
            txtYonHuXinMing.Text = dtYonHu.Rows[0]["UserMC"].ToString().Trim();
            txtYuanMiMa.Text = dtYonHu.Rows[0]["Password"].ToString().Trim();
            rtxtBeiZhu.Text = dtYonHu.Rows[0]["Comments"].ToString().Trim();
            cboYonHuLeiXing.Text=dtYonHu.Rows[0]["UserTypeMC"].ToString().Trim();
            cboSuoShuCheZhang.Text = dtYonHu.Rows[0]["CarStandMC"].ToString().Trim();

            DataTable dtYonHuLeiXing = myFRM_YonHuGuanLi_UpdateClient.SelectYonHuLeiXing().Tables[0];
            cboYonHuLeiXing.DataSource = dtYonHuLeiXing;
            cboYonHuLeiXing.DisplayMember = "UserTypeMC";
            cboYonHuLeiXing.ValueMember = "UserTypeID";

            DataTable dtSuoShuCheZhang = myFRM_YonHuGuanLi_UpdateClient.SelectSuoShuCheZhan().Tables[0];
            cboSuoShuCheZhang.DataSource = dtSuoShuCheZhang;
            cboSuoShuCheZhang.DisplayMember = "CarStandMC";
            cboSuoShuCheZhang.ValueMember = "CarStandID";
        }

        #region 按钮事件

        #region 修改用户信息
        private void butBaoCun_Click(object sender, EventArgs e)
        {
            if (txtXinMiMa.Text == txtQueRenMiMa.Text)
            {
                int UserTypeID = Convert.ToInt32(cboYonHuLeiXing.SelectedValue);
                int CarStandID = Convert.ToInt32(cboSuoShuCheZhang.SelectedValue);
                string UserCoding = txtYonHuBianHao.Text.ToString().Trim();
                string Password = txtXinMiMa.Text.ToString().Trim();
                string Comments = rtxtBeiZhu.Text.ToString().Trim();
                int UserID = YYonHuID;
                string UserMC = txtYonHuXinMing.Text.ToString().Trim();
                int result = myFRM_YonHuGuanLi_UpdateClient.UpdateYuanGongXinXi
                    (UserTypeID, CarStandID, UserCoding, Password, Comments, UserID, UserMC);
                if (result == 1)
                {
                    MessageBox.Show("修改成功！");
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
            }
            else
            {
                MessageBox.Show("密码不一致！");
            }
        }
        #endregion

        #region 窗体关闭
        private void butTuiChu_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #endregion
    }
}
