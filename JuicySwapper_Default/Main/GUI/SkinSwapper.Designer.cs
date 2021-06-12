
namespace JuicySwapper_Default.Main.GUI
{
    partial class SkinSwapper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkinSwapper));
            this.controlBar = new Guna.UI2.WinForms.Guna2Chip();
            this.controlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ConvertBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RevertBtn = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlBar
            // 
            this.controlBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.controlBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.controlBar.ForeColor = System.Drawing.Color.White;
            this.controlBar.Location = new System.Drawing.Point(-3, 0);
            this.controlBar.Name = "controlBar";
            this.controlBar.ShadowDecoration.Parent = this.controlBar;
            this.controlBar.Size = new System.Drawing.Size(455, 28);
            this.controlBar.TabIndex = 7;
            this.controlBar.Text = "Juicy Default Swapper - ";
            this.controlBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // controlBox
            // 
            this.controlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.controlBox.HoverState.Parent = this.controlBox;
            this.controlBox.IconColor = System.Drawing.Color.White;
            this.controlBox.Location = new System.Drawing.Point(407, 0);
            this.controlBox.Name = "controlBox";
            this.controlBox.ShadowDecoration.Parent = this.controlBox;
            this.controlBox.Size = new System.Drawing.Size(45, 28);
            this.controlBox.TabIndex = 9;
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(275, 52);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(167, 147);
            this.LogBox.TabIndex = 10;
            this.LogBox.Text = "";
            this.LogBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 147);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Animated = true;
            this.ConvertBtn.CheckedState.Parent = this.ConvertBtn;
            this.ConvertBtn.CustomImages.Parent = this.ConvertBtn;
            this.ConvertBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.ConvertBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConvertBtn.ForeColor = System.Drawing.Color.White;
            this.ConvertBtn.HoverState.Parent = this.ConvertBtn;
            this.ConvertBtn.Location = new System.Drawing.Point(175, 95);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.ShadowDecoration.Parent = this.ConvertBtn;
            this.ConvertBtn.Size = new System.Drawing.Size(94, 24);
            this.ConvertBtn.TabIndex = 12;
            this.ConvertBtn.Text = "Convert";
            this.ConvertBtn.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // RevertBtn
            // 
            this.RevertBtn.Animated = true;
            this.RevertBtn.CheckedState.Parent = this.RevertBtn;
            this.RevertBtn.CustomImages.Parent = this.RevertBtn;
            this.RevertBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.RevertBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RevertBtn.ForeColor = System.Drawing.Color.White;
            this.RevertBtn.HoverState.Parent = this.RevertBtn;
            this.RevertBtn.Location = new System.Drawing.Point(175, 125);
            this.RevertBtn.Name = "RevertBtn";
            this.RevertBtn.ShadowDecoration.Parent = this.RevertBtn;
            this.RevertBtn.Size = new System.Drawing.Size(94, 24);
            this.RevertBtn.TabIndex = 13;
            this.RevertBtn.Text = "Revert";
            this.RevertBtn.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
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
            this.bunifuElipse2.TargetControl = this.ConvertBtn;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this.RevertBtn;
            // 
            // SkinSwapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 219);
            this.Controls.Add(this.RevertBtn);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.controlBox);
            this.Controls.Add(this.controlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SkinSwapper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkinSwapper";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Chip controlBar;
        private Guna.UI2.WinForms.Guna2ControlBox controlBox;
        private System.Windows.Forms.RichTextBox LogBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button ConvertBtn;
        private Guna.UI2.WinForms.Guna2Button RevertBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}