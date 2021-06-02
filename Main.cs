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
    public partial class Main : Form
    {
        string ctype;
        public Main(string type)
        {
            InitializeComponent();
            ctype = type;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MapForm map = new MapForm(ctype);
            map.Show();
            this.Hide();
            map.Owner = this;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    
    }
    
}
