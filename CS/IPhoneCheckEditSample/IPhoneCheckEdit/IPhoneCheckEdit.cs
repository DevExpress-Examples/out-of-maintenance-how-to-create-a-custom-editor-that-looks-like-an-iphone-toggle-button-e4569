using System.ComponentModel;
using DevExpress.XtraEditors;

namespace DevExpress.WinForms.Samples.IPhoneCheckEdit {
    [System.ComponentModel.DesignerCategory("")]
    public class IPhoneCheckEdit : CheckEdit {
        protected internal new IPhoneCheckEditViewInfo ViewInfo { get { return base.ViewInfo as IPhoneCheckEditViewInfo; } }

        public override string EditorTypeName {
            get { return RepositoryItemIPhoneCheckEdit.CustomEditName; } 
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemIPhoneCheckEdit Properties { 
            get { return base.Properties as RepositoryItemIPhoneCheckEdit; } 
        }

        static IPhoneCheckEdit() {
            RepositoryItemIPhoneCheckEdit.RegisterIPhoneCheckEdit();
        }
    }
}
