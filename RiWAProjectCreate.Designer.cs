namespace RiWABuild
{
    partial class RiWAProjectCreate
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RiWAProjectCreate));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProjPrefix = new System.Windows.Forms.TextBox();
            this.txtProjLocation = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogProjLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnCreateProj = new System.Windows.Forms.Button();
            this.btnCancelProj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProjName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prefix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location";
            // 
            // txtProjPrefix
            // 
            this.txtProjPrefix.Location = new System.Drawing.Point(89, 44);
            this.txtProjPrefix.Name = "txtProjPrefix";
            this.txtProjPrefix.Size = new System.Drawing.Size(160, 20);
            this.txtProjPrefix.TabIndex = 2;
            // 
            // txtProjLocation
            // 
            this.txtProjLocation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtProjLocation.Location = new System.Drawing.Point(89, 72);
            this.txtProjLocation.Name = "txtProjLocation";
            this.txtProjLocation.ReadOnly = true;
            this.txtProjLocation.Size = new System.Drawing.Size(372, 20);
            this.txtProjLocation.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(478, 71);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnCreateProj
            // 
            this.btnCreateProj.Location = new System.Drawing.Point(477, 114);
            this.btnCreateProj.Name = "btnCreateProj";
            this.btnCreateProj.Size = new System.Drawing.Size(75, 23);
            this.btnCreateProj.TabIndex = 5;
            this.btnCreateProj.Text = "Create";
            this.btnCreateProj.UseVisualStyleBackColor = true;
            this.btnCreateProj.Click += new System.EventHandler(this.btnCreateProj_Click);
            // 
            // btnCancelProj
            // 
            this.btnCancelProj.Location = new System.Drawing.Point(14, 114);
            this.btnCancelProj.Name = "btnCancelProj";
            this.btnCancelProj.Size = new System.Drawing.Size(75, 23);
            this.btnCancelProj.TabIndex = 6;
            this.btnCancelProj.Text = "Cancel";
            this.btnCancelProj.UseVisualStyleBackColor = true;
            this.btnCancelProj.Click += new System.EventHandler(this.btnCancelProj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Project name";
            // 
            // txtProjName
            // 
            this.txtProjName.Location = new System.Drawing.Point(89, 16);
            this.txtProjName.Name = "txtProjName";
            this.txtProjName.Size = new System.Drawing.Size(160, 20);
            this.txtProjName.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // RiWAProjectCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 146);
            this.ControlBox = false;
            this.Controls.Add(this.txtProjName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelProj);
            this.Controls.Add(this.btnCreateProj);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtProjLocation);
            this.Controls.Add(this.txtProjPrefix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RiWAProjectCreate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create RiWA Project ";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProjPrefix;
        private System.Windows.Forms.TextBox txtProjLocation;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogProjLocation;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnCreateProj;
        private System.Windows.Forms.Button btnCancelProj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProjName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}