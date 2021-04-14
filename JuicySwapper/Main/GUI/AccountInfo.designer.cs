
namespace JuicySwapper
{
    partial class AccountInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountInfo));
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.CreatedAT = new System.Windows.Forms.Label();
            this.hwid = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.GetInfo = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GetInfoBtn = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl4 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl5 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl6 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LogLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GetInfoBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(67, 43);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 12);
            this.username.TabIndex = 3;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(64, 67);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(0, 12);
            this.password.TabIndex = 4;
            // 
            // CreatedAT
            // 
            this.CreatedAT.AutoSize = true;
            this.CreatedAT.BackColor = System.Drawing.Color.Transparent;
            this.CreatedAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatedAT.ForeColor = System.Drawing.Color.White;
            this.CreatedAT.Location = new System.Drawing.Point(64, 91);
            this.CreatedAT.Name = "CreatedAT";
            this.CreatedAT.Size = new System.Drawing.Size(0, 12);
            this.CreatedAT.TabIndex = 5;
            // 
            // hwid
            // 
            this.hwid.AutoSize = true;
            this.hwid.BackColor = System.Drawing.Color.Transparent;
            this.hwid.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hwid.ForeColor = System.Drawing.Color.White;
            this.hwid.Location = new System.Drawing.Point(46, 115);
            this.hwid.Name = "hwid";
            this.hwid.Size = new System.Drawing.Size(0, 12);
            this.hwid.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.Color.Transparent;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.White;
            this.ID.Location = new System.Drawing.Point(28, 139);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(0, 12);
            this.ID.TabIndex = 7;
            // 
            // GetInfo
            // 
            this.GetInfo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.GetInfo_DoWork);
            // 
            // GetInfoBtn
            // 
            this.GetInfoBtn.BackColor = System.Drawing.Color.Transparent;
            this.GetInfoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetInfoBtn.Location = new System.Drawing.Point(171, 182);
            this.GetInfoBtn.Name = "GetInfoBtn";
            this.GetInfoBtn.Size = new System.Drawing.Size(155, 22);
            this.GetInfoBtn.TabIndex = 10;
            this.GetInfoBtn.TabStop = false;
            this.GetInfoBtn.Click += new System.EventHandler(this.GetInfoBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Location = new System.Drawing.Point(336, 182);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(69, 22);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
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
            this.bunifuDragControl1.TargetControl = this.CreatedAT;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.hwid;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.ID;
            this.bunifuDragControl3.Vertical = true;
            // 
            // bunifuDragControl4
            // 
            this.bunifuDragControl4.Fixed = true;
            this.bunifuDragControl4.Horizontal = true;
            this.bunifuDragControl4.TargetControl = this.password;
            this.bunifuDragControl4.Vertical = true;
            // 
            // bunifuDragControl5
            // 
            this.bunifuDragControl5.Fixed = true;
            this.bunifuDragControl5.Horizontal = true;
            this.bunifuDragControl5.TargetControl = this.username;
            this.bunifuDragControl5.Vertical = true;
            // 
            // bunifuDragControl6
            // 
            this.bunifuDragControl6.Fixed = true;
            this.bunifuDragControl6.Horizontal = true;
            this.bunifuDragControl6.TargetControl = this;
            this.bunifuDragControl6.Vertical = true;
            // 
            // LogLable
            // 
            this.LogLable.AutoSize = true;
            this.LogLable.BackColor = System.Drawing.Color.Transparent;
            this.LogLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogLable.ForeColor = System.Drawing.Color.White;
            this.LogLable.Location = new System.Drawing.Point(30, 163);
            this.LogLable.Name = "LogLable";
            this.LogLable.Size = new System.Drawing.Size(0, 12);
            this.LogLable.TabIndex = 12;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(410, 210);
            this.Controls.Add(this.LogLable);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.GetInfoBtn);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.hwid);
            this.Controls.Add(this.CreatedAT);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JuicySwapper-Accounts";
            ((System.ComponentModel.ISupportInitialize)(this.GetInfoBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label CreatedAT;
        private System.Windows.Forms.Label hwid;
        private System.Windows.Forms.Label ID;
        private System.ComponentModel.BackgroundWorker GetInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox GetInfoBtn;
        private System.Windows.Forms.PictureBox ExitBtn;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl4;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl5;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl6;
        private System.Windows.Forms.Label LogLable;
    }
}

