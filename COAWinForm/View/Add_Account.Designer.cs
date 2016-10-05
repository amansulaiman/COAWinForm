namespace COAWinForm.View
{
    partial class Add_Account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAcctName = new System.Windows.Forms.TextBox();
            this.txtAcctID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRoot = new System.Windows.Forms.ComboBox();
            this.chartOfAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOA_DataSets = new COAWinForm.Model.COA_DataSets();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chartOfAccountsTableAdapter = new COAWinForm.Model.COA_DataSetsTableAdapters.ChartOfAccountsTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartOfAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOA_DataSets)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Name *";
            // 
            // txtAcctName
            // 
            this.txtAcctName.Location = new System.Drawing.Point(16, 28);
            this.txtAcctName.Name = "txtAcctName";
            this.txtAcctName.Size = new System.Drawing.Size(250, 25);
            this.txtAcctName.TabIndex = 1;
            // 
            // txtAcctID
            // 
            this.txtAcctID.Location = new System.Drawing.Point(16, 84);
            this.txtAcctID.Name = "txtAcctID";
            this.txtAcctID.Size = new System.Drawing.Size(254, 25);
            this.txtAcctID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account ID *";
            // 
            // cmbRoot
            // 
            this.cmbRoot.DataSource = this.chartOfAccountsBindingSource;
            this.cmbRoot.DisplayMember = "Acct_Name";
            this.cmbRoot.FormattingEnabled = true;
            this.cmbRoot.Location = new System.Drawing.Point(16, 143);
            this.cmbRoot.Name = "cmbRoot";
            this.cmbRoot.Size = new System.Drawing.Size(254, 28);
            this.cmbRoot.TabIndex = 5;
            this.cmbRoot.ValueMember = "Acct_ID";
            // 
            // chartOfAccountsBindingSource
            // 
            this.chartOfAccountsBindingSource.DataMember = "ChartOfAccounts";
            this.chartOfAccountsBindingSource.DataSource = this.cOA_DataSets;
            // 
            // cOA_DataSets
            // 
            this.cOA_DataSets.DataSetName = "COA_DataSets";
            this.cOA_DataSets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(143, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chartOfAccountsTableAdapter
            // 
            this.chartOfAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(16, 116);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 24);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Root Account";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Add_Account
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(281, 219);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbRoot);
            this.Controls.Add(this.txtAcctID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAcctName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Account";
            this.Text = "Add Account";
            this.Load += new System.EventHandler(this.Add_Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartOfAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOA_DataSets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtAcctName;
        public System.Windows.Forms.TextBox txtAcctID;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbRoot;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public Model.COA_DataSets cOA_DataSets;
        public System.Windows.Forms.BindingSource chartOfAccountsBindingSource;
        public Model.COA_DataSetsTableAdapters.ChartOfAccountsTableAdapter chartOfAccountsTableAdapter;
        public System.Windows.Forms.CheckBox checkBox1;
    }
}