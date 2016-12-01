using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // Show the color dialog box. If the user clicks OK, change the
            // PictureBox control's background to the color the user chose.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //Show the open file dialog. If the user clicks OK, 
            //load the picture that the user chose.
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)

            //    {

            //        pictureBox1.Load(openFileDialog1.FileName);
            //   }
            //openFileDialog1.FileName = "http://img.ifcdn.com/images/c36f034dc29c317d32dd7b65a34cf55c2e73ce4c90e38f56d8b63fddf1b736e1_1.jpg";


            pictureBox1.ImageLocation = "http://i.imgur.com/RqXqsIa.jpg";

            //  pictureBox1.ImageLocation = "http://img.ifcdn.com/images/c36f034dc29c317d32dd7b65a34cf55c2e73ce4c90e38f56d8b63fddf1b736e1_1.jpg";
            pictureBox1.Load();



         //   Load(openFileDialog1.FileName)


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the picture
            pictureBox1.Image = null;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // If the user selects the Stretch check box, 
            // change the PictureBox's
            // SizeMode property to "Stretch". If the user clears 
            // the check box, change it to "Normal".
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;

            //clear
            //webscrape tutorial Branch (current default)
<<<<<<< HEAD
            
=======
            //clear
            //Github practice Branch
>>>>>>> refs/remotes/origin/git-hub-practice-1

            //no clear
            //Master trunk
            //No Clear No Header
            //Webscrape Tutorial Branch (Default)
            //No Clear No Header 
            //Github practise Branch
            //No Clear No Header
            //Master
            //NCNH
            // Webscraper Branch 1
            //NCNH
            // Github Tutorial Branch 2
            //NCNH
            //Branch 1 (default)
            // Cant pull from default, but when you change it the others see it.
            //Master
            //Lets change default again and see if I can pull to other branches
            //branch 1 default
            //now it is letting me pull to other branches
            // in master not letting me pull to default branch 1// I synced, now it seems to let me pull
            //master
            //now i am going to see is it lets me pull after making this change
            //in default branch1 now it is letting me pull to master
            //in master
            // in branch 2, no problem
            //in master woo hooo!
<<<<<<< HEAD
            //nothing let me pull request until i synced
            //
=======
            // nothing let me pull request until i synced
            // I am going to change this line
>>>>>>> refs/remotes/origin/master

// branch 2 
// change this line. didnt work try again


        }
    }
}
