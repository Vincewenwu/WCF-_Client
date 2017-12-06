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
    public partial class FRM_Main : Form
    {
        public FRM_Main()
        {
            InitializeComponent();
        }
        

        private void FRM_Main_Load(object sender, EventArgs e)
        {
            System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
            int iWidth = rect.Width;
            int iHeight = rect.Height;
            this.Height = iHeight;
            this.Width = iWidth;
            //this.Left =  PublicStaticObject.MainLeft+85;//往右距离
            //this.Top =  PublicStaticObject.MainTop+80;//往下距离
            //this.Width =  PublicStaticObject.MainWidth+1370;//加宽宽度
            //this.Height =  PublicStaticObject.MainHeight+720;//加高高度
            //this.pictureBox1.Width = pictureBox1.Right + 260;
            //this.pictureBox1.Height = pictureBox1.Height + 110;
            //this.pictureBox2.Width = pictureBox2.Right + 260;
            //this.groupBox1.Width = rect.Right;
            //this.pictureBox2.Width = rect.Right;
        }

        #region 按钮事件
        #endregion

        private void 票据入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(FRM_Login.yonghuleixing == 1))
            {

                SYS_PublicStaticClass.PublicStaticObject.FRM_PiaoJuRuKu = new 票据管理.FRM_PiaoJuRuKu();
                SYS_PublicStaticClass.PublicStaticObject.FRM_PiaoJuRuKu.ShowDialog();
            }
            else { MessageBox.Show("请选择对应的权限"); }
        }

        private void 用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(FRM_Login.yonghuleixing == 1))
            {
                SYS_PublicStaticClass.PublicStaticObject.FRM_YonHuGuanLi = new 用户管理.FRM_YonHuGuanLi();
                SYS_PublicStaticClass.PublicStaticObject.FRM_YonHuGuanLi.ShowDialog();
            }
            else { MessageBox.Show("请选择对应的权限"); }
        }

        private void 车辆管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(FRM_Login.yonghuleixing == 1))
            {
                SYS_PublicStaticClass.PublicStaticObject.FRM_CheLiangGuangLi = new 车辆管理.FRM_CheLiangGuangLi();
                SYS_PublicStaticClass.PublicStaticObject.FRM_CheLiangGuangLi.ShowDialog();
            }
            else { MessageBox.Show("请选择对应的权限"); }
        }

        private void 票据出库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(FRM_Login.yonghuleixing == 1))
            {
                SYS_PublicStaticClass.PublicStaticObject.FRM_PiaoJuChuKu = new 票据管理.FRM_PiaoJuChuKu();
                SYS_PublicStaticClass.PublicStaticObject.FRM_PiaoJuChuKu.ShowDialog();
            }
            else { MessageBox.Show("请选择对应的权限"); }
        }

        private void 多班检票ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(FRM_Login.yonghuleixing == 1))
            {
                SYS_PublicStaticClass.PublicStaticObject.FRM_JianPiaoXiTong = new 检票系统.FRM_JianPiaoXiTong();
                SYS_PublicStaticClass.PublicStaticObject.FRM_JianPiaoXiTong.ShowDialog();
            }
            else { MessageBox.Show("请选择对应的权限"); }
        }

        private void 班次管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(FRM_Login.yonghuleixing == 1))
            {
                SYS_PublicStaticClass.PublicStaticObject.Frm班次管理 = new 业务窗口.Frm班次管理();
                SYS_PublicStaticClass.PublicStaticObject.Frm班次管理.ShowDialog();
            }
            else { MessageBox.Show("请选择对应的权限"); }
        }

        private void 用户权限管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(FRM_Login.yonghuleixing == 1))
            {
                SYS_PublicStaticClass.PublicStaticObject.FRM_YonHuQuanXianGuanLi = new 用户管理.FRM_YonHuQuanXianGuanLi();
                SYS_PublicStaticClass.PublicStaticObject.FRM_YonHuQuanXianGuanLi.ShowDialog();
            }
            else { MessageBox.Show("请选择对应的权限"); }
        }

        private void DengLuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SYS_PublicStaticClass.PublicStaticObject.FRM_Login = new FRM_Login();
            //SYS_PublicStaticClass.PublicStaticObject.FRM_Login.ShowDialog();
        }

        private void 驾驶员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(FRM_Login.yonghuleixing == 1))
            {
                SYS_PublicStaticClass.PublicStaticObject.FRM_JiaShiYuanGuanLi = new 车辆管理.FRM_JiaShiYuanGuanLi();
                SYS_PublicStaticClass.PublicStaticObject.FRM_JiaShiYuanGuanLi.ShowDialog();
            }
            else { MessageBox.Show("请选择对应的权限"); }
        }

        private void 报班管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(FRM_Login.yonghuleixing == 2 || FRM_Login.yonghuleixing == 1))
            {
                SYS_PublicStaticClass.PublicStaticObject.Frm调度报班 = new 调度管理.调度报班();
                SYS_PublicStaticClass.PublicStaticObject.Frm调度报班.ShowDialog();

            }
            else { MessageBox.Show("请选择对应的权限"); }
        }

        private void 营收缴款ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            财务管理.FRM_YingShouJiaoKuan myFRM_YingShouJiaoKuan = new 财务管理.FRM_YingShouJiaoKuan();
            myFRM_YingShouJiaoKuan.ShowDialog();
        }

        private void 售票窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(FRM_Login.yonghuleixing == 3 || FRM_Login.yonghuleixing == 1))
            {
                SYS_PublicStaticClass.PublicStaticObject.Frm售票窗口 = new 售票管理.Frm售票窗口();
                SYS_PublicStaticClass.PublicStaticObject.Frm售票窗口.ShowDialog();
            }
            else { MessageBox.Show("请选择对应的权限"); }
        }

        private void 进站稽查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(FRM_Login.yonghuleixing == 1009 || FRM_Login.yonghuleixing == 1))
            {

                检查管理.Frm车辆安全检查窗口 my = new 检查管理.Frm车辆安全检查窗口();
                my.ShowDialog();
            }
            else { MessageBox.Show("请选择对应的权限"); }
        }

        private void 出站稽查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(FRM_Login.yonghuleixing == 1009 || FRM_Login.yonghuleixing == 1))
            {
                检查管理.Frm出站稽单 myFrm出站稽单 = new 检查管理.Frm出站稽单();
                myFrm出站稽单.ShowDialog();
            }
            else { MessageBox.Show("请选择对应的权限"); }
        }

        private void 报班管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(FRM_Login.yonghuleixing == 1009 || FRM_Login.yonghuleixing == 1))
            {
                报班管理.FRM_BaoBanGuanLi myFRM_BaoBanGuanLi = new 报班管理.FRM_BaoBanGuanLi();
                myFRM_BaoBanGuanLi.ShowDialog();
            }
            else { MessageBox.Show("请选择对应的权限"); }
        }
    }
}
