using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using COAWinForm.Model;
using System.Threading.Tasks;
using System.Windows.Forms;
using COAWinForm.View;

namespace COAWinForm
{
    public partial class Form1 : Form

    {
        //Global Data Contex
        COSDataClassesDataContext db = new COSDataClassesDataContext();


        public Form1()
        {
            InitializeComponent();
            loadAccounts();
            acctDetailUC1.Visible = false;
            treeViewBound1.AfterSelect += TreeViewBound1_AfterSelect;
            treeViewBound1.NodeMouseClick += TreeViewBound1_NodeMouseClick;
            acctDetailUC1.creditBtn.Click += CreditBtn_Click;
            acctDetailUC1.addChildBtn.Click += AddChildBtn_Click;
        }

        private void AddChildBtn_Click(object sender, EventArgs e)
        {
            if (acctDetailUC1.Refresh)
            {
                loadAccounts();
                acctDetailUC1.Refresh = false;
            }
        }

        private void CreditBtn_Click(object sender, EventArgs e)
        {
            if (acctDetailUC1.Refresh)
            {
                loadAccounts();
                acctDetailUC1.Refresh = false;
            }
        }

        private void TreeViewBound1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
        }

        private void TreeViewBound1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            //Account Details
            var accountDetail = from p in db.ChartOfAccounts
                                where p.Acct_ID == treeViewBound1.SelectedValue.ToString()
                                select p;

            //Transaction Details
            var trandetails = from p in db.Leadgers
                              where p.Source_ID == treeViewBound1.SelectedValue.ToString() || p.Destination_ID == treeViewBound1.SelectedValue.ToString()
                              select p;

            acctDetailUC1.acctName.Text = accountDetail.First().Acct_Name;
            acctDetailUC1.balValue.Text = accountDetail.First().Balance.Value.ToString();

            //Data Grid
            acctDetailUC1.dataGridView1.DataSource = trandetails;

            //Create Account Object
            Accout acct = new Accout() { Acct_ID = accountDetail.First().Acct_ID, Acct_Name = accountDetail.First().Acct_Name, Balance = accountDetail.First().Balance.Value, RootAccountID = accountDetail.First().Parent_ID };

            //Bind it to User Control
            acctDetailUC1.currentAccount = acct;

            //Get Parents Account
            List<String> pAccts = new List<string>();
            foreach (var item in GetParentNodes(treeViewBound1.SelectedNode))
            {
                pAccts.Add(item.Text);
                //MessageBox.Show(item.Tag);
            }
            acctDetailUC1.parentsAcounts = pAccts;
            acctDetailUC1.currID = treeViewBound1.SelectedValue.ToString();
            acctDetailUC1.Visible = true;
        }

        private TreeNode[] GetParentNodes(TreeNode node_)
        {
            TreeNode[] nodes_ = new TreeNode[node_.Level + 1];
            nodes_[0] = node_;
            List<String> pAccts = new List<string>();
            for (int i = 1; i < nodes_.Length; i++)
            {
                nodes_[i] = nodes_[i - 1].Parent;
                pAccts.Add(nodes_[i].Name);
            }
            return nodes_;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        void loadAccounts()
        {
            var acctsdata = from p in db.ChartOfAccounts
                            select p;

            var myds = new Model.COA_DataSets.ChartOfAccountsDataTable();

            foreach (var item in acctsdata)
            {
                myds.Rows.Add(new object[] { item.Acct_ID, item.Acct_Name, item.Parent_ID, item.Balance });
            }
            myds.AcceptChanges();

            this.treeViewBound1.ValueMember = myds.Acct_IDColumn.ColumnName;
            this.treeViewBound1.ParentMember = myds.Parent_IDColumn.ColumnName;
            this.treeViewBound1.DisplayMember = myds.Acct_NameColumn.ColumnName;

            this.treeViewBound1.DataSource = myds;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var add = new Add_Account() { StartPosition = FormStartPosition.CenterParent })
            {
                if (add.ShowDialog() == DialogResult.OK)
                {
                    loadAccounts();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var lgr = new Leader();
            lgr.Show();
        }

        private void acctDetailUC1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newtran = new NewTransaction();
            newtran.ShowDialog();
        }
    }
}
