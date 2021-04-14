
namespace JuicySwapper.Main.GUI
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Cpassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PaidLogin = new System.Windows.Forms.PictureBox();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PaidLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            this.SuspendLayout();
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
            this.password.Location = new System.Drawing.Point(578, 235);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(232, 33);
            this.password.TabIndex = 10;
            this.password.TabStop = false;
            this.password.Text = "Enter a password...";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.Enter += new System.EventHandler(this.password_Enter);
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
            this.Username.Location = new System.Drawing.Point(579, 194);
            this.Username.Margin = new System.Windows.Forms.Padding(4);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(232, 33);
            this.Username.TabIndex = 9;
            this.Username.TabStop = false;
            this.Username.Text = "Enter a username...";
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Username.Enter += new System.EventHandler(this.username_Enter);
            // 
            // Cpassword
            // 
            this.Cpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.Cpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Cpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Cpassword.ForeColor = System.Drawing.Color.White;
            this.Cpassword.HintForeColor = System.Drawing.Color.Empty;
            this.Cpassword.HintText = "";
            this.Cpassword.isPassword = false;
            this.Cpassword.LineFocusedColor = System.Drawing.Color.White;
            this.Cpassword.LineIdleColor = System.Drawing.Color.White;
            this.Cpassword.LineMouseHoverColor = System.Drawing.Color.White;
            this.Cpassword.LineThickness = 2;
            this.Cpassword.Location = new System.Drawing.Point(579, 276);
            this.Cpassword.Margin = new System.Windows.Forms.Padding(4);
            this.Cpassword.Name = "Cpassword";
            this.Cpassword.Size = new System.Drawing.Size(232, 33);
            this.Cpassword.TabIndex = 11;
            this.Cpassword.TabStop = false;
            this.Cpassword.Text = "Confirm password...";
            this.Cpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Cpassword.Enter += new System.EventHandler(this.Cpassword_Enter);
            // 
            // PaidLogin
            // 
            this.PaidLogin.BackColor = System.Drawing.Color.Transparent;
            this.PaidLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaidLogin.Location = new System.Drawing.Point(738, 333);
            this.PaidLogin.Name = "PaidLogin";
            this.PaidLogin.Size = new System.Drawing.Size(155, 22);
            this.PaidLogin.TabIndex = 12;
            this.PaidLogin.TabStop = false;
            this.PaidLogin.Click += new System.EventHandler(this.PaidLogin_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Location = new System.Drawing.Point(799, 493);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(155, 22);
            this.BackBtn.TabIndex = 14;
            this.BackBtn.TabStop = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(966, 530);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.PaidLogin);
            this.Controls.Add(this.Cpassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            ((System.ComponentModel.ISupportInitialize)(this.PaidLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Username;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Cpassword;
        private System.Windows.Forms.PictureBox PaidLogin;
        private System.Windows.Forms.PictureBox BackBtn;
    }
}