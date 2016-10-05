using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COAWinForm.View
{
    public partial class Add_Account : Form
    {
        public bool IsRoot { get; set; }
        public Add_Account()
        {
            InitializeComponent();
            checkBox1.Checked = true;
            cmbRoot.Enabled = false;
            IsRoot = false;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cmbRoot.Enabled = false;
                IsRoot = false;
            }
            else
            {
                cmbRoot.Enabled = true;
                IsRoot = true;
            }
        }

        private void Add_Account_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOA_DataSets.ChartOfAccounts' table. You can move, or remove it, as needed.
            this.chartOfAccountsTableAdapter.Fill(this.cOA_DataSets.ChartOfAccounts);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                var db = new COSDataClassesDataContext();
                var newAcct = new ChartOfAccount() { Acct_ID = txtAcctID.Text, Acct_Name = txtAcctName.Text, Balance = 0 };
                if (IsRoot)
                {
                    newAcct.Parent_ID = cmbRoot.SelectedValue.ToString();
                }
                db.ChartOfAccounts.InsertOnSubmit(newAcct);
                db.SubmitChanges();
                MessageBox.Show("Account have sucssfully Saved", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool validateInputs()
        {
            if (txtAcctName.Text == "")
            {
                MessageBox.Show("Please Enter Account Name");
                txtAcctName.Focus();
                return false;
            }
            else if (txtAcctID.Text == "")
            {
                MessageBox.Show("Please Enter Account ID");
                txtAcctID.Focus();
                return false;
            }
            else if (IsRoot && cmbRoot.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a valid Root Account");
                cmbRoot.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
