using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zpaq_GUI {
    public partial class intro : Form {
        public intro() {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("http://mattmahoney.net/dc/zpaq715.zip");
        }

        private void label2_Click(object sender, EventArgs e) {

        }
    }
}
