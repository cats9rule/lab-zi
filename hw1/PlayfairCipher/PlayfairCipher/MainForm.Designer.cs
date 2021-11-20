
namespace PlayfairCipher
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
            this.togBtnFSW = new PlayfairCipher.ToggleButton();
            this.lblFSWToggle = new System.Windows.Forms.Label();
            this.lblFSWStatus = new System.Windows.Forms.Label();
            this.tbFileToEncrypt = new System.Windows.Forms.TextBox();
            this.lblChooseFileToEncrypt = new System.Windows.Forms.Label();
            this.lblChooseFolderToWatch = new System.Windows.Forms.Label();
            this.tbChooseFolderEncrypt = new System.Windows.Forms.TextBox();
            this.lblChooseDestFolder = new System.Windows.Forms.Label();
            this.tbChooseFolderDecrypt = new System.Windows.Forms.TextBox();
            this.lblChooseFileToDecrypt = new System.Windows.Forms.Label();
            this.tbChooseFileToDecrypt = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // togBtnFSW
            // 
            this.togBtnFSW.Appearance = System.Windows.Forms.Appearance.Button;
            this.togBtnFSW.Location = new System.Drawing.Point(221, 51);
            this.togBtnFSW.MinimumSize = new System.Drawing.Size(45, 22);
            this.togBtnFSW.Name = "togBtnFSW";
            this.togBtnFSW.Size = new System.Drawing.Size(60, 30);
            this.togBtnFSW.TabIndex = 1;
            this.togBtnFSW.UseVisualStyleBackColor = true;
            this.togBtnFSW.CheckedChanged += new System.EventHandler(this.togBtnFSW_CheckedChanged);
            // 
            // lblFSWToggle
            // 
            this.lblFSWToggle.AutoSize = true;
            this.lblFSWToggle.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFSWToggle.Location = new System.Drawing.Point(152, 23);
            this.lblFSWToggle.Name = "lblFSWToggle";
            this.lblFSWToggle.Size = new System.Drawing.Size(220, 23);
            this.lblFSWToggle.TabIndex = 2;
            this.lblFSWToggle.Text = "Toggle File System Watcher:";
            // 
            // lblFSWStatus
            // 
            this.lblFSWStatus.AutoSize = true;
            this.lblFSWStatus.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFSWStatus.Location = new System.Drawing.Point(287, 59);
            this.lblFSWStatus.Name = "lblFSWStatus";
            this.lblFSWStatus.Size = new System.Drawing.Size(27, 15);
            this.lblFSWStatus.TabIndex = 3;
            this.lblFSWStatus.Text = "OFF";
            this.lblFSWStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbFileToEncrypt
            // 
            this.tbFileToEncrypt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFileToEncrypt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFileToEncrypt.Location = new System.Drawing.Point(277, 166);
            this.tbFileToEncrypt.MinimumSize = new System.Drawing.Size(220, 22);
            this.tbFileToEncrypt.Name = "tbFileToEncrypt";
            this.tbFileToEncrypt.Size = new System.Drawing.Size(220, 16);
            this.tbFileToEncrypt.TabIndex = 4;
            this.tbFileToEncrypt.WordWrap = false;
            // 
            // lblChooseFileToEncrypt
            // 
            this.lblChooseFileToEncrypt.AutoSize = true;
            this.lblChooseFileToEncrypt.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChooseFileToEncrypt.Location = new System.Drawing.Point(287, 144);
            this.lblChooseFileToEncrypt.Name = "lblChooseFileToEncrypt";
            this.lblChooseFileToEncrypt.Size = new System.Drawing.Size(154, 19);
            this.lblChooseFileToEncrypt.TabIndex = 5;
            this.lblChooseFileToEncrypt.Text = "Choose file to encrypt:";
            // 
            // lblChooseFolderToWatch
            // 
            this.lblChooseFolderToWatch.AutoSize = true;
            this.lblChooseFolderToWatch.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChooseFolderToWatch.Location = new System.Drawing.Point(20, 144);
            this.lblChooseFolderToWatch.Name = "lblChooseFolderToWatch";
            this.lblChooseFolderToWatch.Size = new System.Drawing.Size(174, 19);
            this.lblChooseFolderToWatch.TabIndex = 7;
            this.lblChooseFolderToWatch.Text = "Choose a folder to watch:";
            // 
            // tbChooseFolderEncrypt
            // 
            this.tbChooseFolderEncrypt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbChooseFolderEncrypt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbChooseFolderEncrypt.Location = new System.Drawing.Point(10, 166);
            this.tbChooseFolderEncrypt.MinimumSize = new System.Drawing.Size(220, 22);
            this.tbChooseFolderEncrypt.Name = "tbChooseFolderEncrypt";
            this.tbChooseFolderEncrypt.Size = new System.Drawing.Size(220, 16);
            this.tbChooseFolderEncrypt.TabIndex = 6;
            this.tbChooseFolderEncrypt.WordWrap = false;
            // 
            // lblChooseDestFolder
            // 
            this.lblChooseDestFolder.AutoSize = true;
            this.lblChooseDestFolder.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChooseDestFolder.Location = new System.Drawing.Point(20, 338);
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
            this.tbChooseFolderDecrypt.MinimumSize = new System.Drawing.Size(220, 22);
            this.tbChooseFolderDecrypt.Name = "tbChooseFolderDecrypt";
            this.tbChooseFolderDecrypt.Size = new System.Drawing.Size(486, 16);
            this.tbChooseFolderDecrypt.TabIndex = 8;
            this.tbChooseFolderDecrypt.WordWrap = false;
            // 
            // lblChooseFileToDecrypt
            // 
            this.lblChooseFileToDecrypt.AutoSize = true;
            this.lblChooseFileToDecrypt.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChooseFileToDecrypt.Location = new System.Drawing.Point(20, 277);
            this.lblChooseFileToDecrypt.Name = "lblChooseFileToDecrypt";
            this.lblChooseFileToDecrypt.Size = new System.Drawing.Size(154, 19);
            this.lblChooseFileToDecrypt.TabIndex = 11;
            this.lblChooseFileToDecrypt.Text = "Choose file to decrypt:";
            // 
            // tbChooseFileToDecrypt
            // 
            this.tbChooseFileToDecrypt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbChooseFileToDecrypt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbChooseFileToDecrypt.Location = new System.Drawing.Point(10, 299);
            this.tbChooseFileToDecrypt.MinimumSize = new System.Drawing.Size(220, 22);
            this.tbChooseFileToDecrypt.Name = "tbChooseFileToDecrypt";
            this.tbChooseFileToDecrypt.Size = new System.Drawing.Size(487, 16);
            this.tbChooseFileToDecrypt.TabIndex = 10;
            this.tbChooseFileToDecrypt.WordWrap = false;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.BurlyWood;
            this.btnEncrypt.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEncrypt.Location = new System.Drawing.Point(336, 209);
            this.btnEncrypt.MinimumSize = new System.Drawing.Size(100, 33);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(100, 33);
            this.btnEncrypt.TabIndex = 12;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
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
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(509, 486);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lblChooseFileToDecrypt);
            this.Controls.Add(this.tbChooseFileToDecrypt);
            this.Controls.Add(this.lblChooseDestFolder);
            this.Controls.Add(this.tbChooseFolderDecrypt);
            this.Controls.Add(this.lblChooseFolderToWatch);
            this.Controls.Add(this.tbChooseFolderEncrypt);
            this.Controls.Add(this.lblChooseFileToEncrypt);
            this.Controls.Add(this.tbFileToEncrypt);
            this.Controls.Add(this.lblFSWStatus);
            this.Controls.Add(this.lblFSWToggle);
            this.Controls.Add(this.togBtnFSW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(525, 525);
            this.MinimumSize = new System.Drawing.Size(525, 525);
            this.Name = "MainForm";
            this.Text = "Playfair Cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToggleButton togBtnFSW;
        private System.Windows.Forms.Label lblFSWToggle;
        private System.Windows.Forms.Label lblFSWStatus;
        private System.Windows.Forms.TextBox tbFileToEncrypt;
        private System.Windows.Forms.Label lblChooseFileToEncrypt;
        private System.Windows.Forms.Label lblChooseFolderToWatch;
        private System.Windows.Forms.TextBox tbChooseFolderEncrypt;
        private System.Windows.Forms.Label lblChooseDestFolder;
        private System.Windows.Forms.TextBox tbChooseFolderDecrypt;
        private System.Windows.Forms.Label lblChooseFileToDecrypt;
        private System.Windows.Forms.TextBox tbChooseFileToDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
    }
}

