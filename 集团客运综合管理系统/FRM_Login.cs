using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace 集团客运综合管理系统
{
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }
        public string yanzhengma = "";
        public static int dengluyonghuID = 0;
        public static int yonghuleixing;
        public static string 用户名称;
        bool bolStar = true;
        int i;
        Panel pyanzhengma = new Panel();
        BLL集团客运综合管理.USRE.USER_DENGLU.USER_DENGLUClient myUSER_DENGLUClient = new BLL集团客运综合管理.USRE.USER_DENGLU.USER_DENGLUClient();
        private void btnDengLu_Click(object sender, EventArgs e)
        {
            dengluyonghuID = Convert.ToInt32(cbo_YongHuMing.SelectedValue);
            用户名称 = cbo_YongHuMing.Text.Trim();
            if (cbo_YongHuMing.Text != null /*&& txtYanZhengMa.Text != null*/ && txtYonHuMiMa.Text != null)
            {
                //if (txtYanZhengMa.Text.ToLower() == yanzhengma.ToLower())
                //{
                    int UserID = Convert.ToInt32(cbo_YongHuMing.SelectedValue);
                    DataTable dt = myUSER_DENGLUClient.SelectMiMaBYyonghu(UserID).Tables[0];
                    string mima = dt.Rows[0]["Password"].ToString().Trim();
                    yonghuleixing = Convert.ToInt32(dt.Rows[0]["UserTypeID"]);
                    if (txtYonHuMiMa.Text == mima)
                    {
                        FRM_Main 没有 = new FRM_Main();
                        没有.ShowDialog();
                    }
                    else { MessageBox.Show("密码错误啦"); }
                //}
                //else { MessageBox.Show("请输入正确的验证码"); }
            }
        }

        private void FRM_Login_Load(object sender, EventArgs e)
        {
            //DataTable dt = myUSER_DENGLUClient.Selectyonghu().Tables[0];
            //cbo_YongHuMing.DataSource = dt;
            //cbo_YongHuMing.ValueMember = "UserID";
            //cbo_YongHuMing.DisplayMember = "UserMC";
            //CreateYanZheengMa();
            //System.Threading.Thread P_thread = //创建线程
            //      new System.Threading.Thread(
            //      () =>//使用lambda表达式
            //    {
            //    while (true)//无限循环
            //    {
            //            try
            //            { this.Invoke(//操作窗体线程
            //           (MethodInvoker)delegate ()//使用匿名方法
            //           {
            //               this.Refresh();//刷新窗体
            //               Graphics P_Graphics = //创建绘图对象
            //          CreateGraphics();
            //               P_Graphics.DrawString("系统时间：" +//在窗体中绘出系统时间
            //                          DateTime.Now.ToString(
            //                          "yyyy年MM月dd日 HH时mm分ss秒"),
            //                          new Font("宋体", 15),
            //                          Brushes.Blue,
            //                          new Point(12, 484));
            //           });
            //            }
            //            catch { MessageBox.Show("你已退出"); }
            //            System.Threading.Thread.Sleep(1000);//线程挂起1秒钟
            //        }
            //    }); 
            //P_thread.IsBackground = true;//将线程设置为后台线程
            //P_thread.Start();//线程开始执行
        }

        #region 验证码生成方法
        public void CreateYanZheengMa()
        {
            //清空界面控件panel1的内容
            this.panel1.Controls.Clear();
            //使用动态声明Panel类型的控件pyanzhengma，并设置该控件显示的相对位置
            pyanzhengma.Location = new Point(0, 0);
            //设置pyanzhengma的控件大小，宽度为84，高度为26
            pyanzhengma.Size = new Size(200, 160);
            //使用重载运算符“+=”为pyanzhengma注册绘制事件，让pyanzhengma中出现文字、前景噪音点 、背景噪音线 
            pyanzhengma.Paint += new PaintEventHandler(p_Paint);
            //为pyanzhengma注册单击事件，使单击验证码图像的时候验证码更新
            pyanzhengma.Click += new EventHandler(pyanzhengma_Click);
            //将设置好的pyanzhengma控件添加到panel1的控件集合中，即可将验证码显示
            this.panel1.Controls.Add(pyanzhengma);
            //生成随机4个文字的验证码，并赋值给自定义的公共字段yanzhengma
            yanzhengma = CreateRandomCode(4);
        }
        #endregion
        #region pyanzhengma验证码显示控件的绘制事件
        public void p_Paint(object sender, PaintEventArgs e)
        {
            CreateImage(yanzhengma, e);
        }
        #endregion
        #region 产生随机验证码
        private string CreateRandomCode(int codeCount)
        {
            string allChar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
            string[] allCharArray = allChar.Split(',');
            int temp = -1;
            string randomCode = "";
            Random rand = new Random();
            for (int i = 0; i < codeCount; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * ((int)DateTime.Now.Ticks));
                }
                int t = rand.Next(61);
                if (temp == t)
                {
                    return CreateRandomCode(codeCount);
                }
                temp = t;
                randomCode += allCharArray[t];
            }
            return randomCode;
        }
        #endregion
        #region 绘制验证码背景噪音线与前景噪音点
        private void CreateImage(string checkCode, PaintEventArgs e)
        {
            if (checkCode == null || checkCode.Trim() == String.Empty)
                return;
            Bitmap image = new Bitmap(checkCode.Length * 150 + 100, 240);
            Graphics g = Graphics.FromImage(image);
            try
            {
                //生成随机生成器 
                Random random = new Random();
                //清空图片背景色 
                g.Clear(Color.White);
                //画图片的背景噪音线 
                for (int i = 0; i < 25; i++)
                {
                    int x1 = random.Next(image.Width);
                    int x2 = random.Next(image.Width);
                    int y1 = random.Next(image.Height);
                    int y2 = random.Next(image.Height);
                    g.DrawLine(new Pen(Color.Silver), x1, y1, x2, y2);
                }

                Font font = new Font("Arial", 12, (FontStyle.Bold | FontStyle.Italic));
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.BlueViolet, Color.Crimson, 1.2f, true);
                g.DrawString(checkCode, font, brush, 2, 2);
                //画图片的前景噪音点 
                for (int i = 0; i < 100; i++)
                {
                    int x = random.Next(image.Width);
                    int y = random.Next(image.Height);
                    image.SetPixel(x, y, Color.FromArgb(random.Next()));
                }

                //画图片的边框线 
                g.DrawRectangle(new Pen(Color.Blue), 0, 0, image.Width - 1, image.Height - 1);
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                    e.Graphics.DrawImage(image, new Point(1, 0));
                }
            }
            catch { }

            finally
            {
                bolStar = false;
                g.Dispose();
                image.Dispose();
            }
        }
        #endregion

        #region 刷新验证码
        private void pyanzhengma_Click(object sender, EventArgs e)
        {
            if (bolStar == false)
            {
                bolStar = true;
                CreateYanZheengMa();
            }
        }
        #endregion

        int cishu = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
                   cishu++;
            diaoyongvisable();
        }
        public void diaoyongvisable()
        {
             if (1== cishu)
            {
                label1.Visible = true;
            }
            if (2==cishu)
            {
                label1.Visible = true;
                label2.Visible = true;
               
            }
            if (3==cishu)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                }
            if (4==cishu)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
            }
            if (5==cishu)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
            }
            if (6==cishu)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
            }
            if (7==cishu)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
            }
            if (8==cishu)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
            }
            if (9==cishu)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
            }
            if (10==cishu)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
            }
            if (11==cishu)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
            }
            if (12==cishu)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
            }
            if (13==cishu)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
            }
            if (14==cishu)
            {
             label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;

                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
            }
            if (15 == cishu)
                {
                    label1.Visible = true;
                }
                if (16 == cishu)
                {
                    label1.Visible = true;
                    label2.Visible = true;

                }
                if (17 == cishu)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                }
                if (18 == cishu)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                }
                if (19 == cishu)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                }
                if (20 == cishu)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                }
                if (21 == cishu)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                }
                if (22 == cishu)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                }
                if (23 == cishu)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                }
                if (24 == cishu)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                }
                if (25 == cishu)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label11.Visible = true;
                }
                if (26 == cishu)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                }
                if (27 == cishu)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                    label13.Visible = true;
                }
                if (28 == cishu)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                    label13.Visible = true;
                    label14.Visible = true;
                }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            cishu++;
            diaoyongvisable();
        }
        private void button1_Click(object sender, EventArgs e)
        {        
                 faceDetect myfaceDetect = new faceDetect();
                 myfaceDetect.ShowDialog();  
        }
    }
}
