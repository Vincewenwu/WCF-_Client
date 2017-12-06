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
    public partial class Frm主界面 : Form
    {
        public Frm主界面()
        {
            InitializeComponent();
        }
        #region 菜单功能字段
        private static Panel Var_Panel = new Panel();//创建静态字段
        private static PictureBox Var_Pict = //创建静态字段
            new PictureBox();
        private static int Var_i = 0;//创建静态字段
        private Font Var_Font = new Font("宋体", 9); //创建字体字段
        #endregion
        #region 菜单的三个按钮功能
        private void pictureBox_1_Click(object sender, EventArgs e)
        {

           
        }

        private void pictureBox_2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox_3_Click(object sender, EventArgs e)
        {
            Var_i = Convert.ToInt16((//得到控件中的数据
               (PictureBox)sender).Tag.ToString());
            switch (Var_i)
            {
                case 1:
                    {
                        Var_Panel = panel_Gut_1;//得到面板对象引用
                        Var_Pict = pictureBox_1;//得到PictureBox对象引用
                        break;
                    }
                case 2:
                    {
                        Var_Panel = panel_Gut_2;//得到面板对象引用
                        Var_Pict = pictureBox_2;//得到PictureBox对象引用
                        break;
                    }
                case 3:
                    {
                        //Var_Panel = panel_Gut_3;//得到面板对象引用
                        //Var_Pict = pictureBox_3;//得到PictureBox对象引用
                        break;
                    }
            }
            if (Convert.ToInt16(Var_Panel.Tag.ToString()) == 0 || Convert.ToInt16(Var_Panel.Tag.ToString()) == 2)
            {
                Var_Panel.Tag = 1;//设置为隐藏标识
                Var_Pict.Image = Properties.Resources.朝下按钮;//设置图像属性
                Var_Panel.Visible = false;//隐藏面板
            }
            else
            {
                if (Convert.ToInt16(Var_Panel.Tag.ToString()) == 1)
                {
                    Var_Panel.Tag = 2;//设置为显示标识
                    Var_Pict.Image = Properties.Resources.朝上按钮;//设置图像属性
                    Var_Panel.Visible = true;//显示面板
                }
            }
        }
        #endregion

        #region 实例化窗口


       


       
        private void butBanCiGuanLi_Click(object sender, EventArgs e)
        {
           
        }
      

        #region 调度管理窗口
        private void butDiaoDuGuanLi_Click_1(object sender, EventArgs e)
        {
            SYS_PublicStaticClass.PublicStaticObject.Frm调度报班 = new 调度管理.调度报班();
            SYS_PublicStaticClass.PublicStaticObject.Frm调度报班.ShowDialog();
        }
        #endregion

        #region 售票管理窗口
        private void butShouPiaoGuanLi_Click_1(object sender, EventArgs e)
        {
            SYS_PublicStaticClass.PublicStaticObject.Frm售票窗口 = new 售票管理.Frm售票窗口();
            SYS_PublicStaticClass.PublicStaticObject.Frm售票窗口.ShowDialog();
        }
        #endregion
        
        #region 出站稽查管理窗口
        private void butChuZhanJiCha_Click(object sender, EventArgs e)
        {
            SYS_PublicStaticClass.PublicStaticObject.Frm出站稽单  = new 检查管理.Frm出站稽单 ();
            SYS_PublicStaticClass.PublicStaticObject.Frm出站稽单 .ShowDialog();
        }
        #endregion

        #region 财务管理窗口
        private void butCaiWuGuanLi_Click_1(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region 票据管理窗口
        private void butPiaoJuGuanLi_Click_1(object sender, EventArgs e)
        {
          
        }
        #endregion

        #endregion

        private void pictureBox_1_Click_1(object sender, EventArgs e)
        {
            Var_i = Convert.ToInt16((//得到控件中的数据
               (PictureBox)sender).Tag.ToString());
            switch (Var_i)
            {
                case 1:
                    {
                        Var_Panel = panel_Gut_1;//得到面板对象引用
                        Var_Pict = pictureBox_1;//得到PictureBox对象引用
                        break;
                    }
                case 2:
                    {
                        Var_Panel = panel_Gut_2;//得到面板对象引用
                        Var_Pict = pictureBox_2;//得到PictureBox对象引用
                        break;
                    }
                case 3:
                    {
                        //Var_Panel = panel_Gut_3;//得到面板对象引用
                        //Var_Pict = pictureBox_3;//得到PictureBox对象引用
                        break;
                    }
            }
            if (Convert.ToInt16(Var_Panel.Tag.ToString()) == 0 || Convert.ToInt16(Var_Panel.Tag.ToString()) == 2)
            {
                Var_Panel.Tag = 1;//设置为隐藏标识
                Var_Pict.Image = Properties.Resources.朝下按钮;//设置图像属性
                Var_Panel.Visible = false;//隐藏面板
            }
            else
            {
                if (Convert.ToInt16(Var_Panel.Tag.ToString()) == 1)
                {
                    Var_Panel.Tag = 2;//设置为显示标识
                    Var_Pict.Image = Properties.Resources.朝上按钮;//设置图像属性
                    Var_Panel.Visible = true;//显示面板
                }
            }

        }

        private void pictureBox_2_Click_1(object sender, EventArgs e)
        {
            Var_i = Convert.ToInt16((//得到控件中的数据
              (PictureBox)sender).Tag.ToString());
            switch (Var_i)
            {
                case 1:
                    {
                        Var_Panel = panel_Gut_1;//得到面板对象引用
                        Var_Pict = pictureBox_1;//得到PictureBox对象引用
                        break;
                    }
                case 2:
                    {
                        Var_Panel = panel_Gut_2;//得到面板对象引用
                        Var_Pict = pictureBox_2;//得到PictureBox对象引用
                        break;
                    }
                case 3:
                    {
                        //Var_Panel = panel_Gut_3;//得到面板对象引用
                        //Var_Pict = pictureBox_3;//得到PictureBox对象引用
                        break;
                    }
            }
            if (Convert.ToInt16(Var_Panel.Tag.ToString()) == 0 || Convert.ToInt16(Var_Panel.Tag.ToString()) == 2)
            {
                Var_Panel.Tag = 1;//设置为隐藏标识
                Var_Pict.Image = Properties.Resources.朝下按钮;//设置图像属性
                Var_Panel.Visible = false;//隐藏面板
            }
            else
            {
                if (Convert.ToInt16(Var_Panel.Tag.ToString()) == 1)
                {
                    Var_Panel.Tag = 2;//设置为显示标识
                    Var_Pict.Image = Properties.Resources.朝上按钮;//设置图像属性
                    Var_Panel.Visible = true;//显示面板
                }
            }
        }
        #region 班次管理窗口
        private void butBanCiGuanLi_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(FRM_Login.yonghuleixing == 1))
            {
                SYS_PublicStaticClass.PublicStaticObject.Frm班次管理 = new 业务窗口.Frm班次管理();
                SYS_PublicStaticClass.PublicStaticObject.Frm班次管理.ShowDialog();
            }
            else { MessageBox.Show("请选择对应的权限"); }
        }
            
        #endregion

            #region 调度管理窗口
        private void butDiaoDuGuanLi_Click(object sender, EventArgs e)//调度管理
        {
            if (Convert.ToBoolean(FRM_Login.yonghuleixing == 2 || FRM_Login.yonghuleixing == 1))
            {
                SYS_PublicStaticClass.PublicStaticObject.Frm调度报班 = new 调度管理.调度报班();
            SYS_PublicStaticClass.PublicStaticObject.Frm调度报班.ShowDialog();
            
             }else { MessageBox.Show("请选择对应的权限"); }
        }
    #endregion

    private void butShouPiaoGuanLi_Click(object sender, EventArgs e)
        {if (Convert .ToBoolean ( FRM_Login .yonghuleixing == 3 || FRM_Login.yonghuleixing == 1))
            {
                SYS_PublicStaticClass.PublicStaticObject.Frm售票窗口 = new 售票管理.Frm售票窗口();
                SYS_PublicStaticClass.PublicStaticObject.Frm售票窗口.ShowDialog();
            }else { MessageBox.Show("请选择对应的权限"); }
            
        }

        private void btnBaoBanGuanLi_Click(object sender, EventArgs e)
        {
            //SYS_PublicStaticClass.PublicStaticObject.FRM_BaoBanGuanLi = new 报班管理.FRM_BaoBanGuanLi();
            //SYS_PublicStaticClass.PublicStaticObject.FRM_BaoBanGuanLi.ShowDialog();
        }

        private void btnCheLiangGuanLi_Click(object sender, EventArgs e)
        {
            //SYS_PublicStaticClass.PublicStaticObject.FRM_CheLiangGuangLi = new 车辆管理.FRM_CheLiangGuangLi();
            //SYS_PublicStaticClass.PublicStaticObject.FRM_CheLiangGuangLi.ShowDialog();
        }
        #region 检票管理窗口
        private void butJianPiaoXiTong_Click(object sender, EventArgs e)
        {
            SYS_PublicStaticClass.PublicStaticObject.FRM_JianPiaoXiTong = new 检票系统.FRM_JianPiaoXiTong();
            SYS_PublicStaticClass.PublicStaticObject.FRM_JianPiaoXiTong.ShowDialog();
        }
        #endregion

        private void butChuZhanJiCha_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(FRM_Login.yonghuleixing == 1009 || FRM_Login.yonghuleixing == 1))
            {
                检查管理.Frm出站稽单 myFrm出站稽单 = new 检查管理.Frm出站稽单();
            myFrm出站稽单.ShowDialog();
            }
            else { MessageBox.Show("请选择对应的权限"); }

        }

        private void butCaiWuGuanLi_Click(object sender, EventArgs e)
        {
            财务管理.FRM_YingShouJiaoKuan myFRM_YingShouJiaoKuan = new 财务管理.FRM_YingShouJiaoKuan();
            myFRM_YingShouJiaoKuan.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(FRM_Login.yonghuleixing == 1009 || FRM_Login.yonghuleixing == 1))
            {
               
            检查管理.Frm车辆安全检查窗口 my = new 检查管理.Frm车辆安全检查窗口();
            my.ShowDialog();
            }
            else { MessageBox.Show("请选择对应的权限"); }

        }

        private void butPiaoJuGuanLi_Click(object sender, EventArgs e)
        {

        }
    }
}
