namespace JuicySwapper.Main.GUI
{
    partial class SettingsMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsMenu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.selectPakPathButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.resetConfigButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.convertedItemsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pakPathTextbox = new System.Windows.Forms.TextBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse7 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.restartButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.backupButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openPakButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.checkPakButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse8 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse9 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse10 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse11 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse12 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.selectPakPathButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.Magenta;
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Sidebar.Location = new System.Drawing.Point(-3, -7);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(70, 210);
            this.Sidebar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Path to paks folder:";
            // 
            // selectPakPathButton
            // 
            this.selectPakPathButton.BackColor = System.Drawing.Color.Transparent;
            this.selectPakPathButton.Image = ((System.Drawing.Image)(resources.GetObject("selectPakPathButton.Image")));
            this.selectPakPathButton.ImageActive = null;
            this.selectPakPathButton.Location = new System.Drawing.Point(442, 75);
            this.selectPakPathButton.Name = "selectPakPathButton";
            this.selectPakPathButton.Size = new System.Drawing.Size(40, 34);
            this.selectPakPathButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectPakPathButton.TabIndex = 4;
            this.selectPakPathButton.TabStop = false;
            this.selectPakPathButton.Zoom = 0;
            this.selectPakPathButton.Click += new System.EventHandler(this.selectPakPathButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(467, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 14);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 5;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 10;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // resetConfigButton
            // 
            this.resetConfigButton.Activecolor = System.Drawing.Color.Transparent;
            this.resetConfigButton.BackColor = System.Drawing.Color.Transparent;
            this.resetConfigButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetConfigButton.BackgroundImage")));
            this.resetConfigButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetConfigButton.BorderRadius = 0;
            this.resetConfigButton.ButtonText = "Reset Config";
            this.resetConfigButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetConfigButton.DisabledColor = System.Drawing.Color.White;
            this.resetConfigButton.ForeColor = System.Drawing.Color.White;
            this.resetConfigButton.Iconcolor = System.Drawing.Color.Transparent;
            this.resetConfigButton.Iconimage = null;
            this.resetConfigButton.Iconimage_right = null;
            this.resetConfigButton.Iconimage_right_Selected = null;
            this.resetConfigButton.Iconimage_Selected = null;
            this.resetConfigButton.IconMarginLeft = 0;
            this.resetConfigButton.IconMarginRight = 0;
            this.resetConfigButton.IconRightVisible = true;
            this.resetConfigButton.IconRightZoom = 0D;
            this.resetConfigButton.IconVisible = true;
            this.resetConfigButton.IconZoom = 50D;
            this.resetConfigButton.IsTab = false;
            this.resetConfigButton.Location = new System.Drawing.Point(77, 116);
            this.resetConfigButton.Name = "resetConfigButton";
            this.resetConfigButton.Normalcolor = System.Drawing.Color.Transparent;
            this.resetConfigButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.resetConfigButton.OnHoverTextColor = System.Drawing.Color.White;
            this.resetConfigButton.selected = false;
            this.resetConfigButton.Size = new System.Drawing.Size(124, 26);
            this.resetConfigButton.TabIndex = 17;
            this.resetConfigButton.Text = "Reset Config";
            this.resetConfigButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resetConfigButton.Textcolor = System.Drawing.Color.White;
            this.resetConfigButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetConfigButton.Click += new System.EventHandler(this.resetConfigButton_Click);
            // 
            // convertedItemsButton
            // 
            this.convertedItemsButton.Activecolor = System.Drawing.Color.Transparent;
            this.convertedItemsButton.BackColor = System.Drawing.Color.Transparent;
            this.convertedItemsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("convertedItemsButton.BackgroundImage")));
            this.convertedItemsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.convertedItemsButton.BorderRadius = 0;
            this.convertedItemsButton.ButtonText = "Converted Items List";
            this.convertedItemsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.convertedItemsButton.DisabledColor = System.Drawing.Color.White;
            this.convertedItemsButton.ForeColor = System.Drawing.Color.White;
            this.convertedItemsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.convertedItemsButton.Iconimage = null;
            this.convertedItemsButton.Iconimage_right = null;
            this.convertedItemsButton.Iconimage_right_Selected = null;
            this.convertedItemsButton.Iconimage_Selected = null;
            this.convertedItemsButton.IconMarginLeft = 0;
            this.convertedItemsButton.IconMarginRight = 0;
            this.convertedItemsButton.IconRightVisible = true;
            this.convertedItemsButton.IconRightZoom = 0D;
            this.convertedItemsButton.IconVisible = true;
            this.convertedItemsButton.IconZoom = 50D;
            this.convertedItemsButton.IsTab = false;
            this.convertedItemsButton.Location = new System.Drawing.Point(207, 116);
            this.convertedItemsButton.Name = "convertedItemsButton";
            this.convertedItemsButton.Normalcolor = System.Drawing.Color.Transparent;
            this.convertedItemsButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.convertedItemsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.convertedItemsButton.selected = false;
            this.convertedItemsButton.Size = new System.Drawing.Size(124, 26);
            this.convertedItemsButton.TabIndex = 18;
            this.convertedItemsButton.Text = "Converted Items List";
            this.convertedItemsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.convertedItemsButton.Textcolor = System.Drawing.Color.White;
            this.convertedItemsButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertedItemsButton.Click += new System.EventHandler(this.convertedItemsButton_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuSeparator1.LineThickness = 4;
            this.bunifuSeparator1.Location = new System.Drawing.Point(77, 101);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(364, 10);
            this.bunifuSeparator1.TabIndex = 20;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // pakPathTextbox
            // 
            this.pakPathTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.pakPathTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pakPathTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pakPathTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pakPathTextbox.ForeColor = System.Drawing.Color.White;
            this.pakPathTextbox.Location = new System.Drawing.Point(77, 84);
            this.pakPathTextbox.Name = "pakPathTextbox";
            this.pakPathTextbox.ReadOnly = true;
            this.pakPathTextbox.Size = new System.Drawing.Size(364, 16);
            this.pakPathTextbox.TabIndex = 21;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 5;
            this.bunifuElipse4.TargetControl = this;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 5;
            this.bunifuElipse5.TargetControl = this.convertedItemsButton;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 5;
            this.bunifuElipse6.TargetControl = this.resetConfigButton;
            // 
            // bunifuElipse7
            // 
            this.bunifuElipse7.ElipseRadius = 5;
            this.bunifuElipse7.TargetControl = this;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.label1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            // 
            // restartButton
            // 
            this.restartButton.Activecolor = System.Drawing.Color.Transparent;
            this.restartButton.BackColor = System.Drawing.Color.Transparent;
            this.restartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("restartButton.BackgroundImage")));
            this.restartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.restartButton.BorderRadius = 0;
            this.restartButton.ButtonText = "Restart Swapper";
            this.restartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartButton.DisabledColor = System.Drawing.Color.White;
            this.restartButton.ForeColor = System.Drawing.Color.White;
            this.restartButton.Iconcolor = System.Drawing.Color.Transparent;
            this.restartButton.Iconimage = null;
            this.restartButton.Iconimage_right = null;
            this.restartButton.Iconimage_right_Selected = null;
            this.restartButton.Iconimage_Selected = null;
            this.restartButton.IconMarginLeft = 0;
            this.restartButton.IconMarginRight = 0;
            this.restartButton.IconRightVisible = true;
            this.restartButton.IconRightZoom = 0D;
            this.restartButton.IconVisible = true;
            this.restartButton.IconZoom = 50D;
            this.restartButton.IsTab = false;
            this.restartButton.Location = new System.Drawing.Point(207, 149);
            this.restartButton.Name = "restartButton";
            this.restartButton.Normalcolor = System.Drawing.Color.Transparent;
            this.restartButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.restartButton.OnHoverTextColor = System.Drawing.Color.White;
            this.restartButton.selected = false;
            this.restartButton.Size = new System.Drawing.Size(124, 26);
            this.restartButton.TabIndex = 25;
            this.restartButton.Text = "Restart Swapper";
            this.restartButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.restartButton.Textcolor = System.Drawing.Color.White;
            this.restartButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // backupButton
            // 
            this.backupButton.Activecolor = System.Drawing.Color.Transparent;
            this.backupButton.BackColor = System.Drawing.Color.Transparent;
            this.backupButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backupButton.BackgroundImage")));
            this.backupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backupButton.BorderRadius = 0;
            this.backupButton.ButtonText = "Backup/Verify";
            this.backupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backupButton.DisabledColor = System.Drawing.Color.White;
            this.backupButton.ForeColor = System.Drawing.Color.White;
            this.backupButton.Iconcolor = System.Drawing.Color.Transparent;
            this.backupButton.Iconimage = null;
            this.backupButton.Iconimage_right = null;
            this.backupButton.Iconimage_right_Selected = null;
            this.backupButton.Iconimage_Selected = null;
            this.backupButton.IconMarginLeft = 0;
            this.backupButton.IconMarginRight = 0;
            this.backupButton.IconRightVisible = true;
            this.backupButton.IconRightZoom = 0D;
            this.backupButton.IconVisible = true;
            this.backupButton.IconZoom = 50D;
            this.backupButton.IsTab = false;
            this.backupButton.Location = new System.Drawing.Point(77, 149);
            this.backupButton.Name = "backupButton";
            this.backupButton.Normalcolor = System.Drawing.Color.Transparent;
            this.backupButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.backupButton.OnHoverTextColor = System.Drawing.Color.White;
            this.backupButton.selected = false;
            this.backupButton.Size = new System.Drawing.Size(124, 26);
            this.backupButton.TabIndex = 24;
            this.backupButton.Text = "Backup/Verify";
            this.backupButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backupButton.Textcolor = System.Drawing.Color.White;
            this.backupButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // openPakButton
            // 
            this.openPakButton.Activecolor = System.Drawing.Color.Transparent;
            this.openPakButton.BackColor = System.Drawing.Color.Transparent;
            this.openPakButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openPakButton.BackgroundImage")));
            this.openPakButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openPakButton.BorderRadius = 0;
            this.openPakButton.ButtonText = "Open Pak Directory";
            this.openPakButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openPakButton.DisabledColor = System.Drawing.Color.White;
            this.openPakButton.ForeColor = System.Drawing.Color.White;
            this.openPakButton.Iconcolor = System.Drawing.Color.Transparent;
            this.openPakButton.Iconimage = null;
            this.openPakButton.Iconimage_right = null;
            this.openPakButton.Iconimage_right_Selected = null;
            this.openPakButton.Iconimage_Selected = null;
            this.openPakButton.IconMarginLeft = 0;
            this.openPakButton.IconMarginRight = 0;
            this.openPakButton.IconRightVisible = true;
            this.openPakButton.IconRightZoom = 0D;
            this.openPakButton.IconVisible = true;
            this.openPakButton.IconZoom = 50D;
            this.openPakButton.IsTab = false;
            this.openPakButton.Location = new System.Drawing.Point(339, 149);
            this.openPakButton.Name = "openPakButton";
            this.openPakButton.Normalcolor = System.Drawing.Color.Transparent;
            this.openPakButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.openPakButton.OnHoverTextColor = System.Drawing.Color.White;
            this.openPakButton.selected = false;
            this.openPakButton.Size = new System.Drawing.Size(124, 26);
            this.openPakButton.TabIndex = 23;
            this.openPakButton.Text = "Open Pak Directory";
            this.openPakButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.openPakButton.Textcolor = System.Drawing.Color.White;
            this.openPakButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPakButton.Click += new System.EventHandler(this.openPakButton_Click);
            // 
            // checkPakButton
            // 
            this.checkPakButton.Activecolor = System.Drawing.Color.Transparent;
            this.checkPakButton.BackColor = System.Drawing.Color.Transparent;
            this.checkPakButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkPakButton.BackgroundImage")));
            this.checkPakButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkPakButton.BorderRadius = 0;
            this.checkPakButton.ButtonText = "Check Pak Directory";
            this.checkPakButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkPakButton.DisabledColor = System.Drawing.Color.White;
            this.checkPakButton.ForeColor = System.Drawing.Color.White;
            this.checkPakButton.Iconcolor = System.Drawing.Color.Transparent;
            this.checkPakButton.Iconimage = null;
            this.checkPakButton.Iconimage_right = null;
            this.checkPakButton.Iconimage_right_Selected = null;
            this.checkPakButton.Iconimage_Selected = null;
            this.checkPakButton.IconMarginLeft = 0;
            this.checkPakButton.IconMarginRight = 0;
            this.checkPakButton.IconRightVisible = true;
            this.checkPakButton.IconRightZoom = 0D;
            this.checkPakButton.IconVisible = true;
            this.checkPakButton.IconZoom = 50D;
            this.checkPakButton.IsTab = false;
            this.checkPakButton.Location = new System.Drawing.Point(339, 117);
            this.checkPakButton.Name = "checkPakButton";
            this.checkPakButton.Normalcolor = System.Drawing.Color.Transparent;
            this.checkPakButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.checkPakButton.OnHoverTextColor = System.Drawing.Color.White;
            this.checkPakButton.selected = false;
            this.checkPakButton.Size = new System.Drawing.Size(124, 26);
            this.checkPakButton.TabIndex = 22;
            this.checkPakButton.Text = "Check Pak Directory";
            this.checkPakButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkPakButton.Textcolor = System.Drawing.Color.White;
            this.checkPakButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPakButton.Click += new System.EventHandler(this.checkPakButton_Click);
            // 
            // bunifuElipse8
            // 
            this.bunifuElipse8.ElipseRadius = 5;
            this.bunifuElipse8.TargetControl = this.checkPakButton;
            // 
            // bunifuElipse9
            // 
            this.bunifuElipse9.ElipseRadius = 5;
            this.bunifuElipse9.TargetControl = this.backupButton;
            // 
            // bunifuElipse10
            // 
            this.bunifuElipse10.ElipseRadius = 5;
            this.bunifuElipse10.TargetControl = this.restartButton;
            // 
            // bunifuElipse11
            // 
            this.bunifuElipse11.ElipseRadius = 5;
            this.bunifuElipse11.TargetControl = this.openPakButton;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Juicy Swapper -Settings";
            // 
            // bunifuElipse12
            // 
            this.bunifuElipse12.ElipseRadius = 2;
            this.bunifuElipse12.TargetControl = this;
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(498, 184);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.openPakButton);
            this.Controls.Add(this.checkPakButton);
            this.Controls.Add(this.pakPathTextbox);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.convertedItemsButton);
            this.Controls.Add(this.resetConfigButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.selectPakPathButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.selectPakPathButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton selectPakPathButton;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton convertedItemsButton;
        private Bunifu.Framework.UI.BunifuFlatButton resetConfigButton;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.TextBox pakPathTextbox;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse7;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuFlatButton restartButton;
        private Bunifu.Framework.UI.BunifuFlatButton backupButton;
        private Bunifu.Framework.UI.BunifuFlatButton openPakButton;
        private Bunifu.Framework.UI.BunifuFlatButton checkPakButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse8;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse9;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse10;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse11;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse12;
    }
}