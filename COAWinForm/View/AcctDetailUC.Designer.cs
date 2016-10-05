namespace COAWinForm.View
{
    partial class AcctDetailUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.acctName = new System.Windows.Forms.GroupBox();
            this.balValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.addChildBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.creditBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tranDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.describtionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leadgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOA_DataSets = new COAWinForm.Model.COA_DataSets();
            this.leadgerTableAdapter = new COAWinForm.Model.COA_DataSetsTableAdapters.LeadgerTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.acctName.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadgerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOA_DataSets)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.acctName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.81971F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.1174F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 477);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // acctName
            // 
            this.acctName.Controls.Add(this.balValue);
            this.acctName.Controls.Add(this.label1);
            this.acctName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acctName.Location = new System.Drawing.Point(3, 3);
            this.acctName.Name = "acctName";
            this.acctName.Size = new System.Drawing.Size(346, 79);
            this.acctName.TabIndex = 0;
            this.acctName.TabStop = false;
            this.acctName.Text = "groupBox1";
            this.acctName.Enter += new System.EventHandler(this.acctName_Enter);
            // 
            // balValue
            // 
            this.balValue.AutoEllipsis = true;
            this.balValue.Location = new System.Drawing.Point(149, 44);
            this.balValue.Name = "balValue";
            this.balValue.Size = new System.Drawing.Size(191, 22);
            this.balValue.TabIndex = 1;
            this.balValue.Text = "0";
            this.balValue.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.addChildBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.deleteBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.creditBtn, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 432);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(346, 42);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // addChildBtn
            // 
            this.addChildBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addChildBtn.Location = new System.Drawing.Point(3, 3);
            this.addChildBtn.Name = "addChildBtn";
            this.addChildBtn.Size = new System.Drawing.Size(109, 36);
            this.addChildBtn.TabIndex = 0;
            this.addChildBtn.Text = "Add Child";
            this.addChildBtn.UseVisualStyleBackColor = true;
            this.addChildBtn.Click += new System.EventHandler(this.addChildBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteBtn.Location = new System.Drawing.Point(118, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(109, 36);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // creditBtn
            // 
            this.creditBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creditBtn.Location = new System.Drawing.Point(233, 3);
            this.creditBtn.Name = "creditBtn";
            this.creditBtn.Size = new System.Drawing.Size(110, 36);
            this.creditBtn.TabIndex = 2;
            this.creditBtn.Text = "Credit";
            this.creditBtn.UseVisualStyleBackColor = true;
            this.creditBtn.Click += new System.EventHandler(this.creditBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tranDateDataGridViewTextBoxColumn,
            this.sourceNameDataGridViewTextBoxColumn,
            this.describtionDataGridViewTextBoxColumn,
            this.destinationNameDataGridViewTextBoxColumn,
            this.drDataGridViewTextBoxColumn,
            this.crDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.leadgerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(346, 338);
            this.dataGridView1.TabIndex = 2;
            // 
            // tranDateDataGridViewTextBoxColumn
            // 
            this.tranDateDataGridViewTextBoxColumn.DataPropertyName = "Tran_Date";
            this.tranDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.tranDateDataGridViewTextBoxColumn.Name = "tranDateDataGridViewTextBoxColumn";
            this.tranDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sourceNameDataGridViewTextBoxColumn
            // 
            this.sourceNameDataGridViewTextBoxColumn.DataPropertyName = "Source_Name";
            this.sourceNameDataGridViewTextBoxColumn.HeaderText = "Source";
            this.sourceNameDataGridViewTextBoxColumn.Name = "sourceNameDataGridViewTextBoxColumn";
            this.sourceNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // describtionDataGridViewTextBoxColumn
            // 
            this.describtionDataGridViewTextBoxColumn.DataPropertyName = "Describtion";
            this.describtionDataGridViewTextBoxColumn.HeaderText = "Describtion";
            this.describtionDataGridViewTextBoxColumn.Name = "describtionDataGridViewTextBoxColumn";
            this.describtionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinationNameDataGridViewTextBoxColumn
            // 
            this.destinationNameDataGridViewTextBoxColumn.DataPropertyName = "Destination_Name";
            this.destinationNameDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationNameDataGridViewTextBoxColumn.Name = "destinationNameDataGridViewTextBoxColumn";
            this.destinationNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drDataGridViewTextBoxColumn
            // 
            this.drDataGridViewTextBoxColumn.DataPropertyName = "Dr";
            this.drDataGridViewTextBoxColumn.HeaderText = "Dr";
            this.drDataGridViewTextBoxColumn.Name = "drDataGridViewTextBoxColumn";
            this.drDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // crDataGridViewTextBoxColumn
            // 
            this.crDataGridViewTextBoxColumn.DataPropertyName = "Cr";
            this.crDataGridViewTextBoxColumn.HeaderText = "Cr";
            this.crDataGridViewTextBoxColumn.Name = "crDataGridViewTextBoxColumn";
            this.crDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leadgerBindingSource
            // 
            this.leadgerBindingSource.DataMember = "Leadger";
            this.leadgerBindingSource.DataSource = this.cOA_DataSets;
            // 
            // cOA_DataSets
            // 
            this.cOA_DataSets.DataSetName = "COA_DataSets";
            this.cOA_DataSets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leadgerTableAdapter
            // 
            this.leadgerTableAdapter.ClearBeforeFill = true;
            // 
            // AcctDetailUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AcctDetailUC";
            this.Size = new System.Drawing.Size(352, 477);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.acctName.ResumeLayout(false);
            this.acctName.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadgerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOA_DataSets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.GroupBox acctName;
        public System.Windows.Forms.Label balValue;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Button addChildBtn;
        public System.Windows.Forms.Button deleteBtn;
        public System.Windows.Forms.Button creditBtn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tranDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn describtionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource leadgerBindingSource;
        private Model.COA_DataSets cOA_DataSets;
        private Model.COA_DataSetsTableAdapters.LeadgerTableAdapter leadgerTableAdapter;
    }
}
