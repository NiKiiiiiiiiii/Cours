﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main main = new Main("nades");
            main.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Main main = new Main("wallbangs");
            main.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main main = new Main("boost");
            main.Show();
        }
    }
}
