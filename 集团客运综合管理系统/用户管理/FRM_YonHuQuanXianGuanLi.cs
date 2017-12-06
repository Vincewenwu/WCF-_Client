using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 集团客运综合管理系统.用户管理
{
    public partial class FRM_YonHuQuanXianGuanLi : Form
    {
        public FRM_YonHuQuanXianGuanLi()
        {
            InitializeComponent();
        }
        BLL集团客运综合管理.UserManager.FRM_YonHuQuanXianGuanLi.FRM_YonHuQuanXianGuanLiClient myFRM_YonHuQuanXianGuanLiClient
            = new BLL集团客运综合管理.UserManager.FRM_YonHuQuanXianGuanLi.FRM_YonHuQuanXianGuanLiClient();

        
        #region Load事件
        private void FRM_YonHuQuanXianGuanLi_Load(object sender, EventArgs e)
        {
            dgvYonHuLeiXing.DataSource = myFRM_YonHuQuanXianGuanLiClient.SelectUserType().Tables[0];

            DataTable mydt = new DataTable();
            mydt = myFRM_YonHuQuanXianGuanLiClient.SelectAuthorityTypeFuID(0).Tables[0];
            for (int i = 0; i < mydt.Rows.Count; i++)
            {
                TreeNode Node = new TreeNode();
                Node.Text = (string)mydt.Rows[i]["AuthorityTypeMC"];
                treeView.Nodes.Add(Node);
                int ID = Convert.ToInt32(mydt.Rows[i]["AuthorityTypeID"]);
                F_TreeView_InsertSonNod(Node, ID);
                
            }

            DataTable myds = new DataTable();
            myds = myFRM_YonHuQuanXianGuanLiClient.SelectCarStandFuID(0).Tables[0];
            for (int a = 0; a < myds.Rows.Count; a++)
            {
                TreeNode Nods = new TreeNode();
                Nods.Text = (string)myds.Rows[a]["CarStandMC"];
                treeView1.Nodes.Add(Nods);
                int ID = Convert.ToInt32(myds.Rows[a]["CarStandID"]);
                F_TreeView_InsertSonNod2(Nods, ID);
            }
        }
        #endregion

        public void F_TreeView_InsertSonNod(TreeNode FartherNode,int FatherID)
        {
            DataTable mydt = new DataTable();
            mydt = myFRM_YonHuQuanXianGuanLiClient.SelectAuthorityTypeFuID(FatherID).Tables[0];
            for(int i = 0; i < mydt.Rows.Count; i++)
            {
                TreeNode Node = new TreeNode();
                Node.Text = (string)mydt.Rows[i]["AuthorityTypeMC"];
                FartherNode.Nodes.Add(Node);
                int ID = Convert.ToInt32(mydt.Rows[i]["AuthorityTypeID"]);
                F_TreeView_InsertSonNod(Node, ID);
            }
        }

        public void F_TreeView_InsertSonNod2(TreeNode FartherNode, int CarStandID)
        {
            DataTable myds = new DataTable();
            myds = myFRM_YonHuQuanXianGuanLiClient.SelectCarStandFuID(CarStandID).Tables[0];
            for (int a = 0; a < myds.Rows.Count; a++)
            {
                TreeNode Nods = new TreeNode();
                Nods.Text = (string)myds.Rows[a]["CarStandMC"];
                FartherNode.Nodes.Add(Nods);
                int ID = Convert.ToInt32(myds.Rows[a]["CarStandID"]);
                F_TreeView_InsertSonNod2(Nods, ID);
            }
        }
    }
}
