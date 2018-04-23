using System.ComponentModel;
using DevExpress.Skins;
using DevExpress.XtraEditors;

namespace IPhoneCheckEditSample {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            InitGrid();
            InitSkinList();      
        }

        void InitGrid() {
            BindingList<GridContentElement> gridContentElements = new BindingList<GridContentElement>();
            gridContentElements.Add(new GridContentElement() { Caption = "Mail", Value = true });
            gridContentElements.Add(new GridContentElement() { Caption = "Contacts", Value = false });
            gridContentElements.Add(new GridContentElement() { Caption = "Calendars", Value = false });
            gridContentElements.Add(new GridContentElement() { Caption = "Bookmarks", Value = false });
            gridControl1.DataSource = gridContentElements;
            gridView1.Columns["Value"].ColumnEdit = repositoryItemIPhoneCheckEdit1;
        }
        void InitSkinList() {
            listBoxControl1.DataSource = SkinManager.Default.Skins;
            listBoxControl1.DisplayMember = "SkinName";
        }
        void listBoxControl1_SelectedIndexChanged(object sender, System.EventArgs e) {
            if((sender as ListBoxControl).SelectedItem == null) return;
            defaultLookAndFeel1.LookAndFeel.SkinName = ((sender as ListBoxControl).SelectedItem as SkinContainer).SkinName;
        }
    }

    class GridContentElement : INotifyPropertyChanged {
        string caption;
        bool value;
        
        public string Caption {
            get { return caption; }
            set {
                if(caption == value) return;
                this.caption = value;
                DoPropertyChanged("Caption");
            }
        }
        public bool Value {
            get { return value; }
            set {
                if(this.value == value) return;
                this.value = value;
                DoPropertyChanged("Value");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        void DoPropertyChanged(string propertyName) {
            if(PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}