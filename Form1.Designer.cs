namespace RiWABuild
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createRiWAProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutRiWABuildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.SysStsLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStsBarLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvFileEplorer = new System.Windows.Forms.TreeView();
            this.imageListFileExplorer = new System.Windows.Forms.ImageList(this.components);
            this.tabControlEditors = new System.Windows.Forms.TabControl();
            this.conMenuFileXplorer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exploreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelMain.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.conMenuFileXplorer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.menuStripMain, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.statusStripMain, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(801, 477);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(801, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createRiWAProjectToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createRiWAProjectToolStripMenuItem
            // 
            this.createRiWAProjectToolStripMenuItem.Name = "createRiWAProjectToolStripMenuItem";
            this.createRiWAProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createRiWAProjectToolStripMenuItem.Text = "Create RiWA Project";
            this.createRiWAProjectToolStripMenuItem.Click += new System.EventHandler(this.createRiWAProjectToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverSetupToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // serverSetupToolStripMenuItem
            // 
            this.serverSetupToolStripMenuItem.Name = "serverSetupToolStripMenuItem";
            this.serverSetupToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.serverSetupToolStripMenuItem.Text = "Server setup";
            this.serverSetupToolStripMenuItem.Click += new System.EventHandler(this.serverSetupToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutRiWABuildToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutRiWABuildToolStripMenuItem
            // 
            this.aboutRiWABuildToolStripMenuItem.Name = "aboutRiWABuildToolStripMenuItem";
            this.aboutRiWABuildToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.aboutRiWABuildToolStripMenuItem.Text = "About RiWABuild";
            this.aboutRiWABuildToolStripMenuItem.Click += new System.EventHandler(this.aboutRiWABuildToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SysStsLbl,
            this.lblStsBarLbl});
            this.statusStripMain.Location = new System.Drawing.Point(0, 455);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStripMain.Size = new System.Drawing.Size(801, 22);
            this.statusStripMain.TabIndex = 1;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // SysStsLbl
            // 
            this.SysStsLbl.Name = "SysStsLbl";
            this.SysStsLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // lblStsBarLbl
            // 
            this.lblStsBarLbl.Name = "lblStsBarLbl";
            this.lblStsBarLbl.Size = new System.Drawing.Size(12, 17);
            this.lblStsBarLbl.Text = "-";
            this.lblStsBarLbl.TextChanged += new System.EventHandler(this.lblStsBarLbl_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 32);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Panel1.Controls.Add(this.tvFileEplorer);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControlEditors);
            this.splitContainer1.Size = new System.Drawing.Size(795, 413);
            this.splitContainer1.SplitterDistance = 140;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // tvFileEplorer
            // 
            this.tvFileEplorer.AllowDrop = true;
            this.tvFileEplorer.BackColor = System.Drawing.SystemColors.Window;
            this.tvFileEplorer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvFileEplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFileEplorer.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvFileEplorer.ImageIndex = 0;
            this.tvFileEplorer.ImageList = this.imageListFileExplorer;
            this.tvFileEplorer.Location = new System.Drawing.Point(1, 1);
            this.tvFileEplorer.Name = "tvFileEplorer";
            this.tvFileEplorer.SelectedImageIndex = 0;
            this.tvFileEplorer.Size = new System.Drawing.Size(138, 411);
            this.tvFileEplorer.TabIndex = 0;
            this.tvFileEplorer.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tvFileEplorer_AfterLabelEdit);
            this.tvFileEplorer.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvFileEplorer_BeforeExpand);
            this.tvFileEplorer.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tvFileEplorer_ItemDrag);
            this.tvFileEplorer.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvFileEplorer_NodeMouseDoubleClick);
            this.tvFileEplorer.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvFileEplorer_DragDrop);
            this.tvFileEplorer.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvFileEplorer_DragEnter);
            this.tvFileEplorer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tvFileEplorer_MouseUp);
            // 
            // imageListFileExplorer
            // 
            this.imageListFileExplorer.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFileExplorer.ImageStream")));
            this.imageListFileExplorer.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFileExplorer.Images.SetKeyName(0, "MyComputer.png");
            this.imageListFileExplorer.Images.SetKeyName(1, "Drive.png");
            this.imageListFileExplorer.Images.SetKeyName(2, "Folder.png");
            this.imageListFileExplorer.Images.SetKeyName(3, "FILEhtml.png");
            this.imageListFileExplorer.Images.SetKeyName(4, "FILEphp.png");
            this.imageListFileExplorer.Images.SetKeyName(5, "FILEcss.png");
            this.imageListFileExplorer.Images.SetKeyName(6, "FILEjs.png");
            this.imageListFileExplorer.Images.SetKeyName(7, "FILEimage.png");
            this.imageListFileExplorer.Images.SetKeyName(8, "FILEtext.png");
            this.imageListFileExplorer.Images.SetKeyName(9, "FILExml.png");
            this.imageListFileExplorer.Images.SetKeyName(10, "FILErest.png");
            // 
            // tabControlEditors
            // 
            this.tabControlEditors.AllowDrop = true;
            this.tabControlEditors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEditors.Location = new System.Drawing.Point(0, 0);
            this.tabControlEditors.Name = "tabControlEditors";
            this.tabControlEditors.SelectedIndex = 0;
            this.tabControlEditors.ShowToolTips = true;
            this.tabControlEditors.Size = new System.Drawing.Size(650, 413);
            this.tabControlEditors.TabIndex = 0;
            this.tabControlEditors.SelectedIndexChanged += new System.EventHandler(this.tabControlEditors_SelectedIndexChanged);
            this.tabControlEditors.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabControlEditors_DragDrop);
            this.tabControlEditors.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabControlEditors_DragEnter);
            this.tabControlEditors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControlEditors_MouseDown);
            this.tabControlEditors.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tabControlEditors_MouseMove);
            // 
            // conMenuFileXplorer
            // 
            this.conMenuFileXplorer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.addFolderToolStripMenuItem,
            this.addFileToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.exploreToolStripMenuItem});
            this.conMenuFileXplorer.Name = "conMenuFileXplorer";
            this.conMenuFileXplorer.Size = new System.Drawing.Size(131, 136);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // addFolderToolStripMenuItem
            // 
            this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
            this.addFolderToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.addFolderToolStripMenuItem.Text = "Add folder";
            this.addFolderToolStripMenuItem.Click += new System.EventHandler(this.addFolderToolStripMenuItem_Click);
            // 
            // addFileToolStripMenuItem
            // 
            this.addFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hTMLToolStripMenuItem,
            this.pHPToolStripMenuItem,
            this.jSToolStripMenuItem,
            this.cSSToolStripMenuItem,
            this.textToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            this.addFileToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.addFileToolStripMenuItem.Text = "Add file";
            // 
            // hTMLToolStripMenuItem
            // 
            this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hTMLToolStripMenuItem.Text = "HTML";
            this.hTMLToolStripMenuItem.Click += new System.EventHandler(this.hTMLToolStripMenuItem_Click);
            // 
            // pHPToolStripMenuItem
            // 
            this.pHPToolStripMenuItem.Name = "pHPToolStripMenuItem";
            this.pHPToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pHPToolStripMenuItem.Text = "PHP";
            this.pHPToolStripMenuItem.Click += new System.EventHandler(this.pHPToolStripMenuItem_Click);
            // 
            // jSToolStripMenuItem
            // 
            this.jSToolStripMenuItem.Name = "jSToolStripMenuItem";
            this.jSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.jSToolStripMenuItem.Text = "JS";
            this.jSToolStripMenuItem.Click += new System.EventHandler(this.jSToolStripMenuItem_Click);
            // 
            // cSSToolStripMenuItem
            // 
            this.cSSToolStripMenuItem.Name = "cSSToolStripMenuItem";
            this.cSSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cSSToolStripMenuItem.Text = "CSS";
            this.cSSToolStripMenuItem.Click += new System.EventHandler(this.cSSToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // exploreToolStripMenuItem
            // 
            this.exploreToolStripMenuItem.Name = "exploreToolStripMenuItem";
            this.exploreToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.exploreToolStripMenuItem.Text = "Explore";
            this.exploreToolStripMenuItem.Click += new System.EventHandler(this.exploreToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 477);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RiWABuild";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.conMenuFileXplorer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControlEditors;
        private System.Windows.Forms.ToolStripStatusLabel SysStsLbl;
        private System.Windows.Forms.ImageList imageListFileExplorer;
        private System.Windows.Forms.TreeView tvFileEplorer;
        private System.Windows.Forms.ContextMenuStrip conMenuFileXplorer;
        private System.Windows.Forms.ToolStripMenuItem addFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exploreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createRiWAProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblStsBarLbl;
        private System.Windows.Forms.ToolStripMenuItem hTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutRiWABuildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

