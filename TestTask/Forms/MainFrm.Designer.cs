namespace TestTask.Forms
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ceAutoSync = new DevExpress.XtraEditors.CheckEdit();
            this.tsValidDestinationPath = new DevExpress.XtraEditors.ToggleSwitch();
            this.tsValidOriginPath = new DevExpress.XtraEditors.ToggleSwitch();
            this.sbSynchronize = new DevExpress.XtraEditors.SimpleButton();
            this.beDestinationFolder = new DevExpress.XtraEditors.ButtonEdit();
            this.beOriginFolder = new DevExpress.XtraEditors.ButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.teMinutes = new DevExpress.XtraEditors.TimeEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoSync.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsValidDestinationPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsValidOriginPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beDestinationFolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beOriginFolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMinutes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.teMinutes);
            this.layoutControl1.Controls.Add(this.ceAutoSync);
            this.layoutControl1.Controls.Add(this.tsValidDestinationPath);
            this.layoutControl1.Controls.Add(this.tsValidOriginPath);
            this.layoutControl1.Controls.Add(this.sbSynchronize);
            this.layoutControl1.Controls.Add(this.beDestinationFolder);
            this.layoutControl1.Controls.Add(this.beOriginFolder);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(864, 134);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ceAutoSync
            // 
            this.ceAutoSync.EditValue = true;
            this.ceAutoSync.Location = new System.Drawing.Point(696, 88);
            this.ceAutoSync.Name = "ceAutoSync";
            this.ceAutoSync.Properties.AutoHeight = false;
            this.ceAutoSync.Properties.Caption = "Automatic Synchronization";
            this.ceAutoSync.Size = new System.Drawing.Size(156, 34);
            this.ceAutoSync.StyleController = this.layoutControl1;
            this.ceAutoSync.TabIndex = 10;
            this.ceAutoSync.CheckedChanged += new System.EventHandler(this.ceAutoSync_CheckedChanged);
            // 
            // tsValidDestinationPath
            // 
            this.tsValidDestinationPath.Location = new System.Drawing.Point(696, 50);
            this.tsValidDestinationPath.Name = "tsValidDestinationPath";
            this.tsValidDestinationPath.Properties.AutoHeight = false;
            this.tsValidDestinationPath.Properties.OffText = "Not Valid";
            this.tsValidDestinationPath.Properties.OnText = "Valid";
            this.tsValidDestinationPath.Properties.ReadOnly = true;
            this.tsValidDestinationPath.Size = new System.Drawing.Size(156, 34);
            this.tsValidDestinationPath.StyleController = this.layoutControl1;
            this.tsValidDestinationPath.TabIndex = 8;
            // 
            // tsValidOriginPath
            // 
            this.tsValidOriginPath.Location = new System.Drawing.Point(696, 12);
            this.tsValidOriginPath.Name = "tsValidOriginPath";
            this.tsValidOriginPath.Properties.AutoHeight = false;
            this.tsValidOriginPath.Properties.OffText = "Not Valid";
            this.tsValidOriginPath.Properties.OnText = "Valid";
            this.tsValidOriginPath.Properties.ReadOnly = true;
            this.tsValidOriginPath.Size = new System.Drawing.Size(156, 34);
            this.tsValidOriginPath.StyleController = this.layoutControl1;
            this.tsValidOriginPath.TabIndex = 7;
            // 
            // sbSynchronize
            // 
            this.sbSynchronize.ImageOptions.SvgImage = global::TestTask.Properties.Resources.changeview;
            this.sbSynchronize.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.sbSynchronize.Location = new System.Drawing.Point(12, 88);
            this.sbSynchronize.Name = "sbSynchronize";
            this.sbSynchronize.Size = new System.Drawing.Size(408, 34);
            this.sbSynchronize.StyleController = this.layoutControl1;
            this.sbSynchronize.TabIndex = 6;
            this.sbSynchronize.Text = "Synchronize";
            this.sbSynchronize.Click += new System.EventHandler(this.sbSynchronize_Click);
            // 
            // beDestinationFolder
            // 
            this.beDestinationFolder.Location = new System.Drawing.Point(12, 50);
            this.beDestinationFolder.Name = "beDestinationFolder";
            this.beDestinationFolder.Properties.AdvancedModeOptions.Label = "Destination Folder";
            this.beDestinationFolder.Properties.AutoHeight = false;
            editorButtonImageOptions2.SvgImage = global::TestTask.Properties.Resources.open;
            editorButtonImageOptions2.SvgImageSize = new System.Drawing.Size(24, 24);
            this.beDestinationFolder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.beDestinationFolder.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.beDestinationFolder.Size = new System.Drawing.Size(680, 34);
            this.beDestinationFolder.StyleController = this.layoutControl1;
            this.beDestinationFolder.TabIndex = 5;
            this.beDestinationFolder.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beDestinationFolder_ButtonClick);
            this.beDestinationFolder.EditValueChanged += new System.EventHandler(this.beDestinationFolder_EditValueChanged);
            this.beDestinationFolder.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.beDestinationFolder_EditValueChanging);
            // 
            // beOriginFolder
            // 
            this.beOriginFolder.Location = new System.Drawing.Point(12, 12);
            this.beOriginFolder.Name = "beOriginFolder";
            this.beOriginFolder.Properties.AdvancedModeOptions.Label = "Origin Folder";
            this.beOriginFolder.Properties.AutoHeight = false;
            editorButtonImageOptions3.SvgImage = global::TestTask.Properties.Resources.open;
            editorButtonImageOptions3.SvgImageSize = new System.Drawing.Size(24, 24);
            this.beOriginFolder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.beOriginFolder.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.beOriginFolder.Size = new System.Drawing.Size(680, 34);
            this.beOriginFolder.StyleController = this.layoutControl1;
            this.beOriginFolder.TabIndex = 4;
            this.beOriginFolder.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beOriginFolder_ButtonClick);
            this.beOriginFolder.EditValueChanged += new System.EventHandler(this.beOriginFolder_EditValueChanged);
            this.beOriginFolder.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.beOriginFolder_EditValueChanging);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(864, 134);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.beOriginFolder;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(684, 38);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.beDestinationFolder;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 38);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(684, 38);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sbSynchronize;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 76);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(96, 32);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(412, 38);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.tsValidOriginPath;
            this.layoutControlItem4.Location = new System.Drawing.Point(684, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(160, 38);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.tsValidDestinationPath;
            this.layoutControlItem5.Location = new System.Drawing.Point(684, 38);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(160, 38);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.ceAutoSync;
            this.layoutControlItem7.Location = new System.Drawing.Point(684, 76);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(160, 38);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // teMinutes
            // 
            this.teMinutes.EditValue = new System.DateTime(2024, 6, 25, 0, 0, 0, 0);
            this.teMinutes.Location = new System.Drawing.Point(424, 88);
            this.teMinutes.Name = "teMinutes";
            this.teMinutes.Properties.AdvancedModeOptions.Label = "Minutes";
            this.teMinutes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teMinutes.Properties.MaskSettings.Set("mask", "mm");
            this.teMinutes.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.teMinutes.Properties.UseMaskAsDisplayFormat = true;
            this.teMinutes.Size = new System.Drawing.Size(268, 34);
            this.teMinutes.StyleController = this.layoutControl1;
            this.teMinutes.TabIndex = 11;
            this.teMinutes.EditValueChanged += new System.EventHandler(this.teMinutes_EditValueChanged);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.teMinutes;
            this.layoutControlItem6.Location = new System.Drawing.Point(412, 76);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(272, 38);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 134);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.SvgImage = global::TestTask.Properties.Resources.tasks;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Task";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoSync.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsValidDestinationPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsValidOriginPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beDestinationFolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beOriginFolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMinutes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.ButtonEdit beOriginFolder;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.ButtonEdit beDestinationFolder;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton sbSynchronize;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.ToggleSwitch tsValidDestinationPath;
        private DevExpress.XtraEditors.ToggleSwitch tsValidOriginPath;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.CheckEdit ceAutoSync;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.TimeEdit teMinutes;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}