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
using System.Speech.Synthesis;
namespace 集团客运综合管理系统.调度管理
{
    public partial class Frm班次催客 : Form
    {
        public Frm班次催客()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.DispatchingManagement.DispatchingManagement.DispatchingmanagementClient myDispatchingManagementClient
             = new BLL集团客运综合管理.DispatchingManagement.DispatchingManagement.DispatchingmanagementClient();
        string q = "";
        public Socket newclient;
        public bool Connected;
        public Thread myThread;
        public delegate void MyInvoke(string str);
        private void Frm班次催客_Load(object sender, EventArgs e)
        {
            try {
                int FrequencyID = 调度管理.调度报班.班次ID;
                DataTable dt = myDispatchingManagementClient.Selectbancixinxitoguangbo(FrequencyID).Tables[0];
                label3.Text = dt.Rows[0]["FrequencyMC"].ToString();
                label7.Text = dt.Rows[0]["VehiclePaiNumber"].ToString();
                label10.Text = dt.Rows[0]["DepartureTime"].ToString();
                DataTable dtt = myDispatchingManagementClient.Selectchaxundiyigezhandian(FrequencyID).Tables[0];
                label9.Text = dtt.Rows[0][1].ToString();
                DataTable dttt = myDispatchingManagementClient.Selectchaxunzuihougezhandian(FrequencyID).Tables[0];
                label6.Text = dttt.Rows[0][1].ToString();
                DataTable dtttt = myDispatchingManagementClient.selecttujinzhan(FrequencyID).Tables[0];
                label18.Text = label10.Text;
                for (int i = 0; i < dtttt.Rows.Count; i++)
                {
                    q += dtttt.Rows[i][0].ToString();
                    q = q + "、";

                }
                label14.Text = label13.Text + label9.Text.Trim() + label15.Text.Trim() + q.Trim() + label17.Text.Trim() + label10.Text.Trim() + label19.Text;
                label24.Text = label20.Text + label9.Text.Trim() + label21.Text + label9.Text.Trim() + label22.Text.Trim() + label9.Text.Trim() + label23.Text.Trim();
            }catch { MessageBox.Show("没有站点，请选择被的班次"); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
            SpeechSynthesizer i = new SpeechSynthesizer();
            i.Speak(mymessage.Text );
        }
        public void Connect()
        {
            byte[] data = new byte[1024];
            newclient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            string ipadd = serverIP.Text .Trim ();
            int port = Convert.ToInt32(serverPort.Text.Trim());
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(ipadd), port);
            try
            {
                newclient.Connect(ie);
                connect1.Enabled = false;
                Connected = true;

            }
            catch (SocketException e)
            {
                MessageBox.Show("连接服务器失败  " + e.Message);
                return;
            }
            ThreadStart myThreaddelegate = new ThreadStart(ReceiveMsg);
            myThread = new Thread(myThreaddelegate);
            myThread.Start();
        }
        public void ReceiveMsg()
        {
            while (true)
            {
                byte[] data = new byte[1024];
                int recv = newclient.Receive(data);
                string stringdata = Encoding.UTF8.GetString(data, 0, recv);
                showMsg(stringdata + "\r\n");
                //receiveMsg.AppendText(stringdata + "\r\n");
            }
        }
        public void showMsg(string msg)
        {

            //在线程里以安全方式调用控件
            if (receiveMsg1.InvokeRequired)
            {
                MyInvoke _myinvoke = new MyInvoke(showMsg);
                receiveMsg1.Invoke(_myinvoke, new object[] { msg });
            }
            else
            {
                receiveMsg1.AppendText(msg);
            }
        }

        private void SendMsg_Click(object sender, EventArgs e)
        {
            int m_length = mymessage.Text.Length;
            byte[] data = new byte[m_length];
            data = Encoding.UTF8.GetBytes(mymessage.Text);
            int i = newclient.Send(data);
            showMsg("我说：" + mymessage.Text + "\r\n");
            mymessage.Text = "";
        }
        private static IPAddress [] gethostAddress(string hostnameoraddress)
        {
            IPAddress[] ips;
            ips = Dns.GetHostAddresses(hostnameoraddress);
      
           foreach (IPAddress ip in ips )
            {
                MessageBox.Show("");

            }
            return ips;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mymessage.Text = label14.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mymessage.Text = label24.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            mymessage.Text = label25.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            mymessage.Text = label26.Text;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            mymessage.Text = label27.Text;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            mymessage.Text = label28.Text;
        }
    }
}
