namespace COAWinForm
{
    partial class AccountsTree
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
            this.accountsTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // accountsTreeView
            // 
            this.accountsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountsTreeView.Location = new System.Drawing.Point(0, 0);
            this.accountsTreeView.Name = "accountsTreeView";
            this.accountsTreeView.Size = new System.Drawing.Size(219, 361);
            this.accountsTreeView.TabIndex = 0;
            // 
            // AccountsTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.accountsTreeView);
            this.Name = "AccountsTree";
            this.Size = new System.Drawing.Size(219, 361);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView accountsTreeView;
    }
}
