namespace JuicySwapper.Main.GUI
{
    partial class CheckIfSwapMesg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckIfSwapMesg));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.openSettingsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.confirmBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "A skin using [] is already converted.";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 50);
            this.label2.TabIndex = 6;
            this.label2.Text = "[] has been swapped for [],  \r\nif this is an error on our end, please reset confi" +
    "g in Settings.";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.openSettingsBtn;
            // 
            // openSettingsBtn
            // 
            this.openSettingsBtn.Activecolor = System.Drawing.Color.Transparent;
            this.openSettingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.openSettingsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openSettingsBtn.BackgroundImage")));
            this.openSettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openSettingsBtn.BorderRadius = 0;
            this.openSettingsBtn.ButtonText = "Settings";
            this.openSettingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openSettingsBtn.DisabledColor = System.Drawing.Color.White;
            this.openSettingsBtn.ForeColor = System.Drawing.Color.White;
            this.openSettingsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.openSettingsBtn.Iconimage = null;
            this.openSettingsBtn.Iconimage_right = null;
            this.openSettingsBtn.Iconimage_right_Selected = null;
            this.openSettingsBtn.Iconimage_Selected = null;
            this.openSettingsBtn.IconMarginLeft = 0;
            this.openSettingsBtn.IconMarginRight = 0;
            this.openSettingsBtn.IconRightVisible = true;
            this.openSettingsBtn.IconRightZoom = 0D;
            this.openSettingsBtn.IconVisible = true;
            this.openSettingsBtn.IconZoom = 50D;
            this.openSettingsBtn.IsTab = false;
            this.openSettingsBtn.Location = new System.Drawing.Point(432, 105);
            this.openSettingsBtn.Name = "openSettingsBtn";
            this.openSettingsBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.openSettingsBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.openSettingsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.openSettingsBtn.selected = false;
            this.openSettingsBtn.Size = new System.Drawing.Size(76, 26);
            this.openSettingsBtn.TabIndex = 26;
            this.openSettingsBtn.Text = "Settings";
            this.openSettingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.openSettingsBtn.Textcolor = System.Drawing.Color.White;
            this.openSettingsBtn.TextFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.openSettingsBtn.Click += new System.EventHandler(this.discordButton_Click);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this.confirmBtn;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Activecolor = System.Drawing.Color.Transparent;
            this.confirmBtn.BackColor = System.Drawing.Color.Transparent;
            this.confirmBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmBtn.BackgroundImage")));
            this.confirmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmBtn.BorderRadius = 0;
            this.confirmBtn.ButtonText = "Continue";
            this.confirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmBtn.DisabledColor = System.Drawing.Color.White;
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.confirmBtn.Iconimage = null;
            this.confirmBtn.Iconimage_right = null;
            this.confirmBtn.Iconimage_right_Selected = null;
            this.confirmBtn.Iconimage_Selected = null;
            this.confirmBtn.IconMarginLeft = 0;
            this.confirmBtn.IconMarginRight = 0;
            this.confirmBtn.IconRightVisible = true;
            this.confirmBtn.IconRightZoom = 0D;
            this.confirmBtn.IconVisible = true;
            this.confirmBtn.IconZoom = 50D;
            this.confirmBtn.IsTab = false;
            this.confirmBtn.Location = new System.Drawing.Point(515, 105);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.confirmBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.confirmBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.confirmBtn.selected = false;
            this.confirmBtn.Size = new System.Drawing.Size(76, 26);
            this.confirmBtn.TabIndex = 25;
            this.confirmBtn.Text = "Continue";
            this.confirmBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.confirmBtn.Textcolor = System.Drawing.Color.White;
            this.confirmBtn.TextFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.confirmBtn.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.label1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.label2;
            this.bunifuDragControl3.Vertical = true;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.Maroon;
            this.Sidebar.GradientBottomRight = System.Drawing.Color.Maroon;
            this.Sidebar.GradientTopLeft = System.Drawing.Color.DarkOrange;
            this.Sidebar.GradientTopRight = System.Drawing.Color.Maroon;
            this.Sidebar.Location = new System.Drawing.Point(-3, -5);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(75, 158);
            this.Sidebar.TabIndex = 23;
            // 
            // CheckIfSwapMesg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(603, 143);
            this.Controls.Add(this.openSettingsBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckIfSwapMesg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pak File Error";
            this.Load += new System.EventHandler(this.PakError_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuFlatButton openSettingsBtn;
        private Bunifu.Framework.UI.BunifuFlatButton confirmBtn;
    }
}