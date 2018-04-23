Imports System.Drawing
Imports DevExpress.Skins
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.Drawing

Namespace DevExpress.WinForms.Samples.IPhoneCheckEdit
	Public Class IPhoneCheckEditPainter
		Inherits CheckEditPainter
		Protected Overrides Sub DrawCheck(ByVal info As ControlGraphicsInfoArgs)
			DrawBackground(info)
			DrawButton(info)
			DrawInfoText(info)
		End Sub

		Private Sub DrawBackground(ByVal info As ControlGraphicsInfoArgs)
			Dim view As IPhoneCheckEditViewInfo = (TryCast(info.ViewInfo, IPhoneCheckEditViewInfo))
			Dim e As SkinElement = CommonSkins.GetSkin(view.LookAndFeel)(CommonSkins.SkinButton)
			Dim ei As New SkinElementInfo(e, view.BackgroundRect) With {.ImageIndex = view.BackgroundImageIndex}
			ObjectPainter.DrawObject(info.Cache, SkinElementPainter.Default, ei)
		End Sub
		Private Sub DrawButton(ByVal info As ControlGraphicsInfoArgs)
			Dim view As IPhoneCheckEditViewInfo = (TryCast(info.ViewInfo, IPhoneCheckEditViewInfo))
			Dim e As SkinElement = CommonSkins.GetSkin(view.LookAndFeel)(CommonSkins.SkinButton)
			Dim ei As New SkinElementInfo(e, view.ButtonRect) With {.ImageIndex = view.ButtonImageIndex}
			ObjectPainter.DrawObject(info.Cache, SkinElementPainter.Default, ei)
		End Sub
		Private Sub DrawInfoText(ByVal info As ControlGraphicsInfoArgs)
			Dim view As IPhoneCheckEditViewInfo = (TryCast(info.ViewInfo, IPhoneCheckEditViewInfo))
			Dim infoTextSize As Size = view.PaintAppearance.CalcTextSizeInt(info.Cache, view.InfoText, Integer.MaxValue)
			Dim infoTextLocation As Point = view.InfoTextLocation
			infoTextLocation.Offset(-infoTextSize.Width \ 2, -infoTextSize.Height \ 2)
			Dim e As SkinElement = CommonSkins.GetSkin(view.LookAndFeel)(CommonSkins.SkinButton)
			view.PaintAppearance.DrawString(info.Cache, view.InfoText, New Rectangle(infoTextLocation, infoTextSize), New SolidBrush(e.Color.GetForeColor()))
		End Sub
	End Class
End Namespace