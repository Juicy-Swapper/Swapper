
namespace JuicySwapper_Launcher
{
    partial class Home
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
            this.controlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.controlBar = new Guna.UI2.WinForms.Guna2Chip();
            this.settingsMenuBtn = new Guna.UI2.WinForms.Guna2Button();
            this.NormalLaunch = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // controlBox
            // 
            this.controlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.controlBox.HoverState.Parent = this.controlBox;
            this.controlBox.IconColor = System.Drawing.Color.White;
            this.controlBox.Location = new System.Drawing.Point(565, 0);
            this.controlBox.Name = "controlBox";
            this.controlBox.ShadowDecoration.Parent = this.controlBox;
            this.controlBox.Size = new System.Drawing.Size(45, 28);
            this.controlBox.TabIndex = 3;
            // 
            // controlBar
            // 
            this.controlBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.controlBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.controlBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.controlBar.ForeColor = System.Drawing.Color.White;
            this.controlBar.Location = new System.Drawing.Point(-1, 0);
            this.controlBar.Name = "controlBar";
            this.controlBar.ShadowDecoration.Parent = this.controlBar;
            this.controlBar.Size = new System.Drawing.Size(611, 28);
            this.controlBar.TabIndex = 2;
            this.controlBar.Text = "Juicy Custom Pak Tool - Main Menu";
            this.controlBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // settingsMenuBtn
            // 
            this.settingsMenuBtn.Animated = true;
            this.settingsMenuBtn.CheckedState.Parent = this.settingsMenuBtn;
            this.settingsMenuBtn.CustomImages.Parent = this.settingsMenuBtn;
            this.settingsMenuBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.settingsMenuBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.settingsMenuBtn.ForeColor = System.Drawing.Color.White;
            this.settingsMenuBtn.HoverState.Parent = this.settingsMenuBtn;
            this.settingsMenuBtn.Location = new System.Drawing.Point(501, 296);
            this.settingsMenuBtn.Name = "settingsMenuBtn";
            this.settingsMenuBtn.ShadowDecoration.Parent = this.settingsMenuBtn;
            this.settingsMenuBtn.Size = new System.Drawing.Size(94, 24);
            this.settingsMenuBtn.TabIndex = 6;
            this.settingsMenuBtn.Text = "Settings";
            // 
            // NormalLaunch
            // 
            this.NormalLaunch.Animated = true;
            this.NormalLaunch.CheckedState.Parent = this.NormalLaunch;
            this.NormalLaunch.CustomImages.Parent = this.NormalLaunch;
            this.NormalLaunch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.NormalLaunch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NormalLaunch.ForeColor = System.Drawing.Color.White;
            this.NormalLaunch.HoverState.Parent = this.NormalLaunch;
            this.NormalLaunch.Location = new System.Drawing.Point(12, 197);
            this.NormalLaunch.Name = "NormalLaunch";
            this.NormalLaunch.ShadowDecoration.Parent = this.NormalLaunch;
            this.NormalLaunch.Size = new System.Drawing.Size(94, 24);
            this.NormalLaunch.TabIndex = 7;
            this.NormalLaunch.Text = "Launch";
            this.NormalLaunch.Click += new System.EventHandler(this.NormalLaunch_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 332);
            this.Controls.Add(this.NormalLaunch);
            this.Controls.Add(this.settingsMenuBtn);
            this.Controls.Add(this.controlBox);
            this.Controls.Add(this.controlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox controlBox;
        private Guna.UI2.WinForms.Guna2Chip controlBar;
        private Guna.UI2.WinForms.Guna2Button settingsMenuBtn;
        private Guna.UI2.WinForms.Guna2Button NormalLaunch;
    }
}

