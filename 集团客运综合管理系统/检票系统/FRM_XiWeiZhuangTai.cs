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
    public partial class FRM_XiWeiZhuangTai : Form
    {
        public FRM_XiWeiZhuangTai()
        {
            InitializeComponent();
        }
        //BLL集团客运综合管理.检票系统.FRM_XiWeiZhuangTai.FRM_XiWeiZhuangTaiClient myFRM_XiWeiZhuangTaiClient
        //    = new BLL集团客运综合管理.检票系统.FRM_XiWeiZhuangTai.FRM_XiWeiZhuangTaiClient();
        //public static AutoCompleteStringCollection fCollectionSurfaceLandCode;
        //static DataTable mydt;
        //public void mCreatePublicDatasetAndCollection()
        //{
        //    if (fCollectionSurfaceLandCode != null)
        //    {
        //        fCollectionSurfaceLandCode.Clear();
        //    }
        //    if (mydt != null)
        //    {
        //        mydt.Clear();
        //    }
        //    fCollectionSurfaceLandCode = new AutoCompleteStringCollection();
        //    mydt = myFRM_XiWeiZhuangTaiClient.SelectTicketMark().Tables[0];
        //    foreach (DataRow dr in mydt.Rows)
        //    {
        //        fCollectionSurfaceLandCode.Add(dr["TicketMark"].ToString().Trim());
        //    }
        //    txtF1PiaoHoa.ImeMode = ImeMode.KatakanaHalf;
        //    txtF1PiaoHoa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //    txtF1PiaoHoa.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //    txtF1PiaoHoa.AutoCompleteCustomSource = fCollectionSurfaceLandCode;
        //}
        //public static int mReturnSurfaceLandID(string TicketMark)
        //{
        //    try
        //    {
        //        DataTable newDt;
        //        var queryZhanDian =
        //                from myVar in mydt.AsEnumerable()
        //                where (string)myVar["TicketMark"] == TicketMark
        //                select myVar;
        //        newDt = queryZhanDian.CopyToDataTable<DataRow>();
        //        return Convert.ToInt32(newDt.Rows[0]["TicketMark"]);
        //    }
        //    catch
        //    {
        //        return 0;
        //    }
        //}

        private void txtF1PiaoHoa_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    int TicketlIstID = Convert.ToInt32(txtF1PiaoHoa.Text);
            //    DataTable dt = myFRM_XiWeiZhuangTaiClient.SelectTicketlIstIDBuJian(TicketlIstID).Tables[0];
            //    txtBanCi.Text = dt.Rows[0]["FrequencyMC"].ToString().Trim();
            //    txtCheLiangBianHao.Text = dt.Rows[0]["PlateNumber"].ToString().Trim();
            //    txtCheLiangBianHao2.Text = dt.Rows[0]["PlateNumber"].ToString().Trim();
            //    txtFaCheShiJian.Text = dt.Rows[0]["DepartureTime"].ToString().Trim();
            //    txtXianLu.Text = dt.Rows[0]["LineMC"].ToString().Trim();
            //    txtXianLuBianHao.Text = dt.Rows[0]["LineNumber"].ToString().Trim();
            //    txtDaoDaZhan.Text = dt.Rows[0]["StationMC"].ToString().Trim();
            //    txtFaCheRiQi.Text = dt.Rows[0]["CirculationDate"].ToString().Trim();
            //    txtFaCheShiJian2.Text = dt.Rows[0]["DepartureTime"].ToString().Trim();
            //    txtChePiaoLeiXing.Text = dt.Rows[0]["TicketPriceTypeMC"].ToString().Trim();
            //    txtPiaoJia.Text = dt.Rows[0]["TicketPrice"].ToString().Trim();
            //    txtZuoHao.Text = dt.Rows[0]["SeatMark"].ToString().Trim();

            //}
            //catch
            //{

            //}
        }

        private void butTuiChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butJianPiao_Click(object sender, EventArgs e)
        {
            //if (butJianPiao != null)
            //{
            //    if (Convert.ToBoolean(MessageBox.Show("检票成功！")))
            //    {
            //        txtF1PiaoHoa.Text = "";
            //        txtBanCi.Text = "";
            //        txtCheLiangBianHao.Text = "";
            //        txtCheLiangBianHao2.Text = "";
            //        txtFaCheShiJian.Text = "";
            //        txtXianLu.Text = "";
            //        txtXianLuBianHao.Text = "";
            //        txtDaoDaZhan.Text = "";
            //        txtFaCheRiQi.Text = "";
            //        txtFaCheShiJian2.Text = "";
            //        txtChePiaoLeiXing.Text = "";
            //        txtPiaoJia.Text = "";
            //        txtZuoHao.Text = "";
            //    }
            //    else
            //    {
            //        MessageBox.Show("检票成功！");
            //    }
            //}
        }
    }
}
