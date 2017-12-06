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
    public partial class Frm出站稽单报表 : Form
    {
        public Frm出站稽单报表()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.chuzhanjicha.chezhanjicha.chezhanjichaClient mychezhanjichaClient
            = new BLL集团客运综合管理.chuzhanjicha.chezhanjicha.chezhanjichaClient();

        private void Frm出站稽单报表_Load(object sender, EventArgs e)
        {
            string PlateNumber = Frm出站稽单.PlateNumber;
            DataTable 明细 = mychezhanjichaClient.SELECTJICHAXIANGMUMINGXI(PlateNumber).Tables[0];
            int TheStationInspectionID =Convert .ToInt32 ( 明细.Rows[0]["TheStationInspectionID"]);
            DataTable 稽查项目 = mychezhanjichaClient.selectjichaxiangmu(TheStationInspectionID).Tables[0];

            集团客运管理系统DataSet my数据集 = new 集团客运管理系统DataSet();
            my数据集.Tables["出站稽查明细"].Merge(明细);
            my数据集.Tables["出站稽查项目"].Merge(稽查项目);
            crp稽单报表 mycrp稽单报表 = new crp稽单报表();
            mycrp稽单报表.SetDataSource(my数据集);
            crystalReportViewer1.ReportSource = mycrp稽单报表;
        }
    }
}
