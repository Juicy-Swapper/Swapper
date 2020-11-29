namespace JuicySwapper.Main.GUI
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.formCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.formDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.updateBtnCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.discordBtnCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dialogHeaderDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.msgDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.discordButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.updateButton = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Update Available";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 175);
            this.label2.TabIndex = 6;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(435, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 14);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 22;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 10;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
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
            this.Sidebar.Location = new System.Drawing.Point(-7, -7);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(79, 288);
            this.Sidebar.TabIndex = 23;
            // 
            // formCurving
            // 
            this.formCurving.ElipseRadius = 7;
            this.formCurving.TargetControl = this;
            // 
            // formDragControl
            // 
            this.formDragControl.Fixed = true;
            this.formDragControl.Horizontal = true;
            this.formDragControl.TargetControl = this;
            this.formDragControl.Vertical = true;
            // 
            // updateBtnCurving
            // 
            this.updateBtnCurving.ElipseRadius = 7;
            this.updateBtnCurving.TargetControl = this.updateButton;
            // 
            // discordBtnCurving
            // 
            this.discordBtnCurving.ElipseRadius = 7;
            this.discordBtnCurving.TargetControl = this.discordButton;
            // 
            // dialogHeaderDragControl
            // 
            this.dialogHeaderDragControl.Fixed = true;
            this.dialogHeaderDragControl.Horizontal = true;
            this.dialogHeaderDragControl.TargetControl = this.label1;
            this.dialogHeaderDragControl.Vertical = true;
            // 
            // msgDragControl
            // 
            this.msgDragControl.Fixed = true;
            this.msgDragControl.Horizontal = true;
            this.msgDragControl.TargetControl = this.label2;
            this.msgDragControl.Vertical = true;
            // 
            // discordButton
            // 
            this.discordButton.Activecolor = System.Drawing.Color.Transparent;
            this.discordButton.BackColor = System.Drawing.Color.Transparent;
            this.discordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("discordButton.BackgroundImage")));
            this.discordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.discordButton.BorderRadius = 0;
            this.discordButton.ButtonText = "Discord";
            this.discordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discordButton.DisabledColor = System.Drawing.Color.White;
            this.discordButton.ForeColor = System.Drawing.Color.White;
            this.discordButton.Iconcolor = System.Drawing.Color.Transparent;
            this.discordButton.Iconimage = null;
            this.discordButton.Iconimage_right = null;
            this.discordButton.Iconimage_right_Selected = null;
            this.discordButton.Iconimage_Selected = null;
            this.discordButton.IconMarginLeft = 0;
            this.discordButton.IconMarginRight = 0;
            this.discordButton.IconRightVisible = true;
            this.discordButton.IconRightZoom = 0D;
            this.discordButton.IconVisible = true;
            this.discordButton.IconZoom = 50D;
            this.discordButton.IsTab = false;
            this.discordButton.Location = new System.Drawing.Point(298, 232);
            this.discordButton.Name = "discordButton";
            this.discordButton.Normalcolor = System.Drawing.Color.Transparent;
            this.discordButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.discordButton.OnHoverTextColor = System.Drawing.Color.White;
            this.discordButton.selected = false;
            this.discordButton.Size = new System.Drawing.Size(76, 26);
            this.discordButton.TabIndex = 25;
            this.discordButton.Text = "Discord";
            this.discordButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.discordButton.Textcolor = System.Drawing.Color.White;
            this.discordButton.TextFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.discordButton.Click += new System.EventHandler(this.discordButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Activecolor = System.Drawing.Color.Transparent;
            this.updateButton.BackColor = System.Drawing.Color.Transparent;
            this.updateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateButton.BackgroundImage")));
            this.updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateButton.BorderRadius = 0;
            this.updateButton.ButtonText = "Update";
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.DisabledColor = System.Drawing.Color.White;
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Iconcolor = System.Drawing.Color.Transparent;
            this.updateButton.Iconimage = null;
            this.updateButton.Iconimage_right = null;
            this.updateButton.Iconimage_right_Selected = null;
            this.updateButton.Iconimage_Selected = null;
            this.updateButton.IconMarginLeft = 0;
            this.updateButton.IconMarginRight = 0;
            this.updateButton.IconRightVisible = true;
            this.updateButton.IconRightZoom = 0D;
            this.updateButton.IconVisible = true;
            this.updateButton.IconZoom = 50D;
            this.updateButton.IsTab = false;
            this.updateButton.Location = new System.Drawing.Point(380, 232);
            this.updateButton.Name = "updateButton";
            this.updateButton.Normalcolor = System.Drawing.Color.Transparent;
            this.updateButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.updateButton.OnHoverTextColor = System.Drawing.Color.White;
            this.updateButton.selected = false;
            this.updateButton.Size = new System.Drawing.Size(76, 26);
            this.updateButton.TabIndex = 24;
            this.updateButton.Text = "Update";
            this.updateButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updateButton.Textcolor = System.Drawing.Color.White;
            this.updateButton.TextFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(468, 270);
            this.Controls.Add(this.discordButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Available";
            this.Load += new System.EventHandler(this.DevMode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuElipse formCurving;
        private Bunifu.Framework.UI.BunifuFlatButton discordButton;
        private Bunifu.Framework.UI.BunifuFlatButton updateButton;
        private Bunifu.Framework.UI.BunifuDragControl formDragControl;
        private Bunifu.Framework.UI.BunifuElipse updateBtnCurving;
        private Bunifu.Framework.UI.BunifuElipse discordBtnCurving;
        private Bunifu.Framework.UI.BunifuDragControl dialogHeaderDragControl;
        private Bunifu.Framework.UI.BunifuDragControl msgDragControl;
    }
}