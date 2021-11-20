
using System.IO;

namespace Homework1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.togBtnFSW = new Homework1.ToggleButton();
            this.lblFSWToggle = new System.Windows.Forms.Label();
            this.lblFSWStatus = new System.Windows.Forms.Label();
            this.tbChooseFileToEncrypt = new System.Windows.Forms.TextBox();
            this.lblChooseFileToEncrypt = new System.Windows.Forms.Label();
            this.lblChooseFolderToWatch = new System.Windows.Forms.Label();
            this.tbChooseFolderToWatch = new System.Windows.Forms.TextBox();
            this.lblChooseDestFolder = new System.Windows.Forms.Label();
            this.tbChooseFolderDecrypt = new System.Windows.Forms.TextBox();
            this.lblChooseFileToDecrypt = new System.Windows.Forms.Label();
            this.tbChooseFileToDecrypt = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnChooseFolderToWatch = new System.Windows.Forms.Button();
            this.btnChooseFileToEncrypt = new System.Windows.Forms.Button();
            this.btnChooseDestinationDecrypt = new System.Windows.Forms.Button();
            this.btnChooseFileToDecrypt = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnChooseFolderFSWEncrypt = new System.Windows.Forms.Button();
            this.lblChooseFolderFSWEncrypt = new System.Windows.Forms.Label();
            this.tbChooseFolderFSWEncrypt = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // togBtnFSW
            // 
            this.togBtnFSW.Appearance = System.Windows.Forms.Appearance.Button;
            this.togBtnFSW.Location = new System.Drawing.Point(215, 49);
            this.togBtnFSW.MinimumSize = new System.Drawing.Size(45, 22);
            this.togBtnFSW.Name = "togBtnFSW";
            this.togBtnFSW.Size = new System.Drawing.Size(60, 30);
            this.togBtnFSW.TabIndex = 1;
            this.togBtnFSW.UseVisualStyleBackColor = true;
            this.togBtnFSW.CheckedChanged += new System.EventHandler(this.TogBtnFSW_CheckedChanged);
            // 
            // lblFSWToggle
            // 
            this.lblFSWToggle.AutoSize = true;
            this.lblFSWToggle.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFSWToggle.Location = new System.Drawing.Point(146, 21);
            this.lblFSWToggle.Name = "lblFSWToggle";
            this.lblFSWToggle.Size = new System.Drawing.Size(220, 23);
            this.lblFSWToggle.TabIndex = 2;
            this.lblFSWToggle.Text = "Toggle File System Watcher:";
            // 
            // lblFSWStatus
            // 
            this.lblFSWStatus.AutoSize = true;
            this.lblFSWStatus.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFSWStatus.Location = new System.Drawing.Point(281, 57);
            this.lblFSWStatus.Name = "lblFSWStatus";
            this.lblFSWStatus.Size = new System.Drawing.Size(27, 15);
            this.lblFSWStatus.TabIndex = 3;
            this.lblFSWStatus.Text = "OFF";
            this.lblFSWStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbChooseFileToEncrypt
            // 
            this.tbChooseFileToEncrypt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbChooseFileToEncrypt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbChooseFileToEncrypt.Location = new System.Drawing.Point(271, 166);
            this.tbChooseFileToEncrypt.MinimumSize = new System.Drawing.Size(100, 22);
            this.tbChooseFileToEncrypt.Name = "tbChooseFileToEncrypt";
            this.tbChooseFileToEncrypt.Size = new System.Drawing.Size(190, 16);
            this.tbChooseFileToEncrypt.TabIndex = 4;
            this.tbChooseFileToEncrypt.WordWrap = false;
            this.tbChooseFileToEncrypt.TextChanged += new System.EventHandler(this.tbChooseFileToEncrypt_TextChanged);
            // 
            // lblChooseFileToEncrypt
            // 
            this.lblChooseFileToEncrypt.AutoSize = true;
            this.lblChooseFileToEncrypt.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChooseFileToEncrypt.Location = new System.Drawing.Point(271, 144);
            this.lblChooseFileToEncrypt.Name = "lblChooseFileToEncrypt";
            this.lblChooseFileToEncrypt.Size = new System.Drawing.Size(154, 19);
            this.lblChooseFileToEncrypt.TabIndex = 5;
            this.lblChooseFileToEncrypt.Text = "Choose file to encrypt:";
            // 
            // lblChooseFolderToWatch
            // 
            this.lblChooseFolderToWatch.AutoSize = true;
            this.lblChooseFolderToWatch.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChooseFolderToWatch.Location = new System.Drawing.Point(10, 144);
            this.lblChooseFolderToWatch.Name = "lblChooseFolderToWatch";
            this.lblChooseFolderToWatch.Size = new System.Drawing.Size(174, 19);
            this.lblChooseFolderToWatch.TabIndex = 7;
            this.lblChooseFolderToWatch.Text = "Choose a folder to watch:";
            // 
            // tbChooseFolderToWatch
            // 
            this.tbChooseFolderToWatch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbChooseFolderToWatch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbChooseFolderToWatch.Location = new System.Drawing.Point(10, 166);
            this.tbChooseFolderToWatch.MinimumSize = new System.Drawing.Size(100, 22);
            this.tbChooseFolderToWatch.Name = "tbChooseFolderToWatch";
            this.tbChooseFolderToWatch.Size = new System.Drawing.Size(190, 16);
            this.tbChooseFolderToWatch.TabIndex = 6;
            this.tbChooseFolderToWatch.WordWrap = false;
            this.tbChooseFolderToWatch.TextChanged += new System.EventHandler(this.tbChooseFolderToWatch_TextChanged);
            // 
            // lblChooseDestFolder
            // 
            this.lblChooseDestFolder.AutoSize = true;
            this.lblChooseDestFolder.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChooseDestFolder.Location = new System.Drawing.Point(12, 338);
            this.lblChooseDestFolder.Name = "lblChooseDestFolder";
            this.lblChooseDestFolder.Size = new System.Drawing.Size(180, 19);
            this.lblChooseDestFolder.TabIndex = 9;
            this.lblChooseDestFolder.Text = "Choose destination folder:";
            // 
            // tbChooseFolderDecrypt
            // 
            this.tbChooseFolderDecrypt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbChooseFolderDecrypt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbChooseFolderDecrypt.Location = new System.Drawing.Point(10, 360);
            this.tbChooseFolderDecrypt.MinimumSize = new System.Drawing.Size(220, 16);
            this.tbChooseFolderDecrypt.Name = "tbChooseFolderDecrypt";
            this.tbChooseFolderDecrypt.Size = new System.Drawing.Size(451, 16);
            this.tbChooseFolderDecrypt.TabIndex = 8;
            this.tbChooseFolderDecrypt.WordWrap = false;
            this.tbChooseFolderDecrypt.TextChanged += new System.EventHandler(this.tbChooseFolderDecrypt_TextChanged);
            // 
            // lblChooseFileToDecrypt
            // 
            this.lblChooseFileToDecrypt.AutoSize = true;
            this.lblChooseFileToDecrypt.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChooseFileToDecrypt.Location = new System.Drawing.Point(12, 285);
            this.lblChooseFileToDecrypt.Name = "lblChooseFileToDecrypt";
            this.lblChooseFileToDecrypt.Size = new System.Drawing.Size(154, 19);
            this.lblChooseFileToDecrypt.TabIndex = 11;
            this.lblChooseFileToDecrypt.Text = "Choose file to decrypt:";
            // 
            // tbChooseFileToDecrypt
            // 
            this.tbChooseFileToDecrypt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbChooseFileToDecrypt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbChooseFileToDecrypt.Location = new System.Drawing.Point(10, 307);
            this.tbChooseFileToDecrypt.MinimumSize = new System.Drawing.Size(220, 16);
            this.tbChooseFileToDecrypt.Name = "tbChooseFileToDecrypt";
            this.tbChooseFileToDecrypt.Size = new System.Drawing.Size(451, 16);
            this.tbChooseFileToDecrypt.TabIndex = 10;
            this.tbChooseFileToDecrypt.WordWrap = false;
            this.tbChooseFileToDecrypt.TextChanged += new System.EventHandler(this.tbChooseFileToDecrypt_TextChanged);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.BurlyWood;
            this.btnEncrypt.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEncrypt.Location = new System.Drawing.Point(325, 199);
            this.btnEncrypt.MinimumSize = new System.Drawing.Size(100, 33);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(100, 33);
            this.btnEncrypt.TabIndex = 12;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDecrypt.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnDecrypt.FlatAppearance.BorderSize = 0;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecrypt.Location = new System.Drawing.Point(207, 405);
            this.btnDecrypt.MinimumSize = new System.Drawing.Size(100, 33);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(100, 33);
            this.btnDecrypt.TabIndex = 13;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.Filter = "*.txt";
            this.fileSystemWatcher.NotifyFilter = ((System.IO.NotifyFilters)((((((((System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.DirectoryName) 
            | System.IO.NotifyFilters.Attributes) 
            | System.IO.NotifyFilters.Size) 
            | System.IO.NotifyFilters.LastWrite) 
            | System.IO.NotifyFilters.LastAccess) 
            | System.IO.NotifyFilters.CreationTime) 
            | System.IO.NotifyFilters.Security)));
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Created);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_OnTick);
            // 
            // btnChooseFolderToWatch
            // 
            this.btnChooseFolderToWatch.BackColor = System.Drawing.SystemColors.Control;
            this.btnChooseFolderToWatch.FlatAppearance.BorderSize = 0;
            this.btnChooseFolderToWatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseFolderToWatch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChooseFolderToWatch.Location = new System.Drawing.Point(206, 160);
            this.btnChooseFolderToWatch.Name = "btnChooseFolderToWatch";
            this.btnChooseFolderToWatch.Size = new System.Drawing.Size(31, 27);
            this.btnChooseFolderToWatch.TabIndex = 14;
            this.btnChooseFolderToWatch.Text = "📂";
            this.btnChooseFolderToWatch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChooseFolderToWatch.UseVisualStyleBackColor = false;
            this.btnChooseFolderToWatch.Click += new System.EventHandler(this.btnChooseFolderToWatch_Click);
            // 
            // btnChooseFileToEncrypt
            // 
            this.btnChooseFileToEncrypt.BackColor = System.Drawing.SystemColors.Control;
            this.btnChooseFileToEncrypt.FlatAppearance.BorderSize = 0;
            this.btnChooseFileToEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseFileToEncrypt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChooseFileToEncrypt.Location = new System.Drawing.Point(467, 160);
            this.btnChooseFileToEncrypt.Name = "btnChooseFileToEncrypt";
            this.btnChooseFileToEncrypt.Size = new System.Drawing.Size(31, 27);
            this.btnChooseFileToEncrypt.TabIndex = 15;
            this.btnChooseFileToEncrypt.Text = "📂";
            this.btnChooseFileToEncrypt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChooseFileToEncrypt.UseVisualStyleBackColor = false;
            this.btnChooseFileToEncrypt.Click += new System.EventHandler(this.btnChooseFileToEncrypt_Click);
            // 
            // btnChooseDestinationDecrypt
            // 
            this.btnChooseDestinationDecrypt.BackColor = System.Drawing.SystemColors.Control;
            this.btnChooseDestinationDecrypt.FlatAppearance.BorderSize = 0;
            this.btnChooseDestinationDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseDestinationDecrypt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChooseDestinationDecrypt.Location = new System.Drawing.Point(467, 353);
            this.btnChooseDestinationDecrypt.Name = "btnChooseDestinationDecrypt";
            this.btnChooseDestinationDecrypt.Size = new System.Drawing.Size(31, 27);
            this.btnChooseDestinationDecrypt.TabIndex = 16;
            this.btnChooseDestinationDecrypt.Text = "📂";
            this.btnChooseDestinationDecrypt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChooseDestinationDecrypt.UseVisualStyleBackColor = false;
            this.btnChooseDestinationDecrypt.Click += new System.EventHandler(this.btnChooseDestinationDecrypt_Click);
            // 
            // btnChooseFileToDecrypt
            // 
            this.btnChooseFileToDecrypt.BackColor = System.Drawing.SystemColors.Control;
            this.btnChooseFileToDecrypt.FlatAppearance.BorderSize = 0;
            this.btnChooseFileToDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseFileToDecrypt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChooseFileToDecrypt.Location = new System.Drawing.Point(467, 300);
            this.btnChooseFileToDecrypt.Name = "btnChooseFileToDecrypt";
            this.btnChooseFileToDecrypt.Size = new System.Drawing.Size(31, 27);
            this.btnChooseFileToDecrypt.TabIndex = 17;
            this.btnChooseFileToDecrypt.Text = "📂";
            this.btnChooseFileToDecrypt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChooseFileToDecrypt.UseVisualStyleBackColor = false;
            this.btnChooseFileToDecrypt.Click += new System.EventHandler(this.btnChooseFileToDecrypt_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.Location = new System.Drawing.Point(46, 95);
            this.lblMessage.MinimumSize = new System.Drawing.Size(425, 40);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(425, 40);
            this.lblMessage.TabIndex = 18;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnChooseFolderFSWEncrypt
            // 
            this.btnChooseFolderFSWEncrypt.BackColor = System.Drawing.SystemColors.Control;
            this.btnChooseFolderFSWEncrypt.FlatAppearance.BorderSize = 0;
            this.btnChooseFolderFSWEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseFolderFSWEncrypt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChooseFolderFSWEncrypt.Location = new System.Drawing.Point(206, 210);
            this.btnChooseFolderFSWEncrypt.Name = "btnChooseFolderFSWEncrypt";
            this.btnChooseFolderFSWEncrypt.Size = new System.Drawing.Size(31, 27);
            this.btnChooseFolderFSWEncrypt.TabIndex = 21;
            this.btnChooseFolderFSWEncrypt.Text = "📂";
            this.btnChooseFolderFSWEncrypt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChooseFolderFSWEncrypt.UseVisualStyleBackColor = false;
            this.btnChooseFolderFSWEncrypt.Click += new System.EventHandler(this.btnChooseFolderFSWEncrypt_Click);
            // 
            // lblChooseFolderFSWEncrypt
            // 
            this.lblChooseFolderFSWEncrypt.AutoSize = true;
            this.lblChooseFolderFSWEncrypt.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChooseFolderFSWEncrypt.Location = new System.Drawing.Point(10, 194);
            this.lblChooseFolderFSWEncrypt.Name = "lblChooseFolderFSWEncrypt";
            this.lblChooseFolderFSWEncrypt.Size = new System.Drawing.Size(180, 19);
            this.lblChooseFolderFSWEncrypt.TabIndex = 20;
            this.lblChooseFolderFSWEncrypt.Text = "Choose destination folder:";
            // 
            // tbChooseFolderFSWEncrypt
            // 
            this.tbChooseFolderFSWEncrypt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbChooseFolderFSWEncrypt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbChooseFolderFSWEncrypt.Location = new System.Drawing.Point(10, 216);
            this.tbChooseFolderFSWEncrypt.MinimumSize = new System.Drawing.Size(100, 16);
            this.tbChooseFolderFSWEncrypt.Name = "tbChooseFolderFSWEncrypt";
            this.tbChooseFolderFSWEncrypt.Size = new System.Drawing.Size(190, 16);
            this.tbChooseFolderFSWEncrypt.TabIndex = 19;
            this.tbChooseFolderFSWEncrypt.WordWrap = false;
            this.tbChooseFolderFSWEncrypt.TextChanged += new System.EventHandler(this.tbChooseFolderFSWEncrypt_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.ShowReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(509, 486);
            this.Controls.Add(this.btnChooseFolderFSWEncrypt);
            this.Controls.Add(this.lblChooseFolderFSWEncrypt);
            this.Controls.Add(this.tbChooseFolderFSWEncrypt);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnChooseFileToDecrypt);
            this.Controls.Add(this.btnChooseDestinationDecrypt);
            this.Controls.Add(this.btnChooseFileToEncrypt);
            this.Controls.Add(this.btnChooseFolderToWatch);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lblChooseFileToDecrypt);
            this.Controls.Add(this.tbChooseFileToDecrypt);
            this.Controls.Add(this.lblChooseDestFolder);
            this.Controls.Add(this.tbChooseFolderDecrypt);
            this.Controls.Add(this.lblChooseFolderToWatch);
            this.Controls.Add(this.tbChooseFolderToWatch);
            this.Controls.Add(this.lblChooseFileToEncrypt);
            this.Controls.Add(this.tbChooseFileToEncrypt);
            this.Controls.Add(this.lblFSWStatus);
            this.Controls.Add(this.lblFSWToggle);
            this.Controls.Add(this.togBtnFSW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(525, 525);
            this.MinimumSize = new System.Drawing.Size(525, 525);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playfair Cipher";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToggleButton togBtnFSW;
        private System.Windows.Forms.Label lblFSWToggle;
        private System.Windows.Forms.Label lblFSWStatus;
        private System.Windows.Forms.TextBox tbChooseFileToEncrypt;
        private System.Windows.Forms.Label lblChooseFileToEncrypt;
        private System.Windows.Forms.Label lblChooseFolderToWatch;
        private System.Windows.Forms.TextBox tbChooseFolderToWatch;
        private System.Windows.Forms.Label lblChooseDestFolder;
        private System.Windows.Forms.TextBox tbChooseFolderDecrypt;
        private System.Windows.Forms.Label lblChooseFileToDecrypt;
        private System.Windows.Forms.TextBox tbChooseFileToDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnChooseFolderToWatch;
        private System.Windows.Forms.Button btnChooseFileToDecrypt;
        private System.Windows.Forms.Button btnChooseDestinationDecrypt;
        private System.Windows.Forms.Button btnChooseFileToEncrypt;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnChooseFolderFSWEncrypt;
        private System.Windows.Forms.Label lblChooseFolderFSWEncrypt;
        private System.Windows.Forms.TextBox tbChooseFolderFSWEncrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

