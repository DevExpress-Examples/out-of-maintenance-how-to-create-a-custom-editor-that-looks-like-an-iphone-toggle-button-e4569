Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.WinForms.Samples.IPhoneCheckEdit
	<System.ComponentModel.DesignerCategory(""), UserRepositoryItem("RegisterIPhoneCheckEdit")> _
	Public Class RepositoryItemIPhoneCheckEdit
		Inherits RepositoryItemCheckEdit
		Private backgroundSkinUncheckedImageIndex_Renamed As Integer = 2
		Private backgroundSkinCheckedImageIndex_Renamed As Integer = 1
		Private buttonSkinImageIndex_Renamed As Integer = 0
		Private infoTextChecked_Renamed As String = "ON"
		Private infoTextUnchecked_Renamed As String = "OFF"

		Public Const CustomEditName As String = "IPhoneCheckEdit"
		Public Shadows ReadOnly Property Properties() As RepositoryItemIPhoneCheckEdit
			Get
				Return Me
			End Get
		End Property
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return CustomEditName
			End Get
		End Property
		Public Shadows ReadOnly Property OwnerEdit() As IPhoneCheckEdit
			Get
				Return TryCast(MyBase.OwnerEdit, IPhoneCheckEdit)
			End Get
		End Property

		Private privateAppearanceChecked As AppearanceObject
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content), RefreshProperties(RefreshProperties.All)> _
		Public Property AppearanceChecked() As AppearanceObject
			Get
				Return privateAppearanceChecked
			End Get
			Private Set(ByVal value As AppearanceObject)
				privateAppearanceChecked = value
			End Set
		End Property
		<Browsable(False)> _
		Public ReadOnly Property BackgroundSkinUncheckedImageIndex() As Integer
			Get
				Return backgroundSkinUncheckedImageIndex_Renamed
			End Get
		End Property
		<Browsable(False)> _
		Public ReadOnly Property BackgroundSkinCheckedImageIndex() As Integer
			Get
				Return backgroundSkinCheckedImageIndex_Renamed
			End Get
		End Property
		<Browsable(False)> _
		Public ReadOnly Property ButtonSkinImageIndex() As Integer
			Get
				Return buttonSkinImageIndex_Renamed
			End Get
		End Property
		<Browsable(False)> _
		Public ReadOnly Property InfoTextUnchecked() As String
			Get
				Return infoTextUnchecked_Renamed
			End Get
		End Property
		<Browsable(False)> _
		Public ReadOnly Property InfoTextChecked() As String
			Get
				Return infoTextChecked_Renamed
			End Get
		End Property

		Public Sub New()
			MyBase.New()
			AppearanceChecked = New AppearanceObject(AppearanceDefault.Empty)
		End Sub

		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			BeginUpdate()
			Try
				MyBase.Assign(item)
				Dim source As RepositoryItemIPhoneCheckEdit = TryCast(item, RepositoryItemIPhoneCheckEdit)
				If source Is Nothing Then
					Return
				End If
				Me.AppearanceChecked.Assign(source.AppearanceChecked)
			Finally
				EndUpdate()
			End Try
		End Sub

		Shared Sub New()
			RegisterIPhoneCheckEdit()
		End Sub
		Public Shared Sub RegisterIPhoneCheckEdit()
			Dim img As Image = Nothing
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomEditName, GetType(IPhoneCheckEdit), GetType(RepositoryItemIPhoneCheckEdit), GetType(IPhoneCheckEditViewInfo), New IPhoneCheckEditPainter(), True, img))
		End Sub
	End Class
End Namespace