using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
//using Microsoft.Office.Interop.Excel;

namespace 集团客运综合管理系统.班次管理
{
    public partial class Frm班次打印 : Form
    {
        public Frm班次打印()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.FrequencyManager.FrequencyListManager.FrequencyListManagerClient myFrequencyListManagerClient
            = new BLL集团客运综合管理.FrequencyManager.FrequencyListManager.FrequencyListManagerClient();

        private void tSPDaoChu_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dt = GetDgvToTable(dgvSiJi);
            ExportToExcel("车辆信息表", dt);
        }
        #region   //数据的导出方法 ExportToExcel
        public void ExportToExcel(string FileName, System.Data.DataTable DATE)
        {
            if (DATE == null) return;

            string 保存文件名 = "";
            bool 是否保存 = false;

            SaveFileDialog saveDialog = new SaveFileDialog();//创建一个保存文件对话框

            saveDialog.DefaultExt = "xls";

            saveDialog.Filter = "Excel文件|*.xls";
            saveDialog.FileName = FileName;

            //if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    保存文件名 = saveDialog.FileName;

            //    //创建一个Excel应用对象
            //    Microsoft.Office.Interop.Excel.Application xlApp
            //        = new Microsoft.Office.Interop.Excel.Application();
            //    if (xlApp == null)
            //    {
            //        MessageBox.Show("创建Excel对象失败，可能您的电脑尚未安装Excel");
            //        return;
            //    }
            //    //通过xlApp对象返回一个工作簿
            //    Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            //    //往工作簿workbooks添加工作页
            //    Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(
            //            Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet
            //        );
            //    Microsoft.Office.Interop.Excel.Worksheet worksheet
            //        = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];


            //    ((Range)worksheet.Columns[1]).ColumnWidth = 15;//设置列宽度
            //    ((Range)worksheet.Columns[2]).ColumnWidth = 15;//设置列宽度
            //    ((Range)worksheet.Columns[3]).ColumnWidth = 15;//设置列宽度
            //    ((Range)worksheet.Columns[4]).ColumnWidth = 15;//设置列宽度
            //    //((Range)worksheet.Columns[5]).ColumnWidth = 15;//设置列宽度
            //    //((Range)worksheet.Columns[6]).ColumnWidth = 20;//设置列宽度

            //    //for循环，将列名添加到工作页中
            //    for (int i = 0; i < DATE.Columns.Count; i++)
            //    {
            //        worksheet.Cells[1, i + 1] = DATE.Columns[i].ColumnName;
            //        Microsoft.Office.Interop.Excel.Range range =
            //            (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[1, i + 1];
            //        range.Interior.ColorIndex = 15;
            //        range.Font.Bold = true;
            //    }

            //    //for循环填写数据
            //    for (int i = 0; i < DATE.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < DATE.Columns.Count; j++)
            //        {
            //            worksheet.Cells[i + 2, j + 1] = "'" + DATE.Rows[i][j];
            //        }
            //        System.Windows.Forms.Application.DoEvents();
            //    }

            //    if (保存文件名 != "")
            //    {
            //        workbook.Saved = true;
            //        workbook.SaveCopyAs(保存文件名);
            //        是否保存 = true;
            //    }
            //    else
            //    {
            //        是否保存 = false;
            //    }
            //    xlApp.Quit();
            //    GC.Collect();
            //    if (是否保存 && File.Exists(保存文件名))
            //        System.Diagnostics.Process.Start(保存文件名);

            //}


        }

        #endregion


        #region //数据的导入方法 ExcelToDT
        public System.Data.DataTable ImpExcelToDT(string fileName)
        {
            try
            {

                string strcn = @"Provider=Microsoft.Jet.OLEDB.4.0;
                Data Source = " + fileName + ";Extended Properties=Excel 8.0;";
                OleDbConnection myCon = new OleDbConnection(strcn);

                string strCom = "select * from [Sheet1$]";
                myCon.Open();
                OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myCon);
                DataSet myDataSet = new DataSet();
                myCommand.Fill(myDataSet, "[Sheet1$]");
                myCon.Close();
                System.Data.DataTable dtUsers = myDataSet.Tables[0];
                return dtUsers;
            }
            catch
            {
                return null;
            }

        }
        #endregion #region //DataGridView 数据转换成DataTable                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
        public System.Data.DataTable GetDgvToTable(DataGridView dgv)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            for (int count = 0; count < dgv.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());
                dt.Columns.Add(dc);
            }
            for (int count = 0; count < dgv.Rows.Count; count++)
            {
                DataRow dr = dt.NewRow();
                for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)
                {
                    dr[countsub] = Convert.ToString(dgv.Rows[count].Cells[countsub].Value);
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }


        private void Frm班次打印_Load(object sender, EventArgs e)
        {
            System.Data.DataTable dt = myFrequencyListManagerClient.selectbanbiao().Tables[0];
            dgvSiJi.DataSource = dt;
        }
    }
}
