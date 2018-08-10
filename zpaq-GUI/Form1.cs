﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                //TODO: check if exists
                dest_txt.Text = file.FileName;
            }
            updateCommand();
        }

        private void files_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog= new OpenFileDialog();
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in dialog.FileNames)
                {
                    string[] row = {file, "0 Bytes"};
                    //TODO: check if exists
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
                string[] row = {dialog.SelectedPath, null };
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
                //tell user no file selected?
            }
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            Form settings = new settings();
            settings.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> Files = new List<String>();
            foreach (ListViewItem file in listView1.Items)
            {
                Files.Add(file.SubItems[0].Text);
            }
            String command = "\"" + Properties.Settings.Default.zpaq_gui + "\" add \"" + dest_txt.Text + "\" " + String.Join(" ", Files.ToArray());

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "CMD.exe";
            startInfo.Arguments = "/c " + command;
            process.StartInfo = startInfo;
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            cmd_output.Text = output;
            process.WaitForExit();

        }

        private void updateCommand()
        {
            List<String> Files = new List<String>();
            foreach (ListViewItem file in listView1.Items)
            {
                Files.Add("\"" + file.SubItems[0].Text + "\"");
                //Files.ad
            }
            String command = "\"" + Properties.Settings.Default.zpaq_gui + "\" add \"" + dest_txt.Text + "\" " + String.Join(" ", Files.ToArray());
            command_in.Text = command;
        }

        private void ZPAQ_Main_Load(object sender, EventArgs e)
        {
            updateCommand();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExtractGUI extractor = new ExtractGUI();
            extractor.Owner = this;
            this.Hide();
            extractor.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Jackzmc/zpaq-gui");
        }
    }
}
