
namespace JuicyIndustries_Launcher
{
    partial class SignUP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUP));
            this.ExitSwapper = new System.Windows.Forms.PictureBox();
            this.PaidLogin = new System.Windows.Forms.PictureBox();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.ExitSwapper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaidLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitSwapper
            // 
            this.ExitSwapper.BackColor = System.Drawing.Color.Transparent;
            this.ExitSwapper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitSwapper.Location = new System.Drawing.Point(800, 493);
            this.ExitSwapper.Name = "ExitSwapper";
            this.ExitSwapper.Size = new System.Drawing.Size(155, 22);
            this.ExitSwapper.TabIndex = 19;
            this.ExitSwapper.TabStop = false;
            this.ExitSwapper.Click += new System.EventHandler(this.ExitSwapper_Click);
            // 
            // PaidLogin
            // 
            this.PaidLogin.BackColor = System.Drawing.Color.Transparent;
            this.PaidLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaidLogin.Location = new System.Drawing.Point(738, 297);
            this.PaidLogin.Name = "PaidLogin";
            this.PaidLogin.Size = new System.Drawing.Size(155, 22);
            this.PaidLogin.TabIndex = 17;
            this.PaidLogin.TabStop = false;
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
            this.password.Location = new System.Drawing.Point(579, 235);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(232, 33);
            this.password.TabIndex = 21;
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
            this.Username.Location = new System.Drawing.Point(580, 194);
            this.Username.Margin = new System.Windows.Forms.Padding(4);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(232, 33);
            this.Username.TabIndex = 20;
            this.Username.TabStop = false;
            this.Username.Text = "Enter a username...";
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SignUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(966, 530);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.ExitSwapper);
            this.Controls.Add(this.PaidLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUP";
            ((System.ComponentModel.ISupportInitialize)(this.ExitSwapper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaidLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ExitSwapper;
        private System.Windows.Forms.PictureBox PaidLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Username;
    }
}