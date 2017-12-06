using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace 集团客运综合管理系统.调度管理
{
    public partial class Frm订票窗口 : Form
    {
        public Frm订票窗口()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.DispatchingManagement.DispatchingManagement.DispatchingmanagementClient myDispatchingmanagementClient
            = new BLL集团客运综合管理.DispatchingManagement.DispatchingManagement.DispatchingmanagementClient();
        public string yanzhengma = "";
        private void button1_Click(object sender, EventArgs e)
        {
            int port = 2000;
            string host = "127.0.0.1";
            IPAddress ip = IPAddress.Parse(host);
            ipe = new IPEndPoint(ip, port);
            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


            th = new Thread(Listen);
            th.IsBackground = true;
            th.Start();
        }
        Socket s;
        private void Frm订票窗口_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
          
        }
        #region 验证码生成方法
        public void CreateYanZheengMa()
        {
            yanzhengma = CreateRandomCode(10);
        }
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
        #endregion
        Thread th;
        IPEndPoint ipe;
        void Listen()
        {
            s.Bind(ipe);
            s.Listen(0);
            string str = ("等待客户端连接" + "\n");
            richTextBox1.AppendText(str);
            temp = s.Accept();
            richTextBox1.AppendText("建立连接" + "\n");

            yu = new Thread(i);
            yu.Start();
            yu.IsBackground = true;
            string sendStr = "我是服务端发来的消息！你看到我了吗？";
            byte[] bs = Encoding.UTF8.GetBytes(sendStr);
            temp.Send(bs, bs.Length, 0);
        }
        Thread yu;
        Socket temp;
        void i()
        {
            while (true)
            {

                string recvStr = "";
                byte[] recvBytes = new byte[1024];
                int bytes;
                bytes = temp.Receive(recvBytes, recvBytes.Length, 0);
                recvStr += Encoding.UTF8.GetString(recvBytes, 0, bytes);
                richTextBox1.AppendText("服务端说;" + recvStr + "\n");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] bs = Encoding.UTF8.GetBytes(textBox1.Text.Trim());
            temp.Send(bs, bs.Length, 0);
            textBox1.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateYanZheengMa();
            textBox2.Text = yanzhengma;
            bool ShiFou = chshengcheng.Checked;
            int myint = myDispatchingmanagementClient.InsectYanZhnegMa(yanzhengma, ShiFou);
            if (myint>0)
            { MessageBox.Show("验证码成功生成");
                textBox1.Text = null ;
            }
           
        }
    }
}
