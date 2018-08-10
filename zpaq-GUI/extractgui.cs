using System;
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
    public partial class ExtractGUI : Form
    {
        private String sourceloc;
        private String destloc;
        public ExtractGUI()
        {
            InitializeComponent();
        }

        private void ExtractGUI_Closing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
                this.Owner.Focus();
            }

        }

        private void saveloc_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
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
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dialog.FileName;
                sourceloc = dialog.FileName;
                // TODO: run command list, grab contents then print into listview
                String command = "\"" + Properties.Settings.Default.zpaq_gui + "\" list \"" + sourceloc + "\"";

                var startInfo = new System.Diagnostics.ProcessStartInfo
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    FileName = "CMD.EXE",
                    Arguments = "/c " + command
                };

                System.Diagnostics.Process process = new System.Diagnostics.Process { StartInfo = startInfo };
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                //
            }
        }

        private void extract_btn_Click(object sender, EventArgs e)
        {
            String command = "\"" + Properties.Settings.Default.zpaq_gui + "\" extract \"" + sourceloc + "\" -to \"" + destloc + "\"";

            var startInfo = new System.Diagnostics.ProcessStartInfo {
                UseShellExecute = false,
                RedirectStandardOutput = true,
                FileName = "CMD.EXE",
                Arguments = "/c " + command
            };

            System.Diagnostics.Process process = new System.Diagnostics.Process {StartInfo = startInfo};
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
        }
    }
}
