namespace menu2
{
    partial class Form1
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnlogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnclose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnWork = new System.Windows.Forms.ToolStripMenuItem();
            this.mnWork1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnWork2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFind1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFind2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSystem,
            this.mnWork,
            this.mnFind});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1274, 39);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mnSystem
            // 
            this.mnSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnLogin,
            this.mnlogout,
            this.mnclose});
            this.mnSystem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnSystem.Name = "mnSystem";
            this.mnSystem.Size = new System.Drawing.Size(99, 35);
            this.mnSystem.Text = "system";
            // 
            // mnLogin
            // 
            this.mnLogin.Name = "mnLogin";
            this.mnLogin.Size = new System.Drawing.Size(224, 36);
            this.mnLogin.Text = "Login";
            this.mnLogin.Click += new System.EventHandler(this.mnLogin_Click);
            // 
            // mnlogout
            // 
            this.mnlogout.Name = "mnlogout";
            this.mnlogout.Size = new System.Drawing.Size(224, 36);
            this.mnlogout.Text = "Logout";
            this.mnlogout.Click += new System.EventHandler(this.mnlogout_Click);
            // 
            // mnclose
            // 
            this.mnclose.Name = "mnclose";
            this.mnclose.Size = new System.Drawing.Size(224, 36);
            this.mnclose.Text = "Close";
            this.mnclose.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // mnWork
            // 
            this.mnWork.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnWork1,
            this.mnWork2});
            this.mnWork.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnWork.Name = "mnWork";
            this.mnWork.Size = new System.Drawing.Size(80, 35);
            this.mnWork.Text = "Work";
            // 
            // mnWork1
            // 
            this.mnWork1.Name = "mnWork1";
            this.mnWork1.Size = new System.Drawing.Size(224, 36);
            this.mnWork1.Text = "work1";
            // 
            // mnWork2
            // 
            this.mnWork2.Name = "mnWork2";
            this.mnWork2.Size = new System.Drawing.Size(224, 36);
            this.mnWork2.Text = "work2";
            // 
            // mnFind
            // 
            this.mnFind.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnFind1,
            this.mnFind2});
            this.mnFind.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnFind.Name = "mnFind";
            this.mnFind.Size = new System.Drawing.Size(72, 35);
            this.mnFind.Text = "Find";
            // 
            // mnFind1
            // 
            this.mnFind1.Name = "mnFind1";
            this.mnFind1.Size = new System.Drawing.Size(224, 36);
            this.mnFind1.Text = "Find1";
            // 
            // mnFind2
            // 
            this.mnFind2.Name = "mnFind2";
            this.mnFind2.Size = new System.Drawing.Size(224, 36);
            this.mnFind2.Text = "Find2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 719);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnSystem;
        private System.Windows.Forms.ToolStripMenuItem mnLogin;
        private System.Windows.Forms.ToolStripMenuItem mnlogout;
        private System.Windows.Forms.ToolStripMenuItem mnclose;
        private System.Windows.Forms.ToolStripMenuItem mnWork;
        private System.Windows.Forms.ToolStripMenuItem mnWork1;
        private System.Windows.Forms.ToolStripMenuItem mnWork2;
        private System.Windows.Forms.ToolStripMenuItem mnFind;
        private System.Windows.Forms.ToolStripMenuItem mnFind1;
        private System.Windows.Forms.ToolStripMenuItem mnFind2;
    }
}

