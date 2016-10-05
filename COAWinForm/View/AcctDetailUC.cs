using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COAWinForm.Model;

namespace COAWinForm.View
{
    public partial class AcctDetailUC : UserControl
    {

        public Accout currentAccount { get; set; }
        public List<String> parentsAcounts { get; set; }
        public string currID { get; set; }
        public bool Refresh { get; set; } = false;


        public AcctDetailUC()
        {
            InitializeComponent();

        }

        private void acctName_Enter(object sender, EventArgs e)
        {

        }

        private void creditBtn_Click(object sender, EventArgs e)
        {
            if (currentAccount == null)
            {
                MessageBox.Show("Please select account");
            }
            else
            {
                using (var crd = new Credit(parentsAcounts, currID))
                {
                    if (crd.ShowDialog() == DialogResult.OK)
                    {
                        var db = new COSDataClassesDataContext();
                        var acctInfo = from p in db.ChartOfAccounts
                                       where p.Acct_ID == currID
                                       select p;

                        balValue.Text = acctInfo.First().Balance.Value.ToString();

                        var accTran = from p in db.Leadgers
                                      where p.Source_ID == currID || p.Destination_ID == currID
                                      select p;

                        dataGridView1.DataSource = accTran;
                        Refresh = true;
                    }
                }
            }
        }
        Add_Account newAcct = new Add_Account();
        private void addChildBtn_Click(object sender, EventArgs e)
        {

            newAcct.Shown += NewAcct_Shown;

            newAcct.StartPosition = FormStartPosition.CenterParent;
            MessageBox.Show(currentAccount.Acct_Name);
            if (newAcct.ShowDialog() == DialogResult.OK)
            {
                Refresh = true;
            }
        }

        private void NewAcct_Shown(object sender, EventArgs e)
        {
            newAcct.checkBox1.Checked = false;
            newAcct.cmbRoot.SelectedValue = currentAccount.Acct_ID;
        }
    }
}
