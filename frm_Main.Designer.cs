﻿namespace ThaiBaHung_0633_DACN
{
    partial class frm_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thựcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tấtCảMónĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThựcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.evaluationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thựcĐơnToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.evaluationToolStripMenuItem,
            this.statisticalToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(851, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thựcĐơnToolStripMenuItem
            // 
            this.thựcĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tấtCảMónĂnToolStripMenuItem,
            this.quảnLýThựcĐơnToolStripMenuItem});
            this.thựcĐơnToolStripMenuItem.Name = "thựcĐơnToolStripMenuItem";
            this.thựcĐơnToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.thựcĐơnToolStripMenuItem.Text = "Menu management";
            // 
            // tấtCảMónĂnToolStripMenuItem
            // 
            this.tấtCảMónĂnToolStripMenuItem.Name = "tấtCảMónĂnToolStripMenuItem";
            this.tấtCảMónĂnToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.tấtCảMónĂnToolStripMenuItem.Text = "Tất Cả Món Ăn";
            this.tấtCảMónĂnToolStripMenuItem.Click += new System.EventHandler(this.tấtCảMónĂnToolStripMenuItem_Click);
            // 
            // quảnLýThựcĐơnToolStripMenuItem
            // 
            this.quảnLýThựcĐơnToolStripMenuItem.Name = "quảnLýThựcĐơnToolStripMenuItem";
            this.quảnLýThựcĐơnToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.quảnLýThựcĐơnToolStripMenuItem.Text = "Danh SáchThực Đơn";
            this.quảnLýThựcĐơnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýThựcĐơnToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnKháchHàngToolStripMenuItem});
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.hóaĐơnToolStripMenuItem.Text = "Invoice";
            // 
            // hóaĐơnKháchHàngToolStripMenuItem
            // 
            this.hóaĐơnKháchHàngToolStripMenuItem.Name = "hóaĐơnKháchHàngToolStripMenuItem";
            this.hóaĐơnKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.hóaĐơnKháchHàngToolStripMenuItem.Text = "Hóa Đơn Khách Hàng";
            this.hóaĐơnKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnKháchHàngToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Log out";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImage = global::ThaiBaHung_0633_DACN.Properties.Resources.syed_hussaini_AUuOz9mQDYM_unsplash;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(851, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // evaluationToolStripMenuItem
            // 
            this.evaluationToolStripMenuItem.Name = "evaluationToolStripMenuItem";
            this.evaluationToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.evaluationToolStripMenuItem.Text = "Evaluation";
            this.evaluationToolStripMenuItem.Click += new System.EventHandler(this.evaluationToolStripMenuItem_Click);
            // 
            // statisticalToolStripMenuItem
            // 
            this.statisticalToolStripMenuItem.Name = "statisticalToolStripMenuItem";
            this.statisticalToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.statisticalToolStripMenuItem.Text = "Statistical";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 494);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.Text = "Default";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thựcĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tấtCảMónĂnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThựcĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnKháchHàngToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem evaluationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticalToolStripMenuItem;
    }
}

