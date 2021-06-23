
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Wrapper = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.HometabBtn = new System.Windows.Forms.PictureBox();
            this.SwappertabBtn = new System.Windows.Forms.PictureBox();
            this.NewstabBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HometabBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwappertabBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewstabBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.Transparent;
            this.Wrapper.Location = new System.Drawing.Point(224, 89);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(815, 526);
            this.Wrapper.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.Wrapper;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(979, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(826, 19);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(150, 15);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Click to accsess profile settings";
            this.guna2HtmlLabel1.Visible = false;
            // 
            // HometabBtn
            // 
            this.HometabBtn.BackColor = System.Drawing.Color.Transparent;
            this.HometabBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HometabBtn.Location = new System.Drawing.Point(28, 119);
            this.HometabBtn.Name = "HometabBtn";
            this.HometabBtn.Size = new System.Drawing.Size(115, 31);
            this.HometabBtn.TabIndex = 3;
            this.HometabBtn.TabStop = false;
            this.HometabBtn.Click += new System.EventHandler(this.HometabBtn_Click);
            // 
            // SwappertabBtn
            // 
            this.SwappertabBtn.BackColor = System.Drawing.Color.Transparent;
            this.SwappertabBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwappertabBtn.Location = new System.Drawing.Point(28, 228);
            this.SwappertabBtn.Name = "SwappertabBtn";
            this.SwappertabBtn.Size = new System.Drawing.Size(115, 31);
            this.SwappertabBtn.TabIndex = 4;
            this.SwappertabBtn.TabStop = false;
            this.SwappertabBtn.Click += new System.EventHandler(this.SwappertabBtn_Click);
            // 
            // NewstabBtn
            // 
            this.NewstabBtn.BackColor = System.Drawing.Color.Transparent;
            this.NewstabBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewstabBtn.Location = new System.Drawing.Point(28, 173);
            this.NewstabBtn.Name = "NewstabBtn";
            this.NewstabBtn.Size = new System.Drawing.Size(115, 31);
            this.NewstabBtn.TabIndex = 5;
            this.NewstabBtn.TabStop = false;
            this.NewstabBtn.Click += new System.EventHandler(this.NewstabBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(28, 568);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 31);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuicySwapper_Launcher.Properties.Resources.Launcher_Home;
            this.ClientSize = new System.Drawing.Size(1055, 634);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.NewstabBtn);
            this.Controls.Add(this.SwappertabBtn);
            this.Controls.Add(this.HometabBtn);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Wrapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HometabBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwappertabBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewstabBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Wrapper;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.PictureBox SwappertabBtn;
        private System.Windows.Forms.PictureBox HometabBtn;
        private System.Windows.Forms.PictureBox NewstabBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

