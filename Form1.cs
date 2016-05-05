using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;

namespace RiWABuild
{
    //File path on Tab page's Tag

    public partial class Form1 : Form
    {

        public string _openingFile = "";
        private string _oldPath = "";//for renaming folder/file
        private FileMan _fm = new FileMan();
        private Dictionary<string, Editor> _editors;
        private TabPage _dragTabPage;

        private static Timer myTimer = new Timer();//to clear status bar




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _editors = new Dictionary<string, Editor>();

            TreeNode rootNode = new TreeNode("My Computer", 0, 0);
            tvFileEplorer.Nodes.Add(rootNode);
            (new FileExplorer()).PopulateDriveList(rootNode);
            tvFileEplorer.Nodes[0].Expand();

        }



        //errors msgs
        private void lblStsBarLbl_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(lblStsBarLbl.Text);//Uncomment if want to read the expetions 

            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 5000;
            myTimer.Start();
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            myTimer.Stop();
            if (lblStsBarLbl.Text != "")
            {
                lblStsBarLbl.Text = "";
            }
        }



        private string getTabPageFilePath()
        {
            return tabControlEditors.SelectedTab.Tag.ToString();
        }

        private string getTabPageFileExtension()
        {
            string[] tempTabNameSplit = getTabPageFilePath().Split('.');
            string extension = tempTabNameSplit[tempTabNameSplit.Length - 1].ToLower();
            if (extension == "html") { extension = "htm"; }//Common extension
            return extension;
        }


        public bool isTabPageFileModified()
        {
            if (tabControlEditors.SelectedTab.Text.Substring(tabControlEditors.SelectedTab.Text.Length - 1, 1) == "*")
            {
                return true;
            }
            return false;
        }

        public bool isTabPageFileModified(TabPage tp)
        {
            if (tp.Text.Substring(tp.Text.Length - 1, 1) == "*")
            {
                return true;
            }
            return false;
        }




        //Main MENU==========================================================================================
        private void createRiWAProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RiWAProjectCreate newProj = new RiWAProjectCreate();
            newProj.Owner = this;
            this.Enabled = false;
            newProj.Show();
        }

        //SERVER Setup
        private void serverSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServerSetup ss = new ServerSetup();
            ss.Owner = this;
            this.Enabled = false;
            ss.Show();
        }

        //About
        private void aboutRiWABuildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Owner = this;
            this.Enabled = false;
            about.Show();
        }

        //Help
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon");
        }







        //==EXPLORER=========================================================================================
        private string getActualPath(string path)
        {
            return path.Replace("My Computer\\", "").Replace("\\\\", "\\");
        }


        //EXPAND FOLDER-------
        private void tvFileEplorer_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            for (int x = 0; x < e.Node.Nodes.Count; x++)
            { (new FileExplorer()).PopulateDirectory(e.Node.Nodes[x]); }
        }



        //SHOW context menu-----------------------------------------------------------------
        private void tvFileEplorer_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tvFileEplorer.SelectedNode = tvFileEplorer.GetNodeAt(e.X, e.Y);
                if (tvFileEplorer.SelectedNode.ImageIndex == 0) { return; }

                refreshToolStripMenuItem.Enabled = false;
                addFolderToolStripMenuItem.Enabled = false;
                addFileToolStripMenuItem.Enabled = false;
                renameToolStripMenuItem.Enabled = false;
                removeToolStripMenuItem.Enabled = false;


                //drives
                if (tvFileEplorer.SelectedNode.ImageIndex == 1)
                {
                    refreshToolStripMenuItem.Enabled = true;
                    addFolderToolStripMenuItem.Enabled = true;
                    addFileToolStripMenuItem.Enabled = true;
                }

                //folders
                if (tvFileEplorer.SelectedNode.ImageIndex == 2)
                {
                    refreshToolStripMenuItem.Enabled = true;
                    addFolderToolStripMenuItem.Enabled = true;
                    addFileToolStripMenuItem.Enabled = true;
                    renameToolStripMenuItem.Enabled = true;
                    removeToolStripMenuItem.Enabled = true;
                }

                //files
                if (tvFileEplorer.SelectedNode.ImageIndex >= 3)
                {
                    renameToolStripMenuItem.Enabled = true;
                    removeToolStripMenuItem.Enabled = true;
                }

                _openingFile = getActualPath(tvFileEplorer.SelectedNode.FullPath);
                conMenuFileXplorer.Show(tvFileEplorer, e.Location);
            }
        }

        //Con MENU - REFRESH
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FileExplorer()).PopulateDirectory(tvFileEplorer.SelectedNode);
        }

        //Con MENU - ADD FOLDER
        private void addFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_fm.addFolder(_openingFile))
            {
                (new FileExplorer()).PopulateDirectory(tvFileEplorer.SelectedNode);

                foreach (TreeNode tn in tvFileEplorer.SelectedNode.Nodes)
                {
                    if (tn.Text == "New Folder")
                    {
                        tvFileEplorer.SelectedNode = tn;
                        break;
                    }
                }
            }
            else
            {
                SysStsLbl.Text = _fm._error;
            }
            _openingFile = "";
        }



        //Con MENU - ADD FILE---------------------------------------------------------------
        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFile("htm");
        }

        //PHP
        private void pHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFile("php");
        }

        //JS
        private void jSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFile("js");
        }

        //CSS
        private void cSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFile("css");
        }

        //TXT
        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFile("txt");
        }

        //XML
        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFile("xml");
        }

        //ADD FILE
        private void addFile(string extension)
        {
            if (_fm.addFile(_openingFile, "." + extension))
            {
                (new FileExplorer()).PopulateDirectory(tvFileEplorer.SelectedNode);
            }
            else
            {
                SysStsLbl.Text = _fm._error;
            }
            _openingFile = "";
        }



        //Con MENU - RENAME FILE/FOLDER--------------------------------------------
        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _oldPath = getActualPath(tvFileEplorer.SelectedNode.FullPath);
            tvFileEplorer.LabelEdit = true;
            tvFileEplorer.SelectedNode.BeginEdit();
        }

        private void tvFileEplorer_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label != null && e.Label.Length > 0)
            {
                if (e.Label.IndexOfAny(new char[] { '@', ',', '!', '#', '%', '^', '*' }) == -1)
                {
                    e.Node.Text = e.Label;
                    _openingFile = getActualPath(tvFileEplorer.SelectedNode.FullPath);


                    if (tvFileEplorer.SelectedNode.ImageIndex == 2)
                    {
                        if (!_fm.renameFolder(_oldPath, _openingFile))
                        {
                            SysStsLbl.Text = _fm._error;
                        }
                    }
                    else if (tvFileEplorer.SelectedNode.ImageIndex >= 3)
                    {
                        if (_fm.renameFile(_oldPath, _openingFile))
                        {
                            renameMoveFile();
                        }
                        else { SysStsLbl.Text = _fm._error; }
                    }
                }
            }
            e.Node.EndEdit(false);
            e.CancelEdit = true;
            tvFileEplorer.LabelEdit = false;

            (new FileExplorer()).PopulateDirectory(tvFileEplorer.SelectedNode.Parent);
        }



        //Con MENU - REMOVE FILE/FOLDER---------------------------------------------
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if its open, no removing
            foreach (TabPage tp in tabControlEditors.TabPages)
            {
                if (getActualPath(tvFileEplorer.SelectedNode.FullPath) == tp.Tag.ToString())
                {
                    MessageBox.Show("File is already opened. Close file first to remove");
                    return;
                }
            }


            if (tvFileEplorer.SelectedNode.ImageIndex == 2)
            {
                if (!_fm.removeFolder(getActualPath(tvFileEplorer.SelectedNode.FullPath)))
                {
                    SysStsLbl.Text = _fm._error;
                }
            }
            else if (tvFileEplorer.SelectedNode.ImageIndex >= 3)
            {
                if (!(_fm.removeFile(getActualPath(tvFileEplorer.SelectedNode.FullPath))))
                {
                    SysStsLbl.Text = _fm._error;
                }
            }

            (new FileExplorer()).PopulateDirectory(tvFileEplorer.SelectedNode.Parent);
        }


        //Con MENU - EXPLORE--------------------------------------------------------
        private void exploreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(getActualPath(tvFileEplorer.SelectedNode.FullPath));
        }




        //DRAG n DROP OPEN----DEPRICATED for file opening------------------------------------------------
        private void tvFileEplorer_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (((TreeNode)e.Item).ImageIndex < 3)
            {
                MessageBox.Show("Moving non file is not allowed");
                return;
            }

            ((TreeView)sender).SelectedNode = (TreeNode)e.Item;
            _openingFile = getActualPath(((TreeView)sender).SelectedNode.FullPath);
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void tvFileEplorer_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        //MOVE FILES by DRAG n DROP---------------
        private void tvFileEplorer_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
            {
                TreeNode curNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

                Point pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
                TreeNode destinationNode = ((TreeView)sender).GetNodeAt(pt);

                if (destinationNode.Nodes.Find((new FileExplorer()).GetNodeNameFromFullPath(_openingFile), false).Length > 0)
                {
                    MessageBox.Show("Cannot move, similar file already exists in target folder.");
                    return;
                }

                _oldPath = getActualPath(curNode.FullPath);
                _openingFile = getActualPath(destinationNode.FullPath) + "\\" + _oldPath.Split('\\').Last();


                if (_fm.renameFile(_oldPath, _openingFile))
                {

                    destinationNode.Nodes.Add((TreeNode)curNode.Clone());
                    destinationNode.Expand();

                    //Remove Original Node
                    curNode.Remove();

                    renameMoveFile();
                }
                else
                {
                    SysStsLbl.Text = _fm._error;
                }
            }
        }





        //--FILE OPEN from Explorer----------------------------------------------------------------------
        private void tvFileEplorer_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            _openingFile = getActualPath(e.Node.FullPath);
            fileOpen();
            e.Node.Tag = "opened";
        }

        private void fileOpen()
        {
            if (_openingFile == "") { return; }//Just for safe, to make sure only files can be opened

            try
            {
                string tabName = (new FileExplorer()).GetNodeNameFromFullPath(_openingFile);

                string[] tempTabNameSplit = tabName.Split('.');
                string extension = tempTabNameSplit[tempTabNameSplit.Length - 1].ToLower();
                if (extension == "html") { extension = "htm"; }//Common extension

                //IF IMAGE add to designer--------------------
                if (extension == "jpg"
                || extension == "jepg"
                || extension == "png")
                {
                    if (tabControlEditors.TabCount > 0 && (getTabPageFileExtension() == "htm" || getTabPageFileExtension() == "php"))
                    {
                        if (_editors.ContainsKey(getTabPageFilePath()))
                        {
                            _editors[getTabPageFilePath()].addImageToDesigner(_openingFile);
                            return;
                        }
                    }
                }

                //ONLY THESE EXTENSIONS-----------------------
                if (!(extension == "htm"
                    || extension == "php"
                    || extension == "js"
                    || extension == "css"
                    || extension == "xml"
                    || extension == "txt"
                    ))
                { return; }


                //if the file is already opened, just select the tab page
                foreach (TabPage tp in tabControlEditors.TabPages)
                {
                    if (tp.Tag.ToString() == _openingFile)
                    {
                        tabControlEditors.SelectedTab = tp;
                        return;
                    }
                }


                //Update EDITORS LIST
                if (!_editors.ContainsKey(_openingFile))
                {
                    Editor temp = new Editor(_openingFile, extension);
                    _editors.Add(_openingFile, temp);
                }


                //Create new tab-----------------------------------------------------
                tabControlEditors.TabPages.Add(_openingFile, "x     " + tabName);
                tabControlEditors.TabPages[_openingFile].Tag = _openingFile;
                tabControlEditors.TabPages[_openingFile].ToolTipText = _openingFile;
                tabControlEditors.TabPages[_openingFile].Controls.Add(_editors[_openingFile].getContainer());
                tabControlEditors.SelectedTab = tabControlEditors.TabPages[_openingFile];

                //DONE-----
                _openingFile = "";
            }
            catch (Exception er)
            {
                //MessageBox.Show(er.ToString());
                lblStsBarLbl.Text = er.ToString();
            }
        }



        //--FILE RENAME from Explorer----------------------------
        private void renameMoveFile()
        {
            foreach (TabPage tp in tabControlEditors.TabPages)
            {
                if (tp.Tag.ToString() == _oldPath)
                {
                    tabControlEditors.TabPages.Remove(tp);
                    fileOpen();
                    break;
                }
            }
        }







        //==TAB=======================================================================================================
        private void tabControlEditors_DragEnter(object sender, DragEventArgs e)
        {
            //------DRAG n DROP OPEN---- Depricated - not used for open file----------
            // e.Effect = DragDropEffects.Move;
        }

        private void tabControlEditors_DragDrop(object sender, DragEventArgs e)
        {
            //fileOpen();
        }


        //Tab Page Change
        private void tabControlEditors_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControlEditors.TabCount > 0)
                {
                    tabControlEditors.SelectedTab.Controls.Find("EditorCoder", true)[0].Focus();
                }
            }
            catch (Exception er) { }
        }


        //Update modification status on TAB name
        public void updateFileModificationOnTab(bool isModified)
        {
            if (!isTabPageFileModified() && isModified)
            {
                tabControlEditors.SelectedTab.Text += " *";
            }
            if (!isModified)
            {
                tabControlEditors.SelectedTab.Text = tabControlEditors.SelectedTab.Text.Replace(" *", "");
            }
        }

        //Get the clicked tab page for closing or dragging
        private TabPage TabAt(Point position)
        {
            int count = tabControlEditors.TabCount;

            for (int i = 0; i < count; i++)
            {
                if (tabControlEditors.GetTabRect(i).Contains(position))
                {
                    return tabControlEditors.TabPages[i];
                }
            }

            return null;
        }



        //CLOSE TAB PAGE-----------------------
        private void tabControlEditors_MouseDown(object sender, MouseEventArgs e)
        {
            _dragTabPage = TabAt(e.Location);

            for (int i = 0; i < this.tabControlEditors.TabPages.Count; i++)
            {
                Rectangle r = tabControlEditors.GetTabRect(i);
                Rectangle closeButton = new Rectangle(r.Left, r.Top, 16, 20);//Getting the position of the "x" mark.

                if (closeButton.Contains(e.Location))
                {
                    this.tabControlEditors.SelectedIndex = i;

                    if (isTabPageFileModified())
                    {
                        DialogResult result = MessageBox.Show("Save and close file?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                        if (result == DialogResult.Cancel) { return; }

                        if (result == DialogResult.Yes)
                        {
                            if (!_editors[getTabPageFilePath()].saveFile())
                            {
                                lblStsBarLbl.Text = "Error while saving file";
                                return;
                            }
                        }

                        //if (_editors.ContainsKey(getTabPageFilePath()))
                        //{
                        //    _editors[getTabPageFilePath()].editorClose();
                        //    _editors.Remove(getTabPageFilePath());
                        //}

                        //this.tabControlEditors.TabPages.RemoveAt(i);
                        //break;
                    }
                    //else
                    //{

                    
                    if (_editors.ContainsKey(getTabPageFilePath()))
                    {
                        _editors[getTabPageFilePath()].editorClose();
                        _editors.Remove(getTabPageFilePath());
                    }
                    this.tabControlEditors.TabPages.Remove(_dragTabPage);
                    break;
                    //}
            }
        }//End of FOR
    }


    //Re-Order Tabs------
    private void tabControlEditors_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left || _dragTabPage == null)
        {
            return;
        }

        TabPage tab = TabAt(e.Location);

        if (tab == null || tab == _dragTabPage)
        {
            return;
        }

        int i = tabControlEditors.TabPages.IndexOf(_dragTabPage);
        int j = tabControlEditors.TabPages.IndexOf(tab);

        if (i >= 0 && j >= 0)
        {
            tabControlEditors.TabPages[i] = tab;
            tabControlEditors.TabPages[j] = _dragTabPage;

            tabControlEditors.SelectedTab = _dragTabPage;
        }
    }





    //CLOSE the APP-------------------------------------------------------
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        //e.Cancel = true;

        bool isModified = false;

        foreach (TabPage tp in tabControlEditors.TabPages)
        {
            if (isTabPageFileModified(tp))
            {
                isModified = true;
                break;
            }
        }

        if (isModified)
        {
            DialogResult result = MessageBox.Show("Save file(s) and exit?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel) { return; }

            if (result == DialogResult.No) { this.Dispose(); }


            if (result == DialogResult.Yes)
            {
                foreach (TabPage tp in tabControlEditors.TabPages)
                {
                    tabControlEditors.SelectedTab = tp;

                    if (!_editors[getTabPageFilePath()].saveFile())
                    {
                        lblStsBarLbl.Text = "Error while saving file " + getTabPageFilePath();
                        return;
                    }
                }
            }
        }

        this.Dispose();
        Application.Exit();
        Process.GetCurrentProcess().Kill();
    }


}//End of CLASS
}//End of NAMESPACE
