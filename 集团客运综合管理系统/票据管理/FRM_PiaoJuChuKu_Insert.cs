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
    public partial class FRM_PiaoJuChuKu_Insert : Form
    {
        public FRM_PiaoJuChuKu_Insert()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.BiIIEnterlibraryManager.FRM_PiaoJuChuKu_Insert.FRM_PiaoJuChuKu_InsertClient myFRM_PiaoJuChuKu_InsertClient =
            new BLL集团客运综合管理.BiIIEnterlibraryManager.FRM_PiaoJuChuKu_Insert.FRM_PiaoJuChuKu_InsertClient();
        public static AutoCompleteStringCollection fCollectionGongGong;
        static DataTable mydt;
        DataTable dts;
        int ChuKuZhongShu = 0;
        int KuCunLiang = 0;
        
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
            mydt = myFRM_PiaoJuChuKu_InsertClient.SelectYonHuBianHao().Tables[0];
            foreach (DataRow dr in mydt.Rows)
            {
                fCollectionGongGong.Add(dr["UserCoding"].ToString().Trim());
            }
            txtJieShouYonHuID.ImeMode = ImeMode.KatakanaHalf;
            txtJieShouYonHuID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtJieShouYonHuID.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtJieShouYonHuID.AutoCompleteCustomSource = fCollectionGongGong;
        }
        public static int mReturnSurfaceLandID(string UserCoding)
        {
            try
            {
                DataTable newDt;
                var queryZhanDian =
                        from myVar in mydt.AsEnumerable()
                        where (string)myVar["UserCoding"] == UserCoding
                        select myVar;
                newDt = queryZhanDian.CopyToDataTable<DataRow>();
                return Convert.ToInt32(newDt.Rows[0]["UserCoding"]);
            }
            catch
            {
                return 0;
            }
        }

        #region Load事件
        private void FRM_PiaoJuChuKu_Insert_Load(object sender, EventArgs e)
        {
            mCreatePublicDatasetAndCollection();
            dgvPiaoJuKuCun.DataSource = myFRM_PiaoJuChuKu_InsertClient.SelectPiaoJuKuCunXinXi().Tables[0];

            DataTable dtShiYonZhuangTai = myFRM_PiaoJuChuKu_InsertClient.SelectShiYonZhuangTai().Tables[0];
            cboShiYonZhaungTai.DataSource = dtShiYonZhuangTai;
            cboShiYonZhaungTai.DisplayMember = "UseStateMC";
            cboShiYonZhaungTai.ValueMember = "UseStateID";
        }
        #endregion

        #region 查询用户通过用户编号
        private void txtJieShouYonHuID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string UserCoding = txtJieShouYonHuID.Text.ToString().Trim();
                dts = myFRM_PiaoJuChuKu_InsertClient.SelectYonHuByYonHuBianHao(UserCoding).Tables[0];
                txtJieShouYonHu.Text = dts.Rows[0]["UserMC"].ToString().Trim();
            }
            catch { }
        }
        #endregion

        #region 按钮事件

        #region 关闭窗体
        private void btnQuXiao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        
        #region 添加票据出库信息
        private void btnQueDing_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtKaiShiPiaoHao.Text);
            int b = Convert.ToInt32(txtLingYongShuLiang.Text);
            int c = Convert.ToInt32(dgvPiaoJuKuCun.CurrentRow.Cells["库存量"].Value);
            ChuKuZhongShu = a + b;
            txtJieShuPiaoHao.Text = ChuKuZhongShu.ToString();
            int BiIITypeID = Convert.ToInt32(dgvPiaoJuKuCun.CurrentRow.Cells["票据类型ID"].Value);
            int ReceiveUserID = Convert.ToInt32(dts.Rows[0]["UserID"].ToString());
            int UseStateID = Convert.ToInt32(cboShiYonZhaungTai.SelectedValue);
            int CreateUserID = 1025;
            int DeleteUserID = 1;
            int BeginTicketMark = Convert.ToInt32(txtKaiShiPiaoHao.Text);
            int FinishTicketMark = Convert.ToInt32(txtJieShuPiaoHao.Text);
            int CurrentTicketMark = Convert.ToInt32(txtKaiShiPiaoHao.Text);
            int SurplusQuantity = Convert.ToInt32(txtLingYongShuLiang.Text);
            DateTime RemovaDate = DateTime.Today;
            string Comment = rtxtBeiZhu.Text.ToString().Trim();
            DateTime CreateTime = DateTime.Now;
            DateTime LogicalDeleteTime = DateTime.Now;
            int NeckUseQuantity = Convert.ToInt32(txtLingYongShuLiang.Text);
            int result = myFRM_PiaoJuChuKu_InsertClient.InsertPiaoJuChuKu(
                BiIITypeID, ReceiveUserID, UseStateID, CreateUserID, DeleteUserID,
                BeginTicketMark, FinishTicketMark, CurrentTicketMark, SurplusQuantity,
                RemovaDate, Comment, CreateTime, LogicalDeleteTime, NeckUseQuantity);
            if (result != 0)
            {
                KuCunLiang = c - b;
                CurrentTicketMark = Convert.ToInt32(txtJieShuPiaoHao.Text);
                int Inventory = Convert.ToInt32(KuCunLiang.ToString());
                int BiIIEnterlibraryID = Convert.ToInt32(dgvPiaoJuKuCun.CurrentRow.Cells["票据入库ID"].Value);
                int PiaoJuRuKu = myFRM_PiaoJuChuKu_InsertClient.UpdatePiaoJuChuKu(CurrentTicketMark, Inventory, BiIIEnterlibraryID);
                if (PiaoJuRuKu > 0)
                {
                    MessageBox.Show("OK！");
                    FRM_PiaoJuChuKu_Insert_Load(null, null);
                }
                else
                {
                    MessageBox.Show("NO！");
                }
            }
        }
        #endregion

        #endregion

        #region 单击dgv绑定数据到TxtBox上
        private void dgvPiaoJuKuCun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int i = Convert.ToInt32(dgvPiaoJuKuCun.CurrentRow.Cells["库存量"].Value);
            if (i > 0)
            {
                if (dgvPiaoJuKuCun.CurrentRow != null)
                {
                    txtPiaoJuLeiXing.Text = dgvPiaoJuKuCun.CurrentRow.Cells["票据类型"].Value.ToString().Trim();
                    txtKaiShiPiaoHao.Text = dgvPiaoJuKuCun.CurrentRow.Cells["当前票号"].Value.ToString().Trim();
                }
            }
            else
            {
                MessageBox.Show("库存量为0，不能添加发放!");
            }
        }
        #endregion

        #region 给dgv添加序号
        private void dgvPiaoJuKuCun_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow CurrentRow = this.dgvPiaoJuKuCun.Rows[e.RowIndex];
            CurrentRow.HeaderCell.Value = Convert.ToString(e.RowIndex + 1);
        }
        #endregion

        #region txtBox的数据相加
        private void txtLingYongShuLiang_TextChanged(object sender, EventArgs e)
        {
            // textBox1.TextChanged和textBox2.TextChanged都设置为textBox1_TextChanged
            // private void textBox1_TextChanged(object sender, EventArgs e)
            //{
            //    float a, b;
            //    float.TryParse(txtKaiShiPiaoHao.Text, out a);
            //    float.TryParse(txtLingYongShuLiang.Text, out b);
            //    txtJieShuPiaoHao.Text = (a + b).ToString();
            //}
            
        }
        #endregion

        private void txtLingYongShuLiang_Validated(object sender, EventArgs e)
        {
            float a, b, c;
            float.TryParse(txtKaiShiPiaoHao.Text, out a);
            float.TryParse(txtLingYongShuLiang.Text, out b);
            float.TryParse(txtJieShuPiaoHao.Text, out c);
            int d = Convert.ToInt32(dgvPiaoJuKuCun.CurrentRow.Cells["库存量"].Value);
            c = a + b;
            txtJieShuPiaoHao.Text = c.ToString();
            if (c <= d)
            {

            }
            else
            {
                MessageBox.Show("领用数量不能大于库存数量！");
                txtLingYongShuLiang.Text = "";
            }
        }
    }
}
