Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList.Nodes.Operations
Imports DevExpress.XtraTreeList.Columns


Namespace WindowsApplication385
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private treeList1 As DevExpress.XtraTreeList.TreeList
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private WithEvents repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1, Me.treeListColumn2})
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Top
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.BeginUnboundLoad()
			Me.treeList1.AppendNode(New Object() { False, "1"}, -1)
			Me.treeList1.AppendNode(New Object() { False, "2"}, -1)
			Me.treeList1.AppendNode(New Object() { False, "21"}, 1)
			Me.treeList1.AppendNode(New Object() { False, "211"}, 2)
			Me.treeList1.AppendNode(New Object() { False, "212"}, 2)
			Me.treeList1.AppendNode(New Object() { False, "213"}, 2)
			Me.treeList1.AppendNode(New Object() { False, "214"}, 2)
			Me.treeList1.AppendNode(New Object() { False, "22"}, 1)
			Me.treeList1.AppendNode(New Object() { False, "23"}, 1)
			Me.treeList1.AppendNode(New Object() { False, "24"}, 1)
			Me.treeList1.AppendNode(New Object() { False, "3"}, -1)
			Me.treeList1.AppendNode(New Object() { False, "4"}, -1)
			Me.treeList1.AppendNode(New Object() { False, "5"}, -1)
			Me.treeList1.AppendNode(New Object() { False, "6"}, -1)
			Me.treeList1.AppendNode(New Object() { False, "7"}, -1)
			Me.treeList1.AppendNode(New Object() { False, "8"}, -1)
			Me.treeList1.AppendNode(New Object() { False, "9"}, -1)
			Me.treeList1.AppendNode(New Object() { False, "10"}, -1)
			Me.treeList1.EndUnboundLoad()
			Me.treeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemCheckEdit1})
			Me.treeList1.Size = New System.Drawing.Size(592, 400)
			Me.treeList1.TabIndex = 0
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "Column1"
			Me.treeListColumn1.ColumnEdit = Me.repositoryItemCheckEdit1
			Me.treeListColumn1.FieldName = "treeListColumn1"
			Me.treeListColumn1.MinWidth = 56
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 0
			' 
			' repositoryItemCheckEdit1
			' 
			Me.repositoryItemCheckEdit1.AutoHeight = False
			Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
'			Me.repositoryItemCheckEdit1.CheckedChanged += New System.EventHandler(Me.repositoryItemCheckEdit1_CheckedChanged);
			' 
			' treeListColumn2
			' 
			Me.treeListColumn2.Caption = "Column2"
			Me.treeListColumn2.FieldName = "treeListColumn2"
			Me.treeListColumn2.Name = "treeListColumn2"
			Me.treeListColumn2.Visible = True
			Me.treeListColumn2.VisibleIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(592, 527)
			Me.Controls.Add(Me.treeList1)
			Me.Name = "Form1"
			Me.Text = "How to change the field value of all child nodes of a certain node"
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Public Class TreeListChangeChildNodesOperation
			Inherits TreeListOperation
			Private column As TreeListColumn
			Private state As Boolean
			Private parentNode As TreeListNode
			Public Sub New(ByVal column As TreeListColumn, ByVal node As TreeListNode, ByVal state As Boolean)
				Me.column = column
				Me.state = state
				Me.parentNode = node
			End Sub

			Public Overrides Sub Execute(ByVal node As TreeListNode)
				If node.HasAsParent(parentNode) Then
					node.SetValue(column, state)
				Else
					If parentNode.HasAsParent(node) Then
						If state Then
							node(column) = state
						Else
							node(column) = Nothing
						End If
					End If
				End If
			End Sub

			Public Overrides Function NeedsVisitChildren(ByVal node As TreeListNode) As Boolean
				Return True
			End Function
		End Class

		Private Sub repositoryItemCheckEdit1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles repositoryItemCheckEdit1.CheckedChanged
			treeList1.PostEditor()
			Dim node As TreeListNode = treeList1.FocusedNode
			Dim op As New TreeListChangeChildNodesOperation(treeListColumn1, node, (TryCast(sender, DevExpress.XtraEditors.CheckEdit)).Checked)
			treeList1.NodesIterator.DoOperation(op)
		End Sub
	End Class
End Namespace
