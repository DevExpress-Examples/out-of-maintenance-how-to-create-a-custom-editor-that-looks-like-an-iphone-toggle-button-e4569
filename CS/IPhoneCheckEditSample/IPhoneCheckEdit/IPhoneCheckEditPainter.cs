using System.Drawing;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Drawing;

namespace DevExpress.WinForms.Samples.IPhoneCheckEdit {
    public class IPhoneCheckEditPainter : CheckEditPainter {
        protected override void DrawCheck(ControlGraphicsInfoArgs info) {
            DrawBackground(info);
            DrawButton(info);
            DrawInfoText(info);
        }

        void DrawBackground(ControlGraphicsInfoArgs info) {
            IPhoneCheckEditViewInfo view = (info.ViewInfo as IPhoneCheckEditViewInfo);
            SkinElement e = CommonSkins.GetSkin(view.LookAndFeel)[CommonSkins.SkinButton];
            SkinElementInfo ei = new SkinElementInfo(e, view.BackgroundRect) { ImageIndex = view.BackgroundImageIndex };
            ObjectPainter.DrawObject(info.Cache, SkinElementPainter.Default, ei);
        }
        void DrawButton(ControlGraphicsInfoArgs info) {
            IPhoneCheckEditViewInfo view = (info.ViewInfo as IPhoneCheckEditViewInfo);
            SkinElement e = CommonSkins.GetSkin(view.LookAndFeel)[CommonSkins.SkinButton];
            SkinElementInfo ei = new SkinElementInfo(e, view.ButtonRect) { ImageIndex = view.ButtonImageIndex };
            ObjectPainter.DrawObject(info.Cache, SkinElementPainter.Default, ei);
        }
        void DrawInfoText(ControlGraphicsInfoArgs info) {
            IPhoneCheckEditViewInfo view = (info.ViewInfo as IPhoneCheckEditViewInfo);
            Size infoTextSize = view.PaintAppearance.CalcTextSizeInt(info.Cache, view.InfoText, int.MaxValue);
            Point infoTextLocation = view.InfoTextLocation;
            infoTextLocation.Offset(-infoTextSize.Width / 2, -infoTextSize.Height / 2);
            SkinElement e = CommonSkins.GetSkin(view.LookAndFeel)[CommonSkins.SkinButton];
            view.PaintAppearance.DrawString(info.Cache, view.InfoText, new Rectangle(infoTextLocation, infoTextSize), new SolidBrush(e.Color.GetForeColor()));
        }
    }
}