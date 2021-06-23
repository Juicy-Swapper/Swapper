
namespace JuicySwapper_Launcher.Main.GUI
{
    partial class NewsTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewsTab));
            this.JuicyNews = new System.Windows.Forms.PictureBox();
            this.FortniteNews = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.JuicyNews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FortniteNews)).BeginInit();
            this.SuspendLayout();
            // 
            // JuicyNews
            // 
            this.JuicyNews.BackColor = System.Drawing.Color.Transparent;
            this.JuicyNews.Location = new System.Drawing.Point(38, 299);
            this.JuicyNews.Name = "JuicyNews";
            this.JuicyNews.Size = new System.Drawing.Size(377, 190);
            this.JuicyNews.TabIndex = 0;
            this.JuicyNews.TabStop = false;
            // 
            // FortniteNews
            // 
            this.FortniteNews.BackColor = System.Drawing.Color.Transparent;
            this.FortniteNews.Location = new System.Drawing.Point(38, 53);
            this.FortniteNews.Name = "FortniteNews";
            this.FortniteNews.Size = new System.Drawing.Size(377, 190);
            this.FortniteNews.TabIndex = 1;
            this.FortniteNews.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // NewsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.FortniteNews);
            this.Controls.Add(this.JuicyNews);
            this.Name = "NewsTab";
            this.Size = new System.Drawing.Size(815, 520);
            ((System.ComponentModel.ISupportInitialize)(this.JuicyNews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FortniteNews)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox JuicyNews;
        private System.Windows.Forms.PictureBox FortniteNews;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
