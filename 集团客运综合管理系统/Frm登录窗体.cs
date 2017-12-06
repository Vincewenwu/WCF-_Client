using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 集团客运综合管理系统
{
    public partial class Frm登录窗体 : Form
    {
        public Frm登录窗体()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.USRE.USER_DENGLU.USER_DENGLUClient myUSER_DENGLUClient = new BLL集团客运综合管理.USRE.USER_DENGLU.USER_DENGLUClient();
        private void btn_DengLu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
          //  Frm主界面 myFrm主界面 = new Frm主界面();
          //  myFrm主界面.ShowDialog();
            
        }

        private void Frm登录窗体_Load(object sender, EventArgs e)
        {
           cbo_YongHuMing .DataSource = myUSER_DENGLUClient.Selectyonghu().Tables [0];
            cbo_YongHuMing.SelectedValue = "UserID";
            cbo_YongHuMing.DisplayMember = "UserMC";
        }
    }
}
