using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace 集团客运综合管理系统
{
    class SYS_PublicStaticClass
    {
        [DllImport("user32.dll")]  //需添加using System.Runtime.InteropServices
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        public static class PublicStaticObject
        {

            
            public static 检查管理.Frm出站稽单 Frm出站稽单;
            public static 检查管理.Frm出站稽单报表 Frm出站稽单报表;
            public static 检查管理.Frm车辆安全检查窗口 Frm车辆安全检查窗口;

            public static 调度管理.调度报班 Frm调度报班;

            public static 售票管理.Frm售票窗口 Frm售票窗口;

            public static 检票系统.FRM_JianPiaoXiTong FRM_JianPiaoXiTong;
            public static 检票系统.FRM_XiWeiZhuangTai FRM_XiWeiZhuangTai;
            public static 报班管理.FRM_BaoBanGuanLi FRM_BaoBanGuanLi;

            public static 票据管理.FRM_PiaoJuChuKu FRM_PiaoJuChuKu;
            public static 票据管理.FRM_PiaoJuChuKu_Insert FRM_PiaoJuChuKu_Insert;
            public static 票据管理.FRM_PiaoJuChuKu_Update FRM_PiaoJuChuKu_Update;
            public static 票据管理.FRM_PiaoJuRuKu FRM_PiaoJuRuKu;
            public static 票据管理.FRM_PiaoJuRuKu_Insert FRM_PiaoJuRuKu_Insert;
            
            public static 业务窗口.Frm班次管理 Frm班次管理;
            public static 业务窗口.Frm新增班次窗口 Frm新增班次窗口;
            public static 业务窗口.Frm修改班次窗口 Frm修改班次窗口;

            public static 班次管理 .Frm新增站点 Frm新增站点;
            public static 班次管理.Frm新增线路 Frm新增线路;
            public static 班次管理.Frm添加途径站点 Frm添加途径站点;
            public static 班次管理.Frm修改途径站窗口 Frm修改途径站窗口;
            public static 系统管理.Frm权限管理 Frm权限管理;
            public static 班次管理.Frm班次打印 Frm班次打印;

            public static 广播系统.Frm自动语音播放 Frm自动语音播放;

            //public static Frm主界面 Frm主界面;
            public static FRM_Main FRM_Main;

            public static 车辆管理.FRM_CheLiangGuangLi FRM_CheLiangGuangLi;
            public static 车辆管理.FRM_CheLiangGuangLi_Insert FRM_CheLiangGuangLi_Insert;
            public static 车辆管理.FRM_CheLiangGuangLi_Update FRM_CheLiangGuangLi_Update;
            public static 车辆管理.FRM_JiaShiYuanGuanLi FRM_JiaShiYuanGuanLi;
            public static 车辆管理.FRM_JiaShiYuanGuanLi_Insert FRM_JiaShiYuanGuanLi_Insert;
            public static 车辆管理.FRM_JiaShiYuanGuanLi_Update FRM_JiaShiYuanGuanLi_Update;
            public static 车辆管理.FRM_JiaShiYuanXinXi FRM_JiaShiYuanXinXi;

            public static 用户管理.FRM_YonHuGuanLi FRM_YonHuGuanLi;
            public static 用户管理.FRM_YonHuGuanLi_Insert FRM_YonHuGuanLi_Insert;
            public static 用户管理.FRM_YonHuGuanLi_Update FRM_YonHuGuanLi_Update;
            public static 用户管理.FRM_YonHuQuanXianGuanLi FRM_YonHuQuanXianGuanLi;













        }

    }
}
