using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace COAWinForm
{
    /// <summary>
    /// Summary description for TreeViewBound.
    /// </summary>
    public class TreeViewBound : System.Windows.Forms.TreeView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public TreeViewBound()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitializeComponent call

        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            // 
            // TreeViewBound
            // 
            this.Name = "TreeViewBound";
            this.Size = new System.Drawing.Size(360, 136);

        }
        #endregion

        #region Properties
        private DataTable _datasource;
        [Bindable(true), Category("Data"), DefaultValue((string)null), RefreshProperties(RefreshProperties.Repaint), TypeConverter("System.Windows.Forms.Design.DataSourceConverter, System.Design")]
        public DataTable DataSource
        {
            get
            {   
                return _datasource;
            }
            set
            {
                //If the it's a change of datasource 
                if (this._datasource != null)
                {
                    //unsubscribe events
                    this._datasource.RowDeleting -= new DataRowChangeEventHandler(value_RowDeleting);
                    this._datasource.RowChanged -= new DataRowChangeEventHandler(value_RowChanged);

                }
                if (value == null)
                {
                    Clear();
                    this._datasource = null;
                }
                else
                {
                    //subscribe to datatable events
                    value.RowDeleting += new DataRowChangeEventHandler(value_RowDeleting);
                    value.RowChanged += new DataRowChangeEventHandler(value_RowChanged);


                    this._datasource = value;
                    LoadTree();
                }
            }
        }

        private string _displayMember;
        [Bindable(true)]
        [Category("Data")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")]
        [RefreshProperties(RefreshProperties.All)]
        public string DisplayMember
        {
            get
            {
                return _displayMember;
            }
            set
            {
                if (_displayMember != value)
                {
                    _displayMember = value;
                    LoadTree();
                }
            }
        }

        private string _valueMember;
        [Bindable(true)]
        [Category("Data")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")]
        [RefreshProperties(RefreshProperties.All)]
        public string ValueMember
        {
            get
            {
                return _valueMember;
            }
            set
            {
                if (_valueMember != value)
                {
                    _valueMember = value;
                    LoadTree();
                }
            }
        }

        private string _parentMember;
        [Bindable(true)]
        [Category("Data")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")]
        [RefreshProperties(RefreshProperties.All)]
        public string ParentMember
        {
            get
            {
                return _parentMember;
            }
            set
            {
                if (_parentMember != value)
                {
                    _parentMember = value;
                    LoadTree();
                }
            }
        }

        private object _rootParentValue = DBNull.Value;
        [Browsable(false)]
        public object RootParentValue
        {
            get
            {
                return _rootParentValue;
            }
            set
            {
                _rootParentValue = value;
            }
        }

        [Browsable(false), DefaultValue(null)]
        public object SelectedValue
        {
            get
            {
                if (this.SelectedNode != null)
                {
                    return ((TreeNodeBound)this.SelectedNode).Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (_nodesByValueMember != null && value != null)
                {
                    this.SelectedNode = (TreeNodeBound)_nodesByValueMember[value];
                }
            }
        }
        #endregion

        private Hashtable _nodesByValueMember;

        public void Clear()
        {
            base.Nodes.Clear();
            _nodesByValueMember = new Hashtable();
        }

        #region Load
        private void LoadTree()
        {

            if (this._datasource != null && this._displayMember != null && this._valueMember != null && this._parentMember != null)
            {
                Clear();
                foreach (DataRow dr in this._datasource.Rows)
                {
                    TreeNodeBound node = new TreeNodeBound(dr[this._displayMember].ToString());
                    node.Value = dr[this._valueMember];
                    node.ParentValue = dr[this._parentMember];

                    _nodesByValueMember.Add(node.Value, node);
                }


                foreach (TreeNodeBound node in _nodesByValueMember.Values)
                {
                    if (node.ParentValue == _rootParentValue)
                    {
                        //the node is a Root, add it to the root collection
                        this.Nodes.Add(node);
                    }
                    else
                    {
                        //look for the parent
                        TreeNodeBound parent = (TreeNodeBound)_nodesByValueMember[node.ParentValue];
                        if (parent != null)
                        {
                            //add it to the nodes collection of the parent node
                            parent.Nodes.Add(node);
                        }
                        else
                        {
                            throw new ArgumentException("Node with Value = " + Convert.ToString(node.ParentValue) + " does not exist. The referencing node has a value = " + Convert.ToString(node.Value) + ". Check your datasource integrity.");
                        }
                    }
                }
            }
        }


        #endregion

        #region Row Changed & Row Deleted
        private void value_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (e.Action == DataRowAction.Add)
            {
                if (e.Row[this._valueMember] != DBNull.Value)
                {
                    TreeNodeBound node = new TreeNodeBound(e.Row[this.DisplayMember].ToString());
                    node.Value = e.Row[this._valueMember];
                    node.ParentValue = e.Row[this._parentMember];
                    _nodesByValueMember.Add(node.Value, node);
                    if (node.ParentValue == _rootParentValue)
                    {
                        //Its a root
                        this.Nodes.Add(node);
                    }
                    else if (_nodesByValueMember[node.ParentValue] != null)
                    {
                        //The parent exist
                        TreeNodeBound parent = (TreeNodeBound)_nodesByValueMember[node.ParentValue];
                        if (parent != null)
                        {
                            parent.Nodes.Add(node);
                        }
                        else
                        {
                            throw new ArgumentException("Node with Value = " + Convert.ToString(node.ParentValue) + " does not exist. The referencing node has a value = " + Convert.ToString(node.Value) + ". Check your datasource integrity.");
                        }

                        if (parent.IsVisible)
                        {
                            parent.Expand();
                        }
                    }
                }
            }
            else if (e.Action == DataRowAction.Change)
            {

                TreeNodeBound node = (TreeNodeBound)_nodesByValueMember[e.Row[this._valueMember]];
                object actualParent = e.Row[this._parentMember].ToString();

                //Change parenthood
                if (actualParent.ToString() != node.ParentValue.ToString())
                {
                    if (node.ParentValue != _rootParentValue)
                    {
                        TreeNodeBound oldParent = (TreeNodeBound)_nodesByValueMember[node.ParentValue];
                        if (oldParent != null)
                        {
                            oldParent.Nodes.Remove(node);
                        }
                    }
                    else
                    {
                        //Remove it from the root nodes
                        this.Nodes.Remove(node);
                    }

                    node.ParentValue = e.Row[this._parentMember];

                    if (node.ParentValue != _rootParentValue)
                    {
                        TreeNodeBound newParent = (TreeNodeBound)_nodesByValueMember[node.ParentValue];
                        if (newParent != null) //if exist
                        {

                            newParent.Nodes.Add(node);
                            if (newParent.IsVisible)
                            {
                                newParent.Expand();
                            }
                        }
                    }
                    else
                    {
                        this.Nodes.Add(node);
                    }
                }
                //Change the text
                node.Text = e.Row[this.DisplayMember].ToString();
            }
        }

        private void value_RowDeleting(object sender, DataRowChangeEventArgs e)
        {
            TreeNodeBound node = (TreeNodeBound)_nodesByValueMember[e.Row[this._valueMember]];
            _nodesByValueMember.Remove(node.Value);
            if (node.TreeView != null)
            {
                node.Remove();
            }
        }
        #endregion

    }
}
