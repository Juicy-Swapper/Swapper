
namespace JuicySwapper_Launcher
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation7 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation8 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SettingsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ControlBar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.WrapsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SkinButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DashButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MoveToDash = new System.Windows.Forms.Timer(this.components);
            this.MoveToSkin = new System.Windows.Forms.Timer(this.components);
            this.MoveToBack = new System.Windows.Forms.Timer(this.components);
            this.MoveToPick = new System.Windows.Forms.Timer(this.components);
            this.MoveToEmote = new System.Windows.Forms.Timer(this.components);
            this.MoveToWraps = new System.Windows.Forms.Timer(this.components);
            this.MoveToSettings = new System.Windows.Forms.Timer(this.components);
            this.AnimacionSidebarFirst = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimationSidebarReturn = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Wrapper = new System.Windows.Forms.Panel();
            this.SidebarWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.AnimationSidebarReturn.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarFirst.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 0);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(90, 462);
            this.SidebarWrapper.TabIndex = 2;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.bunifuFlatButton1);
            this.Sidebar.Controls.Add(this.SettingsButton);
            this.Sidebar.Controls.Add(this.ControlBar);
            this.Sidebar.Controls.Add(this.label1);
            this.Sidebar.Controls.Add(this.bunifuImageButton2);
            this.Sidebar.Controls.Add(this.WrapsButton);
            this.Sidebar.Controls.Add(this.SkinButton);
            this.Sidebar.Controls.Add(this.DashButton);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.label2);
            this.AnimationSidebarReturn.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarFirst.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.Magenta;
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Sidebar.Location = new System.Drawing.Point(16, 19);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(68, 431);
            this.Sidebar.TabIndex = 0;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Activecolor = System.Drawing.Color.Transparent;
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsButton.BorderRadius = 0;
            this.SettingsButton.ButtonText = "      SETTINGS";
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarFirst.SetDecoration(this.SettingsButton, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.SettingsButton, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.SettingsButton, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarReturn.SetDecoration(this.SettingsButton, BunifuAnimatorNS.DecorationType.None);
            this.SettingsButton.DisabledColor = System.Drawing.Color.Transparent;
            this.SettingsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.SettingsButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Iconimage")));
            this.SettingsButton.Iconimage_right = null;
            this.SettingsButton.Iconimage_right_Selected = null;
            this.SettingsButton.Iconimage_Selected = null;
            this.SettingsButton.IconMarginLeft = 0;
            this.SettingsButton.IconMarginRight = 0;
            this.SettingsButton.IconRightVisible = true;
            this.SettingsButton.IconRightZoom = 0D;
            this.SettingsButton.IconVisible = true;
            this.SettingsButton.IconZoom = 50D;
            this.SettingsButton.IsTab = false;
            this.SettingsButton.Location = new System.Drawing.Point(9, 371);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Normalcolor = System.Drawing.Color.Transparent;
            this.SettingsButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.SettingsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SettingsButton.selected = false;
            this.SettingsButton.Size = new System.Drawing.Size(252, 51);
            this.SettingsButton.TabIndex = 15;
            this.SettingsButton.Text = "      SETTINGS";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Textcolor = System.Drawing.Color.White;
            this.SettingsButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ControlBar
            // 
            this.ControlBar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarFirst.SetDecoration(this.ControlBar, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarReturn.SetDecoration(this.ControlBar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.ControlBar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.ControlBar, BunifuAnimatorNS.DecorationType.None);
            this.ControlBar.Image = ((System.Drawing.Image)(resources.GetObject("ControlBar.Image")));
            this.ControlBar.Location = new System.Drawing.Point(-2, 91);
            this.ControlBar.Name = "ControlBar";
            this.ControlBar.Size = new System.Drawing.Size(5, 51);
            this.ControlBar.TabIndex = 16;
            this.ControlBar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarFirst.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarReturn.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Welcome, ";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.AnimationSidebarReturn.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarFirst.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(13, 13);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // WrapsButton
            // 
            this.WrapsButton.Activecolor = System.Drawing.Color.Transparent;
            this.WrapsButton.BackColor = System.Drawing.Color.Transparent;
            this.WrapsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WrapsButton.BorderRadius = 0;
            this.WrapsButton.ButtonText = "      PRIVATE SERVER";
            this.WrapsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarFirst.SetDecoration(this.WrapsButton, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.WrapsButton, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.WrapsButton, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarReturn.SetDecoration(this.WrapsButton, BunifuAnimatorNS.DecorationType.None);
            this.WrapsButton.DisabledColor = System.Drawing.Color.Transparent;
            this.WrapsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.WrapsButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("WrapsButton.Iconimage")));
            this.WrapsButton.Iconimage_right = null;
            this.WrapsButton.Iconimage_right_Selected = null;
            this.WrapsButton.Iconimage_Selected = null;
            this.WrapsButton.IconMarginLeft = 0;
            this.WrapsButton.IconMarginRight = 0;
            this.WrapsButton.IconRightVisible = true;
            this.WrapsButton.IconRightZoom = 0D;
            this.WrapsButton.IconVisible = true;
            this.WrapsButton.IconZoom = 50D;
            this.WrapsButton.IsTab = false;
            this.WrapsButton.Location = new System.Drawing.Point(9, 231);
            this.WrapsButton.Name = "WrapsButton";
            this.WrapsButton.Normalcolor = System.Drawing.Color.Transparent;
            this.WrapsButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.WrapsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.WrapsButton.selected = false;
            this.WrapsButton.Size = new System.Drawing.Size(252, 51);
            this.WrapsButton.TabIndex = 13;
            this.WrapsButton.Text = "      PRIVATE SERVER";
            this.WrapsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WrapsButton.Textcolor = System.Drawing.Color.White;
            this.WrapsButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // SkinButton
            // 
            this.SkinButton.Activecolor = System.Drawing.Color.Transparent;
            this.SkinButton.BackColor = System.Drawing.Color.Transparent;
            this.SkinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SkinButton.BorderRadius = 0;
            this.SkinButton.ButtonText = "      SWAPPER";
            this.SkinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarFirst.SetDecoration(this.SkinButton, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.SkinButton, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.SkinButton, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarReturn.SetDecoration(this.SkinButton, BunifuAnimatorNS.DecorationType.None);
            this.SkinButton.DisabledColor = System.Drawing.Color.Transparent;
            this.SkinButton.Iconcolor = System.Drawing.Color.Transparent;
            this.SkinButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("SkinButton.Iconimage")));
            this.SkinButton.Iconimage_right = null;
            this.SkinButton.Iconimage_right_Selected = null;
            this.SkinButton.Iconimage_Selected = null;
            this.SkinButton.IconMarginLeft = 0;
            this.SkinButton.IconMarginRight = 0;
            this.SkinButton.IconRightVisible = true;
            this.SkinButton.IconRightZoom = 0D;
            this.SkinButton.IconVisible = true;
            this.SkinButton.IconZoom = 50D;
            this.SkinButton.IsTab = false;
            this.SkinButton.Location = new System.Drawing.Point(9, 161);
            this.SkinButton.Name = "SkinButton";
            this.SkinButton.Normalcolor = System.Drawing.Color.Transparent;
            this.SkinButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.SkinButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SkinButton.selected = false;
            this.SkinButton.Size = new System.Drawing.Size(252, 51);
            this.SkinButton.TabIndex = 9;
            this.SkinButton.Text = "      SWAPPER";
            this.SkinButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SkinButton.Textcolor = System.Drawing.Color.White;
            this.SkinButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // DashButton
            // 
            this.DashButton.Activecolor = System.Drawing.Color.Transparent;
            this.DashButton.BackColor = System.Drawing.Color.Transparent;
            this.DashButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DashButton.BorderRadius = 0;
            this.DashButton.ButtonText = "      DASHBOARD";
            this.DashButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarFirst.SetDecoration(this.DashButton, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.DashButton, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.DashButton, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarReturn.SetDecoration(this.DashButton, BunifuAnimatorNS.DecorationType.None);
            this.DashButton.DisabledColor = System.Drawing.Color.Transparent;
            this.DashButton.Iconcolor = System.Drawing.Color.Transparent;
            this.DashButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("DashButton.Iconimage")));
            this.DashButton.Iconimage_right = null;
            this.DashButton.Iconimage_right_Selected = null;
            this.DashButton.Iconimage_Selected = null;
            this.DashButton.IconMarginLeft = 0;
            this.DashButton.IconMarginRight = 0;
            this.DashButton.IconRightVisible = true;
            this.DashButton.IconRightZoom = 0D;
            this.DashButton.IconVisible = true;
            this.DashButton.IconZoom = 50D;
            this.DashButton.IsTab = false;
            this.DashButton.Location = new System.Drawing.Point(9, 91);
            this.DashButton.Name = "DashButton";
            this.DashButton.Normalcolor = System.Drawing.Color.Transparent;
            this.DashButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.DashButton.OnHoverTextColor = System.Drawing.Color.White;
            this.DashButton.selected = false;
            this.DashButton.Size = new System.Drawing.Size(252, 51);
            this.DashButton.TabIndex = 8;
            this.DashButton.Text = "      DASHBOARD";
            this.DashButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashButton.Textcolor = System.Drawing.Color.White;
            this.DashButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimationSidebarReturn.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarFirst.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(7, 68);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(52, 1);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarFirst.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarReturn.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Juicy Swapper";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "      ACCOUNT";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarFirst.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarReturn.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(9, 301);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(252, 51);
            this.bunifuFlatButton1.TabIndex = 17;
            this.bunifuFlatButton1.Text = "      ACCOUNT";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this.Sidebar;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.AnimacionSidebar.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 1F;
            this.AnimacionSidebar.DefaultAnimation = animation6;
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.AnimacionSidebarBack.Cursor = null;
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 0F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(0);
            animation7.RotateCoeff = 0F;
            animation7.RotateLimit = 0F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 1F;
            this.AnimacionSidebarBack.DefaultAnimation = animation7;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Sidebar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // MoveToDash
            // 
            this.MoveToDash.Interval = 1;
            // 
            // MoveToSkin
            // 
            this.MoveToSkin.Interval = 1;
            // 
            // MoveToBack
            // 
            this.MoveToBack.Interval = 1;
            // 
            // MoveToPick
            // 
            this.MoveToPick.Interval = 1;
            // 
            // MoveToEmote
            // 
            this.MoveToEmote.Interval = 1;
            // 
            // MoveToWraps
            // 
            this.MoveToWraps.Interval = 1;
            // 
            // MoveToSettings
            // 
            this.MoveToSettings.Interval = 1;
            // 
            // AnimacionSidebarFirst
            // 
            this.AnimacionSidebarFirst.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.AnimacionSidebarFirst.Cursor = null;
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 1F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 0;
            animation8.Padding = new System.Windows.Forms.Padding(0);
            animation8.RotateCoeff = 0F;
            animation8.RotateLimit = 0F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 0F;
            animation8.TransparencyCoeff = 1F;
            this.AnimacionSidebarFirst.DefaultAnimation = animation8;
            // 
            // AnimationSidebarReturn
            // 
            this.AnimationSidebarReturn.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.AnimationSidebarReturn.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 1F;
            this.AnimationSidebarReturn.DefaultAnimation = animation5;
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.Wrapper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnimationSidebarReturn.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarFirst.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(90, 0);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(872, 462);
            this.Wrapper.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 462);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SidebarWrapper);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarReturn.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarFirst.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.SidebarWrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidebarWrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuFlatButton SettingsButton;
        private System.Windows.Forms.PictureBox ControlBar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuFlatButton WrapsButton;
        private Bunifu.Framework.UI.BunifuFlatButton SkinButton;
        private Bunifu.Framework.UI.BunifuFlatButton DashButton;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarFirst;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimationSidebarReturn;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer MoveToDash;
        private System.Windows.Forms.Timer MoveToSkin;
        private System.Windows.Forms.Timer MoveToBack;
        private System.Windows.Forms.Timer MoveToPick;
        private System.Windows.Forms.Timer MoveToEmote;
        private System.Windows.Forms.Timer MoveToWraps;
        private System.Windows.Forms.Timer MoveToSettings;
        private System.Windows.Forms.Panel Wrapper;
    }
}