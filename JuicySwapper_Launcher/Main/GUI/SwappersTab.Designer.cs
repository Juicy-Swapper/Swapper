
namespace JuicySwapper_Launcher.Main
{
    partial class SwappersTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwappersTab));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SwapperLauncher = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SwapperLauncherDefault = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.SwapperLauncher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwapperLauncherDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.SwapperLauncher;
            // 
            // SwapperLauncher
            // 
            this.SwapperLauncher.BackColor = System.Drawing.Color.Transparent;
            this.SwapperLauncher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwapperLauncher.Image = ((System.Drawing.Image)(resources.GetObject("SwapperLauncher.Image")));
            this.SwapperLauncher.ImageActive = null;
            this.SwapperLauncher.Location = new System.Drawing.Point(41, 77);
            this.SwapperLauncher.Name = "SwapperLauncher";
            this.SwapperLauncher.Size = new System.Drawing.Size(200, 375);
            this.SwapperLauncher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SwapperLauncher.TabIndex = 49;
            this.SwapperLauncher.TabStop = false;
            this.SwapperLauncher.Zoom = 2;
            this.SwapperLauncher.Click += new System.EventHandler(this.SwapperLauncher_Click);
            this.SwapperLauncher.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SwapperLauncher_MouseClick);
            this.SwapperLauncher.MouseEnter += new System.EventHandler(this.SwapperLauncher_MouseEnter);
            this.SwapperLauncher.MouseLeave += new System.EventHandler(this.SwapperLauncher_MouseLeave);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.SwapperLauncherDefault;
            // 
            // SwapperLauncherDefault
            // 
            this.SwapperLauncherDefault.BackColor = System.Drawing.Color.Transparent;
            this.SwapperLauncherDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwapperLauncherDefault.Image = ((System.Drawing.Image)(resources.GetObject("SwapperLauncherDefault.Image")));
            this.SwapperLauncherDefault.ImageActive = null;
            this.SwapperLauncherDefault.Location = new System.Drawing.Point(303, 77);
            this.SwapperLauncherDefault.Name = "SwapperLauncherDefault";
            this.SwapperLauncherDefault.Size = new System.Drawing.Size(200, 375);
            this.SwapperLauncherDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SwapperLauncherDefault.TabIndex = 50;
            this.SwapperLauncherDefault.TabStop = false;
            this.SwapperLauncherDefault.Zoom = 2;
            this.SwapperLauncherDefault.MouseEnter += new System.EventHandler(this.SwapperLauncherDefault_MouseEnter);
            this.SwapperLauncherDefault.MouseLeave += new System.EventHandler(this.SwapperLauncherDefault_MouseLeave);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 15;
            this.bunifuElipse3.TargetControl = this.bunifuImageButton1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(571, 77);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(200, 375);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 51;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 2;
            // 
            // SwappersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.SwapperLauncherDefault);
            this.Controls.Add(this.SwapperLauncher);
            this.Name = "SwappersTab";
            this.Size = new System.Drawing.Size(815, 520);
            ((System.ComponentModel.ISupportInitialize)(this.SwapperLauncher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwapperLauncherDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton SwapperLauncher;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton SwapperLauncherDefault;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}
