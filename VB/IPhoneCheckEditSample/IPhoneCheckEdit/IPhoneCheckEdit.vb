Imports System.ComponentModel
Imports DevExpress.XtraEditors

Namespace DevExpress.WinForms.Samples.IPhoneCheckEdit
	<System.ComponentModel.DesignerCategory("")> _
	Public Class IPhoneCheckEdit
		Inherits CheckEdit
		Protected Friend Shadows ReadOnly Property ViewInfo() As IPhoneCheckEditViewInfo
			Get
				Return TryCast(MyBase.ViewInfo, IPhoneCheckEditViewInfo)
			End Get
		End Property

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemIPhoneCheckEdit.CustomEditName
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemIPhoneCheckEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemIPhoneCheckEdit)
			End Get
		End Property

		Shared Sub New()
			RepositoryItemIPhoneCheckEdit.RegisterIPhoneCheckEdit()
		End Sub
	End Class
End Namespace
