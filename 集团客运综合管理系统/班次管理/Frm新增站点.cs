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
    public partial class Frm新增站点 : Form
    {
        public Frm新增站点()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.FrequencyManager.NEWFrequencyInsect.NEWFrequencyInsectClient myNEWFrequencyInsectClient
            = new BLL集团客运综合管理.FrequencyManager.NEWFrequencyInsect.NEWFrequencyInsectClient();
      
        private void button1_Click(object sender, EventArgs e)//新增站点
        {
            string StationMC = txtstationname.Text;
            DataTable dt = myNEWFrequencyInsectClient.StationSelectOn(StationMC).Tables[0];
            if (dt.Rows .Count ==0)
            {
                if (txtPingYinJianXie.Text!="" && txtStationNunber.Text !="" && txtstationname.Text!="" )
                {
                    DateTime CreateTime = Convert.ToDateTime(DateTime.Now.ToString("m"));
                    int CreateUserID = 1;
                    int DeleteUserID = 1;
                    StationMC = txtstationname.Text;
                    string SitePinYinInitials = txtPingYinJianXie.Text;
                    string StationNunber = txtStationNunber.Text;
                    int myint = myNEWFrequencyInsectClient.StationInsect(CreateUserID, DeleteUserID, StationMC,
                                                           SitePinYinInitials, StationNunber, CreateTime);
                    if (myint > 0)
                    {
                        MessageBox.Show("新增成功");
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("请输入信息");
                }

            }
           else
            {
                MessageBox.Show("站点已存在啦");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
