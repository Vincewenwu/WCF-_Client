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
    public partial class FRM_YonHuGuanLi : Form
    {
        public FRM_YonHuGuanLi()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.UserManager.FRM_YonHuGuanLi.FRM_YonHuGuanLiClient myFRM_YonHuGuanLiClient =
            new BLL集团客运综合管理.UserManager.FRM_YonHuGuanLi.FRM_YonHuGuanLiClient();
        public static AutoCompleteStringCollection fCollectionGongGong;
        static DataTable mydt;
        DataTable dt = new DataTable();
        bool suo = false;
        #region 自动完成查询条件
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
            mydt = myFRM_YonHuGuanLiClient.SelectUser().Tables[0];
            foreach (DataRow dr in mydt.Rows)
            {
                fCollectionGongGong.Add(dr["UserCoding"].ToString().Trim());
            }
            txtYongHuBianHao.ImeMode = ImeMode.KatakanaHalf;
            txtYongHuBianHao.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtYongHuBianHao.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtYongHuBianHao.AutoCompleteCustomSource = fCollectionGongGong;
            foreach (DataRow dr in mydt.Rows)
            {
                fCollectionGongGong.Add(dr["UserMC"].ToString().Trim());
            }
            txtYonHuXingMing.ImeMode = ImeMode.KatakanaHalf;
            txtYonHuXingMing.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtYonHuXingMing.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtYonHuXingMing.AutoCompleteCustomSource = fCollectionGongGong;
        }
        #endregion 

        #region 联想自动查询 1
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
        #endregion

        #region 联想自动查询 2
        public static int mReturnSurfaceLandID1(string UserMC)
        {
            try
            {
                DataTable newDt;
                var queryZhanDian =
                        from myVar in mydt.AsEnumerable()
                        where (string)myVar["UserMC"] == UserMC
                        select myVar;
                newDt = queryZhanDian.CopyToDataTable<DataRow>();
                return Convert.ToInt32(newDt.Rows[0]["UserMC"]);
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        #region Load事件
        private void FRM_YonHuGuanLi_Load(object sender, EventArgs e)
        {
            mCreatePublicDatasetAndCollection();

            dgvYongHuXinXi.DataSource = myFRM_YonHuGuanLiClient.SelectYonHuXinXi().Tables[0];

            DataTable dtSuoShuCheZhan = myFRM_YonHuGuanLiClient.SelectCarStand().Tables[0];
            cboSuoShuCheZhan.DataSource = dtSuoShuCheZhan;
            cboSuoShuCheZhan.DisplayMember = "CarStandMC";
            cboSuoShuCheZhan.ValueMember = "CarStandID";

            DataTable dtYongHuLeiXin = myFRM_YonHuGuanLiClient.SelectUserType().Tables[0];
            cboYongHuLeiXin.DataSource = dtYongHuLeiXin;
            cboYongHuLeiXin.DisplayMember = "UserTypeMC";
            cboYongHuLeiXin.ValueMember = "UserTypeID";
            suo = true;
        }
        #endregion

        #region 按钮事件

        #region 实例化界面
        private void tlsXingZen_Click(object sender, EventArgs e)
        {
            SYS_PublicStaticClass.PublicStaticObject.FRM_YonHuGuanLi_Insert = new FRM_YonHuGuanLi_Insert();
            SYS_PublicStaticClass.PublicStaticObject.FRM_YonHuGuanLi_Insert.ShowDialog();
            dgvYongHuXinXi.DataSource = myFRM_YonHuGuanLiClient.SelectYonHuXinXi().Tables[0];
        }
        private void tlsXiuGai_Click(object sender, EventArgs e)
        {
            int YonHuID = Convert.ToInt32(dgvYongHuXinXi.CurrentRow.Cells["用户ID"].Value.ToString());
            SYS_PublicStaticClass.PublicStaticObject.FRM_YonHuGuanLi_Update = new FRM_YonHuGuanLi_Update(YonHuID);
            SYS_PublicStaticClass.PublicStaticObject.FRM_YonHuGuanLi_Update.ShowDialog();
            dgvYongHuXinXi.DataSource = myFRM_YonHuGuanLiClient.SelectYonHuXinXi().Tables[0];
        }
        #endregion

        #region 窗体关闭
        private void tsbTuiChu_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region 删除用户信息
        private void tsbShanChu_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(dgvYongHuXinXi.CurrentRow.Cells["用户ID"].Value);
            int result = myFRM_YonHuGuanLiClient.DeleteYonHuXinXi(UserID);
            if (result > 0)
            {
                MessageBox.Show("OK!");
                dgvYongHuXinXi.DataSource = myFRM_YonHuGuanLiClient.SelectYonHuXinXi().Tables[0];
            }
        }
        #endregion
        
        #endregion

        #region 查询员工信息通过员工编号
        private void txtYongHuBianHao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string UserCoding = txtYongHuBianHao.Text;
                DataTable dt = myFRM_YonHuGuanLiClient.SelectYonHuXinXiByUserCoding(UserCoding).Tables[0];
                dgvYongHuXinXi.DataSource = dt;
            }
            catch { }
        }
        #endregion

        #region 查询员工信息通过员工姓名
        private void txtYonHuXingMing_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string UserMC = txtYonHuXingMing.Text;
                DataTable dt = myFRM_YonHuGuanLiClient.SelectYonHuXinXiByUserMC(UserMC).Tables[0];
                dgvYongHuXinXi.DataSource = dt;
            }
            catch { }
        }
        #endregion

        #region 根据条件锁进行查询1
        private void cboSuoShuCheZhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suo)
            {
                int CarStandID = Convert.ToInt32(cboSuoShuCheZhan.SelectedValue);
                DataTable dt = myFRM_YonHuGuanLiClient.SelectYonHuXinXiByCarStandMC(CarStandID).Tables[0];
                dgvYongHuXinXi.DataSource = dt;
            }
        }
        #endregion

        #region 根据条件锁进行查询1
        private void cboYongHuLeiXin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suo)
            {
                int UserTypeID = Convert.ToInt32(cboYongHuLeiXin.SelectedValue);
                DataTable dt = myFRM_YonHuGuanLiClient.SelectYonHuXinXiByUserTypeMC(UserTypeID).Tables[0];
                dgvYongHuXinXi.DataSource = dt;
            }
        }
        #endregion

        #region dgv单击刷新
        private void dgvYongHuXinXi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvYongHuXinXi.DataSource = myFRM_YonHuGuanLiClient.SelectYonHuXinXi().Tables[0];
        }





        #endregion

       
    }
}
