
namespace BACKUPRESTORETEST
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
            this.DGVMain = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.txtbackup = new System.Windows.Forms.TextBox();
            this.btnBackupBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.txtRestore = new System.Windows.Forms.TextBox();
            this.btnRestoreBrowse = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMain)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMain
            // 
            this.DGVMain.AllowUserToAddRows = false;
            this.DGVMain.AllowUserToDeleteRows = false;
            this.DGVMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ProductName});
            this.DGVMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGVMain.Location = new System.Drawing.Point(0, 0);
            this.DGVMain.Name = "DGVMain";
            this.DGVMain.ReadOnly = true;
            this.DGVMain.RowHeadersVisible = false;
            this.DGVMain.Size = new System.Drawing.Size(526, 183);
            this.DGVMain.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "Product";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(439, 190);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 1;
            this.LoadBtn.Text = "LOAD";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // txtbackup
            // 
            this.txtbackup.Location = new System.Drawing.Point(12, 236);
            this.txtbackup.Name = "txtbackup";
            this.txtbackup.Size = new System.Drawing.Size(344, 20);
            this.txtbackup.TabIndex = 2;
            // 
            // btnBackupBrowse
            // 
            this.btnBackupBrowse.Location = new System.Drawing.Point(362, 234);
            this.btnBackupBrowse.Name = "btnBackupBrowse";
            this.btnBackupBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBackupBrowse.TabIndex = 3;
            this.btnBackupBrowse.Text = "BROWSE";
            this.btnBackupBrowse.UseVisualStyleBackColor = true;
            this.btnBackupBrowse.Click += new System.EventHandler(this.btnBackupBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "BACKUP";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(281, 262);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "BACKUP";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // txtRestore
            // 
            this.txtRestore.Location = new System.Drawing.Point(12, 301);
            this.txtRestore.Name = "txtRestore";
            this.txtRestore.Size = new System.Drawing.Size(344, 20);
            this.txtRestore.TabIndex = 2;
            // 
            // btnRestoreBrowse
            // 
            this.btnRestoreBrowse.Location = new System.Drawing.Point(362, 299);
            this.btnRestoreBrowse.Name = "btnRestoreBrowse";
            this.btnRestoreBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnRestoreBrowse.TabIndex = 3;
            this.btnRestoreBrowse.Text = "BROWSE";
            this.btnRestoreBrowse.UseVisualStyleBackColor = true;
            this.btnRestoreBrowse.Click += new System.EventHandler(this.btnRestoreBrowse_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(281, 327);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "RESTORE";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "RESTORE";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Location = new System.Drawing.Point(415, 358);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(99, 37);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "IMPORT";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 407);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestoreBrowse);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.txtRestore);
            this.Controls.Add(this.btnBackupBrowse);
            this.Controls.Add(this.txtbackup);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.DGVMain);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGVMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.TextBox txtbackup;
        private System.Windows.Forms.Button btnBackupBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.TextBox txtRestore;
        private System.Windows.Forms.Button btnRestoreBrowse;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnImport;
        public System.Windows.Forms.DataGridView DGVMain;
    }
}

