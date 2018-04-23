Imports System.ComponentModel
Imports DevExpress.Skins
Imports DevExpress.XtraEditors

Namespace IPhoneCheckEditSample
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			InitGrid()
			InitSkinList()
		End Sub

		Private Sub InitGrid()
			Dim gridContentElements As New BindingList(Of GridContentElement)()
			gridContentElements.Add(New GridContentElement() With {.Caption = "Mail", .Value = True})
			gridContentElements.Add(New GridContentElement() With {.Caption = "Contacts", .Value = False})
			gridContentElements.Add(New GridContentElement() With {.Caption = "Calendars", .Value = False})
			gridContentElements.Add(New GridContentElement() With {.Caption = "Bookmarks", .Value = False})
			gridControl1.DataSource = gridContentElements
			gridView1.Columns("Value").ColumnEdit = repositoryItemIPhoneCheckEdit1
		End Sub
		Private Sub InitSkinList()
			listBoxControl1.DataSource = SkinManager.Default.Skins
			listBoxControl1.DisplayMember = "SkinName"
		End Sub
		Private Sub listBoxControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles listBoxControl1.SelectedIndexChanged
			If (TryCast(sender, ListBoxControl)).SelectedItem Is Nothing Then
				Return
			End If
			defaultLookAndFeel1.LookAndFeel.SkinName = (TryCast((TryCast(sender, ListBoxControl)).SelectedItem, SkinContainer)).SkinName
		End Sub
	End Class

	Friend Class GridContentElement
		Implements INotifyPropertyChanged
		Private caption_Renamed As String
		Private value_Renamed As Boolean

		Public Property Caption() As String
			Get
				Return caption_Renamed
			End Get
			Set(ByVal value As String)
				If caption_Renamed = value Then
					Return
				End If
				Me.caption_Renamed = value
				DoPropertyChanged("Caption")
			End Set
		End Property
		Public Property Value() As Boolean
			Get
				Return value_Renamed
			End Get
			Set(ByVal value As Boolean)
                If Me.value_Renamed = value Then
                    Return
                End If
				Me.value_Renamed = value
				DoPropertyChanged("Value")
			End Set
		End Property
		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Private Sub DoPropertyChanged(ByVal propertyName As String)
			If PropertyChangedEvent Is Nothing Then
				Return
			End If
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub
	End Class
End Namespace