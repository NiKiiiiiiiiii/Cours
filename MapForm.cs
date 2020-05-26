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
using System.IO;

namespace CourseWork
{
    public partial class MapForm : Form
    {
        string path = Directory.GetCurrentDirectory()+ @"\Videos";
        
        public MapForm(string type)
        {
            
            InitializeComponent();
            PictureBox[] AllpictureBoxes = {pictureBox1, pictureBox2,pictureBox4,pictureBox7,pictureBox12, pictureBox13,pictureBox14,pictureBox15,
                pictureBox16,pictureBox17,pictureBox18,pictureBox21,pictureBox23,pictureBox24,pictureBox25,pictureBox26,pictureBox27,pictureBox28,pictureBox29,
                pictureBox33, pictureBox3,pictureBox8,pictureBox9,pictureBox19,pictureBox22, pictureBox11,pictureBox5,pictureBox6,pictureBox10,pictureBox20,
                pictureBox30,pictureBox31,pictureBox32,pictureBox34,pictureBox35};
            PictureBox[] NadespictureBoxes = { pictureBox1, pictureBox2,pictureBox4,pictureBox7,pictureBox12, pictureBox13,pictureBox14,pictureBox15,
                pictureBox16,pictureBox17,pictureBox18,pictureBox21,pictureBox23,pictureBox24,pictureBox25,pictureBox26,pictureBox27,pictureBox28,pictureBox29,
                pictureBox33, pictureBox3,pictureBox8,pictureBox9,pictureBox19,pictureBox22, pictureBox11,pictureBox5,pictureBox6,pictureBox10,pictureBox20,
                pictureBox30,pictureBox31,pictureBox32,pictureBox34};
            PictureBox[] WallbangspictureBoxes = { pictureBox35 };



            for (int i = 0; i < AllpictureBoxes.Length; i++)
            {
                AllpictureBoxes[i].Visible = false;
            }

            if (type=="nades")
            {

                ImproveSmokesButtons();
                ImproveFlashesButtons();
                ImproveMollyButtons();
                for (int i = 0; i < NadespictureBoxes.Length; i++)
                {
                    NadespictureBoxes[i].Visible = true;
                }
            }
            if (type== "wallbangs")
            {
                for (int i = 0; i < WallbangspictureBoxes.Length; i++)
                {
                    WallbangspictureBoxes[i].Visible = true;
                }
                ImproveWallbangsButtons();
            }
           
           
        }
        private void ImproveWallbangsButtons()
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, 12, 12);
            Region myRegion = new Region(myPath);
            PictureBox[] pictureBoxes = { pictureBox35 };
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].Region = myRegion;
                pictureBoxes[i].BackColor = Color.Black;
            }
        }

        private void ImproveSmokesButtons()
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, 12, 12);
            Region myRegion = new Region(myPath);
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2,pictureBox4,pictureBox7,pictureBox12, pictureBox13,pictureBox14,pictureBox15,
                pictureBox16,pictureBox17,pictureBox18,pictureBox21,pictureBox23,pictureBox24,pictureBox25,pictureBox26,pictureBox27,pictureBox28,pictureBox29,
                pictureBox33 };
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].Region = myRegion;
                pictureBoxes[i].BackColor = Color.Green;
            }
        }
        private void ImproveFlashesButtons()
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, 12, 12);
            Region myRegion = new Region(myPath);
            PictureBox[] pictureBoxes = { pictureBox3,pictureBox8,pictureBox9,pictureBox19,pictureBox22, pictureBox11 };
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].Region = myRegion;
                pictureBoxes[i].BackColor = Color.Yellow;
            }
        }
        private void ImproveMollyButtons()
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, 12, 12);
            Region myRegion = new Region(myPath);
            PictureBox[] pictureBoxes = {pictureBox5,pictureBox6,pictureBox10,pictureBox20,pictureBox30,pictureBox31,pictureBox32,pictureBox34 };
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].Region = myRegion;
                pictureBoxes[i].BackColor = Color.Red;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\StairsSmoke.mp4");
            lerningForm.Show();
        }

        private void MapForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\BacksideMolly.MP4");
            lerningForm.Show();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\TopConSmoke.mp4");
            lerningForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\AntiShortFl.MP4");
            lerningForm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\AstralisMid.MP4", path + @"\CtToRamp.MP4");
            lerningForm.Show(); 
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\BanchMolly.MP4");
            lerningForm.Show();
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\BappsClose.MP4", path + @"\BappsDeep.MP4");
            lerningForm.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\BappsPickFlash.MP4");
            lerningForm.Show();
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\UselessSmokeFromTapps.MP4");
            lerningForm.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\BsideFl.MP4");
            lerningForm.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\CarMolly.MP4");
            lerningForm.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\CtOffenciveMidFL.MP4");
            lerningForm.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\CtSmoke.MP4");
            lerningForm.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\CtSmokeFromTetris.MP4");
            lerningForm.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\CtToAppsAgressive.MP4");
            lerningForm.Show();
        }

        private void MapForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\FromMidWindowSmoke.MP4");
            lerningForm.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\JungleSmoke.MP4");
            lerningForm.Show();
            
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\KichenWindow.MP4");
            lerningForm.Show();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\LeftArchFromTspawn.MP4");
            lerningForm.Show();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\MidOutFl.MP4");
            lerningForm.Show();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\NinjaDefoultMolly.MP4");
            lerningForm.Show();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\OutPalaceSmoke.MP4");
            lerningForm.Show();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\RampOutFlMP4.MP4");
            lerningForm.Show();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\RightArchFromTspawn.MP4");
            lerningForm.Show();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\RightArchSmoke.MP4");
            lerningForm.Show();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\ShortSmoke.MP4");
            lerningForm.Show();
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\UnderwoodFromRampMolly.MP4");
            lerningForm.Show(); 
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\UnderwodMolyapps.MP4");
            lerningForm.Show();
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\WindowMolly1.MP4");
            lerningForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\TopMidSmoke.MP4");
            lerningForm.Show();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\WindowSmoke.MP4");
            lerningForm.Show();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\TappsOutOneway.MP4");
            lerningForm.Show();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            LerningForm lerningForm = new LerningForm(path + @"\TopConFromMID.MP4");
            lerningForm.Show();
            
        }
    }
}
