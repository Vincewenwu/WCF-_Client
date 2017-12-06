using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 集团客运综合管理系统.检票系统
{
    public partial class FRM_JianPiaoXiTong : Form
    {
        public FRM_JianPiaoXiTong()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.InspectTicketManager.FRM_JianPiaoXiTong.FRM_JianPiaoXiTongClient myFRM_JianPiaoXiTongClient
            = new BLL集团客运综合管理.InspectTicketManager.FRM_JianPiaoXiTong.FRM_JianPiaoXiTongClient();
        //AutoCompleteStringCollection功能等同控件AutoCompleteCustomSource的集合属性，但性能更快。
        public static AutoCompleteStringCollection fCollectioCheLiangBianHao;
        public static AutoCompleteStringCollection fCollectioPiaoHao1;

        //声明“基础数据公共DataSet”：dsPublic
        public static DataSet dsPublic;
        //声明临时DataTable对象：mydt
        static DataTable mydt;
        DataTable dte;
        DataTable xiwei;
        bool suo = false;
        public void mCreatePublicDatasetAndCollection()
        //创建公共的dataset和datatable
        {
            //初始化对象：清空数据。
            if (fCollectioCheLiangBianHao != null)
            {
                fCollectioCheLiangBianHao.Clear();
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
            fCollectioCheLiangBianHao = new AutoCompleteStringCollection();
            dsPublic = new DataSet();

            //添加 DataTable对象 "站点"，到DataSet之对象 dsPublic中，在dsPublic中编号为0
            mydt = myFRM_JianPiaoXiTongClient.SelectCheLiangBianHao().Tables[0];
            //添加 "站点"表的数据到AutoCompleteStringCollection对象“fCollectionZhanDian”（站点）集合中
            foreach (DataRow dr in mydt.Rows)
            {
                fCollectioCheLiangBianHao.Add(dr["VehicleNumber"].ToString().Trim());
                //如果把数据直接追加到   txtZhanDian的AutoCompleteCustomSource中速度就很慢。 
                // txtZhanDian.AutoCompleteCustomSource.Add(dr["站点MC1"].ToString().Trim());
            }
            txtCheLiangBianHao.ImeMode = ImeMode.KatakanaHalf;
            txtCheLiangBianHao.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCheLiangBianHao.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCheLiangBianHao.AutoCompleteCustomSource = fCollectioCheLiangBianHao;
        }
        #region 联想自动查询
        public static int mReturnSurfaceLandID(string VehicleNumber)
        {
            try
            {
                DataTable newDt;
                var queryZhanDian =
                        from myVar in mydt.AsEnumerable()
                        where (string)myVar["VehicleNumber"] == VehicleNumber
                        select myVar;
                newDt = queryZhanDian.CopyToDataTable<DataRow>();
                return Convert.ToInt32(newDt.Rows[0]["VehicleNumber"]);
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        #region 联想自动查询1
        public static int mReturnSurfaceLandID1(string TicketMark)
        {
            try
            {
                DataTable newDt;
                var queryZhanDian =
                        from myVar in mydt.AsEnumerable()
                        where (string)myVar["TicketMark"] == TicketMark
                        select myVar;
                newDt = queryZhanDian.CopyToDataTable<DataRow>();
                return Convert.ToInt32(newDt.Rows[0]["TicketMark"]);
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        #region Lood事件
        private void FRM_JianPiaoXiTong_Load(object sender, EventArgs e)
        {
            mCreatePublicDatasetAndCollection();
            labShiJian.Text = DateTime.Now.ToString();
            dgvDaiJianBanCi.DataSource = myFRM_JianPiaoXiTongClient.SelectDaiJianCheLiang().Tables[0];
            dgvYiBaoBanCi.DataSource = myFRM_JianPiaoXiTongClient.SelectBaoBanXinXi().Tables[0];
        }
        #endregion

        #region 通过票号查询检票信息
        private void txtPiaokou_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string TicketMark = txtPiaokou.Text.ToString().Trim();
                int VehicleID = Convert.ToInt32(dgvDaiJianBanCi.CurrentRow.Cells["车辆ID"].Value.ToString());
                dte = myFRM_JianPiaoXiTongClient.SelectJianPiaoXinXi(TicketMark, VehicleID).Tables[0];
                txtZuoWei.Text = dte.Rows[0]["SeatNoMC"].ToString().Trim();
                txtFaCheRiQi.Text = dte.Rows[0]["CirculationDate"].ToString().Trim();
                txtFaCheShiJian.Text = dte.Rows[0]["DepartureTime"].ToString().Trim();
                txtPiaoJia.Text = dte.Rows[0]["Howmoney"].ToString().Trim();
                txtChePiaoLeiXing.Text = dte.Rows[0]["TicketPriceTypeMC"].ToString().Trim();
                txtDaoDaZhang.Text = dte.Rows[0]["StationMC"].ToString().Trim();
            }
            catch { }
        }
        #endregion

        #region 查询车辆通过车辆编号
        private void txtCheLiangBianHao_TextChanged(object sender, EventArgs e)
        {
            string VehicleNumber = txtCheLiangBianHao.Text.ToString().Trim();
           dgvDaiJianBanCi.DataSource = myFRM_JianPiaoXiTongClient.
                SelectCheLiangByCheLiangBianHao(VehicleNumber).Tables[0];
        }
        #endregion

        #region 图片绘制文字事件
        void pb_paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 4);
            PictureBox pb = sender as PictureBox;
            Graphics g = e.Graphics;
            DataRow dr = (DataRow)pb.Tag;
            string 司机名称 = dr["SeatNoMC"].ToString().Trim();
            Font 字体样式 = new System.Drawing.Font("微软雅黑", 8, FontStyle.Bold);
            PointF 字符串坐标 = new PointF(14, 1);
            g.DrawString(司机名称, 字体样式, SystemBrushes.ActiveCaptionText, 字符串坐标);
        }
        #endregion

        #region 查询待检班次信息
        private void dgvDaiJianBanCi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (flpZuoWeiZhuangTai.Controls.Count == 0)
            {
                int VehicleID = Convert.ToInt32(dgvDaiJianBanCi.CurrentRow.Cells["车辆ID"].Value.ToString());
                xiwei = myFRM_JianPiaoXiTongClient.SelectCheLiangXiWeiZhangTai(VehicleID).Tables[0];
                labBanCi.Text = xiwei.Rows[0]["FrequencyMC"].ToString().Trim();
                labCheHao.Text = xiwei.Rows[0]["VehicleNumber"].ToString().Trim();
                labFaCheShiJian2.Text = xiwei.Rows[0]["DepartureTime"].ToString().Trim();
                labXianLu.Text = xiwei.Rows[0]["LineMC"].ToString().Trim();
                for (int i = 0; i < xiwei.Rows.Count; i++)
                {
                    PictureBox pb = new PictureBox();
                    pb.Size = new Size(30, 27);
                    pb.Tag = xiwei.Rows[i];
                    int 席位状态ID = (int)xiwei.Rows[i]["SeatsStateID"];
                    switch (席位状态ID)
                    {
                        case 1: pb.BackgroundImage = Properties.Resources._002; break;
                        case 2: pb.BackgroundImage = Properties.Resources._003; break;
                        case 7: pb.BackgroundImage = Properties.Resources._001; break;
                    }
                    pb.BackgroundImageLayout = ImageLayout.Stretch;
                    pb.Paint += new PaintEventHandler(pb_paint);
                    flpZuoWeiZhuangTai.Controls.Add(pb);
                }
                dataGridView1.DataSource = xiwei;
                int z = 0; int s = 0; int t = 0;
                foreach (DataGridViewRow dgv in dataGridView1.Rows)
                {
                    int i = Convert.ToInt32(dgv.Cells["SeatsStateID"].Value);
                    if (i == 1)
                    {
                        z = z + 1;
                    }
                    if (i == 2)
                    {
                        s = s + 1;
                    }
                    if (i == 7)
                    {
                        t = t + 1;
                    }
                }
                labYiJian.Text = t.ToString();
                labWeiJian.Text = (z + t - t).ToString();
                labYiShou.Text = (z + t).ToString();
                fCollectioPiaoHao1 = new AutoCompleteStringCollection();
                dsPublic = new DataSet();
                mydt = myFRM_JianPiaoXiTongClient.SelectPiaoHaoByCheLiangID(VehicleID).Tables[0];
                foreach (DataRow dr in mydt.Rows)
                {
                    fCollectioPiaoHao1.Add(dr["TicketMark"].ToString().Trim());
                }

                txtPiaokou.ImeMode = ImeMode.KatakanaHalf;
                txtPiaokou.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtPiaokou.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtPiaokou.AutoCompleteCustomSource = fCollectioPiaoHao1;
            }
            if (flpZuoWeiZhuangTai.Controls.Count != 0)
            {
                flpZuoWeiZhuangTai.Controls.Clear();
                int VehicleID = Convert.ToInt32(dgvDaiJianBanCi.CurrentRow.Cells["车辆ID"].Value.ToString());
                xiwei = myFRM_JianPiaoXiTongClient.SelectCheLiangXiWeiZhangTai(VehicleID).Tables[0];
                labBanCi.Text = xiwei.Rows[0]["FrequencyMC"].ToString().Trim();
                labCheHao.Text = xiwei.Rows[0]["VehicleNumber"].ToString().Trim();
                labFaCheShiJian2.Text = xiwei.Rows[0]["DepartureTime"].ToString().Trim();
                labXianLu.Text = xiwei.Rows[0]["LineMC"].ToString().Trim();
                for (int i = 0; i < xiwei.Rows.Count; i++)
                {
                    PictureBox pb = new PictureBox();
                    pb.Size = new Size(30, 27);
                    pb.Tag = xiwei.Rows[i];
                    int 席位状态ID = (int)xiwei.Rows[i]["SeatsStateID"];
                    switch (席位状态ID)
                    {
                        case 1: pb.BackgroundImage = Properties.Resources._002; break;
                        case 2: pb.BackgroundImage = Properties.Resources._003; break;
                        case 7: pb.BackgroundImage = Properties.Resources._001; break;
                    }
                    pb.BackgroundImageLayout = ImageLayout.Stretch;
                    pb.Paint += new PaintEventHandler(pb_paint);
                    flpZuoWeiZhuangTai.Controls.Add(pb);
                }
                dataGridView1.DataSource = xiwei;
                int z = 0; int s = 0; int t = 0;
                foreach (DataGridViewRow dgv in dataGridView1.Rows)
                {
                    int i = Convert.ToInt32(dgv.Cells["SeatsStateID"].Value);
                    if (i == 1)
                    {
                        z = z + 1;
                    }
                    if (i == 2)
                    {
                        s = s + 1;
                    }
                    if (i == 7)
                    {
                        t = t + 1;
                    }
                }
                labYiJian.Text = t.ToString();
                labWeiJian.Text = (z + t - t).ToString();
                labYiShou.Text = (z + t).ToString();
                fCollectioPiaoHao1 = new AutoCompleteStringCollection();
                dsPublic = new DataSet();
                mydt = myFRM_JianPiaoXiTongClient.SelectPiaoHaoByCheLiangID(VehicleID).Tables[0];
                foreach (DataRow dr in mydt.Rows)
                {
                    fCollectioPiaoHao1.Add(dr["TicketMark"].ToString().Trim());
                }

                txtPiaokou.ImeMode = ImeMode.KatakanaHalf;
                txtPiaokou.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtPiaokou.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtPiaokou.AutoCompleteCustomSource = fCollectioPiaoHao1;
            }
        }
        #endregion

        #region 窗体关闭事件
        private void butTuiChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 根据信息进行检票
        private void butJianPiao_Click(object sender, EventArgs e)
        {
            suo = true;
            int SeatsID = Convert.ToInt32(dte.Rows[0]["SeatsID"].ToString().Trim());
            int XiWeiZhuangTai = myFRM_JianPiaoXiTongClient.UpdateSeatsState(SeatsID);
            if (XiWeiZhuangTai != 0)
            {
                MessageBox.Show("检票成功！");
            }
            else
            {
                MessageBox.Show("检票失败！");
            }
            txtPiaokou.Text = "";
            txtZuoWei.Text = "";
            txtFaCheRiQi.Text = "";
            txtFaCheShiJian.Text = "";
            txtPiaoJia.Text = "";
            txtChePiaoLeiXing.Text = "";
            txtDaoDaZhang.Text = "";
            flpZuoWeiZhuangTai.Controls.Clear();
            dgvDaiJianBanCi_CellClick(null, null);
            mCreatePublicDatasetAndCollection();
        }
        #endregion
    }
}
