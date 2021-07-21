namespace JuicySwapper_Installer.Main.GUI
{
    partial class Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.RoundForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ProgressBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Downloader = new System.ComponentModel.BackgroundWorker();
            this.DownloaderUpdater = new System.ComponentModel.BackgroundWorker();
            this.InformationsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RoundForm
            // 
            this.RoundForm.ElipseRadius = 5;
            this.RoundForm.TargetControl = this;
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ProgressBar.BorderRadius = 5;
            this.ProgressBar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProgressBar.Location = new System.Drawing.Point(12, 163);
            this.ProgressBar.MaximumValue = 100;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProgressBar.Size = new System.Drawing.Size(382, 22);
            this.ProgressBar.TabIndex = 0;
            this.ProgressBar.Value = 0;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this;
            this.DragControl.Vertical = true;
            // 
            // Downloader
            // 
            this.Downloader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Downloader_DoWork);
            // 
            // DownloaderUpdater
            // 
            this.DownloaderUpdater.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DownloaderUpdater_DoWork);
            // 
            // InformationsLabel
            // 
            this.InformationsLabel.AutoSize = true;
            this.InformationsLabel.BackColor = System.Drawing.Color.Transparent;
            this.InformationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationsLabel.ForeColor = System.Drawing.Color.White;
            this.InformationsLabel.Location = new System.Drawing.Point(12, 148);
            this.InformationsLabel.Name = "InformationsLabel";
            this.InformationsLabel.Size = new System.Drawing.Size(0, 12);
            this.InformationsLabel.TabIndex = 2;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(406, 207);
            this.Controls.Add(this.InformationsLabel);
            this.Controls.Add(this.ProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JuicySwapper - Installer";
            this.Load += new System.EventHandler(this.Setup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse RoundForm;
        private Bunifu.Framework.UI.BunifuProgressBar ProgressBar;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.ComponentModel.BackgroundWorker Downloader;
        private System.ComponentModel.BackgroundWorker DownloaderUpdater;
        private System.Windows.Forms.Label InformationsLabel;
    }
}