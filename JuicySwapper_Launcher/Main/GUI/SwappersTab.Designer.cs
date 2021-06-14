
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
            ((System.ComponentModel.ISupportInitialize)(this.SwapperLauncher)).BeginInit();
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
            // SwappersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.SwapperLauncher);
            this.Name = "SwappersTab";
            this.Size = new System.Drawing.Size(815, 520);
            ((System.ComponentModel.ISupportInitialize)(this.SwapperLauncher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton SwapperLauncher;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
