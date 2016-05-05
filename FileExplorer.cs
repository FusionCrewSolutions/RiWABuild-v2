using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Management;

namespace RiWABuild
{
    class FileExplorer
    {


        public string GetNodeNameFromFullPath(string stringPath)
        {
            //Get Name of folder 
            string[] stringSplit = stringPath.Split('\\');
            return stringSplit[stringSplit.Length - 1];
        }

        protected string getFilePathFromNodePath(string stringPath)
        {
            return stringPath.Replace("My Computer\\", "");
        }


        protected ManagementObjectCollection getDrives()
        {
            //get drive collection 
            ManagementObjectSearcher query = new ManagementObjectSearcher("SELECT * From Win32_LogicalDisk ");
            ManagementObjectCollection queryCollection = query.Get();
            return queryCollection;
        }

        public void PopulateDriveList(TreeNode nodeMyComp)
        {
            int imageIndex = 1;
            int selectIndex = 1;

            TreeNodeCollection nodeCollection = nodeMyComp.Nodes;

            //Get Drive list 
            ManagementObjectCollection queryCollection = getDrives();
            foreach (ManagementObject mo in queryCollection)
            {
                switch (int.Parse(mo["DriveType"].ToString()))
                {
                    case 2: //removable drives 
                        imageIndex = 1;
                        selectIndex = 1;
                        break;
                    case 3: //Local drives 
                        imageIndex = 1;
                        selectIndex = 1;
                        break;
                    case 4: //Network drives 
                        imageIndex = 1;
                        selectIndex = 1;
                        break;
                    case 5: //CD rom drives
                        imageIndex = 1;
                        selectIndex = 1;
                        break;

                    default: //defalut to folder 
                        imageIndex = 2;
                        selectIndex = 2;
                        break;
                }

                //create new drive node
                nodeMyComp = new TreeNode(mo["Name"].ToString() + "\\", imageIndex, selectIndex);
                nodeCollection.Add(nodeMyComp);
            }//End of foreach
        }

        public TreeNode PopulateDirectory(TreeNode nodeCurrent)
        {
            try
            {
                nodeCurrent.Nodes.Clear();

                if (Directory.Exists(getFilePathFromNodePath(nodeCurrent.FullPath)))
                {
                    string[] stringDirectories = Directory.GetDirectories(getFilePathFromNodePath(nodeCurrent.FullPath));

                    foreach (string stringDir in stringDirectories)
                    {
                        DirectoryInfo curDirInfo = new DirectoryInfo(stringDir);

                        if (curDirInfo.Attributes.HasFlag(FileAttributes.Hidden))//|| curDirInfo.Attributes.HasFlag(FileAttributes.System)
                        { continue; }

                        TreeNode newNode = new TreeNode(GetNodeNameFromFullPath(stringDir));
                        newNode.ImageIndex = 2;
                        newNode.SelectedImageIndex = 2;
                        newNode.Name = GetNodeNameFromFullPath(stringDir);
                        nodeCurrent.Nodes.Add(newNode);

                        if (nodeCurrent.IsExpanded)
                        {
                            PopulateDirectory(nodeCurrent.Nodes[GetNodeNameFromFullPath(stringDir)]);
                        }
                    }
                    PopulateFiles(nodeCurrent);
                }
            }
            catch (Exception e)
            {
                //SysStsLbl.Text = "Error: " + e;
                MessageBox.Show(e.ToString());
            }
            return nodeCurrent;
        }

        protected void PopulateFiles(TreeNode nodeCurrent)
        {
            if (Directory.Exists((string)getFilePathFromNodePath(nodeCurrent.FullPath)))
            {
                try
                {
                    string[] stringFiles = Directory.GetFiles(getFilePathFromNodePath(nodeCurrent.FullPath));

                    //loop throught all files
                    foreach (string stringFile in stringFiles)
                    {
                        int imgIndex = getFileImageIndex(stringFile);
                        nodeCurrent.Nodes.Add(new TreeNode(GetNodeNameFromFullPath(stringFile), imgIndex, imgIndex));
                    }
                }
                catch (Exception e)
                {
                    //SysStsLbl.Text = "Error: " + e;
                }
            }
        }

        private int getFileImageIndex(string stringFile)
        {
            int imageIndex = 10;

            string[] tempSplit = stringFile.Split('.');
            string extension = tempSplit[tempSplit.Length - 1].ToLower();

            switch (extension)
            {
                case "htm":
                case "html":
                    imageIndex = 3;
                    break;

                case "php":
                    imageIndex = 4;
                    break;

                case "css":
                    imageIndex = 5;
                    break;

                case "js":
                    imageIndex = 6;
                    break;

                case "txt":
                    imageIndex = 8;
                    break;

                case "xml":
                    imageIndex = 9;
                    break;

                case "jpg":
                case "jpeg":
                case "png":
                case "gif":
                    imageIndex = 7;
                    break;
            }

            return imageIndex;
        }

    }
}
