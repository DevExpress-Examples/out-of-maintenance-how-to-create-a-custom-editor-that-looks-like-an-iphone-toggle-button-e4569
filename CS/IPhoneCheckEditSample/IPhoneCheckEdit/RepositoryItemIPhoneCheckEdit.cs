using System.ComponentModel;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.WinForms.Samples.IPhoneCheckEdit {
    [System.ComponentModel.DesignerCategory("")]
    [UserRepositoryItem("RegisterIPhoneCheckEdit")]
    public class RepositoryItemIPhoneCheckEdit : RepositoryItemCheckEdit {
        int backgroundSkinUncheckedImageIndex = 2;
        int backgroundSkinCheckedImageIndex = 1;
        int buttonSkinImageIndex = 0;
        string infoTextChecked = "ON";
        string infoTextUnchecked = "OFF";

        public const string CustomEditName = "IPhoneCheckEdit";
        public new RepositoryItemIPhoneCheckEdit Properties { get { return this; } }
        public override string EditorTypeName { get { return CustomEditName; } }
        public new IPhoneCheckEdit OwnerEdit { get { return base.OwnerEdit as IPhoneCheckEdit; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), RefreshProperties(RefreshProperties.All)]
        public AppearanceObject AppearanceChecked { get; private set; }
        [Browsable(false)]
        public int BackgroundSkinUncheckedImageIndex { get { return backgroundSkinUncheckedImageIndex; } }
        [Browsable(false)]
        public int BackgroundSkinCheckedImageIndex { get { return backgroundSkinCheckedImageIndex; } }
        [Browsable(false)]
        public int ButtonSkinImageIndex { get { return buttonSkinImageIndex; } }
        [Browsable(false)]
        public string InfoTextUnchecked { get { return infoTextUnchecked; } }
        [Browsable(false)]
        public string InfoTextChecked { get { return infoTextChecked; } }

        public RepositoryItemIPhoneCheckEdit(): base() {
            AppearanceChecked = new AppearanceObject(AppearanceDefault.Empty);
        }

        public override void Assign(RepositoryItem item) {
            BeginUpdate();
            try {
                base.Assign(item);
                RepositoryItemIPhoneCheckEdit source = item as RepositoryItemIPhoneCheckEdit;
                if(source == null) return;
                this.AppearanceChecked.Assign(source.AppearanceChecked);
            }
            finally {
                EndUpdate();
            }
        }

        static RepositoryItemIPhoneCheckEdit() {
            RegisterIPhoneCheckEdit();
        }
        public static void RegisterIPhoneCheckEdit() {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName,
              typeof(IPhoneCheckEdit), typeof(RepositoryItemIPhoneCheckEdit),
              typeof(IPhoneCheckEditViewInfo), new IPhoneCheckEditPainter(), true, img));
        }
    }
}