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
    public partial class FRM_YonHuGuanLi_Insert : Form
    {
        public FRM_YonHuGuanLi_Insert()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.UserManager.FRM_YonHuGuanLi_Insert.FRM_YonHuGuanLi_InsertClient myFRM_YonHuGuanLi_InsertClient =
            new BLL集团客运综合管理.UserManager.FRM_YonHuGuanLi_Insert.FRM_YonHuGuanLi_InsertClient();
        private void FRM_YonHuGuanLi_Insert_Load(object sender, EventArgs e)
        {
            DataTable dtUserType = myFRM_YonHuGuanLi_InsertClient.SelectUserType().Tables[0];
            cboYonHuLeiXing.DataSource = dtUserType;
            cboYonHuLeiXing.DisplayMember = "UserTypeMC";
            cboYonHuLeiXing.ValueMember = "UserTypeID";
            DataTable dtCarStand = myFRM_YonHuGuanLi_InsertClient.SelectCarStand().Tables[0];
            cboSuoShuCheZhang.DataSource = dtCarStand;
            cboSuoShuCheZhang.DisplayMember = "CarStandMC";
            cboSuoShuCheZhang.ValueMember = "CarStandID";
        }
        #region 窗体关闭事件
        private void btoTuiChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 新增用户信息
        private void btoBaoCun_Click(object sender, EventArgs e)
        {
            string CarStandMC = cboSuoShuCheZhang.Text.ToString().Trim();
            DataTable dtCarStandMC = myFRM_YonHuGuanLi_InsertClient.SelectCheZhanByCarStandMC(CarStandMC).Tables[0];
            string UserTypeMC = cboYonHuLeiXing.Text.ToString().Trim();
            DataTable dtUserTypeMC = myFRM_YonHuGuanLi_InsertClient.SelectUserTypeByUserTypeMC(UserTypeMC).Tables[0];

            int i = 0;
            int j = 0;
            for (int a = 0; a < dtCarStandMC.Rows.Count; a++)
            {
                if (dtCarStandMC.Rows[a]["CarStandMC"].ToString() == cboSuoShuCheZhang.Text)
                {
                    i++;
                }
            }
            for(int b = 0; b < dtUserTypeMC.Rows.Count; b++)
            {
                if(dtUserTypeMC.Rows[b]["UserTypeMC"].ToString() == cboYonHuLeiXing.Text)
                {
                    j++;
                }
            }
            if (i > 0 && j > 0)
            {
                if (txtMiMa.Text == txtQueRenMiMa.Text)
                {
                    int UserTypeID = Convert.ToInt32(cboYonHuLeiXing.SelectedValue);
                    int CarStandID = Convert.ToInt32(cboSuoShuCheZhang.SelectedValue);
                    int AuthorityTypeID = 1;
                    string UserMC = txtYonHuXingMing.Text.ToString().Trim();
                    string UserCoding = txtYonHuBianMa.Text.ToString().Trim();
                    string Password = txtQueRenMiMa.Text.ToString().Trim();
                    string Comments = rtxtBeiZhu.Text.ToString().Trim();
                    int dt = myFRM_YonHuGuanLi_InsertClient.InsertUser(UserTypeID, AuthorityTypeID,
                        CarStandID, UserMC, UserCoding, Password, Comments);
                    if (dt == 1)
                    {
                        MessageBox.Show("新增成功！");
                        txtMiMa.Text = "";
                        txtQueRenMiMa.Text = "";
                        txtYonHuBianMa.Text = "";
                        txtYonHuXingMing.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("新增失败！");
                    }
                }
                else
                {
                    MessageBox.Show("密码不一致！");
                }
            }
            else
            {
                if (txtMiMa.Text == txtQueRenMiMa.Text)
                {
                    string UserTypeMCs = Convert.ToString(cboYonHuLeiXing.Text);
                    int dtUserTypeID = myFRM_YonHuGuanLi_InsertClient.InsertUserTypeXinXi(UserTypeMCs);
                    string CarStandMCs = Convert.ToString(cboSuoShuCheZhang.Text);
                    int dtCarStandID = myFRM_YonHuGuanLi_InsertClient.InsertCarStandXinXi(CarStandMCs);
                    if(dtUserTypeID != 0 && dtCarStandID != 0)
                    {
                        int AuthorityTypeID = 1;
                        string UserMC = txtYonHuXingMing.Text.ToString().Trim();
                        string UserCoding = txtYonHuBianMa.Text.ToString().Trim();
                        string Password = txtQueRenMiMa.Text.ToString().Trim();
                        string Comments = rtxtBeiZhu.Text.ToString().Trim();
                        int dt = myFRM_YonHuGuanLi_InsertClient.InsertUser(dtUserTypeID, AuthorityTypeID,
                            dtCarStandID, UserMC, UserCoding, Password, Comments);
                        if (dt == 1)
                        {
                            MessageBox.Show("新增成功！");
                            txtMiMa.Text = "";
                            txtQueRenMiMa.Text = "";
                            txtYonHuBianMa.Text = "";
                            txtYonHuXingMing.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("新增失败！");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("密码不一致！");
                }
            }
        }
        #endregion
    }
}
