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
    public partial class MyMainMenu : Form
    {
        public MyMainMenu()
        {
            InitializeComponent();
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

    }
}
