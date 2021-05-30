namespace JuicySwapper.Main.GUI
{
    partial class SettingsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsMenu));
            this.ResetConfigBtn = new System.Windows.Forms.PictureBox();
            this.ConvertitemsBtn = new System.Windows.Forms.PictureBox();
            this.Backupverifybtn = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MusicSwitch = new System.Windows.Forms.PictureBox();
            this.selectPakPathButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ResetConfigBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConvertitemsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Backupverifybtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPakPathButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ResetConfigBtn
            // 
            this.ResetConfigBtn.BackColor = System.Drawing.Color.Transparent;
            this.ResetConfigBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetConfigBtn.Location = new System.Drawing.Point(8, 97);
            this.ResetConfigBtn.Name = "ResetConfigBtn";
            this.ResetConfigBtn.Size = new System.Drawing.Size(155, 22);
            this.ResetConfigBtn.TabIndex = 6;
            this.ResetConfigBtn.TabStop = false;
            this.ResetConfigBtn.Click += new System.EventHandler(this.ResetConfigBtn_Click);
            // 
            // ConvertitemsBtn
            // 
            this.ConvertitemsBtn.BackColor = System.Drawing.Color.Transparent;
            this.ConvertitemsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConvertitemsBtn.Location = new System.Drawing.Point(249, 97);
            this.ConvertitemsBtn.Name = "ConvertitemsBtn";
            this.ConvertitemsBtn.Size = new System.Drawing.Size(155, 22);
            this.ConvertitemsBtn.TabIndex = 7;
            this.ConvertitemsBtn.TabStop = false;
            this.ConvertitemsBtn.Click += new System.EventHandler(this.ConvertitemsBtn_Click);
            // 
            // Backupverifybtn
            // 
            this.Backupverifybtn.BackColor = System.Drawing.Color.Transparent;
            this.Backupverifybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Backupverifybtn.Location = new System.Drawing.Point(247, 132);
            this.Backupverifybtn.Name = "Backupverifybtn";
            this.Backupverifybtn.Size = new System.Drawing.Size(155, 22);
            this.Backupverifybtn.TabIndex = 9;
            this.Backupverifybtn.TabStop = false;
            this.Backupverifybtn.Click += new System.EventHandler(this.Backupverifybtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Location = new System.Drawing.Point(172, 132);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(69, 22);
            this.CloseBtn.TabIndex = 10;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "PlaceHolder";
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // MusicSwitch
            // 
            this.MusicSwitch.BackColor = System.Drawing.Color.Transparent;
            this.MusicSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MusicSwitch.Image = ((System.Drawing.Image)(resources.GetObject("MusicSwitch.Image")));
            this.MusicSwitch.Location = new System.Drawing.Point(7, 131);
            this.MusicSwitch.Name = "MusicSwitch";
            this.MusicSwitch.Size = new System.Drawing.Size(157, 24);
            this.MusicSwitch.TabIndex = 8;
            this.MusicSwitch.TabStop = false;
            this.MusicSwitch.Click += new System.EventHandler(this.MusicSwitch_Click);
            // 
            // selectPakPathButton
            // 
            this.selectPakPathButton.BackColor = System.Drawing.Color.Transparent;
            this.selectPakPathButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectPakPathButton.Location = new System.Drawing.Point(7, 59);
            this.selectPakPathButton.Name = "selectPakPathButton";
            this.selectPakPathButton.Size = new System.Drawing.Size(35, 28);
            this.selectPakPathButton.TabIndex = 12;
            this.selectPakPathButton.TabStop = false;
            this.selectPakPathButton.Click += new System.EventHandler(this.selectPakPathButton_Click);
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(412, 168);
            this.Controls.Add(this.selectPakPathButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.Backupverifybtn);
            this.Controls.Add(this.MusicSwitch);
            this.Controls.Add(this.ConvertitemsBtn);
            this.Controls.Add(this.ResetConfigBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ResetConfigBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConvertitemsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Backupverifybtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPakPathButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ResetConfigBtn;
        private System.Windows.Forms.PictureBox ConvertitemsBtn;
        private System.Windows.Forms.PictureBox Backupverifybtn;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox MusicSwitch;
        private System.Windows.Forms.PictureBox selectPakPathButton;
    }
}