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
    public partial class Frm修改途径站窗口 : Form
    {
        public Frm修改途径站窗口()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.FrequencyManager.FrequencyListManager.FrequencyListManagerClient myFrequencyListManagerClient
            = new BLL集团客运综合管理.FrequencyManager.FrequencyListManager.FrequencyListManagerClient();
        int FrequencyID = 0;
      

        private void Frm修改途径站窗口_Load(object sender, EventArgs e)
        {
           FrequencyID=业务窗口.Frm班次管理.FrequencyID;
            DataTable dt= myFrequencyListManagerClient.SelectUpdatetujinStation(FrequencyID).Tables [0];
            SelectUpdatetujinStation.DataSource = dt;
            dataGridView1.Visible = false;
        }

        private void SelectUpdatetujinStation_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnnewStopsinroute_Click(object sender, EventArgs e)//确定修改站点信息
        {
            int myin=0;
            foreach (DataGridViewRow dgv in SelectUpdatetujinStation.Rows)
            {
              
                int StaionID = Convert.ToInt32(dgv.Cells["StaionID"].Value.ToString());
                int CreateUserID = 1;
                int DeleteUserID = 1;
                string StopsinrouteMC = dgv.Cells["StopsinrouteMC"].Value.ToString();
                int Standingorder = Convert.ToInt32(dgv.Cells["Standingorder"].Value.ToString());
                string StationNunber = dgv.Cells["StationNunber"].Value.ToString();
                bool Whetherdock = Convert.ToBoolean(dgv.Cells["Whetherdock"].Value.ToString());
                DateTime CreateTime = Convert.ToDateTime(DateTime.Now.ToString().ToString());
                int StopsinrouteID = Convert.ToInt32(dgv.Cells["StopsinrouteID"].Value.ToString());
                int kilometer = Convert.ToInt32(dgv.Cells["kilometer"].Value.ToString());
                myin = myFrequencyListManagerClient.UpdateTuJinStation(FrequencyID, StaionID, CreateUserID, DeleteUserID, StopsinrouteMC,
                                         Standingorder, StationNunber, Whetherdock, CreateTime, StopsinrouteID, kilometer);
            }
            if (myin >0)
            {
                MessageBox.Show("SuccessOK");
            }else
            {
                MessageBox.Show("Successbit");
            }


        }

        private void SelectUpdatetujinStation_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //DataTable dt = myFrequencyListManagerClient.SelectUpdatetujinStation(FrequencyID).Tables[0];
            //int StaionID = Convert.ToInt32(dt.Rows[e.RowIndex]["StaionID"].ToString());
            //int CreateUserID = 1;
            //int DeleteUserID = 1;
            //string StopsinrouteMC = dt.Rows[e.RowIndex]["StopsinrouteMC"].ToString();
            //int Standingorder = Convert.ToInt32(SelectUpdatetujinStation.Rows[e.RowIndex].Cells["Standingorder"].Value.ToString());
            //string StationNunber = dt.Rows[e.RowIndex]["StationNunber"].ToString();
            //bool Whetherdock = Convert.ToBoolean(dt.Rows[e.RowIndex]["Whetherdock"].ToString());
            //DateTime CreateTime = Convert.ToDateTime(DateTime.Now.ToString().ToString());
            //int StopsinrouteID = Convert.ToInt32(dt.Rows[e.RowIndex]["StopsinrouteID"].ToString());
            //int kilometer = 0;
            //int myin = myFrequencyListManagerClient.UpdateTuJinStation(FrequencyID, StaionID, CreateUserID, DeleteUserID, StopsinrouteMC,
            //                             Standingorder, StationNunber, Whetherdock, CreateTime, StopsinrouteID, kilometer);

            //if (myin != 0)
            //{
            //    SelectUpdatetujinStation.Visible = false;
            //    dataGridView1.Visible = true;
            //    DataTable dt1 = myFrequencyListManagerClient.SelectUpdatetujinStation(FrequencyID).Tables[0];
            //    dataGridView1.DataSource = dt1;
            //}


        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)//结束时修改当前德尔值并且更新，让站序自己排好,只能改站序号
        {

           // DataTable dt = myFrequencyListManagerClient.SelectUpdatetujinStation(FrequencyID).Tables[0];
           // int StaionID = Convert.ToInt32(dt.Rows[e.RowIndex]["StaionID"].ToString());
           // int CreateUserID = 1;
           // int DeleteUserID = 1;
           // string StopsinrouteMC = dt.Rows[e.RowIndex]["StopsinrouteMC"].ToString();
           // int Standingorder = Convert.ToInt32(SelectUpdatetujinStation.Rows[e.RowIndex].Cells["Standingorder"].Value.ToString());
           // string StationNunber = dt.Rows[e.RowIndex]["StationNunber"].ToString();
           // bool Whetherdock = Convert.ToBoolean(dt.Rows[e.RowIndex]["Whetherdock"].ToString());
           // DateTime CreateTime = Convert.ToDateTime(DateTime.Now.ToString().ToString());
           // int StopsinrouteID = Convert.ToInt32(dt.Rows[e.RowIndex]["StopsinrouteID"].ToString());
           // int kilometer = 0;
           // int myin = myFrequencyListManagerClient.UpdateTuJinStation(FrequencyID, StaionID, CreateUserID, DeleteUserID, StopsinrouteMC,
           //                              Standingorder, StationNunber, Whetherdock, CreateTime, StopsinrouteID, kilometer);

           //if (myin != 0)
           //     {
           //         SelectUpdatetujinStation.Visible = false;
           //         dataGridView1.Visible = true;
           //  //   DataTable dt1 = myFrequencyListManagerClient.SelectUpdatetujinStation(FrequencyID).Tables[0];
              
           // }else { MessageBox.Show(""); }
        }
    }
}
