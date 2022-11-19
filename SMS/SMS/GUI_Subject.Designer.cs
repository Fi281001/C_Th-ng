namespace SMS
{
    partial class GUI_Subject
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bxtNew = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSbjectName = new System.Windows.Forms.TextBox();
            this.txtmark = new System.Windows.Forms.Label();
            this.txtSName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStudentName = new System.Windows.Forms.ComboBox();
            this.dgvSubject = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(953, 479);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 47);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(754, 479);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(119, 47);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(576, 479);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 47);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(382, 479);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 47);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(187, 479);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 47);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bxtNew
            // 
            this.bxtNew.Location = new System.Drawing.Point(793, 49);
            this.bxtNew.Name = "bxtNew";
            this.bxtNew.Size = new System.Drawing.Size(119, 47);
            this.bxtNew.TabIndex = 16;
            this.bxtNew.Text = "...";
            this.bxtNew.UseVisualStyleBackColor = true;
            this.bxtNew.Click += new System.EventHandler(this.bxtNew_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(361, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(376, 22);
            this.txtEmail.TabIndex = 15;
            // 
            // txtSbjectName
            // 
            this.txtSbjectName.Location = new System.Drawing.Point(361, 60);
            this.txtSbjectName.Name = "txtSbjectName";
            this.txtSbjectName.Size = new System.Drawing.Size(376, 22);
            this.txtSbjectName.TabIndex = 14;
            // 
            // txtmark
            // 
            this.txtmark.AutoSize = true;
            this.txtmark.Location = new System.Drawing.Point(217, 97);
            this.txtmark.Name = "txtmark";
            this.txtmark.Size = new System.Drawing.Size(37, 16);
            this.txtmark.TabIndex = 13;
            this.txtmark.Text = "Mark";
            // 
            // txtSName
            // 
            this.txtSName.AutoSize = true;
            this.txtSName.Location = new System.Drawing.Point(217, 60);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(89, 16);
            this.txtSName.TabIndex = 12;
            this.txtSName.Text = "SubjectName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "StudentName";
            // 
            // cmbStudentName
            // 
            this.cmbStudentName.FormattingEnabled = true;
            this.cmbStudentName.Location = new System.Drawing.Point(361, 12);
            this.cmbStudentName.Name = "cmbStudentName";
            this.cmbStudentName.Size = new System.Drawing.Size(376, 24);
            this.cmbStudentName.TabIndex = 23;
            this.cmbStudentName.SelectedIndexChanged += new System.EventHandler(this.cmbStudentName_SelectedIndexChanged);
            // 
            // dgvSubject
            // 
            this.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubject.Location = new System.Drawing.Point(187, 146);
            this.dgvSubject.Name = "dgvSubject";
            this.dgvSubject.RowHeadersWidth = 51;
            this.dgvSubject.RowTemplate.Height = 24;
            this.dgvSubject.Size = new System.Drawing.Size(967, 287);
            this.dgvSubject.TabIndex = 24;
            // 
            // GUI_Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 574);
            this.Controls.Add(this.dgvSubject);
            this.Controls.Add(this.cmbStudentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bxtNew);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSbjectName);
            this.Controls.Add(this.txtmark);
            this.Controls.Add(this.txtSName);
            this.Name = "GUI_Subject";
            this.Text = "GUI_Subject";
            this.Load += new System.EventHandler(this.GUI_Subject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button bxtNew;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSbjectName;
        private System.Windows.Forms.Label txtmark;
        private System.Windows.Forms.Label txtSName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStudentName;
        private System.Windows.Forms.DataGridView dgvSubject;
    }
}