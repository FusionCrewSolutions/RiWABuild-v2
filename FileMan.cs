using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;


namespace RiWABuild
{
    class FileMan
    {
        public string _error = "";


        public bool addFolder(string path)
        {
            try
            {
                int count = 1;

                string nameOnly = "\\NewFolder";
                string newFullPath = path + nameOnly;

                while (Directory.Exists(newFullPath))
                {
                    newFullPath = string.Format("{0}({1})", path + nameOnly, count++);
                }

                Directory.CreateDirectory(newFullPath);

                return true;
            }
            catch (Exception er)
            {
                _error = er.ToString().Trim();
                return false;
            }
        }

        public bool addFile(string path, string extension)
        {
            try
            {
                int count = 1;

                string nameOnly = "\\NewFile";
                string newFullPath = path + nameOnly + extension;

                while (File.Exists(newFullPath))
                {
                    newFullPath = string.Format("{0}({1})" + extension, path + nameOnly, count++);
                }

                File.Create(newFullPath).Close();
                return true;
            }
            catch (Exception er)
            {
                _error = er.ToString().Trim();
                return false;
            }
        }



        public bool renameFolder(string oldPath, string newPath)
        {
            try
            {
                if (Directory.Exists(newPath))
                {
                    MessageBox.Show("Folder already exists.  Please use a different folder name.");
                    return false;
                }

                Directory.Move(oldPath, newPath);
                return true;
            }
            catch (Exception er)
            {
                _error = er.ToString().Trim();
                return false;
            }
        }

        public bool renameFile(string oldPath, string newPath)
        {
            try
            {
                if (File.Exists(newPath))
                {
                    MessageBox.Show("File already exists. Please use a different file name.");
                }
                File.Move(oldPath, newPath);
                return true;
            }
            catch (Exception er)
            {
                _error = er.ToString().Trim();
                return false;
            }
        }



        public bool removeFolder(string path)
        {
            try
            {
                bool deleteAll = false;

                if (Directory.GetDirectories(path).Length > 0 || Directory.GetFiles(path).Length > 0)
                {

                    if (MessageBox.Show("Do you want to remove everything inside folder?", "Delete all", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        deleteAll = true;
                    }
                    else { return false; }
                }

                Directory.Delete(path, deleteAll);
                return true;
            }
            catch (Exception er)
            {
                _error = er.ToString().Trim();
                return false;
            }
        }

        public bool removeFile(string path)
        {
            try
            {
                File.Delete(path);
                return true;
            }
            catch (Exception er)
            {
                _error = er.ToString().Trim();
                return false;
            }
        }



        public string fileOpen(string path)
        {
            try
            {
                return File.ReadAllText(path);
            }
            catch (Exception er)
            {
                _error = er.ToString().Trim();
                return "";
            }
        }

        public bool fileSave(string path, string content)
        {
            try
            {
                File.WriteAllText(path, content);
                return true;
            }
            catch (Exception er)
            {
                _error = er.ToString().Trim();
                return false;
            }


        }


        public bool createProject(string location, string projName, string prefix)
        {
            try
            {
                if (!Directory.Exists(location))
                {
                    _error = "Directory does not exist";
                    return false;
                }

                string projPath = location + "\\" + projName;
                Directory.CreateDirectory(projPath);
                Directory.CreateDirectory(projPath + "\\" + prefix + "Model");
                Directory.CreateDirectory(projPath + "\\" + prefix + "Controller");
                Directory.CreateDirectory(projPath + "\\" + prefix + "View");
                File.Create(projPath + "\\index.php");
                File.Create(projPath + "\\" + prefix + "Model" + "\\config.php");
                File.Create(projPath + "\\" + prefix + "Model" + "\\" + prefix + "DCBusIndex.php");

            }
            catch (Exception er)
            {
                _error = er.ToString().Trim();
                return false;
            }

            return true;
        }


        public List<AutocompleteItem> getAutoCompKeys(string extension)
        {
            List<AutocompleteItem> keyWords = new List<AutocompleteItem>();

            try
            {
                string[] codeKeys = { "" };

                switch (extension)
                {
                    case "htm":
                        codeKeys = File.ReadAllLines(Application.StartupPath + "\\CodeKeysHTML.txt");
                        break;
                    case "css":
                        codeKeys = File.ReadAllLines(Application.StartupPath + "\\CodeKeysCSS.txt");
                        break;
                    case "js":
                        codeKeys = File.ReadAllLines(Application.StartupPath + "\\CodeKeysJS.txt");
                        break;
                    case "php":
                        codeKeys = File.ReadAllLines(Application.StartupPath + "\\CodeKeysPHP.txt");
                        break;
                }

                foreach (string key in codeKeys)
                {
                    if (extension == "css")
                    {
                        keyWords.Add(new MethodAutocompleteItem2(key, ':'));
                    }
                    else
                    {
                        keyWords.Add(new SnippetAutocompleteItem(key) { ImageIndex = 0 });
                    }
                }
            }
            catch (Exception er) { }

            return keyWords;
        }
    }// END of FileMan class

    public class MethodAutocompleteItem2 : MethodAutocompleteItem
    {
        string _firstPart;
        string _lastPart;
        char _delimeter;

        public MethodAutocompleteItem2(string text, char delimeter) : base(text)
        {
            var i = text.LastIndexOf(delimeter);
            if (i < 0)
                _firstPart = text;
            else
            {
                _firstPart = text.Substring(0, i);
                _lastPart = text.Substring(i + 1);
                _delimeter = delimeter;
            }
        }

        public override CompareResult Compare(string fragmentText)
        {
            int i = fragmentText.LastIndexOf(_delimeter);

            if (i < 0)
            {
                if (_firstPart.StartsWith(fragmentText) && string.IsNullOrEmpty(_lastPart))
                    return CompareResult.VisibleAndSelected;
                //if (firstPart.ToLower().Contains(fragmentText.ToLower()))
                //  return CompareResult.Visible;
            }
            else
            {
                var fragmentFirstPart = fragmentText.Substring(0, i);
                var fragmentLastPart = fragmentText.Substring(i + 1);


                if (_firstPart != fragmentFirstPart)
                    return CompareResult.Hidden;

                if (_lastPart != null && _lastPart.StartsWith(fragmentLastPart))
                    return CompareResult.VisibleAndSelected;

                if (_lastPart != null && _lastPart.ToLower().Contains(fragmentLastPart.ToLower()))
                    return CompareResult.Visible;

            }

            return CompareResult.Hidden;
        }

        public override string GetTextForReplace()
        {
            if (_lastPart == null)
                return _firstPart;

            return _firstPart + _delimeter + _lastPart;
        }

        public override string ToString()
        {
            if (_lastPart == null)
                return _firstPart;

            return _lastPart;
        }
    }
}
