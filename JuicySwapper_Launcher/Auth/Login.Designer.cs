
namespace JuicyIndustries_Launcher
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Exit = new System.Windows.Forms.PictureBox();
            this.NitroLogin = new System.Windows.Forms.PictureBox();
            this.SignUp = new System.Windows.Forms.PictureBox();
            this.LoginFree = new System.Windows.Forms.PictureBox();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NitroLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginFree)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Location = new System.Drawing.Point(800, 493);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(155, 22);
            this.Exit.TabIndex = 17;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // NitroLogin
            // 
            this.NitroLogin.BackColor = System.Drawing.Color.Transparent;
            this.NitroLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NitroLogin.Location = new System.Drawing.Point(650, 331);
            this.NitroLogin.Name = "NitroLogin";
            this.NitroLogin.Size = new System.Drawing.Size(155, 22);
            this.NitroLogin.TabIndex = 16;
            this.NitroLogin.TabStop = false;
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.Color.Transparent;
            this.SignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUp.Location = new System.Drawing.Point(738, 297);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(155, 22);
            this.SignUp.TabIndex = 15;
            this.SignUp.TabStop = false;
            this.SignUp.Click += new System.EventHandler(this.PaidLogin_Click);
            // 
            // LoginFree
            // 
            this.LoginFree.BackColor = System.Drawing.Color.Transparent;
            this.LoginFree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginFree.Location = new System.Drawing.Point(571, 297);
            this.LoginFree.Name = "LoginFree";
            this.LoginFree.Size = new System.Drawing.Size(155, 22);
            this.LoginFree.TabIndex = 14;
            this.LoginFree.TabStop = false;
            this.LoginFree.Click += new System.EventHandler(this.LoginFree_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.HintForeColor = System.Drawing.Color.Empty;
            this.password.HintText = "";
            this.password.isPassword = false;
            this.password.LineFocusedColor = System.Drawing.Color.White;
            this.password.LineIdleColor = System.Drawing.Color.White;
            this.password.LineMouseHoverColor = System.Drawing.Color.White;
            this.password.LineThickness = 2;
            this.password.Location = new System.Drawing.Point(576, 235);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(232, 33);
            this.password.TabIndex = 19;
            this.password.TabStop = false;
            this.password.Text = "Enter a password...";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.HintForeColor = System.Drawing.Color.Empty;
            this.Username.HintText = "";
            this.Username.isPassword = false;
            this.Username.LineFocusedColor = System.Drawing.Color.White;
            this.Username.LineIdleColor = System.Drawing.Color.White;
            this.Username.LineMouseHoverColor = System.Drawing.Color.White;
            this.Username.LineThickness = 2;
            this.Username.Location = new System.Drawing.Point(577, 194);
            this.Username.Margin = new System.Windows.Forms.Padding(4);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(232, 33);
            this.Username.TabIndex = 18;
            this.Username.TabStop = false;
            this.Username.Text = "Enter a username...";
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(964, 530);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NitroLogin);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.LoginFree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NitroLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginFree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox NitroLogin;
        private System.Windows.Forms.PictureBox SignUp;
        private System.Windows.Forms.PictureBox LoginFree;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Username;
    }
}

