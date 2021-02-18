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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.UpdateBtn = new System.Windows.Forms.PictureBox();
            this.DiscordBtn = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscordBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.Location = new System.Drawing.Point(285, 151);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(119, 22);
            this.UpdateBtn.TabIndex = 10;
            this.UpdateBtn.TabStop = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DiscordBtn
            // 
            this.DiscordBtn.BackColor = System.Drawing.Color.Transparent;
            this.DiscordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiscordBtn.Location = new System.Drawing.Point(156, 151);
            this.DiscordBtn.Name = "DiscordBtn";
            this.DiscordBtn.Size = new System.Drawing.Size(119, 22);
            this.DiscordBtn.TabIndex = 11;
            this.DiscordBtn.TabStop = false;
            this.DiscordBtn.Click += new System.EventHandler(this.DiscordBtn_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Location = new System.Drawing.Point(77, 151);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(69, 22);
            this.Close.TabIndex = 12;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(417, 187);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.DiscordBtn);
            this.Controls.Add(this.UpdateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Available";
            this.Load += new System.EventHandler(this.DevMode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpdateBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscordBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox UpdateBtn;
        private System.Windows.Forms.PictureBox DiscordBtn;
        private System.Windows.Forms.PictureBox Close;
    }
}