﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //boi add this system.io

namespace zpaq_GUI
{
    public partial class ZPAQ_Main : Form
    {
        
        public ZPAQ_Main()
        {
            InitializeComponent();
        }

        private void dest_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Title = "Save Location";
            file.Filter = "Zpaq (*.zpaq)|*.zpaq";
            if (file.ShowDialog() == DialogResult.OK)
            {
            }
            updateCommand();
        }

        //<summary>
        //Returns a compressed number along with whether its in Kilobytes, Megabytes, etc.
        //</summary>
        float compressFileSize(long sizeInBytes, out string byteType)
        {
            string[] byteTypes = new string[] { " Bytes", " KB", " MB", " GB", " TB" };
            float size = (float)sizeInBytes;
            int compressionLevel = 0;
            while (size / 1000 >= 1)
            {
                if (compressionLevel == byteTypes.Length - 1) break; //Stop at TB and dont go up to PB (unless added later)
                compressionLevel++;
                size /= 1000;
            }
            byteType = byteTypes[compressionLevel];
            return (float)Math.Round(size, 2);
        }

        //<summary>
        //Returns the size (in Bytes) of the folder by recursively going through every folder and adding the sizes of files.
        //</summary>
        long recursiveCheckFolder(string path)
        {
            long byteSize = 0;
            if (Directory.EnumerateDirectories(path).Count() > 0)
            {
                foreach (string dir in Directory.EnumerateDirectories(path))
                    byteSize += recursiveCheckFolder(dir);
            }
            foreach (string file in Directory.EnumerateFiles(path))
                byteSize += new FileInfo(file).Length;
            return byteSize;
        }

        private void files_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog= new OpenFileDialog();
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in dialog.FileNames)
                {
                    string[] row = { file, "0 Bytes" };
                    //TODO: check if exists
                    if (File.Exists(file))
                        row[1] = compressFileSize(new FileInfo(file).Length, out string type) + type; //i gotchu fam
                    listView1.Items.Add(new ListViewItem(row));
                }
                    //add to listview
                    
                
            }
            updateCommand();
        }

        private void folders_add_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            //dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string[] row = {dialog.SelectedPath, compressFileSize(recursiveCheckFolder(dialog.SelectedPath), out string type) + type};
                listView1.Items.Add(new ListViewItem(row));
               
                //add to listview
            }
            updateCommand();
        }

        private void files_remove_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListView.SelectedListViewItemCollection selected = listView1.SelectedItems;
                foreach (ListViewItem item in selected)
                {
                    listView1.Items.RemoveAt(item.Index);
                }
                updateCommand();
            } else {
                MessageBox.Show("No file has been selected.", "ZPAQ GUI", MessageBoxButtons.OK, MessageBoxIcon.Error); //i gotchu
            }
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            Form settings = new settings();
            settings.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) //on start btn
        {
            //TODO: check if dest folder exists
            List<String> Files = new List<String>();
            foreach (ListViewItem file in listView1.Items)
            {
                Files.Add(file.SubItems[0].Text);
            }
            String command = "\"" + Properties.Settings.Default.zpaq_gui + "\" add \"" + dest_txt.Text + "\" " + String.Join(" ", Files.ToArray());

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            var startInfo = new System.Diagnostics.ProcessStartInfo
            {
                UseShellExecute = false,
                RedirectStandardOutput = true,
                FileName = "CMD.exe",
                Arguments = "/c" + command,
            };
            process.StartInfo = startInfo;
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            cmd_output.Text = output;
            process.WaitForExit();

        }


        private void ZPAQ_Main_Load(object sender, EventArgs e)
        {
            updateCommand();
            version_label.Text = $"v{ProductVersion}";
        }

        private void button2_Click(object sender, EventArgs e) //extract gui btn
        {
            ExtractGUI extractor = new ExtractGUI();
            extractor.Owner = this;
            this.Hide();
            extractor.Show();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Jackzmc/zpaq-gui");
        }

        private void command_Clicked(object sender, EventArgs e)
        {
            command_in.SelectAll();
        }

        /* functions */
        private void updateCommand()
        {
            List<String> Files = new List<String>();
            foreach (ListViewItem file in listView1.Items)
            {
                Files.Add("\"" + file.SubItems[0].Text + "\"");
                //Files.ad
            }
            String dest_path = (dest_txt.Text == "") ? "" : dest_txt.Text;
            String command = "\"" + Properties.Settings.Default.zpaq_gui + "\" add " + dest_path + " " + String.Join(" ", Files.ToArray());
            command_in.Text = command;
        }

        private void reportbug_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/Jackzmc/zpaq-gui/issues/new");
        }
    }
}
