using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;

namespace DevExpress.WinForms.Samples.IPhoneCheckEdit {
    public class IPhoneCheckEditViewInfo : CheckEditViewInfo {
        string infoText;
        int backgroundImageIndex;
        int buttonImageIndex;
        Rectangle backgroundRect;
        Rectangle buttonRect;
        Point infoTextLocation;

        public string InfoText { get { return infoText; } }
        public Point InfoTextLocation { get { return infoTextLocation; } }
        public new RepositoryItemIPhoneCheckEdit Item { get { return base.Item as RepositoryItemIPhoneCheckEdit; } }
        public Rectangle BackgroundRect { get { return backgroundRect; } }
        public Rectangle ButtonRect { get { return buttonRect; } }
        public int BackgroundImageIndex { get { return backgroundImageIndex; } }
        public int ButtonImageIndex { get { return buttonImageIndex; } }

        public IPhoneCheckEditViewInfo(RepositoryItem item) : base(item) {
        }

        public override bool AllowDrawFocusRect {
            get { return false; }
            set { base.AllowDrawFocusRect = false; }
        }
        public override void Offset(int x, int y) {
            base.Offset(x, y);
            OffsetContentLocation(x, y);
        }
        public override void UpdatePaintAppearance() {
            if(CheckState == System.Windows.Forms.CheckState.Checked) {
                PaintAppearance.Assign(Item.AppearanceChecked);
                return;
            }
            base.UpdatePaintAppearance();
        }
        protected override void Assign(BaseControlViewInfo info) {
            base.Assign(info);
            IPhoneCheckEditViewInfo view = (info as IPhoneCheckEditViewInfo);
            if(view == null) return;
            this.infoText = view.infoText;
            this.buttonImageIndex = view.backgroundImageIndex;
            this.buttonImageIndex = view.buttonImageIndex;
            this.backgroundRect = view.backgroundRect;
            this.buttonRect = view.buttonRect;
            this.infoTextLocation = view.infoTextLocation;
        }
        protected override void CalcContentRect(Rectangle bounds) {
            base.CalcContentRect(bounds);
            CalcBackgroundRectSize();
            CalcButtonRectSize();
            UpdateButtonLocationByState();
            UpdateInfoTextLocationByState();
        }
        protected override void OnEditValueChanged() {
            base.OnEditValueChanged();
            UpdateBackgroundSkinImageIndexByState();
            UpdateButtonSkinImageIndexByState();
            UpdateButtonLocationByState();
            UpdateInfoTextByState();
            UpdateInfoTextLocationByState();
        }

        void CalcBackgroundRectSize() {
            this.backgroundRect.Size = ContentRect.Size;
        }
        void CalcButtonRectSize() {
            this.buttonRect.Size = new Size(ContentRect.Width / 2, ContentRect.Height);
        }
        void OffsetContentLocation(int x, int y) {
            this.backgroundRect.Offset(x, y);
            this.buttonRect.Offset(x, y);
            this.infoTextLocation.Offset(x, y);
        }
        void UpdateBackgroundSkinImageIndexByState() {
            this.backgroundImageIndex = (CheckState == CheckState.Checked) ? Item.BackgroundSkinCheckedImageIndex : Item.BackgroundSkinUncheckedImageIndex;
        }
        void UpdateButtonSkinImageIndexByState() {
            this.buttonImageIndex = Item.ButtonSkinImageIndex;
        }
        void UpdateButtonLocationByState() {
            this.buttonRect.Y = ContentRect.Top;
            this.buttonRect.X = (CheckState == CheckState.Checked) ? (ContentRect.Right - this.buttonRect.Width) : ContentRect.Left;
        }
        void UpdateInfoTextByState() {
            this.infoText = (CheckState == CheckState.Checked) ? Item.InfoTextChecked : Item.InfoTextUnchecked;
        }
        void UpdateInfoTextLocationByState() {
            this.infoTextLocation.Y = ContentRect.Top + (ContentRect.Height / 2);
            this.infoTextLocation.X = (CheckState == CheckState.Checked) ? (ContentRect.Left + (this.buttonRect.Left / 2)) : (ContentRect.Right - ((ContentRect.Right - this.buttonRect.Right) / 2));
        }
    }
}
