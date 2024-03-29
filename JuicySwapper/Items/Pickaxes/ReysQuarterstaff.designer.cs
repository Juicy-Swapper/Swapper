﻿namespace JuicySwapper.Items.Pickaxes
{
    partial class ReysQuarterstaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReysQuarterstaff));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.ActionButton = new System.Windows.Forms.PictureBox();
            this.SkinImage = new System.Windows.Forms.PictureBox();
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.CloseTimer = new System.Windows.Forms.Timer(this.components);
            this.ConvertBytes = new System.ComponentModel.BackgroundWorker();
            this.RevertBytes = new System.ComponentModel.BackgroundWorker();
            this.bunifuDragControl5 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl4 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkinImage)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Location = new System.Drawing.Point(337, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 18);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click_1);
            // 
            // ActionButton
            // 
            this.ActionButton.BackColor = System.Drawing.Color.Transparent;
            this.ActionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActionButton.Image = global::JuicySwapper.Properties.Resources.ConvertBtn;
            this.ActionButton.Location = new System.Drawing.Point(193, 181);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(157, 24);
            this.ActionButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ActionButton.TabIndex = 6;
            this.ActionButton.TabStop = false;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // SkinImage
            // 
            this.SkinImage.BackColor = System.Drawing.Color.Transparent;
            this.SkinImage.Image = ((System.Drawing.Image)(resources.GetObject("SkinImage.Image")));
            this.SkinImage.Location = new System.Drawing.Point(8, 28);
            this.SkinImage.Name = "SkinImage";
            this.SkinImage.Size = new System.Drawing.Size(157, 147);
            this.SkinImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SkinImage.TabIndex = 5;
            this.SkinImage.TabStop = false;
            this.SkinImage.Click += new System.EventHandler(this.SkinImage_Click);
            // 
            // LogBox
            // 
            this.LogBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogBox.ForeColor = System.Drawing.Color.White;
            this.LogBox.Location = new System.Drawing.Point(169, 28);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(181, 147);
            this.LogBox.TabIndex = 4;
            this.LogBox.Text = "";
            // 
            // CloseTimer
            // 
            this.CloseTimer.Interval = 3000;
            this.CloseTimer.Tick += new System.EventHandler(this.CloseTimer_Tick);
            // 
            // ConvertBytes
            // 
            this.ConvertBytes.WorkerSupportsCancellation = true;
            this.ConvertBytes.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ConvertBytes_DoWork);
            this.ConvertBytes.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ConvertBytes_RunWorkerCompleted);
            // 
            // RevertBytes
            // 
            this.RevertBytes.WorkerSupportsCancellation = true;
            this.RevertBytes.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RevertBytes_DoWork);
            this.RevertBytes.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.RevertBytes_RunWorkerCompleted);
            // 
            // bunifuDragControl5
            // 
            this.bunifuDragControl5.Fixed = true;
            this.bunifuDragControl5.Horizontal = true;
            this.bunifuDragControl5.TargetControl = this.SkinImage;
            this.bunifuDragControl5.Vertical = true;
            // 
            // bunifuDragControl4
            // 
            this.bunifuDragControl4.Fixed = true;
            this.bunifuDragControl4.Horizontal = true;
            this.bunifuDragControl4.TargetControl = this;
            this.bunifuDragControl4.Vertical = true;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 7;
            this.bunifuElipse2.TargetControl = this;
            // 
            // ReysQuarterstaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(360, 210);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.SkinImage);
            this.Controls.Add(this.LogBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReysQuarterstaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlaceHolder";
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkinImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox ActionButton;
        private System.Windows.Forms.PictureBox SkinImage;
        private System.Windows.Forms.RichTextBox LogBox;
        private System.Windows.Forms.Timer CloseTimer;
        private System.ComponentModel.BackgroundWorker ConvertBytes;
        private System.ComponentModel.BackgroundWorker RevertBytes;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl5;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}