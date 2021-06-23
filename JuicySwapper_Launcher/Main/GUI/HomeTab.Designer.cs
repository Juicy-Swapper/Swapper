
namespace JuicySwapper_Launcher.Main.GUI
{
    partial class HomeTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeTab));
            this.UserInformationsLabel = new System.Windows.Forms.Label();
            this.DownloadInformationsLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SuspendLayout();
            // 
            // UserInformationsLabel
            // 
            this.UserInformationsLabel.AutoSize = true;
            this.UserInformationsLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserInformationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInformationsLabel.ForeColor = System.Drawing.Color.White;
            this.UserInformationsLabel.Location = new System.Drawing.Point(116, 44);
            this.UserInformationsLabel.Name = "UserInformationsLabel";
            this.UserInformationsLabel.Size = new System.Drawing.Size(14, 13);
            this.UserInformationsLabel.TabIndex = 3;
            this.UserInformationsLabel.Text = "0";
            // 
            // DownloadInformationsLabel
            // 
            this.DownloadInformationsLabel.AutoSize = true;
            this.DownloadInformationsLabel.BackColor = System.Drawing.Color.Transparent;
            this.DownloadInformationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadInformationsLabel.ForeColor = System.Drawing.Color.White;
            this.DownloadInformationsLabel.Location = new System.Drawing.Point(304, 44);
            this.DownloadInformationsLabel.Name = "DownloadInformationsLabel";
            this.DownloadInformationsLabel.Size = new System.Drawing.Size(14, 13);
            this.DownloadInformationsLabel.TabIndex = 4;
            this.DownloadInformationsLabel.Text = "0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(628, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(184, 446);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // HomeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.DownloadInformationsLabel);
            this.Controls.Add(this.UserInformationsLabel);
            this.Name = "HomeTab";
            this.Size = new System.Drawing.Size(815, 520);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserInformationsLabel;
        private System.Windows.Forms.Label DownloadInformationsLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
