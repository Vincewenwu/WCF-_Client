using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 集团客运综合管理系统.业务窗口
{
    public partial class Frm班次管理 : Form
    {
        public Frm班次管理()
        {
            InitializeComponent();
        }
        private void btnxinzengbanci_Click(object sender, EventArgs e)
        {
            Frm新增班次窗口 myFrm新增班次窗口 = new Frm新增班次窗口();
            myFrm新增班次窗口.ShowDialog();
        }

        private void btnxiugaibanci_Click(object sender, EventArgs e)
        {
            Frm修改班次窗口 myFrm修改班次窗口 = new Frm修改班次窗口();
            myFrm修改班次窗口.ShowDialog();
        }

        private void btnbancigudingyuliu_Click(object sender, EventArgs e)
        {
            Frm添加班次固定预留窗口 myFrm添加班次固定预留窗口 = new Frm添加班次固定预留窗口();
            myFrm添加班次固定预留窗口.ShowDialog();
        }

        private void btnbancichangting_Click(object sender, EventArgs e)
        {
            Frm班次长停窗口 myFrm班次长停窗口 = new Frm班次长停窗口();
            myFrm班次长停窗口.ShowDialog();
        }

        private void Frm班次管理_Load(object sender, EventArgs e)
        {
            //Frm主界面 myFrm主界面 = new Frm主界面();
            //this.Left = myFrm主界面.Left;
            //this.Top = myFrm主界面.Top ;
            //this.Width = myFrm主界面.Width ;
            //this.Height = myFrm主界面.Height ;
        }
    }
}
