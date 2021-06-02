using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CourseWork
{
    public partial class MyMainMenu : Form
    {
        public MyMainMenu()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Demo files(*.dem)|*.dem|All files(*.*)|*.*";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main main = new Main("nades");
            this.Hide();
            main.Show();
            main.Owner = this;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Main main = new Main("wallbangs");
            this.Hide();
            main.Show();
            main.Owner = this;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main main = new Main("boost");
            this.Hide();
            main.Show();
            main.Owner = this;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            var FileName = @"E:\Demowiever\csgoverview\csgoverview.exe";
            string filename = openFileDialog1.FileName;
            Process.Start(FileName, filename);
        }
    }
}
