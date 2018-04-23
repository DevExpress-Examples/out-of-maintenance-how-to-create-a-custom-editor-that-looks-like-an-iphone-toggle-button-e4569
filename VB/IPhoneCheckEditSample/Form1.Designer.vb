Imports Microsoft.VisualBasic
Imports System
Namespace IPhoneCheckEditSample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.iPhoneCheckEdit1 = New DevExpress.WinForms.Samples.IPhoneCheckEdit.IPhoneCheckEdit()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.repositoryItemIPhoneCheckEdit1 = New DevExpress.WinForms.Samples.IPhoneCheckEdit.RepositoryItemIPhoneCheckEdit()
			Me.iPhoneCheckEdit2 = New DevExpress.WinForms.Samples.IPhoneCheckEdit.IPhoneCheckEdit()
			Me.iPhoneCheckEdit3 = New DevExpress.WinForms.Samples.IPhoneCheckEdit.IPhoneCheckEdit()
			Me.iPhoneCheckEdit4 = New DevExpress.WinForms.Samples.IPhoneCheckEdit.IPhoneCheckEdit()
			Me.iPhoneCheckEdit5 = New DevExpress.WinForms.Samples.IPhoneCheckEdit.IPhoneCheckEdit()
			Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.iPhoneCheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemIPhoneCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.iPhoneCheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.iPhoneCheckEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.iPhoneCheckEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.iPhoneCheckEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Foggy"
			' 
			' iPhoneCheckEdit1
			' 
			Me.iPhoneCheckEdit1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.iPhoneCheckEdit1.Location = New System.Drawing.Point(516, 12)
			Me.iPhoneCheckEdit1.Name = "iPhoneCheckEdit1"
			Me.iPhoneCheckEdit1.Properties.Caption = "iPhoneCheckEdit1"
			Me.iPhoneCheckEdit1.Size = New System.Drawing.Size(75, 15)
			Me.iPhoneCheckEdit1.TabIndex = 0
			' 
			' gridControl1
			' 
			Me.gridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gridControl1.Location = New System.Drawing.Point(12, 12)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemIPhoneCheckEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(418, 527)
			Me.gridControl1.TabIndex = 1
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' repositoryItemIPhoneCheckEdit1
			' 
			Me.repositoryItemIPhoneCheckEdit1.AutoHeight = False
			Me.repositoryItemIPhoneCheckEdit1.Name = "repositoryItemIPhoneCheckEdit1"
			' 
			' iPhoneCheckEdit2
			' 
			Me.iPhoneCheckEdit2.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.iPhoneCheckEdit2.EditValue = True
			Me.iPhoneCheckEdit2.Location = New System.Drawing.Point(436, 96)
			Me.iPhoneCheckEdit2.Name = "iPhoneCheckEdit2"
			Me.iPhoneCheckEdit2.Properties.Appearance.Font = New System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold)
			Me.iPhoneCheckEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Red
			Me.iPhoneCheckEdit2.Properties.Appearance.Options.UseFont = True
			Me.iPhoneCheckEdit2.Properties.Appearance.Options.UseForeColor = True
			Me.iPhoneCheckEdit2.Properties.AppearanceChecked.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.iPhoneCheckEdit2.Properties.AppearanceChecked.ForeColor = System.Drawing.Color.Blue
			Me.iPhoneCheckEdit2.Properties.AppearanceChecked.Options.UseFont = True
			Me.iPhoneCheckEdit2.Properties.AppearanceChecked.Options.UseForeColor = True
			Me.iPhoneCheckEdit2.Properties.AutoHeight = False
			Me.iPhoneCheckEdit2.Properties.Caption = "iPhoneCheckEdit2"
			Me.iPhoneCheckEdit2.Size = New System.Drawing.Size(155, 46)
			Me.iPhoneCheckEdit2.TabIndex = 2
			' 
			' iPhoneCheckEdit3
			' 
			Me.iPhoneCheckEdit3.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.iPhoneCheckEdit3.Location = New System.Drawing.Point(516, 75)
			Me.iPhoneCheckEdit3.Name = "iPhoneCheckEdit3"
			Me.iPhoneCheckEdit3.Properties.Caption = "iPhoneCheckEdit3"
			Me.iPhoneCheckEdit3.Size = New System.Drawing.Size(75, 15)
			Me.iPhoneCheckEdit3.TabIndex = 3
			' 
			' iPhoneCheckEdit4
			' 
			Me.iPhoneCheckEdit4.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.iPhoneCheckEdit4.EditValue = True
			Me.iPhoneCheckEdit4.Location = New System.Drawing.Point(516, 54)
			Me.iPhoneCheckEdit4.Name = "iPhoneCheckEdit4"
			Me.iPhoneCheckEdit4.Properties.Caption = "iPhoneCheckEdit4"
			Me.iPhoneCheckEdit4.Size = New System.Drawing.Size(75, 15)
			Me.iPhoneCheckEdit4.TabIndex = 4
			' 
			' iPhoneCheckEdit5
			' 
			Me.iPhoneCheckEdit5.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.iPhoneCheckEdit5.EditValue = True
			Me.iPhoneCheckEdit5.Location = New System.Drawing.Point(516, 33)
			Me.iPhoneCheckEdit5.Name = "iPhoneCheckEdit5"
			Me.iPhoneCheckEdit5.Properties.Caption = "iPhoneCheckEdit5"
			Me.iPhoneCheckEdit5.Size = New System.Drawing.Size(75, 15)
			Me.iPhoneCheckEdit5.TabIndex = 5
			' 
			' listBoxControl1
			' 
			Me.listBoxControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.listBoxControl1.Location = New System.Drawing.Point(436, 174)
			Me.listBoxControl1.Name = "listBoxControl1"
			Me.listBoxControl1.Size = New System.Drawing.Size(155, 365)
			Me.listBoxControl1.TabIndex = 6
'			Me.listBoxControl1.SelectedIndexChanged += New System.EventHandler(Me.listBoxControl1_SelectedIndexChanged);
			' 
			' labelControl1
			' 
			Me.labelControl1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10F)
			Me.labelControl1.Location = New System.Drawing.Point(436, 152)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(65, 16)
			Me.labelControl1.TabIndex = 7
			Me.labelControl1.Text = "Active skin:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(603, 551)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.listBoxControl1)
			Me.Controls.Add(Me.iPhoneCheckEdit5)
			Me.Controls.Add(Me.iPhoneCheckEdit4)
			Me.Controls.Add(Me.iPhoneCheckEdit3)
			Me.Controls.Add(Me.iPhoneCheckEdit2)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.iPhoneCheckEdit1)
			Me.LookAndFeel.SkinName = "DevExpress Dark Style"
			Me.Name = "Form1"
			Me.Text = "Sample : IPhoneCheckEdit"
			CType(Me.iPhoneCheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemIPhoneCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.iPhoneCheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.iPhoneCheckEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.iPhoneCheckEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.iPhoneCheckEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private iPhoneCheckEdit1 As DevExpress.WinForms.Samples.IPhoneCheckEdit.IPhoneCheckEdit
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private repositoryItemIPhoneCheckEdit1 As DevExpress.WinForms.Samples.IPhoneCheckEdit.RepositoryItemIPhoneCheckEdit
		Private iPhoneCheckEdit2 As DevExpress.WinForms.Samples.IPhoneCheckEdit.IPhoneCheckEdit
		Private iPhoneCheckEdit3 As DevExpress.WinForms.Samples.IPhoneCheckEdit.IPhoneCheckEdit
		Private iPhoneCheckEdit4 As DevExpress.WinForms.Samples.IPhoneCheckEdit.IPhoneCheckEdit
		Private iPhoneCheckEdit5 As DevExpress.WinForms.Samples.IPhoneCheckEdit.IPhoneCheckEdit
		Private WithEvents listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl


	End Class
End Namespace
