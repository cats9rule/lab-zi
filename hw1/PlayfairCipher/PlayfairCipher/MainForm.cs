using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Homework1
{
    public partial class MainForm : Form
    {
        #region Attributes

        private string folderToWatch = "";
        private string folderEncryptDestination = "";
        private string fileEncryptSource = "";
        private string folderDecryptDestination = "";
        private string fileDecryptSource = "";

        private PlayfairCipher playfairCipher;

        private bool shouldCallToggleControls = true;

        #endregion

        public MainForm()
        {
            InitializeComponent();
            playfairCipher = new PlayfairCipher();
        }

        #region Properties

        public string FolderToWatch
        {
            get { return folderToWatch; }
            set { folderToWatch = value; }
        }
        public string FileEncryptTarget
        {
            get { return fileEncryptSource; }
            set { fileEncryptSource = value; }
        }
        public string FolderDecryptTarget
        {
            get { return folderDecryptDestination; }
            set { folderDecryptDestination = value; }
        }
        public string FileDecryptSource
        {
            get { return fileDecryptSource; }
            set { fileDecryptSource = value; }
        }

        #endregion

        #region Methods

        private void ToggleControls()
        {
            lblFSWStatus.Text = lblFSWStatus.Text == "ON" ? "OFF" : "ON";

            lblChooseFolderToWatch.Enabled = !lblChooseFolderToWatch.Enabled;
            tbChooseFolderToWatch.Enabled = !tbChooseFolderToWatch.Enabled;

            lblChooseFolderFSWEncrypt.Enabled = !lblChooseFolderFSWEncrypt.Enabled;
            tbChooseFolderFSWEncrypt.Enabled = !tbChooseFolderFSWEncrypt.Enabled;

            lblChooseFileToEncrypt.Enabled = !lblChooseFileToEncrypt.Enabled;
            tbChooseFileToEncrypt.Enabled = !tbChooseFileToEncrypt.Enabled;
            btnEncrypt.Enabled = !btnEncrypt.Enabled;

            lblChooseFileToDecrypt.Enabled = !lblChooseFileToDecrypt.Enabled;
            tbChooseFileToDecrypt.Enabled = !tbChooseFileToDecrypt.Enabled;

            lblChooseDestFolder.Enabled = !lblChooseDestFolder.Enabled;
            tbChooseFolderDecrypt.Enabled = !tbChooseFolderDecrypt.Enabled;
            btnDecrypt.Enabled = !btnDecrypt.Enabled;

            if (!togBtnFSW.Checked) SetFileSystemPathsToTextboxes();
        }
        private void SetFileSystemPathsToTextboxes()
        {
            tbChooseFolderToWatch.Text = folderToWatch;
            tbChooseFileToDecrypt.Text = fileDecryptSource;
            tbChooseFolderDecrypt.Text = folderDecryptDestination;
            tbChooseFileToEncrypt.Text = fileEncryptSource;
            tbChooseFolderFSWEncrypt.Text = folderEncryptDestination;
        }

        private bool ValidateForEncrypt()
        {
            if (File.Exists(fileEncryptSource)
                && Directory.Exists(folderEncryptDestination)
                && fileEncryptSource.EndsWith(".txt"))
                return true;
            else return false;
        }
        private bool ValidateForDecrypt()
        {
            if (File.Exists(fileDecryptSource)
                && Directory.Exists(folderDecryptDestination)
                && fileDecryptSource.EndsWith(".encrypt.txt")) return true;
            else return false;
        }

        #endregion

        #region Event Handlers

        private void TogBtnFSW_CheckedChanged(object sender, EventArgs e)
        {
            if (togBtnFSW.Checked)
            {
                string path = folderToWatch;

                if (!Directory.Exists(path))
                {
                    lblMessage.Text = "You must choose a valid folder to watch!";
                    lblMessage.ForeColor = Color.IndianRed;
                    timer.Interval = 300;
                    timer.Start();
                    return;
                }
                if (!Directory.Exists(folderEncryptDestination)) {
                    lblMessage.Text = "You must choose a valid destination folder!";
                    lblMessage.ForeColor = Color.IndianRed;
                    timer.Interval = 300;
                    timer.Start();
                    return;
                }
                if (folderToWatch == folderEncryptDestination)
                {
                    lblMessage.Text = "The watched folder and destination folder must be different!";
                    lblMessage.ForeColor = Color.IndianRed;
                    timer.Interval = 300;
                    timer.Start();
                    return;
                }
                else
                {
                    ToggleControls();
                    fileSystemWatcher.Path = path;
                    fileSystemWatcher.EnableRaisingEvents = true;
                    path = path.Split("\\").Last();
                    lblMessage.Text = $"Watching folder: {path}";
                    lblMessage.ForeColor = Color.DarkGreen;
                }
            }
            else if (shouldCallToggleControls) 
            {
                ToggleControls();
                lblMessage.Text = "";
                fileSystemWatcher.EnableRaisingEvents = false;
            } 
            else shouldCallToggleControls = true;
        }

        private void fileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            //TODO: call encrypt on new file
            playfairCipher.Encrypt(e.FullPath, folderEncryptDestination);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (ValidateForEncrypt()) playfairCipher.Encrypt(fileEncryptSource, folderEncryptDestination);
            else MessageBox.Show("You must choose a valid source and destination for encryption." +
                "\nFile must be \"*.txt\".",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (ValidateForDecrypt()) playfairCipher.Decrypt(fileDecryptSource, folderDecryptDestination);
            else MessageBox.Show("You must choose a valid source and destination for decryption." +
                "\nFile must be \"*.encrypt.txt\".",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnChooseFolderToWatch_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = "";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (folderEncryptDestination != folderBrowserDialog.SelectedPath)
                {
                    folderToWatch = folderBrowserDialog.SelectedPath;
                    tbChooseFolderToWatch.Text = folderToWatch;
                }
                else
                {
                    MessageBox.Show("The watched folder cannot be the same as destination folder. " +
                        "You must specify a different folder!",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnChooseFolderFSWEncrypt_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = "";
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (folderToWatch != folderBrowserDialog.SelectedPath)
                {
                    folderEncryptDestination = folderBrowserDialog.SelectedPath;
                    tbChooseFolderFSWEncrypt.Text = folderEncryptDestination;
                }
                else
                {
                    MessageBox.Show("The destination folder cannot be the same as watched folder. " +
                        "You must specify a different folder!",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnChooseDestinationDecrypt_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = "";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderDecryptDestination = folderBrowserDialog.SelectedPath;
                tbChooseFolderDecrypt.Text = folderDecryptDestination;
            }
        }
        private void btnChooseFileToEncrypt_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Title = "Choose a file to encrypt";
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileEncryptSource = openFileDialog.FileName;
                tbChooseFileToEncrypt.Text = fileEncryptSource;
            }
        }
        private void btnChooseFileToDecrypt_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Title = "Choose a file to decrypt";
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileDecryptSource = openFileDialog.FileName;
                tbChooseFileToDecrypt.Text = fileDecryptSource;
            }
        }

        private void tbChooseFolderToWatch_TextChanged(object sender, EventArgs e)
        {
            folderToWatch = tbChooseFolderToWatch.Text;
        }

        private void tbChooseFolderFSWEncrypt_TextChanged(object sender, EventArgs e)
        {
            folderEncryptDestination = tbChooseFolderFSWEncrypt.Text;
        }

        private void tbChooseFolderDecrypt_TextChanged(object sender, EventArgs e)
        {
            folderDecryptDestination = tbChooseFolderDecrypt.Text;
        }

        private void tbChooseFileToEncrypt_TextChanged(object sender, EventArgs e)
        {
            fileEncryptSource = tbChooseFileToEncrypt.Text;
        }

        private void tbChooseFileToDecrypt_TextChanged(object sender, EventArgs e)
        {
            fileDecryptSource = tbChooseFileToDecrypt.Text;
        }

        private void Timer_OnTick(object sender, EventArgs e)
        {
            timer.Stop();
            shouldCallToggleControls = false;
            togBtnFSW.Checked = false;
        }

        #endregion
    }
}
