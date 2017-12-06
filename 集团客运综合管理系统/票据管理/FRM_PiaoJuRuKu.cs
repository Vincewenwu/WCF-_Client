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
    public partial class FRM_PiaoJuRuKu : Form
    {
        public FRM_PiaoJuRuKu()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.BiIIEnterlibraryManager.FRM_PiaoJuRuKu.FRM_PiaoJuRuKuClient myFRM_PiaoJuRuKuClient =
            new BLL集团客运综合管理.BiIIEnterlibraryManager.FRM_PiaoJuRuKu.FRM_PiaoJuRuKuClient();

        #region 按钮事件
        private void tosXinZeng_Click(object sender, EventArgs e)
        {
            SYS_PublicStaticClass.PublicStaticObject.FRM_PiaoJuRuKu_Insert = new FRM_PiaoJuRuKu_Insert();
            SYS_PublicStaticClass.PublicStaticObject.FRM_PiaoJuRuKu_Insert.ShowDialog();
            DataTable dt = myFRM_PiaoJuRuKuClient.SelectPiaoJuXinXi().Tables[0];
            dgvPiaoJuXinXi.DataSource = dt;
        }
        private void tlpShanChu_Click(object sender, EventArgs e)
        {
           try
            {
                int BiIIEnterlibraryID = Convert.ToInt32(dgvPiaoJuXinXi.CurrentRow.Cells["票据入库ID"].Value);
                int result = myFRM_PiaoJuRuKuClient.DeleteBiIIEnterlibraryXinXi(BiIIEnterlibraryID);
                if (result > 0)
                {
                    MessageBox.Show("OK!");
                    dgvPiaoJuXinXi.DataSource = myFRM_PiaoJuRuKuClient.SelectPiaoJuXinXi().Tables[0];
                }
            }
            catch { }
        }
        private void tlpTuiChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Load事件
        private void FRM_PiaoJuRuKu_Load(object sender, EventArgs e)
        {
            //this.Left = PublicStaticObject.MainLeft + 400;//往右距离
            //this.Top = PublicStaticObject.MainTop + 227;//往下距离
            //this.Width = PublicStaticObject.MainWidth + 958;//加宽宽度
            //this.Height = PublicStaticObject.MainHeight + 490;//加高高度


            DataTable dt = myFRM_PiaoJuRuKuClient.SelectPiaoJuXinXi().Tables[0];
            dgvPiaoJuXinXi.DataSource = dt;
        }
        #endregion
        
    }
}
