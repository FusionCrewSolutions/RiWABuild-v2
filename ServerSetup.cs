using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiWABuild
{
    public partial class ServerSetup : Form
    {
        public ServerSetup()
        {
            InitializeComponent();
        }

        private void ServerSetup_Load(object sender, EventArgs e)
        {
            txtDocRoot.Text = Properties.Settings.Default.DocRoot;
            txtServerRoot.Text = Properties.Settings.Default.ServerRoot;
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogProjLocation.ShowDialog() == DialogResult.OK)
            {
                txtDocRoot.Text = folderBrowserDialogProjLocation.SelectedPath;
            }
        }

        private bool isValidForm()
        {
            bool noError = true;
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtServerRoot.Text.Trim()))
            {
                errorProvider1.SetError(txtServerRoot, "Server root is needed");
                noError = false;
            }

            if (string.IsNullOrEmpty(txtDocRoot.Text.Trim()))
            {
                errorProvider1.SetError(txtDocRoot, "Document root is needed");
                noError = false;
            }
            return noError;
        }

        private void btnCreateProj_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DocRoot = txtDocRoot.Text.Trim();
            Properties.Settings.Default.ServerRoot = txtServerRoot.Text.Trim();
            this.Owner.Enabled = true;
            this.Dispose();
        }

        private void btnCancelProj_Click(object sender, EventArgs e)
        {
            this.Owner.Enabled = true;
            this.Dispose();
        }
    }
}
