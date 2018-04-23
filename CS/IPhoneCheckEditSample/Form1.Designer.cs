namespace IPhoneCheckEditSample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.iPhoneCheckEdit1 = new DevExpress.WinForms.Samples.IPhoneCheckEdit.IPhoneCheckEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemIPhoneCheckEdit1 = new DevExpress.WinForms.Samples.IPhoneCheckEdit.RepositoryItemIPhoneCheckEdit();
            this.iPhoneCheckEdit2 = new DevExpress.WinForms.Samples.IPhoneCheckEdit.IPhoneCheckEdit();
            this.iPhoneCheckEdit3 = new DevExpress.WinForms.Samples.IPhoneCheckEdit.IPhoneCheckEdit();
            this.iPhoneCheckEdit4 = new DevExpress.WinForms.Samples.IPhoneCheckEdit.IPhoneCheckEdit();
            this.iPhoneCheckEdit5 = new DevExpress.WinForms.Samples.IPhoneCheckEdit.IPhoneCheckEdit();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.iPhoneCheckEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIPhoneCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPhoneCheckEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPhoneCheckEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPhoneCheckEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPhoneCheckEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Foggy";
            // 
            // iPhoneCheckEdit1
            // 
            this.iPhoneCheckEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iPhoneCheckEdit1.Location = new System.Drawing.Point(516, 12);
            this.iPhoneCheckEdit1.Name = "iPhoneCheckEdit1";
            this.iPhoneCheckEdit1.Properties.Caption = "iPhoneCheckEdit1";
            this.iPhoneCheckEdit1.Size = new System.Drawing.Size(75, 15);
            this.iPhoneCheckEdit1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemIPhoneCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(418, 527);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // repositoryItemIPhoneCheckEdit1
            // 
            this.repositoryItemIPhoneCheckEdit1.AutoHeight = false;
            this.repositoryItemIPhoneCheckEdit1.Name = "repositoryItemIPhoneCheckEdit1";
            // 
            // iPhoneCheckEdit2
            // 
            this.iPhoneCheckEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iPhoneCheckEdit2.EditValue = true;
            this.iPhoneCheckEdit2.Location = new System.Drawing.Point(436, 96);
            this.iPhoneCheckEdit2.Name = "iPhoneCheckEdit2";
            this.iPhoneCheckEdit2.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.iPhoneCheckEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.iPhoneCheckEdit2.Properties.Appearance.Options.UseFont = true;
            this.iPhoneCheckEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.iPhoneCheckEdit2.Properties.AppearanceChecked.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iPhoneCheckEdit2.Properties.AppearanceChecked.ForeColor = System.Drawing.Color.Blue;
            this.iPhoneCheckEdit2.Properties.AppearanceChecked.Options.UseFont = true;
            this.iPhoneCheckEdit2.Properties.AppearanceChecked.Options.UseForeColor = true;
            this.iPhoneCheckEdit2.Properties.AutoHeight = false;
            this.iPhoneCheckEdit2.Properties.Caption = "iPhoneCheckEdit2";
            this.iPhoneCheckEdit2.Size = new System.Drawing.Size(155, 46);
            this.iPhoneCheckEdit2.TabIndex = 2;
            // 
            // iPhoneCheckEdit3
            // 
            this.iPhoneCheckEdit3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iPhoneCheckEdit3.Location = new System.Drawing.Point(516, 75);
            this.iPhoneCheckEdit3.Name = "iPhoneCheckEdit3";
            this.iPhoneCheckEdit3.Properties.Caption = "iPhoneCheckEdit3";
            this.iPhoneCheckEdit3.Size = new System.Drawing.Size(75, 15);
            this.iPhoneCheckEdit3.TabIndex = 3;
            // 
            // iPhoneCheckEdit4
            // 
            this.iPhoneCheckEdit4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iPhoneCheckEdit4.EditValue = true;
            this.iPhoneCheckEdit4.Location = new System.Drawing.Point(516, 54);
            this.iPhoneCheckEdit4.Name = "iPhoneCheckEdit4";
            this.iPhoneCheckEdit4.Properties.Caption = "iPhoneCheckEdit4";
            this.iPhoneCheckEdit4.Size = new System.Drawing.Size(75, 15);
            this.iPhoneCheckEdit4.TabIndex = 4;
            // 
            // iPhoneCheckEdit5
            // 
            this.iPhoneCheckEdit5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iPhoneCheckEdit5.EditValue = true;
            this.iPhoneCheckEdit5.Location = new System.Drawing.Point(516, 33);
            this.iPhoneCheckEdit5.Name = "iPhoneCheckEdit5";
            this.iPhoneCheckEdit5.Properties.Caption = "iPhoneCheckEdit5";
            this.iPhoneCheckEdit5.Size = new System.Drawing.Size(75, 15);
            this.iPhoneCheckEdit5.TabIndex = 5;
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxControl1.Location = new System.Drawing.Point(436, 174);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(155, 365);
            this.listBoxControl1.TabIndex = 6;
            this.listBoxControl1.SelectedIndexChanged += new System.EventHandler(this.listBoxControl1_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(436, 152);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 16);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Active skin:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 551);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.iPhoneCheckEdit5);
            this.Controls.Add(this.iPhoneCheckEdit4);
            this.Controls.Add(this.iPhoneCheckEdit3);
            this.Controls.Add(this.iPhoneCheckEdit2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.iPhoneCheckEdit1);
            this.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.Name = "Form1";
            this.Text = "Sample : IPhoneCheckEdit";
            ((System.ComponentModel.ISupportInitialize)(this.iPhoneCheckEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIPhoneCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPhoneCheckEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPhoneCheckEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPhoneCheckEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPhoneCheckEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.WinForms.Samples.IPhoneCheckEdit.IPhoneCheckEdit iPhoneCheckEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.WinForms.Samples.IPhoneCheckEdit.RepositoryItemIPhoneCheckEdit repositoryItemIPhoneCheckEdit1;
        private DevExpress.WinForms.Samples.IPhoneCheckEdit.IPhoneCheckEdit iPhoneCheckEdit2;
        private DevExpress.WinForms.Samples.IPhoneCheckEdit.IPhoneCheckEdit iPhoneCheckEdit3;
        private DevExpress.WinForms.Samples.IPhoneCheckEdit.IPhoneCheckEdit iPhoneCheckEdit4;
        private DevExpress.WinForms.Samples.IPhoneCheckEdit.IPhoneCheckEdit iPhoneCheckEdit5;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;


    }
}
