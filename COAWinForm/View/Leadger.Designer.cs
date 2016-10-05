namespace COAWinForm.View
{
    partial class Leader
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cOA_DataSets = new COAWinForm.Model.COA_DataSets();
            this.leadgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leadgerTableAdapter = new COAWinForm.Model.COA_DataSetsTableAdapters.LeadgerTableAdapter();
            this.tranIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tranDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.describtionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOA_DataSets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadgerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(946, 484);
            this.splitContainer1.SplitterDistance = 61;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tranIDDataGridViewTextBoxColumn,
            this.tranDateDataGridViewTextBoxColumn,
            this.sourceIDDataGridViewTextBoxColumn,
            this.sourceNameDataGridViewTextBoxColumn,
            this.describtionDataGridViewTextBoxColumn,
            this.destinationIDDataGridViewTextBoxColumn,
            this.destinationNameDataGridViewTextBoxColumn,
            this.drDataGridViewTextBoxColumn,
            this.crDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.leadgerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(946, 417);
            this.dataGridView1.TabIndex = 0;
            // 
            // cOA_DataSets
            // 
            this.cOA_DataSets.DataSetName = "COA_DataSets";
            this.cOA_DataSets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leadgerBindingSource
            // 
            this.leadgerBindingSource.DataMember = "Leadger";
            this.leadgerBindingSource.DataSource = this.cOA_DataSets;
            // 
            // leadgerTableAdapter
            // 
            this.leadgerTableAdapter.ClearBeforeFill = true;
            // 
            // tranIDDataGridViewTextBoxColumn
            // 
            this.tranIDDataGridViewTextBoxColumn.DataPropertyName = "Tran_ID";
            this.tranIDDataGridViewTextBoxColumn.HeaderText = "Tran_ID";
            this.tranIDDataGridViewTextBoxColumn.Name = "tranIDDataGridViewTextBoxColumn";
            this.tranIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tranDateDataGridViewTextBoxColumn
            // 
            this.tranDateDataGridViewTextBoxColumn.DataPropertyName = "Tran_Date";
            this.tranDateDataGridViewTextBoxColumn.HeaderText = "Tran_Date";
            this.tranDateDataGridViewTextBoxColumn.Name = "tranDateDataGridViewTextBoxColumn";
            // 
            // sourceIDDataGridViewTextBoxColumn
            // 
            this.sourceIDDataGridViewTextBoxColumn.DataPropertyName = "Source_ID";
            this.sourceIDDataGridViewTextBoxColumn.HeaderText = "Source_ID";
            this.sourceIDDataGridViewTextBoxColumn.Name = "sourceIDDataGridViewTextBoxColumn";
            // 
            // sourceNameDataGridViewTextBoxColumn
            // 
            this.sourceNameDataGridViewTextBoxColumn.DataPropertyName = "Source_Name";
            this.sourceNameDataGridViewTextBoxColumn.HeaderText = "Source_Name";
            this.sourceNameDataGridViewTextBoxColumn.Name = "sourceNameDataGridViewTextBoxColumn";
            // 
            // describtionDataGridViewTextBoxColumn
            // 
            this.describtionDataGridViewTextBoxColumn.DataPropertyName = "Describtion";
            this.describtionDataGridViewTextBoxColumn.HeaderText = "Describtion";
            this.describtionDataGridViewTextBoxColumn.Name = "describtionDataGridViewTextBoxColumn";
            // 
            // destinationIDDataGridViewTextBoxColumn
            // 
            this.destinationIDDataGridViewTextBoxColumn.DataPropertyName = "Destination_ID";
            this.destinationIDDataGridViewTextBoxColumn.HeaderText = "Destination_ID";
            this.destinationIDDataGridViewTextBoxColumn.Name = "destinationIDDataGridViewTextBoxColumn";
            // 
            // destinationNameDataGridViewTextBoxColumn
            // 
            this.destinationNameDataGridViewTextBoxColumn.DataPropertyName = "Destination_Name";
            this.destinationNameDataGridViewTextBoxColumn.HeaderText = "Destination_Name";
            this.destinationNameDataGridViewTextBoxColumn.Name = "destinationNameDataGridViewTextBoxColumn";
            // 
            // drDataGridViewTextBoxColumn
            // 
            this.drDataGridViewTextBoxColumn.DataPropertyName = "Dr";
            this.drDataGridViewTextBoxColumn.HeaderText = "Dr";
            this.drDataGridViewTextBoxColumn.Name = "drDataGridViewTextBoxColumn";
            // 
            // crDataGridViewTextBoxColumn
            // 
            this.crDataGridViewTextBoxColumn.DataPropertyName = "Cr";
            this.crDataGridViewTextBoxColumn.HeaderText = "Cr";
            this.crDataGridViewTextBoxColumn.Name = "crDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // Leadger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 484);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Leadger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leadger";
            this.Load += new System.EventHandler(this.Leadger_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOA_DataSets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadgerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Model.COA_DataSets cOA_DataSets;
        private System.Windows.Forms.BindingSource leadgerBindingSource;
        private Model.COA_DataSetsTableAdapters.LeadgerTableAdapter leadgerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tranIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tranDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn describtionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
    }
}