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
    public partial class FRM_PiaoJuChuKu : Form
    {
        public FRM_PiaoJuChuKu()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.BiIIEnterlibraryManager.FRM_PiaoJuChuKu.FRM_PiaoJuChuKuClient myFRM_PiaoJuChuKuClient =
            new BLL集团客运综合管理.BiIIEnterlibraryManager.FRM_PiaoJuChuKu.FRM_PiaoJuChuKuClient();

        #region Load事件
        private void FRM_PiaoJuChuKu_Load(object sender, EventArgs e)
        {
            dgvYuanGongXinXi.DataSource = myFRM_PiaoJuChuKuClient.SelectYuanGongXinXi().Tables[0];
        }
        #endregion

        #region 按钮事件
        private void btnXinZeng_Click(object sender, EventArgs e)
        {
            SYS_PublicStaticClass.PublicStaticObject.FRM_PiaoJuChuKu_Insert = new FRM_PiaoJuChuKu_Insert();
            SYS_PublicStaticClass.PublicStaticObject.FRM_PiaoJuChuKu_Insert.ShowDialog();
            dgvYuanGongXinXi.DataSource = myFRM_PiaoJuChuKuClient.SelectYuanGongXinXi().Tables[0];
        }
        private void btnTuiChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnShanChu_Click(object sender, EventArgs e)
        {
           try
            {
                int BillremovalD = Convert.ToInt32(dgvPiaoJuXinXi.CurrentRow.Cells["票据出库ID"].Value);
                myFRM_PiaoJuChuKuClient.DelectBillremova(BillremovalD);
                dgvYuanGongXinXi_CellClick(null, null);
            }
            catch { }
        }
        private void btnDaYing_Click(object sender, EventArgs e)
        {
            dgvYuanGongXinXi_CellClick(null, null);
        }
        private void btnXiuGai_Click(object sender, EventArgs e)
        {
            int PiaoJuChuKuID = Convert.ToInt32(dgvPiaoJuXinXi.CurrentRow.Cells["票据出库ID"].Value.ToString());
            SYS_PublicStaticClass.PublicStaticObject.FRM_PiaoJuChuKu_Update = new FRM_PiaoJuChuKu_Update(PiaoJuChuKuID);
            SYS_PublicStaticClass.PublicStaticObject.FRM_PiaoJuChuKu_Update.ShowDialog();
            dgvYuanGongXinXi.DataSource = myFRM_PiaoJuChuKuClient.SelectYuanGongXinXi().Tables[0];
        }
        #endregion

        #region 点击dgv进行绑定数据
        private void dgvYuanGongXinXi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int ReceiveUserID = Convert.ToInt32(dgvYuanGongXinXi.CurrentRow.Cells["用户ID"].Value);
                dgvPiaoJuXinXi.DataSource = myFRM_PiaoJuChuKuClient.SelectPiaoJuChuKuXinXi(ReceiveUserID).Tables[0];
                DataTable dt = myFRM_PiaoJuChuKuClient.SeleceBillremovaXinXi(ReceiveUserID).Tables[0];
                txtKePiaoLingYongZongShu.Text = dt.Rows[0]["NeckUseQuantity"].ToString().Trim();
                txtKePiaoShengYuZhangShu.Text = dt.Rows[0]["SurplusQuantity"].ToString().Trim();
            }
            catch
            {
                MessageBox.Show("没有数据！");
            }
        }
        #endregion


    }
}
