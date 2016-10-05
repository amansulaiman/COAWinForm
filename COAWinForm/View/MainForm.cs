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

        COSDataClassesDataContext db = new COSDataClassesDataContext();
        //AccountsTree Ac_Tree;

        public Form1()
        {
            InitializeComponent();
            //Ac_Tree = new AccountsTree() { Dock = DockStyle.Fill };
            //splitContainer2.Panel1.Controls.Add(Ac_Tree);
            loadAccounts();
            acctDetailUC1.Visible = false;
            treeViewBound1.AfterSelect += TreeViewBound1_AfterSelect;
            //

        }

        private void TreeViewBound1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var accountDetail = from p in db.ChartOfAccounts
                                where p.Acct_ID == treeViewBound1.SelectedValue.ToString()
                                select p;

            acctDetailUC1.acctName.Text = accountDetail.First().Acct_Name;
            acctDetailUC1.balValue.Text = accountDetail.First().Balance.Value.ToString();

            acctDetailUC1.Visible = true;
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
    }
}
