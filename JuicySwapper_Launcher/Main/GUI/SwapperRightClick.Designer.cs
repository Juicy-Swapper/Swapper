
namespace JuicySwapper_Launcher.Main.GUI
{
    partial class SwapperRightClick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwapperRightClick));
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ConvertitemsBtn = new System.Windows.Forms.PictureBox();
            this.Version = new System.Windows.Forms.Label();
            this.APIversion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConvertitemsBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this;
            // 
            // ConvertitemsBtn
            // 
            this.ConvertitemsBtn.BackColor = System.Drawing.Color.Transparent;
            this.ConvertitemsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConvertitemsBtn.Location = new System.Drawing.Point(29, 311);
            this.ConvertitemsBtn.Name = "ConvertitemsBtn";
            this.ConvertitemsBtn.Size = new System.Drawing.Size(122, 22);
            this.ConvertitemsBtn.TabIndex = 8;
            this.ConvertitemsBtn.TabStop = false;
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.BackColor = System.Drawing.Color.Transparent;
            this.Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.ForeColor = System.Drawing.Color.White;
            this.Version.Location = new System.Drawing.Point(84, 47);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(11, 12);
            this.Version.TabIndex = 9;
            this.Version.Text = "0";
            this.Version.MouseLeave += new System.EventHandler(this.SwapperRightClick_MouseLeave);
            // 
            // APIversion
            // 
            this.APIversion.AutoSize = true;
            this.APIversion.BackColor = System.Drawing.Color.Transparent;
            this.APIversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APIversion.ForeColor = System.Drawing.Color.White;
            this.APIversion.Location = new System.Drawing.Point(76, 72);
            this.APIversion.Name = "APIversion";
            this.APIversion.Size = new System.Drawing.Size(11, 12);
            this.APIversion.TabIndex = 11;
            this.APIversion.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(114, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "0";
            // 
            // SwapperRightClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(180, 351);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.APIversion);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.ConvertitemsBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SwapperRightClick";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SwapperRightClick";
            this.Load += new System.EventHandler(this.SwapperRightClick_Load);
            this.MouseLeave += new System.EventHandler(this.SwapperRightClick_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.ConvertitemsBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.PictureBox ConvertitemsBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label APIversion;
        private System.Windows.Forms.Label Version;
    }
}