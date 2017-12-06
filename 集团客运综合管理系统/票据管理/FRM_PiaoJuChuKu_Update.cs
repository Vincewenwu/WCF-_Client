using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 集团客运综合管理系统.票据管理
{
    public partial class FRM_PiaoJuChuKu_Update : Form
    {
        public FRM_PiaoJuChuKu_Update()
        {
            InitializeComponent();
        }
        int PPiaoJuChuKuID = 0;
        public FRM_PiaoJuChuKu_Update(int PiaoJuChuKuID)
        {
            InitializeComponent();
            PPiaoJuChuKuID = PiaoJuChuKuID;
        }
        
        BLL集团客运综合管理.BiIIEnterlibraryManager.FRM_PiaoJuChuKu_Update.FRM_PiaoJuChuKu_UpdateClient myFRM_PiaoJuChuKu_UpdateClient =
            new BLL集团客运综合管理.BiIIEnterlibraryManager.FRM_PiaoJuChuKu_Update.FRM_PiaoJuChuKu_UpdateClient();

        #region Load事件
        private void FRM_PiaoJuChuKu_Update_Load(object sender, EventArgs e)
        {
            DataTable dt = myFRM_PiaoJuChuKu_UpdateClient.SelectPiaoJuChuKu(PPiaoJuChuKuID).Tables[0];
            dgvPiaoJuXinXi.DataSource = dt;

            DataTable dtYuanGon = myFRM_PiaoJuChuKu_UpdateClient.SelectYuanGon().Tables[0];
            cboJieShouYonHu.DataSource = dtYuanGon;
            cboJieShouYonHu.DisplayMember = "UserMC";
            cboJieShouYonHu.ValueMember = "UserID";

            DataTable dtShiYongZhuangTai = myFRM_PiaoJuChuKu_UpdateClient.SelectShiYongZhuangTai().Tables[0];
            cboShiYonZhaungTai.DataSource = dtShiYongZhuangTai;
            cboShiYonZhaungTai.DisplayMember = "UseStateMC";
            cboShiYonZhaungTai.ValueMember = "UseStateID";
        }
        #endregion

        #region 按钮事件
        private void btnQuXiao_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnQueDing_Click(object sender, EventArgs e)
        {
            int UseStateID = Convert.ToInt32(cboShiYonZhaungTai.SelectedValue.ToString().Trim());
            int ReceiveUserID = Convert.ToInt32(cboJieShouYonHu.SelectedValue.ToString().Trim());
            string Comment = rtxtBeiZhu.Text.ToString().Trim();
            int BillremovalD = PPiaoJuChuKuID;
            int result = myFRM_PiaoJuChuKu_UpdateClient.UpdatePiaoJuChuKuXinXi(UseStateID,
                ReceiveUserID, Comment, BillremovalD);
            if (result == 1)
            {
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        #endregion

        
    }
}
