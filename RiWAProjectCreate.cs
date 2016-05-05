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
    public partial class RiWAProjectCreate : Form
    {
        public RiWAProjectCreate()
        {
            InitializeComponent();
        }


        private void btnCancelProj_Click(object sender, EventArgs e)
        {
            this.Owner.Enabled = true;
            this.Dispose();
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogProjLocation.ShowDialog() == DialogResult.OK)
            {
                txtProjLocation.Text = folderBrowserDialogProjLocation.SelectedPath;
            }
        }


        private void btnCreateProj_Click(object sender, EventArgs e)
        {
            if (!isValidForm()) { return; }

            FileMan fm = new FileMan();

            if (fm.createProject(txtProjLocation.Text.Trim(), txtProjName.Text.Trim(), txtProjPrefix.Text.Trim()))
            {
                this.Owner.Enabled = true;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error while creating project: " + fm._error);
            }
        }


        private bool isValidForm()
        {
            bool noError = true;
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtProjName.Text.Trim()))
            {
                errorProvider1.SetError(txtProjName, "Project name is needed");
                noError = false;
            }

            if (string.IsNullOrEmpty(txtProjLocation.Text.Trim()))
            {
                errorProvider1.SetError(txtProjLocation, "Project location is needed");
                noError = false;
            }
            return noError;
        }
    }
}
