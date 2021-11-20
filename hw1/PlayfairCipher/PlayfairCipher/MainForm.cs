using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayfairCipher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void togBtnFSW_CheckedChanged(object sender, EventArgs e)
        {
            this.lblFSWStatus.Text = this.lblFSWStatus.Text == "ON" ? "OFF" : "ON";
            this.lblChooseFolderToWatch.Enabled = !this.lblChooseFolderToWatch.Enabled;
            this.tbChooseFolderEncrypt.Enabled = !this.tbChooseFolderEncrypt.Enabled;
            this.lblChooseFileToEncrypt.Enabled = !this.lblChooseFileToEncrypt.Enabled;
            this.tbFileToEncrypt.Enabled = !this.tbFileToEncrypt.Enabled;
            this.btnEncrypt.Enabled = !this.btnEncrypt.Enabled;
            this.lblChooseFileToDecrypt.Enabled = !this.lblChooseFileToDecrypt.Enabled;
            this.tbChooseFileToDecrypt.Enabled = !this.tbChooseFileToDecrypt.Enabled;
            this.lblChooseDestFolder.Enabled = !this.lblChooseDestFolder.Enabled;
            this.tbChooseFolderDecrypt.Enabled = !this.tbChooseFolderDecrypt.Enabled;
            this.btnDecrypt.Enabled = !this.btnDecrypt.Enabled;
        }
    }
}
