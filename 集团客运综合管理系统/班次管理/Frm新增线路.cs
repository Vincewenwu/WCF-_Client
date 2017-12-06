using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 集团客运综合管理系统.班次管理
{
    public partial class Frm新增线路 : Form
    {
        public Frm新增线路()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.FrequencyManager.NEWFrequencyInsect.NEWFrequencyInsectClient myNEWFrequencyInsectClient
               = new BLL集团客运综合管理.FrequencyManager.NEWFrequencyInsect.NEWFrequencyInsectClient();
        private void button1_Click(object sender, EventArgs e)
        {
            string LineMC = txtLinename.Text;
          DataTable dt=  myNEWFrequencyInsectClient.LineSelectOn(LineMC).Tables[0];
            if (dt .Rows .Count ==0)
            {
                DateTime CreateTime = Convert.ToDateTime(DateTime.Now.ToString("m"));
                int CreateUserID =1;
                int DeleteUserID =1;
                LineMC = txtLinename.Text;
                string LineNumber =txtLineNunber .Text;
               int myint=   myNEWFrequencyInsectClient.LineLInsect(CreateUserID, DeleteUserID, LineMC, LineNumber, CreateTime);
                if (myint > 0)
                {
                    MessageBox.Show("新增成功");
                    this.Visible = false;
                }

            }
            else
            {
                MessageBox.Show("站点已存在啦");
            }
        }
        
    }
}
