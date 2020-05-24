using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class LerningForm : Form
    {
        string urlc1;
        string urlc2;
        public LerningForm(string url)
        {
            string Urlc = url;
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.URL = url;
        }
        public LerningForm(string url, string url2)
        {
            urlc1 = url;
            urlc2 = url2;
            InitializeComponent();
            button1.Visible = true;
            button2.Visible = true;
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.URL = url;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = urlc1;
            //also change description if needs
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = urlc2;
            //also change description if needs
        }
    }
}
