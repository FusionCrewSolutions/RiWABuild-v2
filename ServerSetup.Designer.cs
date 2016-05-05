namespace RiWABuild
{
    partial class ServerSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerSetup));
            this.txtDocRoot = new System.Windows.Forms.TextBox();
            this.txtServerRoot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialogProjLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCancelProj = new System.Windows.Forms.Button();
            this.btnCreateProj = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDocRoot
            // 
            this.txtDocRoot.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDocRoot.Location = new System.Drawing.Point(94, 44);
            this.txtDocRoot.Name = "txtDocRoot";
            this.txtDocRoot.ReadOnly = true;
            this.txtDocRoot.Size = new System.Drawing.Size(372, 20);
            this.txtDocRoot.TabIndex = 12;
            // 
            // txtServerRoot
            // 
            this.txtServerRoot.Location = new System.Drawing.Point(94, 16);
            this.txtServerRoot.Name = "txtServerRoot";
            this.txtServerRoot.Size = new System.Drawing.Size(372, 20);
            this.txtServerRoot.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Document root";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Server root";
            // 
            // btnCancelProj
            // 
            this.btnCancelProj.Location = new System.Drawing.Point(19, 86);
            this.btnCancelProj.Name = "btnCancelProj";
            this.btnCancelProj.Size = new System.Drawing.Size(75, 23);
            this.btnCancelProj.TabIndex = 15;
            this.btnCancelProj.Text = "Cancel";
            this.btnCancelProj.UseVisualStyleBackColor = true;
            this.btnCancelProj.Click += new System.EventHandler(this.btnCancelProj_Click);
            // 
            // btnCreateProj
            // 
            this.btnCreateProj.Location = new System.Drawing.Point(482, 86);
            this.btnCreateProj.Name = "btnCreateProj";
            this.btnCreateProj.Size = new System.Drawing.Size(75, 23);
            this.btnCreateProj.TabIndex = 14;
            this.btnCreateProj.Text = "Setup";
            this.btnCreateProj.UseVisualStyleBackColor = true;
            this.btnCreateProj.Click += new System.EventHandler(this.btnCreateProj_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(483, 43);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // ServerSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 121);
            this.ControlBox = false;
            this.Controls.Add(this.txtDocRoot);
            this.Controls.Add(this.txtServerRoot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelProj);
            this.Controls.Add(this.btnCreateProj);
            this.Controls.Add(this.btnBrowse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerSetup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Setup";
            this.Load += new System.EventHandler(this.ServerSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDocRoot;
        private System.Windows.Forms.TextBox txtServerRoot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogProjLocation;
        private System.Windows.Forms.Button btnCancelProj;
        private System.Windows.Forms.Button btnCreateProj;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}