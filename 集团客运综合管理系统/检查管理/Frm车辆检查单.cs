using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 集团客运综合管理系统.检查管理
{
    public partial class Frm车辆检查单 : Form
    {
        public Frm车辆检查单()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.进站检查.Jinzhanjiancha.JinzhanjianchaClient myJinzhanjianchaClient = new BLL集团客运综合管理.进站检查.Jinzhanjiancha.JinzhanjianchaClient();
        public static AutoCompleteStringCollection fCollectionZhanDian;
        //AutoCompleteStringCollection功能等同控件AutoCompleteCustomSource的集合属性，但性能更快。
        public static AutoCompleteStringCollection fCollectioCheCi;
        public static int VehicleID;
        //声明“基础数据公共DataSet”：dsPublic
        public static DataSet dsPublic;
        //声明临时DataTable对象：mydt
        static DataTable mydt;
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
            mydt = myJinzhanjianchaClient.CarSaveCheak_Selectchelaing().Tables[0];
            dsPublic.Tables.Add(mydt.Copy());
            dsPublic.Tables[0].TableName = "Station";
            //添加 "站点"表的数据到AutoCompleteStringCollection对象“fCollectionZhanDian”（站点）集合中
            foreach (DataRow dr in mydt.Rows)
            {
                fCollectionZhanDian.Add(dr["VehiclePaiNumber"].ToString().Trim());
                //如果把数据直接追加到   txtZhanDian的AutoCompleteCustomSource中速度就很慢。 
                // txtZhanDian.AutoCompleteCustomSource.Add(dr["站点MC1"].ToString().Trim());

            }

            //添加 DataTable对象 "车次"，到DataSet之对象 dsPublic中，在dsPublic中编号为1
            //mydt = myNEWFrequencyInsectClient .VehicleSelect().Tables[0];
            //dsPublic.Tables.Add(mydt.Copy());
            //dsPublic.Tables[1].TableName = "车次";

            ////添加 "车次"表的数据到AutoCompleteStringCollection对象“fCollectioCheCi”（车次）集合中
            //foreach (DataRow dr in mydt.Rows)
            //{
            //    fCollectioCheCi.Add(dr["PlateNumber"].ToString().Trim());
            //}
        }
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
            // txtFrequencyMC.AutoCompleteCustomSource = fCollectioCheCi;
        }
        #endregion
        private void Frm车辆检查单_Load(object sender, EventArgs e)
        {
            mCreatePublicDatasetAndCollection();
            AutoCompleteControl();
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
           DataTable dt= myJinzhanjianchaClient.selectdongtaijianchadan(textBox1 .Text .Trim ()).Tables[0];
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { int CarriageInspectionShedID =Convert .ToInt32 ( dataGridView1.CurrentRow.Cells["CarriageInspectionShedID"].Value);
          DataTable dt= myJinzhanjianchaClient.selectmnigxi(CarriageInspectionShedID).Tables [0];
            dataGridView2.DataSource = dt;
        }
    }
}
