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
    public partial class FRM_PiaoJuRuKu_Insert : Form
    {
        public FRM_PiaoJuRuKu_Insert()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.BiIIEnterlibraryManager.FRM_PiaoJuRuKu_Insert.FRM_PiaoJuRuKu_InsertClient myFRM_PiaoJuRuKu_InsertClient =
            new BLL集团客运综合管理.BiIIEnterlibraryManager.FRM_PiaoJuRuKu_Insert.FRM_PiaoJuRuKu_InsertClient();
        public int RuKuShuLiang = 0;
        private void FRM_PiaoJuRuKu_Insert_Load(object sender, EventArgs e)
        {
            DataTable dt = myFRM_PiaoJuRuKu_InsertClient.SelectBiIIType().Tables[0];
            cboPiaoJuLeiXing.DataSource = dt;
            cboPiaoJuLeiXing.DisplayMember = "BiIITypeMC";
            cboPiaoJuLeiXing.ValueMember = "BiIITypeID";
            
        }

        #region 新增票据入库
        private void btnBaoCun_Click(object sender, EventArgs e)
        {
            if (txtKaiShiPiaoHao.Text != null || txtJieShuPiaoHao.Text != null)
            {
                int a = Convert.ToInt32(txtKaiShiPiaoHao.Text);
                int b = Convert.ToInt32(txtJieShuPiaoHao.Text);
                RuKuShuLiang = b - a;
                txtRuKuShuLiang.Text = RuKuShuLiang.ToString();
                txtKuCunLiang.Text = RuKuShuLiang.ToString();
                txtDanQianPiaoHao.Text = txtKaiShiPiaoHao.Text;
                int BiIITypeID = Convert.ToInt32(cboPiaoJuLeiXing.SelectedValue);
                int CreateUserID = 1025;
                int DeleteUserID = 1;
                int BeginTicketMark = Convert.ToInt32(txtKaiShiPiaoHao.Text.ToString().Trim());
                int FinishTicketMark = Convert.ToInt32(txtJieShuPiaoHao.Text.ToString().Trim());
                int CurrentTicketMark = Convert.ToInt32(txtDanQianPiaoHao.Text.ToString().Trim());
                int EnterlibraryQuantity = Convert.ToInt32(txtRuKuShuLiang.Text.ToString().Trim());
                int Inventory = Convert.ToInt32(txtKuCunLiang.Text.ToString().Trim());
                string ddd = Convert.ToString(dateTimeRuKuRiQi.Value);
                DateTime EnterlibraryDate = Convert.ToDateTime(ddd.Remove(9));
                string Comment = rtxtBeiZhu.Text.ToString().Trim();
                int result = myFRM_PiaoJuRuKu_InsertClient.InsertBiIIEnterlibraryXinXi(
                BiIITypeID, CreateUserID, DeleteUserID, BeginTicketMark, FinishTicketMark,
                CurrentTicketMark, EnterlibraryQuantity, Inventory, EnterlibraryDate, Comment);
                if (result != 0)
                {
                    MessageBox.Show("OK！");
                }
                else
                {
                    MessageBox.Show("ON！");
                }
            }

        }
        #endregion

        #region 关闭按钮
        private void btnTuiChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
