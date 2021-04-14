namespace JuicySwapper
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SettingsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ControlBar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.WrapsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.EmoteButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PickaxeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BackblingButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SkinButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DashButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Wrapper = new System.Windows.Forms.Panel();
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
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this.Sidebar;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.SettingsButton);
            this.Sidebar.Controls.Add(this.ControlBar);
            this.Sidebar.Controls.Add(this.label1);
            this.Sidebar.Controls.Add(this.bunifuImageButton2);
            this.Sidebar.Controls.Add(this.WrapsButton);
            this.Sidebar.Controls.Add(this.EmoteButton);
            this.Sidebar.Controls.Add(this.PickaxeButton);
            this.Sidebar.Controls.Add(this.BackblingButton);
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
            this.Sidebar.Size = new System.Drawing.Size(68, 573);
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
            this.SettingsButton.Location = new System.Drawing.Point(9, 511);
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
            this.SettingsButton.Click += new System.EventHandler(this.displaySettings_Click);
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
            this.bunifuImageButton2.Click += new System.EventHandler(this.MenuSidebar_Click);
            // 
            // WrapsButton
            // 
            this.WrapsButton.Activecolor = System.Drawing.Color.Transparent;
            this.WrapsButton.BackColor = System.Drawing.Color.Transparent;
            this.WrapsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WrapsButton.BorderRadius = 0;
            this.WrapsButton.ButtonText = "      MISC";
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
            this.WrapsButton.Location = new System.Drawing.Point(9, 441);
            this.WrapsButton.Name = "WrapsButton";
            this.WrapsButton.Normalcolor = System.Drawing.Color.Transparent;
            this.WrapsButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.WrapsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.WrapsButton.selected = false;
            this.WrapsButton.Size = new System.Drawing.Size(252, 51);
            this.WrapsButton.TabIndex = 13;
            this.WrapsButton.Text = "      MISC";
            this.WrapsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WrapsButton.Textcolor = System.Drawing.Color.White;
            this.WrapsButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrapsButton.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // EmoteButton
            // 
            this.EmoteButton.Activecolor = System.Drawing.Color.Transparent;
            this.EmoteButton.BackColor = System.Drawing.Color.Transparent;
            this.EmoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EmoteButton.BorderRadius = 0;
            this.EmoteButton.ButtonText = "      EMOTES";
            this.EmoteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarFirst.SetDecoration(this.EmoteButton, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.EmoteButton, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.EmoteButton, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarReturn.SetDecoration(this.EmoteButton, BunifuAnimatorNS.DecorationType.None);
            this.EmoteButton.DisabledColor = System.Drawing.Color.Transparent;
            this.EmoteButton.Iconcolor = System.Drawing.Color.Transparent;
            this.EmoteButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("EmoteButton.Iconimage")));
            this.EmoteButton.Iconimage_right = null;
            this.EmoteButton.Iconimage_right_Selected = null;
            this.EmoteButton.Iconimage_Selected = null;
            this.EmoteButton.IconMarginLeft = 0;
            this.EmoteButton.IconMarginRight = 0;
            this.EmoteButton.IconRightVisible = true;
            this.EmoteButton.IconRightZoom = 0D;
            this.EmoteButton.IconVisible = true;
            this.EmoteButton.IconZoom = 50D;
            this.EmoteButton.IsTab = false;
            this.EmoteButton.Location = new System.Drawing.Point(9, 371);
            this.EmoteButton.Name = "EmoteButton";
            this.EmoteButton.Normalcolor = System.Drawing.Color.Transparent;
            this.EmoteButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.EmoteButton.OnHoverTextColor = System.Drawing.Color.White;
            this.EmoteButton.selected = false;
            this.EmoteButton.Size = new System.Drawing.Size(252, 51);
            this.EmoteButton.TabIndex = 12;
            this.EmoteButton.Text = "      EMOTES";
            this.EmoteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmoteButton.Textcolor = System.Drawing.Color.White;
            this.EmoteButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmoteButton.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // PickaxeButton
            // 
            this.PickaxeButton.Activecolor = System.Drawing.Color.Transparent;
            this.PickaxeButton.BackColor = System.Drawing.Color.Transparent;
            this.PickaxeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PickaxeButton.BorderRadius = 0;
            this.PickaxeButton.ButtonText = "      PICKAXES";
            this.PickaxeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarFirst.SetDecoration(this.PickaxeButton, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.PickaxeButton, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.PickaxeButton, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarReturn.SetDecoration(this.PickaxeButton, BunifuAnimatorNS.DecorationType.None);
            this.PickaxeButton.DisabledColor = System.Drawing.Color.Transparent;
            this.PickaxeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.PickaxeButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("PickaxeButton.Iconimage")));
            this.PickaxeButton.Iconimage_right = null;
            this.PickaxeButton.Iconimage_right_Selected = null;
            this.PickaxeButton.Iconimage_Selected = null;
            this.PickaxeButton.IconMarginLeft = 0;
            this.PickaxeButton.IconMarginRight = 0;
            this.PickaxeButton.IconRightVisible = true;
            this.PickaxeButton.IconRightZoom = 0D;
            this.PickaxeButton.IconVisible = true;
            this.PickaxeButton.IconZoom = 50D;
            this.PickaxeButton.IsTab = false;
            this.PickaxeButton.Location = new System.Drawing.Point(9, 301);
            this.PickaxeButton.Name = "PickaxeButton";
            this.PickaxeButton.Normalcolor = System.Drawing.Color.Transparent;
            this.PickaxeButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.PickaxeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.PickaxeButton.selected = false;
            this.PickaxeButton.Size = new System.Drawing.Size(252, 51);
            this.PickaxeButton.TabIndex = 11;
            this.PickaxeButton.Text = "      PICKAXES";
            this.PickaxeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PickaxeButton.Textcolor = System.Drawing.Color.White;
            this.PickaxeButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickaxeButton.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // BackblingButton
            // 
            this.BackblingButton.Activecolor = System.Drawing.Color.Transparent;
            this.BackblingButton.BackColor = System.Drawing.Color.Transparent;
            this.BackblingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackblingButton.BorderRadius = 0;
            this.BackblingButton.ButtonText = "      BACKBLINGS";
            this.BackblingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarFirst.SetDecoration(this.BackblingButton, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.BackblingButton, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.BackblingButton, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarReturn.SetDecoration(this.BackblingButton, BunifuAnimatorNS.DecorationType.None);
            this.BackblingButton.DisabledColor = System.Drawing.Color.Transparent;
            this.BackblingButton.Iconcolor = System.Drawing.Color.Transparent;
            this.BackblingButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("BackblingButton.Iconimage")));
            this.BackblingButton.Iconimage_right = null;
            this.BackblingButton.Iconimage_right_Selected = null;
            this.BackblingButton.Iconimage_Selected = null;
            this.BackblingButton.IconMarginLeft = 0;
            this.BackblingButton.IconMarginRight = 0;
            this.BackblingButton.IconRightVisible = true;
            this.BackblingButton.IconRightZoom = 0D;
            this.BackblingButton.IconVisible = true;
            this.BackblingButton.IconZoom = 50D;
            this.BackblingButton.IsTab = false;
            this.BackblingButton.Location = new System.Drawing.Point(9, 231);
            this.BackblingButton.Name = "BackblingButton";
            this.BackblingButton.Normalcolor = System.Drawing.Color.Transparent;
            this.BackblingButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.BackblingButton.OnHoverTextColor = System.Drawing.Color.White;
            this.BackblingButton.selected = false;
            this.BackblingButton.Size = new System.Drawing.Size(252, 51);
            this.BackblingButton.TabIndex = 10;
            this.BackblingButton.Text = "      BACKBLINGS";
            this.BackblingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackblingButton.Textcolor = System.Drawing.Color.White;
            this.BackblingButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackblingButton.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // SkinButton
            // 
            this.SkinButton.Activecolor = System.Drawing.Color.Transparent;
            this.SkinButton.BackColor = System.Drawing.Color.Transparent;
            this.SkinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SkinButton.BorderRadius = 0;
            this.SkinButton.ButtonText = "      SKINS";
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
            this.SkinButton.Text = "      SKINS";
            this.SkinButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SkinButton.Textcolor = System.Drawing.Color.White;
            this.SkinButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkinButton.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
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
            this.DashButton.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
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
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.AnimacionSidebar.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this.AnimacionSidebar.DefaultAnimation = animation3;
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
            this.SidebarWrapper.Size = new System.Drawing.Size(90, 609);
            this.SidebarWrapper.TabIndex = 1;
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
            this.Wrapper.Size = new System.Drawing.Size(931, 609);
            this.Wrapper.TabIndex = 2;
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.AnimacionSidebarBack.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.AnimacionSidebarBack.DefaultAnimation = animation2;
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
            this.MoveToDash.Tick += new System.EventHandler(this.MoveToDash_Tick);
            // 
            // MoveToSkin
            // 
            this.MoveToSkin.Interval = 1;
            this.MoveToSkin.Tick += new System.EventHandler(this.MoveToSkin_Tick);
            // 
            // MoveToBack
            // 
            this.MoveToBack.Interval = 1;
            this.MoveToBack.Tick += new System.EventHandler(this.MoveToBack_Tick);
            // 
            // MoveToPick
            // 
            this.MoveToPick.Interval = 1;
            this.MoveToPick.Tick += new System.EventHandler(this.MoveToPick_Tick);
            // 
            // MoveToEmote
            // 
            this.MoveToEmote.Interval = 1;
            this.MoveToEmote.Tick += new System.EventHandler(this.MoveToEmote_Tick);
            // 
            // MoveToWraps
            // 
            this.MoveToWraps.Interval = 1;
            this.MoveToWraps.Tick += new System.EventHandler(this.MoveToWraps_Tick);
            // 
            // MoveToSettings
            // 
            this.MoveToSettings.Interval = 1;
            this.MoveToSettings.Tick += new System.EventHandler(this.MoveToSettings_Tick);
            // 
            // AnimacionSidebarFirst
            // 
            this.AnimacionSidebarFirst.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.AnimacionSidebarFirst.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.AnimacionSidebarFirst.DefaultAnimation = animation1;
            // 
            // AnimationSidebarReturn
            // 
            this.AnimationSidebarReturn.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.AnimationSidebarReturn.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 1F;
            this.AnimationSidebarReturn.DefaultAnimation = animation4;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1021, 609);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SidebarWrapper);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarReturn.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarFirst.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juicy Swapper";
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel SidebarWrapper;
        private System.Windows.Forms.Timer MoveToDash;
        private System.Windows.Forms.Timer MoveToSkin;
        private System.Windows.Forms.Timer MoveToBack;
        private System.Windows.Forms.Timer MoveToPick;
        private System.Windows.Forms.Timer MoveToEmote;
        private System.Windows.Forms.Timer MoveToWraps;
        private System.Windows.Forms.Timer MoveToSettings;
        private System.Windows.Forms.Panel Wrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuFlatButton SettingsButton;
        private System.Windows.Forms.PictureBox ControlBar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuFlatButton WrapsButton;
        private Bunifu.Framework.UI.BunifuFlatButton EmoteButton;
        private Bunifu.Framework.UI.BunifuFlatButton PickaxeButton;
        private Bunifu.Framework.UI.BunifuFlatButton BackblingButton;
        private Bunifu.Framework.UI.BunifuFlatButton SkinButton;
        private Bunifu.Framework.UI.BunifuFlatButton DashButton;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label label2;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarFirst;
        private BunifuAnimatorNS.BunifuTransition AnimationSidebarReturn;
    }
}

