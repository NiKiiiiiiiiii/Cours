using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace CourseWork
{
    public partial class MapForm : Form
    {
        public MapForm()
        {
            InitializeComponent();
            ImproveSmokesButtons();
            ImproveFlashesButtons();
            ImproveMollyButtons();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void ImproveSmokesButtons()
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, 10, 10);
            Region myRegion = new Region(myPath);
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2 };
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].Region = myRegion;
                pictureBoxes[i].BackColor = Color.Green;
            }
        }
        private void ImproveFlashesButtons()
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, 10, 10);
            Region myRegion = new Region(myPath);
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2 };
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].Region = myRegion;
                pictureBoxes[i].BackColor = Color.Yellow;
            }
        }
        private void ImproveMollyButtons()
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, 10, 10);
            Region myRegion = new Region(myPath);
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2 };
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].Region = myRegion;
                pictureBoxes[i].BackColor = Color.Red;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(@"");
            lerningForm.Show();
        }
    }
}
