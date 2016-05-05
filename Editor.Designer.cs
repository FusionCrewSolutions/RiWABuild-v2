namespace RiWABuild
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.EditorMenuStrip = new System.Windows.Forms.MenuStrip();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.EditorContainer = new System.Windows.Forms.TableLayoutPanel();
            this.EditorPreviewer = new Awesomium.Windows.Forms.WebControl(this.components);
            this.splitContainerEditor = new System.Windows.Forms.SplitContainer();
            this.EditorCoder = new FastColoredTextBoxNS.FastColoredTextBox();
            this.conMenuCoder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertJSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentReadyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventHandlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aJAXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditorDesigner = new System.Windows.Forms.WebBrowser();
            this.imageListAutoComp = new System.Windows.Forms.ImageList(this.components);
            this.cssColor = new System.Windows.Forms.ColorDialog();
            this.EditorMenuStrip.SuspendLayout();
            this.EditorContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEditor)).BeginInit();
            this.splitContainerEditor.Panel1.SuspendLayout();
            this.splitContainerEditor.Panel2.SuspendLayout();
            this.splitContainerEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditorCoder)).BeginInit();
            this.conMenuCoder.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditorMenuStrip
            // 
            this.EditorMenuStrip.BackColor = System.Drawing.Color.White;
            this.EditorMenuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codeToolStripMenuItem,
            this.designToolStripMenuItem,
            this.splitToolStripMenuItem,
            this.toolStripMenuItem1,
            this.previewToolStripMenuItem,
            this.toolStripMenuItem2});
            this.EditorMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.EditorMenuStrip.Name = "EditorMenuStrip";
            this.EditorMenuStrip.Size = new System.Drawing.Size(637, 25);
            this.EditorMenuStrip.TabIndex = 2;
            this.EditorMenuStrip.Text = "menuStrip1";
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.codeToolStripMenuItem.Text = "Code";
            this.codeToolStripMenuItem.Click += new System.EventHandler(this.codeToolStripMenuItem_Click);
            // 
            // designToolStripMenuItem
            // 
            this.designToolStripMenuItem.Name = "designToolStripMenuItem";
            this.designToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.designToolStripMenuItem.Text = "Design";
            this.designToolStripMenuItem.Click += new System.EventHandler(this.designToolStripMenuItem_Click);
            // 
            // splitToolStripMenuItem
            // 
            this.splitToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.splitToolStripMenuItem.Name = "splitToolStripMenuItem";
            this.splitToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.splitToolStripMenuItem.Text = "Split";
            this.splitToolStripMenuItem.Click += new System.EventHandler(this.splitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 21);
            this.toolStripMenuItem1.Text = "|";
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.previewToolStripMenuItem.Text = "Preview";
            this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 21);
            this.toolStripMenuItem2.Text = "|";
            // 
            // EditorContainer
            // 
            this.EditorContainer.BackColor = System.Drawing.Color.White;
            this.EditorContainer.ColumnCount = 1;
            this.EditorContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EditorContainer.Controls.Add(this.EditorPreviewer, 0, 2);
            this.EditorContainer.Controls.Add(this.EditorMenuStrip, 0, 0);
            this.EditorContainer.Controls.Add(this.splitContainerEditor, 0, 1);
            this.EditorContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorContainer.Location = new System.Drawing.Point(0, 0);
            this.EditorContainer.Name = "EditorContainer";
            this.EditorContainer.RowCount = 3;
            this.EditorContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.EditorContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EditorContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.EditorContainer.Size = new System.Drawing.Size(637, 446);
            this.EditorContainer.TabIndex = 3;
            // 
            // EditorPreviewer
            // 
            this.EditorPreviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorPreviewer.Location = new System.Drawing.Point(3, 448);
            this.EditorPreviewer.Size = new System.Drawing.Size(631, 1);
            this.EditorPreviewer.TabIndex = 5;
            this.EditorPreviewer.Tag = "EditorPreviewer";
            // 
            // splitContainerEditor
            // 
            this.splitContainerEditor.BackColor = System.Drawing.Color.White;
            this.splitContainerEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEditor.Location = new System.Drawing.Point(3, 28);
            this.splitContainerEditor.Name = "splitContainerEditor";
            this.splitContainerEditor.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerEditor.Panel1
            // 
            this.splitContainerEditor.Panel1.Controls.Add(this.EditorCoder);
            // 
            // splitContainerEditor.Panel2
            // 
            this.splitContainerEditor.Panel2.Controls.Add(this.EditorDesigner);
            this.splitContainerEditor.Size = new System.Drawing.Size(631, 414);
            this.splitContainerEditor.SplitterDistance = 207;
            this.splitContainerEditor.TabIndex = 4;
            // 
            // EditorCoder
            // 
            this.EditorCoder.AutoCompleteBrackets = true;
            this.EditorCoder.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\'',
        '<',
        '>'};
            this.EditorCoder.AutoIndentChars = false;
            this.EditorCoder.AutoIndentCharsPatterns = "\n^\\s*\\$[\\w\\.\\[\\]\\\'\\\"]+\\s*(?<range>=)\\s*(?<range>[^;]+);\n";
            this.EditorCoder.AutoScrollMinSize = new System.Drawing.Size(0, 15);
            this.EditorCoder.BackBrush = null;
            this.EditorCoder.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.EditorCoder.CharHeight = 15;
            this.EditorCoder.CharWidth = 8;
            this.EditorCoder.ContextMenuStrip = this.conMenuCoder;
            this.EditorCoder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EditorCoder.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.EditorCoder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorCoder.Font = new System.Drawing.Font("Courier New", 10F);
            this.EditorCoder.HighlightingRangeType = FastColoredTextBoxNS.HighlightingRangeType.AllTextRange;
            this.EditorCoder.Hotkeys = resources.GetString("EditorCoder.Hotkeys");
            this.EditorCoder.IsReplaceMode = false;
            this.EditorCoder.Language = FastColoredTextBoxNS.Language.PHP;
            this.EditorCoder.LeftBracket = '(';
            this.EditorCoder.LeftBracket2 = '{';
            this.EditorCoder.Location = new System.Drawing.Point(0, 0);
            this.EditorCoder.Name = "EditorCoder";
            this.EditorCoder.Paddings = new System.Windows.Forms.Padding(0);
            this.EditorCoder.RightBracket = ')';
            this.EditorCoder.RightBracket2 = '}';
            this.EditorCoder.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.EditorCoder.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("EditorCoder.ServiceColors")));
            this.EditorCoder.Size = new System.Drawing.Size(629, 205);
            this.EditorCoder.TabIndex = 2;
            this.EditorCoder.TabLength = 3;
            this.EditorCoder.WordWrap = true;
            this.EditorCoder.Zoom = 100;
            this.EditorCoder.DragDrop += new System.Windows.Forms.DragEventHandler(this.EditorCoder_DragDrop);
            this.EditorCoder.DragEnter += new System.Windows.Forms.DragEventHandler(this.EditorCoder_DragEnter);
            this.EditorCoder.Enter += new System.EventHandler(this.EditorCoder_Enter);
            this.EditorCoder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditorCoder_KeyDown);
            this.EditorCoder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditorCoder_KeyPress);
            this.EditorCoder.Leave += new System.EventHandler(this.EditorCoder_Leave);
            // 
            // conMenuCoder
            // 
            this.conMenuCoder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.findToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.insertJSToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.conMenuCoder.Name = "conMenuEditor";
            this.conMenuCoder.Size = new System.Drawing.Size(159, 136);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.formatToolStripMenuItem.Text = "Format";
            this.formatToolStripMenuItem.Click += new System.EventHandler(this.formatToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.replaceToolStripMenuItem.Text = "Replace";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // insertJSToolStripMenuItem
            // 
            this.insertJSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentReadyToolStripMenuItem,
            this.eventHandlerToolStripMenuItem,
            this.aJAXToolStripMenuItem});
            this.insertJSToolStripMenuItem.Name = "insertJSToolStripMenuItem";
            this.insertJSToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.insertJSToolStripMenuItem.Text = "Insert";
            this.insertJSToolStripMenuItem.Visible = false;
            // 
            // documentReadyToolStripMenuItem
            // 
            this.documentReadyToolStripMenuItem.Name = "documentReadyToolStripMenuItem";
            this.documentReadyToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.documentReadyToolStripMenuItem.Text = "Document.ready()";
            this.documentReadyToolStripMenuItem.Click += new System.EventHandler(this.documentReadyToolStripMenuItem_Click);
            // 
            // eventHandlerToolStripMenuItem
            // 
            this.eventHandlerToolStripMenuItem.Name = "eventHandlerToolStripMenuItem";
            this.eventHandlerToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.eventHandlerToolStripMenuItem.Text = "Event handler";
            this.eventHandlerToolStripMenuItem.Click += new System.EventHandler(this.eventHandlerToolStripMenuItem_Click);
            // 
            // aJAXToolStripMenuItem
            // 
            this.aJAXToolStripMenuItem.Name = "aJAXToolStripMenuItem";
            this.aJAXToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.aJAXToolStripMenuItem.Text = "AJAX";
            this.aJAXToolStripMenuItem.Click += new System.EventHandler(this.aJAXToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // EditorDesigner
            // 
            this.EditorDesigner.AllowNavigation = false;
            this.EditorDesigner.AllowWebBrowserDrop = false;
            this.EditorDesigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorDesigner.IsWebBrowserContextMenuEnabled = false;
            this.EditorDesigner.Location = new System.Drawing.Point(0, 0);
            this.EditorDesigner.MinimumSize = new System.Drawing.Size(20, 20);
            this.EditorDesigner.Name = "EditorDesigner";
            this.EditorDesigner.ScriptErrorsSuppressed = true;
            this.EditorDesigner.Size = new System.Drawing.Size(629, 201);
            this.EditorDesigner.TabIndex = 1;
            this.EditorDesigner.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.EditorDesigner_DocumentCompleted);
            this.EditorDesigner.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditorDesigner_PreviewKeyDown);
            // 
            // imageListAutoComp
            // 
            this.imageListAutoComp.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListAutoComp.ImageStream")));
            this.imageListAutoComp.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListAutoComp.Images.SetKeyName(0, "RDP_remoting_file.png");
            // 
            // cssColor
            // 
            this.cssColor.AnyColor = true;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 446);
            this.Controls.Add(this.EditorContainer);
            this.MainMenuStrip = this.EditorMenuStrip;
            this.Name = "Editor";
            this.Text = "Editor";
            this.EditorMenuStrip.ResumeLayout(false);
            this.EditorMenuStrip.PerformLayout();
            this.EditorContainer.ResumeLayout(false);
            this.EditorContainer.PerformLayout();
            this.splitContainerEditor.Panel1.ResumeLayout(false);
            this.splitContainerEditor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEditor)).EndInit();
            this.splitContainerEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditorCoder)).EndInit();
            this.conMenuCoder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip EditorMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel EditorContainer;
        private System.Windows.Forms.SplitContainer splitContainerEditor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private FastColoredTextBoxNS.FastColoredTextBox EditorCoder;
        private System.Windows.Forms.WebBrowser EditorDesigner;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip conMenuCoder;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ImageList imageListAutoComp;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private Awesomium.Windows.Forms.WebControl EditorPreviewer;
        private System.Windows.Forms.ColorDialog cssColor;
        private System.Windows.Forms.ToolStripMenuItem insertJSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentReadyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventHandlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aJAXToolStripMenuItem;
    }
}