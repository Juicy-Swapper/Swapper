
namespace JuicySwapper_Default
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.controlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.controlBar = new Guna.UI2.WinForms.Guna2Chip();
            this.settingsMenuBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // controlBox
            // 
            this.controlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.controlBox.HoverState.Parent = this.controlBox;
            this.controlBox.IconColor = System.Drawing.Color.White;
            this.controlBox.Location = new System.Drawing.Point(639, -1);
            this.controlBox.Name = "controlBox";
            this.controlBox.ShadowDecoration.Parent = this.controlBox;
            this.controlBox.Size = new System.Drawing.Size(45, 28);
            this.controlBox.TabIndex = 3;
            // 
            // controlBar
            // 
            this.controlBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.controlBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.controlBar.ForeColor = System.Drawing.Color.White;
            this.controlBar.Location = new System.Drawing.Point(-2, -1);
            this.controlBar.Name = "controlBar";
            this.controlBar.ShadowDecoration.Parent = this.controlBar;
            this.controlBar.Size = new System.Drawing.Size(686, 28);
            this.controlBar.TabIndex = 2;
            this.controlBar.Text = "Juicy Default Swapper - Home";
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
            this.settingsMenuBtn.Location = new System.Drawing.Point(579, 414);
            this.settingsMenuBtn.Name = "settingsMenuBtn";
            this.settingsMenuBtn.ShadowDecoration.Parent = this.settingsMenuBtn;
            this.settingsMenuBtn.Size = new System.Drawing.Size(94, 24);
            this.settingsMenuBtn.TabIndex = 6;
            this.settingsMenuBtn.Text = "Settings";
            this.settingsMenuBtn.Click += new System.EventHandler(this.settingsMenuBtn_Click);
            // 
            // Wrapper
            // 
            this.Wrapper.Location = new System.Drawing.Point(-2, 33);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(686, 365);
            this.Wrapper.TabIndex = 7;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.controlBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.settingsMenuBtn;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.settingsMenuBtn);
            this.Controls.Add(this.controlBox);
            this.Controls.Add(this.controlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox controlBox;
        private Guna.UI2.WinForms.Guna2Chip controlBar;
        private Guna.UI2.WinForms.Guna2Button settingsMenuBtn;
        private System.Windows.Forms.Panel Wrapper;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}

