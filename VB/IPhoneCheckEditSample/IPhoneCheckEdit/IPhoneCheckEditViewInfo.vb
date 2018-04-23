Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo

Namespace DevExpress.WinForms.Samples.IPhoneCheckEdit
	Public Class IPhoneCheckEditViewInfo
		Inherits CheckEditViewInfo
		Private infoText_Renamed As String
		Private backgroundImageIndex_Renamed As Integer
		Private buttonImageIndex_Renamed As Integer
		Private backgroundRect_Renamed As Rectangle
		Private buttonRect_Renamed As Rectangle
		Private infoTextLocation_Renamed As Point

		Public ReadOnly Property InfoText() As String
			Get
				Return infoText_Renamed
			End Get
		End Property
		Public ReadOnly Property InfoTextLocation() As Point
			Get
				Return infoTextLocation_Renamed
			End Get
		End Property
		Public Shadows ReadOnly Property Item() As RepositoryItemIPhoneCheckEdit
			Get
				Return TryCast(MyBase.Item, RepositoryItemIPhoneCheckEdit)
			End Get
		End Property
		Public ReadOnly Property BackgroundRect() As Rectangle
			Get
				Return backgroundRect_Renamed
			End Get
		End Property
		Public ReadOnly Property ButtonRect() As Rectangle
			Get
				Return buttonRect_Renamed
			End Get
		End Property
		Public ReadOnly Property BackgroundImageIndex() As Integer
			Get
				Return backgroundImageIndex_Renamed
			End Get
		End Property
		Public ReadOnly Property ButtonImageIndex() As Integer
			Get
				Return buttonImageIndex_Renamed
			End Get
		End Property

		Public Sub New(ByVal item As RepositoryItem)
			MyBase.New(item)
		End Sub

		Public Overrides Property AllowDrawFocusRect() As Boolean
			Get
				Return False
			End Get
			Set(ByVal value As Boolean)
				MyBase.AllowDrawFocusRect = False
			End Set
		End Property
		Public Overrides Overloads Sub Offset(ByVal x As Integer, ByVal y As Integer)
			MyBase.Offset(x, y)
			OffsetContentLocation(x, y)
		End Sub
		Public Overrides Sub UpdatePaintAppearance()
			If CheckState = System.Windows.Forms.CheckState.Checked Then
				PaintAppearance.Assign(Item.AppearanceChecked)
				Return
			End If
			MyBase.UpdatePaintAppearance()
		End Sub
		Protected Overrides Sub Assign(ByVal info As BaseControlViewInfo)
			MyBase.Assign(info)
			Dim view As IPhoneCheckEditViewInfo = (TryCast(info, IPhoneCheckEditViewInfo))
			If view Is Nothing Then
				Return
			End If
			Me.infoText_Renamed = view.infoText
			Me.buttonImageIndex_Renamed = view.backgroundImageIndex
			Me.buttonImageIndex_Renamed = view.buttonImageIndex
			Me.backgroundRect_Renamed = view.backgroundRect
			Me.buttonRect_Renamed = view.buttonRect
			Me.infoTextLocation_Renamed = view.infoTextLocation
		End Sub
		Protected Overrides Sub CalcContentRect(ByVal bounds As Rectangle)
			MyBase.CalcContentRect(bounds)
			CalcBackgroundRectSize()
			CalcButtonRectSize()
			UpdateButtonLocationByState()
			UpdateInfoTextLocationByState()
		End Sub
		Protected Overrides Sub OnEditValueChanged()
			MyBase.OnEditValueChanged()
			UpdateBackgroundSkinImageIndexByState()
			UpdateButtonSkinImageIndexByState()
			UpdateButtonLocationByState()
			UpdateInfoTextByState()
			UpdateInfoTextLocationByState()
		End Sub

		Private Sub CalcBackgroundRectSize()
			Me.backgroundRect_Renamed.Size = ContentRect.Size
		End Sub
		Private Sub CalcButtonRectSize()
			Me.buttonRect_Renamed.Size = New Size(ContentRect.Width \ 2, ContentRect.Height)
		End Sub
		Private Sub OffsetContentLocation(ByVal x As Integer, ByVal y As Integer)
			Me.backgroundRect_Renamed.Offset(x, y)
			Me.buttonRect_Renamed.Offset(x, y)
			Me.infoTextLocation_Renamed.Offset(x, y)
		End Sub
		Private Sub UpdateBackgroundSkinImageIndexByState()
			Me.backgroundImageIndex_Renamed = If((CheckState = CheckState.Checked), Item.BackgroundSkinCheckedImageIndex, Item.BackgroundSkinUncheckedImageIndex)
		End Sub
		Private Sub UpdateButtonSkinImageIndexByState()
			Me.buttonImageIndex_Renamed = Item.ButtonSkinImageIndex
		End Sub
		Private Sub UpdateButtonLocationByState()
			Me.buttonRect_Renamed.Y = ContentRect.Top
			Me.buttonRect_Renamed.X = If((CheckState = CheckState.Checked), (ContentRect.Right - Me.buttonRect_Renamed.Width), ContentRect.Left)
		End Sub
		Private Sub UpdateInfoTextByState()
			Me.infoText_Renamed = If((CheckState = CheckState.Checked), Item.InfoTextChecked, Item.InfoTextUnchecked)
		End Sub
		Private Sub UpdateInfoTextLocationByState()
            Me.infoTextLocation_Renamed.Y = ContentRect.Top + CType((ContentRect.Height / 2), Integer)
            If CheckState = CheckState.Checked Then
                Me.infoTextLocation_Renamed.X = ContentRect.Left + CType((Me.buttonRect_Renamed.Left / 2), Integer)
            Else
                Me.infoTextLocation_Renamed.X = ContentRect.Right - CType(((ContentRect.Right - Me.buttonRect_Renamed.Right) / 2), Integer)
            End If
        End Sub
	End Class
End Namespace
