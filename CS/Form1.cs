using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Nodes.Operations;
using DevExpress.XtraTreeList.Columns;


namespace WindowsApplication385
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DevExpress.XtraTreeList.TreeList treeList1;
		private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
		private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            false,
            "1"}, -1);
            this.treeList1.AppendNode(new object[] {
            false,
            "2"}, -1);
            this.treeList1.AppendNode(new object[] {
            false,
            "21"}, 1);
            this.treeList1.AppendNode(new object[] {
            false,
            "211"}, 2);
            this.treeList1.AppendNode(new object[] {
            false,
            "212"}, 2);
            this.treeList1.AppendNode(new object[] {
            false,
            "213"}, 2);
            this.treeList1.AppendNode(new object[] {
            false,
            "214"}, 2);
            this.treeList1.AppendNode(new object[] {
            false,
            "22"}, 1);
            this.treeList1.AppendNode(new object[] {
            false,
            "23"}, 1);
            this.treeList1.AppendNode(new object[] {
            false,
            "24"}, 1);
            this.treeList1.AppendNode(new object[] {
            false,
            "3"}, -1);
            this.treeList1.AppendNode(new object[] {
            false,
            "4"}, -1);
            this.treeList1.AppendNode(new object[] {
            false,
            "5"}, -1);
            this.treeList1.AppendNode(new object[] {
            false,
            "6"}, -1);
            this.treeList1.AppendNode(new object[] {
            false,
            "7"}, -1);
            this.treeList1.AppendNode(new object[] {
            false,
            "8"}, -1);
            this.treeList1.AppendNode(new object[] {
            false,
            "9"}, -1);
            this.treeList1.AppendNode(new object[] {
            false,
            "10"}, -1);
            this.treeList1.EndUnboundLoad();
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.treeList1.Size = new System.Drawing.Size(592, 400);
            this.treeList1.TabIndex = 0;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Column1";
            this.treeListColumn1.ColumnEdit = this.repositoryItemCheckEdit1;
            this.treeListColumn1.FieldName = "treeListColumn1";
            this.treeListColumn1.MinWidth = 56;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.CheckedChanged += new System.EventHandler(this.repositoryItemCheckEdit1_CheckedChanged);
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Column2";
            this.treeListColumn2.FieldName = "treeListColumn2";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(592, 527);
            this.Controls.Add(this.treeList1);
            this.Name = "Form1";
            this.Text = "How to change the field value of all child nodes of a certain node";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		public class TreeListChangeChildNodesOperation : TreeListOperation 
		{
			private TreeListColumn column;
			private bool state;
			private TreeListNode parentNode;
			public TreeListChangeChildNodesOperation(TreeListColumn column, TreeListNode node, bool state) 
			{ 
				this.column = column;
				this.state = state;
				this.parentNode = node;
			}

			public override void Execute(TreeListNode node) 
			{
				if (node.HasAsParent(parentNode))
					node.SetValue(column, state);
				else
					if (parentNode.HasAsParent(node))
						if (state)
							node[column] = state;
						else
							node[column] = null;
			}				

			public override bool NeedsVisitChildren(TreeListNode node) { return true; }
		}

		private void repositoryItemCheckEdit1_CheckedChanged(object sender, System.EventArgs e)
		{
			treeList1.PostEditor();
			TreeListNode node = treeList1.FocusedNode;
			TreeListChangeChildNodesOperation op = new TreeListChangeChildNodesOperation(treeListColumn1, node, (sender as DevExpress.XtraEditors.CheckEdit).Checked);
			treeList1.NodesIterator.DoOperation(op);			
		}
	}
}
