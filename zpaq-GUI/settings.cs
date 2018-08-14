using BrendanGrant.Helpers.FileAssociation;
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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://mattmahoney.net/dc/zpaq715.zip");
        }

        private void browe_zpaq_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                //TODO: check if exists
                zpaq_path.Text = file.FileName;
                Properties.Settings.Default.zpaq_gui = file.FileName;
                Properties.Settings.Default.Save();
                this.Close(); //close settings window (on select)
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //no need to save, just closes (should work fine?)
            this.Close(); //close settings window
        }
        private void settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.zpaq_gui = zpaq_path.Text;
            Properties.Settings.Default.Save();
            System.Diagnostics.Debug.WriteLine("saved " + zpaq_path.Text);
        }

        private void settings_Load(object sender, EventArgs e)
        {
            zpaq_path.Text = Properties.Settings.Default.zpaq_gui;
        }


        private void label3_Click(object sender, EventArgs e) {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            //run with admin - set file assoc
            FileAssociationInfo fai = new FileAssociationInfo(".zpaq");
            if (!fai.Exists) {
                fai.Create("zpaq_gui");
                //fai.ContentType = "application/zpaq"; //MIME type (is optional)
                fai.OpenWithList = new string[] { "zpaq-gui.exe" };
            }
            ProgramAssociationInfo pai = new ProgramAssociationInfo(fai.ProgID);
            if (!pai.Exists) {
                pai.Create
                (
                //Description of program/file type
                ".zpaq compression",

                new ProgramVerb
                     (
                     //Verb name
                     "Open",
                     //Path and arguments to use

                     System.Reflection.Assembly.GetEntryAssembly().Location
                     )
                   );

                //optional
                pai.DefaultIcon = new ProgramIcon(@"C:\SomePath\SomeIcon.ico");
            }
        }
    }
}
