using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 集团客运综合管理系统.调度管理
{
    public partial class Frm报班调度报表 : Form
    {
        public Frm报班调度报表()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.DispatchingManagement.DispatchingManagement.DispatchingmanagementClient myDispatchingManagementClient
              = new BLL集团客运综合管理.DispatchingManagement.DispatchingManagement.DispatchingmanagementClient();

        private void Frm报班调度报表_Load(object sender, EventArgs e)
        {
           DataTable dt=  myDispatchingManagementClient.selectbaobanbanci().Tables[0];
            集团客运管理系统DataSet myshujuji = new 集团客运管理系统DataSet();
            myshujuji.Tables["Datatable1"].Merge(dt);
            CrystalReport2 mymuban = new CrystalReport2();
            mymuban.SetDataSource(myshujuji);
            crystalReportViewer1.ReportSource = mymuban;

        }
    }
}
