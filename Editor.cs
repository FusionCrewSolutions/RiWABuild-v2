using FastColoredTextBoxNS;
using System;
using System.Drawing;
using System.Windows.Forms;
using TidyManaged;
using System.Collections.Generic;


namespace RiWABuild
{

    public partial class Editor : Form
    {
        public string _filePath = "";
        public string _fileExtension = "";
        private FileMan _fileMan = new FileMan();
        private AutocompleteMenu _autoComp;
        private static Timer _timer = new Timer();//to update CODER on designer change
        private char _lastChar = ' ';//To get the last typed char on the coder
        List<AutocompleteItem> _KeysHTM;
        List<AutocompleteItem> _KeysCss;
        List<AutocompleteItem> _KeysJS;
        List<AutocompleteItem> _KeysPhp;
        private FindForm _findForm = null;
        private ReplaceForm _replaceForm = null;



        public Editor()
        {
            InitializeComponent();
        }


        //File opening in load ----------------------------
        public Editor(string filePath, string extension)
        {
            InitializeComponent();

            _filePath = filePath;
            _fileExtension = extension;
            _findForm = new FindForm(EditorCoder);
            _findForm.Dispose();
            _replaceForm = new ReplaceForm(EditorCoder);
            _replaceForm.Dispose();


            //CODER-------------------------------------------
            //For Intellisense----------
            _KeysHTM = _fileMan.getAutoCompKeys("htm");
            _KeysCss = _fileMan.getAutoCompKeys("css"); ;
            _KeysJS = _fileMan.getAutoCompKeys("js");
            _KeysPhp = _fileMan.getAutoCompKeys("php");

            _autoComp = new AutocompleteMenu(EditorCoder);
            _autoComp.Items.ImageList = imageListAutoComp;
            _autoComp.Items.MaximumSize = new System.Drawing.Size(200, 300);
            _autoComp.Items.Width = 200;
            _autoComp.SearchPattern = @"[\w\:]";

            if (_fileExtension == "htm")
            {
                EditorCoder.Language = Language.HTML;
                _autoComp.Items.SetAutocompleteItems(_KeysHTM);
            }
            else if (_fileExtension == "php")
            {
                EditorCoder.Language = Language.PHP;
                _autoComp.Items.SetAutocompleteItems(_KeysPhp);
            }
            else if (_fileExtension == "js")
            {
                EditorCoder.Language = Language.JS;
                _autoComp.Items.SetAutocompleteItems(_KeysJS);
                insertJSToolStripMenuItem.Visible = true;
            }
            else if (_fileExtension == "css")
            {
                EditorCoder.Language = Language.CSharp;
                _autoComp.Items.SetAutocompleteItems(_KeysCss);
            }

            //Open file to the coder---------
            EditorCoder.Text = (_fileMan.fileOpen(_filePath));
            EditorCoder.Font = new Font("Calibri", 10);
            EditorCoder.Focus();



            //DESIGNER----------------------------------------------------
            if (_fileExtension == "htm" || _fileExtension == "php")
            {
                EditorDesigner.Navigate(_filePath);
                Application.DoEvents();
            }


            refreshDesignerAndPreview();
        }




        //For parent to get the Editor's container
        public Control getContainer()
        {
            return this.EditorContainer;
        }


        public RiWABuild.Form1 getParentForm()
        {
            return ((RiWABuild.Form1)this.EditorContainer.FindForm());
        }





        //EDITOR MENU===================================================================================
        private void initEditorMenuItemColor()
        {
            foreach (ToolStripMenuItem mitem in EditorMenuStrip.Items)
            {
                mitem.BackColor = Color.White;
            }
        }

        //CODE View
        private void codeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initEditorMenuItemColor();
            codeToolStripMenuItem.BackColor = Color.Gainsboro;

            EditorContainer.RowStyles[1].SizeType = SizeType.Percent;
            EditorContainer.RowStyles[1].Height = 100;

            EditorContainer.RowStyles[2].SizeType = SizeType.Absolute;
            EditorContainer.RowStyles[2].Height = 0;

            this.splitContainerEditor.Panel2Collapsed = true;
        }

        //DESIGN View
        private void designToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initEditorMenuItemColor();
            designToolStripMenuItem.BackColor = Color.Gainsboro;

            EditorContainer.RowStyles[1].SizeType = SizeType.Percent;
            EditorContainer.RowStyles[1].Height = 100;

            EditorContainer.RowStyles[2].SizeType = SizeType.Absolute;
            EditorContainer.RowStyles[2].Height = 0;

            this.splitContainerEditor.Panel1Collapsed = true;
        }

        //SPLIT View
        private void splitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initEditorMenuItemColor();
            splitToolStripMenuItem.BackColor = Color.Gainsboro;

            EditorContainer.RowStyles[1].SizeType = SizeType.Percent;
            EditorContainer.RowStyles[1].Height = 100;

            EditorContainer.RowStyles[2].SizeType = SizeType.Absolute;
            EditorContainer.RowStyles[2].Height = 0;

            this.splitContainerEditor.Panel1Collapsed = false;
            this.splitContainerEditor.Panel2Collapsed = false;
            try { this.splitContainerEditor.SplitterDistance = 300; } catch (Exception er) { }
        }

        //PREVIEW View
        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initEditorMenuItemColor();
            previewToolStripMenuItem.BackColor = Color.Gainsboro;

            EditorContainer.RowStyles[1].SizeType = SizeType.Absolute;
            EditorContainer.RowStyles[1].Height = 0;

            EditorContainer.RowStyles[2].SizeType = SizeType.Percent;
            EditorContainer.RowStyles[2].Height = 100;
        }



        //Editor EVENTS----------------------------------------------------------------------------------
        public void editorClose()
        {
            if (_findForm != null)
            { _findForm.Dispose(); }

            if (_replaceForm != null)
            { _replaceForm.Dispose(); }

            this.EditorPreviewer.Dispose();
        }

        private void EditorCoder_Leave(object sender, EventArgs e)
        {
            if (_findForm != null)
            { _findForm.Close(); }

            if (_replaceForm != null)
            { _replaceForm.Close(); }
        }

        private void EditorCoder_Enter(object sender, EventArgs e)
        {
            if (_findForm != null && !_findForm.IsDisposed)
            { _findForm.Show(); }

            if (_replaceForm != null && !_replaceForm.IsDisposed)
            { _replaceForm.Show(); }
        }



        //DESIGNER===================================================================================
        private void EditorDesigner_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //Short Keys--------------------------------------
            if (e.Control && e.KeyCode == Keys.S)// Ctrl+S SAVE
            {
                //e.SuppressKeyPress = true;// Stops bing! Also sets handled which stop event bubbling
                saveFile();
                return;
            }
            else if (e.Control && e.KeyCode == Keys.Q)// Ctrl+Q FORMAT
            {
                //e.SuppressKeyPress = true;
                formatCode();
                return;
            }


            _timer.Tick += new EventHandler(TimerEventProcessor);
            _timer.Interval = 100;
            _timer.Start();
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            _timer.Stop();
            updateCoder();
        }

        public void addImageToDesigner(string imagePath)
        {
            EditorDesigner.Document.ExecCommand("InsertImage", false, imagePath);
            updateCoder();
        }

        private void refreshDesignerAndPreview()
        {
            if (_fileExtension == "htm" || _fileExtension == "php")
            {
                EditorDesigner.Navigate(_filePath);
                EditorDesigner.Refresh();

                if (Properties.Settings.Default.DocRoot.Trim() != "" && _filePath.Contains(Properties.Settings.Default.DocRoot))
                {
                    EditorPreviewer.Source = new Uri(_filePath.Replace(Properties.Settings.Default.DocRoot, Properties.Settings.Default.ServerRoot));
                }
                else
                {
                    EditorPreviewer.Source = new Uri(_filePath);
                }

                EditorPreviewer.Reload(true);
            }
        }


        private void EditorDesigner_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            foreach (HtmlElement el in EditorDesigner.Document.All)
            {
                el.SetAttribute("unselectable", "on");
                el.SetAttribute("contenteditable", "false");
            }

            if (EditorDesigner.Document.Body != null)
            {
                EditorDesigner.Document.Body.SetAttribute("width", (this.Width - 200).ToString() + "px");
                EditorDesigner.Document.Body.SetAttribute("height", "100%");
                EditorDesigner.Document.Body.SetAttribute("contenteditable", "true");
            }
            EditorDesigner.Document.DomDocument.GetType().GetProperty("designMode").SetValue(EditorDesigner.Document.DomDocument, "On", null);
        }



        //CODER EVENTS================================================================================
        private void EditorCoder_KeyDown(object sender, KeyEventArgs e)
        {
            //Short Keys--------------------------------------
            if (e.Control && e.KeyCode == Keys.S)// Ctrl+S SAVE
            {
                e.SuppressKeyPress = true;// Stops bing! Also sets handled which stop event bubbling
                saveFile();
                return;
            }
            else if (e.Control && e.KeyCode == Keys.Q)// Ctrl+Q FORMAT
            {
                e.SuppressKeyPress = true;
                formatCode();
                return;
            }


            //Special chars------------------------------------
            if (e.Modifiers == Keys.Shift && e.KeyCode == Keys.OemSemicolon)
            {
                _lastChar = ':';
            }

            if (e.Modifiers == Keys.Shift && e.KeyCode == Keys.D3)
            {
                if (_lastChar == ':')
                {
                    insertColor();
                    _lastChar = ' ';
                }
            }


            //intellisense-------------------------------------
            if (e.Control && e.KeyCode == Keys.Space)
            {
                //e.SuppressKeyPress = true;
                //Intellisense(_lastChar);
                _autoComp.Show(true);
                e.Handled = true;
                return;
            }

            // e.SuppressKeyPress = false;

            if (e.Control ||
                e.Alt ||
                e.Shift ||
                e.KeyCode == Keys.S && e.Control ||
                e.KeyCode == Keys.F && e.Control ||
                e.KeyCode == Keys.Space && e.Control ||
                e.KeyData == Keys.ControlKey ||
                e.KeyCode == Keys.CapsLock)
            { return; }


            getParentForm().updateFileModificationOnTab(true);
        }

        private void EditorCoder_KeyPress(object sender, KeyPressEventArgs e)
        {
            Intellisense(e.KeyChar);
        }




        //INTELLISENSE---------------------------------------
        private void Intellisense(char keyChar)
        {
            //HTML----------
            if (_fileExtension == "htm")
            {
                int curChar = EditorCoder.PlaceToPosition(EditorCoder.Selection.Start);
                int scriptStart = EditorCoder.Text.IndexOf("<style>");
                int scriptEnd = EditorCoder.Text.IndexOf("</style>");

                if (scriptStart < curChar && scriptEnd > curChar)
                {
                    if (keyChar == ' ')
                    {
                        _autoComp.Items.SetAutocompleteItems(_KeysCss);
                    }
                    else if (keyChar == ':')
                    {
                        _autoComp.Items.SetAutocompleteItems(_KeysCss);
                    }
                }
                else
                {
                    _autoComp.Items.SetAutocompleteItems(_KeysHTM);
                }
            }
            //PHP------------
            else if (_fileExtension == "php")
            {
                int curChar = EditorCoder.PlaceToPosition(EditorCoder.Selection.Start);
                int scriptStart = EditorCoder.Text.IndexOf("<html>");
                int scriptEnd = EditorCoder.Text.IndexOf("</html>");

                if (scriptStart < curChar && scriptEnd > curChar)
                {
                    _autoComp.Items.SetAutocompleteItems(_KeysHTM);
                }

                else if (keyChar == ' ')
                {
                    _autoComp.Items.SetAutocompleteItems(_KeysPhp);
                }
                else if (keyChar == ' ')
                {
                    _autoComp.Items.SetAutocompleteItems(_KeysPhp);
                }
            }

            //CSS------------
            else if (_fileExtension == "css")
            {
                _autoComp.Items.SetAutocompleteItems(_KeysCss);
            }
        }

        private void insertColor()
        {
            int curChar = EditorCoder.PlaceToPosition(EditorCoder.Selection.Start);

            if (_fileExtension == "htm" || _fileExtension == "php")
            {

                int scriptStart = EditorCoder.Text.IndexOf("<style>");
                int scriptEnd = EditorCoder.Text.IndexOf("</style>");

                if (scriptStart < curChar && scriptEnd > curChar)
                {
                    if (cssColor.ShowDialog() == DialogResult.OK)
                    {
                        EditorCoder.Text = EditorCoder.Text.Insert(curChar,
                            "#" + cssColor.Color.R.ToString("X2") + cssColor.Color.G.ToString("X2") + cssColor.Color.B.ToString("X2"));
                    }
                }
            }
            else if (_fileExtension == "css")
            {
                if (cssColor.ShowDialog() == DialogResult.OK)
                {
                    EditorCoder.Text = EditorCoder.Text.Insert(curChar,
                        "#" + cssColor.Color.R.ToString("X2") + cssColor.Color.G.ToString("X2") + cssColor.Color.B.ToString("X2") + ";");
                }
            }

            EditorCoder.Selection.Start = EditorCoder.PositionToPlace(curChar + 9);
        }



        //Drop CSS/JS files on HTM/PHP code
        private void EditorCoder_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void EditorCoder_DragDrop(object sender, DragEventArgs e)
        {
            if (!(_fileExtension == "htm" || _fileExtension == "php")) { return; }



            string[] tempSplit = getParentForm()._openingFile.Split('.');
            string extension = tempSplit[tempSplit.Length - 1].ToLower();

            string element = "";

            if (extension == "css")
            {
                element = "<link href=\"" + getParentForm()._openingFile + "\" rel=\"stylesheet\" type=\"text/css\">";
            }
            else if (extension == "js")
            {
                element = "<script src=\"" + getParentForm()._openingFile + "\"></script>";
            }


            if (extension == "css" || extension == "js")
            {
                int curChar = EditorCoder.PlaceToPosition(EditorCoder.Selection.Start);

                string code = EditorCoder.Text;
                int position = code.IndexOf("<head>") + 6;
                EditorCoder.Text = code.Substring(0, position) + element + code.Substring(position);
                EditorCoder.Selection.Start = EditorCoder.PositionToPlace(curChar);

                formatCode();
                refreshDesignerAndPreview();
            }
        }





        //CODER CON MENU==============================================================================
        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formatCode();
        }

        //SAVE
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        //FIND
        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_replaceForm.IsDisposed)
            { _replaceForm.Dispose(); }

            if (_findForm == null || _findForm.IsDisposed)
            {
                _findForm = (new FindForm(EditorCoder));
                _findForm.Owner = getParentForm();
            }

            _findForm.Show();
            moveChild();
        }

        //REPLACE
        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_findForm.IsDisposed)
            { _findForm.Dispose(); }

            if (_replaceForm == null || _replaceForm.IsDisposed)
            {
                _replaceForm = (new ReplaceForm(EditorCoder));
                _replaceForm.Owner = getParentForm();
            }

            _replaceForm.Show();
            moveChild();
        }

        void moveChild()
        {
            if (_findForm != null)
            {
                _findForm.Location = this.PointToScreen(new Point(EditorCoder.Width - _findForm.Width, 0));
            }

            if (_replaceForm != null)
            {
                _replaceForm.Location = this.PointToScreen(new Point(EditorCoder.Width - _replaceForm.Width, 0));
            }
        }

        //REFRESH
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshDesignerAndPreview();
        }


        //INSERT - JS SNIPPETS---------------------------------
        private void documentReadyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int curChar = EditorCoder.PlaceToPosition(EditorCoder.Selection.Start);

            EditorCoder.Text = EditorCoder.Text.Insert(curChar,
                      "$( document ).ready(function()\n{\n  //your code \n});\n");

            EditorCoder.Selection.Start = EditorCoder.PositionToPlace(curChar);
        }

        private void eventHandlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int curChar = EditorCoder.PlaceToPosition(EditorCoder.Selection.Start);

            EditorCoder.Text = EditorCoder.Text.Insert(curChar,
                      "$(document).on(\"<event>\", \"<element>\", function()\n" +
                      "{\n  //your code\n});\n");

            EditorCoder.Selection.Start = EditorCoder.PositionToPlace(curChar);
        }

        private void aJAXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int curChar = EditorCoder.PlaceToPosition(EditorCoder.Selection.Start);

            EditorCoder.Text = EditorCoder.Text.Insert(curChar,
                      "$.ajax\n({\n" +
                        "method: \"get\",\nurl: \"DCBus.php\",\ndataType: \"html\",\ndata: \"data\"\n})\n" +
                        ".done(function(data)\n{\n  //success code\n})\n" +
                        ".fail(function(jqXHR, textStatus, error)\n{\n  //fail code\n})\n" +
                        ".always(function()\n{\n  //complete code\n});\n");

            EditorCoder.Selection.Start = EditorCoder.PositionToPlace(curChar);
        }





        //FILE FORMAT------------------OTHER-----------------------------------------
        private void formatCode()
        {
            int curChar = EditorCoder.PlaceToPosition(EditorCoder.Selection.Start);

            if (_fileExtension == "htm" || _fileExtension == "php")
            {
                using (Document doc = Document.FromString(EditorCoder.Text))
                {
                    doc.ShowWarnings = false;
                    doc.Quiet = true;
                    doc.OutputXhtml = true;
                    doc.IndentWithTabs = false;
                    doc.IndentSpaces = 3;
                    doc.IndentBlockElements = AutoBool.Yes;
                    doc.DocType = DocTypeMode.Omit;
                    doc.WrapAt = 0;
                    doc.OutputXhtml = false;
                    doc.AttributeSortType = SortStrategy.Alpha;
                    doc.NewBlockLevelTags = "<a>";
                    doc.FixUrlBackslashes = true;
                    doc.CleanAndRepair();

                    this.EditorCoder.Text = doc.Save();
                }


                //this.EditorCoder.Text = this.EditorCoder.Text
                //    .Replace("<meta name=\"generator\" content=", "")
                //    .Replace("\"HTML Tidy for HTML5 for Windows version 5.1.25\" />", "")
                //    .Replace(" xmlns=\"http://www.w3.org/1999/xhtml\"", "")
                //    .Replace("<meta content=\"text/html; charset=utf-8\" http-equiv=", "")
                //    .Replace("\"Content-Type\">", "")
                //    .Replace("\"Content-Type\"&gt;", "")
                //    .Replace("<meta name=\"GENERATOR\" content=\"MSHTML 11.00.10240.16603\">", "")
                //    .Replace("\"HTML Tidy for HTML5 for Windows version 5.1.25\">", "");

                this.EditorCoder.Text = this.EditorCoder.Text
                     .Replace("<meta content=\"HTML Tidy for HTML5 for Windows version 5.1.25\" name=\"generator\">", "")
                     .Replace("</a>", "</a>\r");
            }

            EditorCoder.Selection.Start = EditorCoder.PositionToPlace(curChar);

            getParentForm().updateFileModificationOnTab(true);
        }


        //UPDATE Coder when changes in Designer
        private void updateCoder()
        {
            int line = EditorCoder.Selection.Start.iLine;
            EditorCoder.Text = EditorDesigner.DocumentText;
            formatCode();
            EditorCoder.Navigate(line);

            try
            {
                if (!getParentForm().isTabPageFileModified())
                {
                    getParentForm().updateFileModificationOnTab(true);
                }
            }
            catch (Exception er) { }
        }


        //FILE SAVE
        public bool saveFile()
        {
            if (!_fileMan.fileSave(_filePath, this.EditorCoder.Text))
            {
                //SysStsLbl.Text = _fm._error;
                return false;
            }

            refreshDesignerAndPreview();
            getParentForm().updateFileModificationOnTab(false);

            return true;
        }

    }
}
