using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 集团客运综合管理系统.财务管理
{
    public partial class FRM_YingShouJiaoKuan : Form
    {
        public FRM_YingShouJiaoKuan()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.CampseizedmoneyManager.Campseizedmoneyguanli.CampseizedmoneyguanliClient myCampseizedmoneyguanliClient
               = new BLL集团客运综合管理.CampseizedmoneyManager.Campseizedmoneyguanli.CampseizedmoneyguanliClient();
        string UserCoding = "";
        int UserID = 0;
        int shoupiaozhangshu = 0;
        int tuipiaozhangshu = 0;
        int feipiaozhangshu = 0;
        decimal Shoupiaojine = 0;
        decimal tuipiaojine = 0;
        decimal feipiaojine = 0;
        public static AutoCompleteStringCollection fCollectionZhanDian;
        //AutoCompleteStringCollection功能等同控件AutoCompleteCustomSource的集合属性，但性能更快。
        public static AutoCompleteStringCollection fCollectioCheCi;

        //声明“基础数据公共DataSet”：dsPublic
        public static DataSet dsPublic;
        //声明临时DataTable对象：mydt
        static DataTable mydt;
        void AutoCompleteControl()
        {
            //遍历本窗体中所有的System.Windows.Forms.TextBox控件
            //技巧：进入窗体的构造方法的InitializeComponent()中可以找到当前窗体控件的完整类名
            #region 初始化文本框的输入法设置：半角；自动搜索数据源
            foreach (Control txtControl in groupBox1.Controls)
            {
                if (txtControl.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    (txtControl as TextBox).ImeMode = ImeMode.KatakanaHalf;
                    (txtControl as TextBox).AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    (txtControl as TextBox).AutoCompleteSource = AutoCompleteSource.CustomSource;
                    (txtControl as TextBox).AutoCompleteCustomSource = fCollectionZhanDian;
                }
            }
            #endregion

        }
        public void mCreatePublicDatasetAndCollection()
        //创建公共的dataset和datatable
        {

            //初始化对象：清空数据。
            if (fCollectionZhanDian != null)
            {
                fCollectionZhanDian.Clear();
            }
            if (fCollectioCheCi != null)
            {
                fCollectioCheCi.Clear();
            }
            if (dsPublic != null)
            {
                dsPublic.Tables.Clear();
            }

            if (mydt != null)
            {
                mydt.Clear();
            }

            //创建相关对象
            fCollectionZhanDian = new AutoCompleteStringCollection();
            fCollectioCheCi = new AutoCompleteStringCollection();
            dsPublic = new DataSet();

            //添加 DataTable对象 "站点"，到DataSet之对象 dsPublic中，在dsPublic中编号为0
            mydt = myCampseizedmoneyguanliClient .selectyonghu ().Tables[0];
            dsPublic.Tables.Add(mydt.Copy());
            dsPublic.Tables[0].TableName = "UserMC";
            //添加 "站点"表的数据到AutoCompleteStringCollection对象“fCollectionZhanDian”（站点）集合中
            foreach (DataRow dr in mydt.Rows)
            {
                fCollectionZhanDian.Add(dr["UserMC"].ToString().Trim());
                //如果把数据直接追加到   txtZhanDian的AutoCompleteCustomSource中速度就很慢。 
               // txtZhanDian.AutoCompleteCustomSource.Add(dr["站点MC1"].ToString().Trim());

            }
        }
        public static int mReturnZhanDianID(string strZhanDian)
        //根据“站点MC”，返回该名称对应的“站点ID”
        {
            try
            {
                DataTable newDt;
                var queryZhanDian =from myVar in dsPublic.Tables["UserMC"].AsEnumerable()//把“站点”赋值给myVar //把myVar赋值给queryZhanDian，二者都是临时var对象。
                        where (string)myVar["UserMC"] == strZhanDian//查询实参为“strZhanDian”的“站点”数据，
                        select myVar; //保存到myVar中，并赋值给queryZhanDian
                //把临时var对象queryZhanDian赋值给DataTable对象newDt
                newDt = queryZhanDian.CopyToDataTable<DataRow>();
                //获取并返回newDt的“站点ID”
                return Convert.ToInt32(newDt.Rows[0]["UserID"]);
            }
            catch
            {
                return 0;
            }
        }
        private void FRM_YingShouJiaoKuan_Load(object sender, EventArgs e)
        {
            mCreatePublicDatasetAndCollection();
            AutoCompleteControl();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtshoupiaoyuan_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int z = 0;

            int i = 0;
            UserID = mReturnZhanDianID(txtshoupiaoyuan.Text);
            DataTable dt = myCampseizedmoneyguanliClient.Campseizedmoney_selectdangqianpiaohao(UserID).Tables[0];
            if (dt.Rows.Count != 0)
            {
                UserCoding = dt.Rows[0]["UserCoding"].ToString();
                UserID = Convert.ToInt32(dt.Rows[0]["UserID"]);
                if (dt.Rows.Count != 0)
                {
                    i = Convert.ToInt32(dt.Rows[0]["CurrentTicketMark"]);
                    DateTime TicketingDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    DataTable dtt = myCampseizedmoneyguanliClient.Campseizedmoney_selectshoupiaozhangshu(UserID, TicketingDate).Tables[0];
                    dataGridView2.DataSource = dtt;
                    foreach (DataGridViewRow dgv in dataGridView2.Rows)
                    {
                        //     Shoupiaojine =
                        //    tuipiaojine =
                        //    feipiaojine =
                        z = z + 1;
                        if (Convert.ToInt32(dgv.Cells["TicketStateID"].Value) == 3)
                        {
                            Shoupiaojine += Convert.ToDecimal(dgv.Cells["Howmoney"].Value);
                            shoupiaozhangshu++;
                        }
                        if (Convert.ToInt32(dgv.Cells["TicketStateID"].Value) == 2)
                        {
                            tuipiaojine += Convert.ToDecimal(dgv.Cells["Tuipiaoshouxufei"].Value);
                            tuipiaozhangshu++;
                        }
                        if (Convert.ToInt32(dgv.Cells["TicketStateID"].Value) == 1)
                        {
                            feipiaojine += Convert.ToDecimal(dgv.Cells["Howmoney"].Value);
                            feipiaozhangshu++;
                        }

                    }
                }
                else { MessageBox.Show("请选择正确的售票员"); }
                txtkaishipiaohao.Text = Convert.ToString(i - (shoupiaozhangshu + tuipiaozhangshu + feipiaozhangshu));
                txtjieshupiaohao.Text = i.ToString();
                txtshoupiaozhangshu.Text = shoupiaozhangshu.ToString();
                txtfeipiaozhangshu.Text = feipiaozhangshu.ToString();
                txttuipiaozhangshu.Text = tuipiaozhangshu.ToString();
            }
            else
            {
                MessageBox.Show("该售票员没有对应的库存数据，请新增");
            }
        }

        private void btnQueDing_Click(object sender, EventArgs e)
        {
            int myint = 0;
                decimal jiankuanjine = Shoupiaojine + tuipiaojine;
                string Comments = txtbeizhu.Text;
                DateTime Createtime = dateTimePicker1.Value;
            myint = myCampseizedmoneyguanliClient.Campseizedmoney_insectyingshoujiaofeidan(UserCoding, UserID, shoupiaozhangshu, Shoupiaojine,
                                          tuipiaozhangshu, tuipiaojine, feipiaozhangshu, feipiaojine, jiankuanjine, Comments, Createtime);
            if (myint >0)
            {
                MessageBox.Show("记录成功");
                DataTable dt = myCampseizedmoneyguanliClient.Campseizedmoney_yingshoudan(UserID).Tables[0];
                dataGridView1.DataSource = dt;
            }else
            {
                DataTable dt = myCampseizedmoneyguanliClient.Campseizedmoney_yingshoudan(UserID).Tables[0];
                dataGridView1.DataSource = dt;
            }
           
        }
    }
}
