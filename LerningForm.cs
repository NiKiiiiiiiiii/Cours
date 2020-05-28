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
        string descc1;
        string descc2;
        public LerningForm(string url)
        {
            string Urlc = url;
            InitializeComponent();
            label1.Visible = false;
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.URL = url;
        }
        public LerningForm(string url,string desc,bool i)
        {
            string Urlc = url;
            InitializeComponent();
            label1.Visible = true;
            label1.Text = desc;
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
            label1.Visible = false;
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.URL = url;
        }
        public LerningForm(string url, string url2,string desc1,string desc2)
        {
            urlc1 = url;
            urlc2 = url2;
            InitializeComponent();
            label1.Visible = true;
            descc1 = desc1;
            descc2 = desc2;
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
            label1.Text = descc1;
            //also change description if needs
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = descc2;
            axWindowsMediaPlayer1.URL = urlc2;
            //also change description if needs
        }
    }
}
