﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Ookii.Dialogs.WinForms;

namespace zpaq_GUI
{
    public partial class ExtractGUI : Form
    {
        private String sourceloc;
        private String destloc;

        //todo: make file list be a dir list?
        //also possibly check if valid, and remove input by using the new OpenFolderDialog thing

        public ExtractGUI(String args)
        {
            InitializeComponent();
            if(args != "") {
                String openedWithFile = args;
                if (openedWithFile.EndsWith(".zpaq")) {
                    Debug.WriteLine("Opened a .zpaq file, processing..");
                    //this.Show();
                    //this.initalizeWithFile(openedWithFile);
                    source_btn.Enabled = false;
                    textBox2.ReadOnly = true;
                    textBox2.Text = openedWithFile;
                    sourceloc = openedWithFile;

                    // TODO: run command list, grab contents then print into listview

                    try {
                        String command = "" + Properties.Settings.Default.zpaq_gui + " list " + sourceloc + "";
                        System.Diagnostics.Debug.WriteLine(command);
                        var startInfo = new System.Diagnostics.ProcessStartInfo {
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            FileName = "cmd.exe",
                            Arguments = "/c " + command
                        };
                        System.Diagnostics.Process process = new System.Diagnostics.Process { StartInfo = startInfo };
                        process.Start();
                        string output = process.StandardOutput.ReadToEnd();
                        //Use REGEX to get the data we want
                        String[] outputlines = output.Split(new[] { "\r\n", "\r", "\n" },StringSplitOptions.None);
                        Regex rgx = new Regex(@"^.*(- ).*$", RegexOptions.Singleline);
                        foreach(String line in outputlines) {
                            var match = rgx.Match(line);
                            if (match.Success) {
                                var dateMatch = Regex.Match(line,
                                    "[0-9][0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9] [0-9][0-9]:[0-9][0-9]:[0-9][0-9]");
                                var sizeMatch = Regex.Match(line, @"(?<=.)\d*(?= [AD])");
                                var fileMatch = Regex.Match(line, @"(?<=[AD]\s{5}).*"); //(?=A).*$
                                DateTime dateModified = DateTime.Parse(dateMatch.ToString());
                                //Grab and compress our file size;
                                string fileSize = compressFileSize(long.Parse(sizeMatch.ToString()),out string byteType) + byteType;
                                //Get the file name.
                                string fileName = fileMatch.ToString();//.Substring(1).Split(' ').ToString();

                                if (!doesItemExist(fileName)) {
                                    var date = dateModified.ToString(CultureInfo.CurrentCulture);
                                    string[] listViewInfo = { fileName, date, fileSize };
                                    filelist.Items.Add(new ListViewItem(listViewInfo));
                                }
                            }
                        }
                        /*foreach (Match fileInfo in rgx.Matches(output)) {
                            System.Diagnostics.Debug.WriteLine(fileInfo);
                            //Parse our date information
                            DateTime dateModified = DateTime.Parse(Regex.Matches(fileInfo.ToString(), $"/[0-9][0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9] [0-9][0-9]:[0-9][0-9]:[0-9][0-9]/gm")[0].ToString());
                            //Grab and compress our file size;
                            string fileSize = compressFileSize(long.Parse(Regex.Matches(fileInfo.ToString(), $"/.............(?= A)/g")[0].ToString()), out string byteType) + byteType;
                            //Get the file name.
                            string fileName = Regex.Matches(fileInfo.ToString(), $"/(?=A).*$/g")[0].ToString().Substring(1).Split(' ').ToString();
                            
                            if (!doesItemExist(fileName)) {
                                string[] listViewInfo = { fileName, dateModified.ToString(), fileSize };
                                filelist.Items.Add(new ListViewItem(listViewInfo));
                            }
                        }*/
                        process.WaitForExit();
                    }catch(Exception err) {
                        MessageBox.Show(err.Message, "Error Listing Files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            
        }

        private void ExtractGUI_Closing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
                this.Owner.Focus();
            }

        }

        private void saveloc_btn_Click(object sender, EventArgs e) {
            VistaFolderBrowserDialog dialog = new VistaFolderBrowserDialog();
            //FolderBrowserDialog dialog = new FolderBrowserDialog();
            //dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
                destloc = dialog.SelectedPath;
                

            }
        }

        private void source_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Zpaq (*.zpaq)|*.zpaq";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dialog.FileName;
                sourceloc = dialog.FileName;
                // TODO: run command list, grab contents then print into listview
                var startInfo = new System.Diagnostics.ProcessStartInfo
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = Properties.Settings.Default.zpaq_gui,
                    Arguments = $"list \"{sourceloc}\""
                };

                Process process = new Process { StartInfo = startInfo };
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                //Use REGEX to get the data we want
                foreach(Match fileInfo in Regex.Matches(output, @"/^.*(- ).*$/gm"))
                {
                    //Parse our date information
                    DateTime dateModified = DateTime.Parse(Regex.Matches(fileInfo.ToString(), $"/[0-9][0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9] [0-9][0-9]:[0-9][0-9]:[0-9][0-9]/gm")[0].ToString());
                    //Grab and compress our file size;
                    string fileSize = compressFileSize(long.Parse(Regex.Matches(fileInfo.ToString(), $"/.............(?= A)/g")[0].ToString()), out string byteType) + byteType;
                    //Get the file name.
                    string fileName = Regex.Matches(fileInfo.ToString(), $"/(?=A).*$/g")[0].ToString().Substring(1).Split(' ').ToString();

                    if (!doesItemExist(fileName))
                    {
                        string[] listViewInfo = { fileName, dateModified.ToString(), fileSize };
                        filelist.Items.Add(new ListViewItem(listViewInfo));
                    }
                }

            }
        }

        private void extract_btn_Click(object sender, EventArgs e)
        {
            //TODO: checks for: sourceloc & destloc
            var startInfo = new ProcessStartInfo {
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                FileName = Properties.Settings.Default.zpaq_gui,
                Arguments = $"extract \"{sourceloc}\" -to \"{destloc}\""
            };

            Process process = new Process { StartInfo = startInfo};
            process.Start();
            var output = process.StandardOutput.ReadToEnd();
            cmd_output.Text = output;
            process.WaitForExit();
        }

        float compressFileSize(long sizeInBytes, out string byteType)
        {
            string[] byteTypes = new string[] { " Bytes", " KB", " MB", " GB", " TB" };
            float size = (float)sizeInBytes;
            int compressionLevel = 0;
            while (size / 1024 >= 1)
            {
                if (compressionLevel == byteTypes.Length - 1) break; //Stop at TB and dont go up to PB (unless added later)
                compressionLevel++;
                size /= 1024;
            }
            byteType = byteTypes[compressionLevel];
            return (float)Math.Round(size, 2);
        }


        bool doesItemExist(string item)
        {
            foreach (ListViewItem viewItem in filelist.Items)
            {
                foreach (ListViewItem.ListViewSubItem items in viewItem.SubItems)
                {
                    if (items.Text == item)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void ExtractGUI_Load(object sender, EventArgs e) {

        }

        private void filelist_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
