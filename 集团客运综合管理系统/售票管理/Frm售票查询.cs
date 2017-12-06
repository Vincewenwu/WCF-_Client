using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 集团客运综合管理系统.售票管理
{
    public partial class chpiaophao : Form
    {
        public chpiaophao()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.SeaseTicket.TicketSease.TicketSeaseClient myTicketSeaseClient =
           new BLL集团客运综合管理.SeaseTicket.TicketSease.TicketSeaseClient();

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            string 动态条件 = "";
            if (chbanci.Checked)
            {
                动态条件 += " and FrequencyList.FrequencyMC = '" + txtbanci.Text.Trim() + "'";
            }
            if (chshijian.Checked)
            {
                动态条件 += " and ( TicketingInformationList.TicketingDate between '"
                     + dateTimePicker1.Value.ToShortDateString()
                     + " 00:00:00.000' and '"
                     + dateTimePicker2.Value.ToShortDateString()
                     + " 23:59:59.999' )";
            }
            if (chchexing.Checked)
               
            {
                动态条件 += " and VehicleTypeList.VehicleTypeMC = '" + cbochexing.Text.Trim() + "'";
            }
            if (chqidian.Checked)
                
            {
                动态条件 += " and StationList.StationMC = '" + txtqidian.Text.Trim() + "'";
            }
            if (chzhongdian.Checked)
                
            {
                动态条件 += " and StationList_1.StationMC = '" + txtzhongdian.Text.Trim() + "'";
            }
            if (chpiaoxing.Checked)
               
            {
                动态条件 += " and TicketPriceTypeList.TicketPriceTypeMC = '" + cbopiaoxing.Text.Trim() + "'";
            }

            if (chpiaohao.Checked)
                
            {
                动态条件 += " and TicketingInformationList.TicketMark = " + txtpiaohao.Text.Trim();
            }
            if (chzuoweihao.Checked)
                
            {
                动态条件 += " and SeatsList.SeatNoMC = " + txtzuoweihao.Text.Trim();
            }
            if (chpiaozhaungtai .Checked)

            {
                动态条件 += " and  TicketStateList_1.TicketStateMC = '" + cbopaiozhaungtai.Text .Trim () +"'" ;
            }
            DataTable dt = myTicketSeaseClient.MoHuSelectpiaoxinxi(动态条件).Tables[0];
            dataGridView1.DataSource = dt;
        }

        private void glassButton2_Click(object sender, EventArgs e)
        {
            txtbanci.Text = "";
            txtpiaohao.Text= "";
            txtqidian.Text= "";
            txtzhongdian.Text= "";
            txtzuoweihao.Text= "";
            chbanci.Checked=false;
            chshijian.Checked=false;
            chchexing.Checked=false;
            chqidian.Checked=false;
            chzhongdian.Checked =false;
            chpiaoxing.Checked=false;
            chpiaohao.Checked=false;
            chzuoweihao.Checked=false;
            cbochexing.Text = "";
            cbopaiozhaungtai.Text = "";
            cbopiaoxing.Text = "";
            cboshoupiaoyuan.Text = "";
        }

        private void chpiaophao_Load(object sender, EventArgs e)
        {
            cbochexing.DataSource = myTicketSeaseClient.selectchexing().Tables[0];
            cbochexing.DisplayMember = "VehicleTypeMC";

            cbopaiozhaungtai .DataSource = myTicketSeaseClient.selectpiaozhaungrtai ().Tables[0];
            cbopaiozhaungtai.DisplayMember = "TicketStateMC";

            cbopiaoxing .DataSource = myTicketSeaseClient.selectpiaoxing ().Tables[0];
            cbopiaoxing.DisplayMember = "TicketPriceTypeMC";
        }

        private void glassButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
