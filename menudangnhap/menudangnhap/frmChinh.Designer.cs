﻿namespace menudangnhap
{
    partial class frmChinh
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
            this.mnHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDanhMuc1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDanhMuc2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTraCuu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnHeThong,
            this.mnDanhMuc,
            this.mnTraCuu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1427, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnHeThong
            // 
            this.mnHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnDangNhap,
            this.mnDangXuat,
            this.mnThoat});
            this.mnHeThong.Name = "mnHeThong";
            this.mnHeThong.Size = new System.Drawing.Size(85, 24);
            this.mnHeThong.Text = "Hệ thống";
            // 
            // mnDangNhap
            // 
            this.mnDangNhap.Name = "mnDangNhap";
            this.mnDangNhap.Size = new System.Drawing.Size(224, 26);
            this.mnDangNhap.Text = "Đăng nhập";
            this.mnDangNhap.Click += new System.EventHandler(this.mnDangNhap_Click);
            // 
            // mnDangXuat
            // 
            this.mnDangXuat.Name = "mnDangXuat";
            this.mnDangXuat.Size = new System.Drawing.Size(224, 26);
            this.mnDangXuat.Text = "Đăng xuất";
            this.mnDangXuat.Click += new System.EventHandler(this.mnDangXuat_Click);
            // 
            // mnThoat
            // 
            this.mnThoat.Name = "mnThoat";
            this.mnThoat.Size = new System.Drawing.Size(224, 26);
            this.mnThoat.Text = "Thoát";
            this.mnThoat.Click += new System.EventHandler(this.mnThoat_Click);
            // 
            // mnDanhMuc
            // 
            this.mnDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnDanhMuc1,
            this.mnDanhMuc2});
            this.mnDanhMuc.Name = "mnDanhMuc";
            this.mnDanhMuc.Size = new System.Drawing.Size(88, 24);
            this.mnDanhMuc.Text = "danh mục";
            // 
            // mnDanhMuc1
            // 
            this.mnDanhMuc1.Name = "mnDanhMuc1";
            this.mnDanhMuc1.Size = new System.Drawing.Size(169, 26);
            this.mnDanhMuc1.Text = "danh mục 1";
            // 
            // mnDanhMuc2
            // 
            this.mnDanhMuc2.Name = "mnDanhMuc2";
            this.mnDanhMuc2.Size = new System.Drawing.Size(169, 26);
            this.mnDanhMuc2.Text = "danh mục 2";
            // 
            // mnTraCuu
            // 
            this.mnTraCuu.Name = "mnTraCuu";
            this.mnTraCuu.Size = new System.Drawing.Size(71, 24);
            this.mnTraCuu.Text = "Tra cứu";
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 609);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChinh";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.frmChinh_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnThoat;
        private System.Windows.Forms.ToolStripMenuItem mnDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnDanhMuc1;
        private System.Windows.Forms.ToolStripMenuItem mnDanhMuc2;
        private System.Windows.Forms.ToolStripMenuItem mnTraCuu;
    }
}

