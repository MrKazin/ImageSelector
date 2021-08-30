using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class ImageForm : Form
    {
        public static decimal value = 0;
        public int imgvalue;
        public ImageForm(int imgvalue, bool comboflag, bool listflag)
        {
            InitializeComponent();
            numericUpDown1.Value = 150;
            this.imgvalue = imgvalue;
            if (comboflag.Equals(true) && listflag.Equals(false))  //по имени
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = imageList1.Images[imgvalue];
                linkLabel1.Visible = false;
                linkLabel2.Visible = false;


            }
            else if (comboflag.Equals(false) && listflag.Equals(true)) // по стране
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = imageList1.Images[imgvalue];
                timer1.Interval = 1000;
                timer1.Start();
                
            }
            else if (comboflag.Equals(false) && listflag.Equals(false))
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = imageList1.Images[imgvalue];
                timer1.Interval = 1000;
                timer1.Start();
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 200;
            if (numericUpDown1.Value > value)
            {
                if (value < 201)
                {
                    pictureBox1.Height++;
                    pictureBox1.Width++;
                }
            }
            else
            {
                pictureBox1.Height--;
                pictureBox1.Width--;
            }
            value = numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (imgvalue != 0)
            {
                imgvalue--;
                pictureBox1.Image = imageList1.Images[imgvalue];
            }
            else
            {
                MessageBox.Show("первая фотка");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (imgvalue != 8)
            {
                imgvalue++;
                pictureBox1.Image = imageList1.Images[imgvalue];
            }
            else
            {
                MessageBox.Show("последняя фотка");
            }
        }

        private void ImageForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(imgvalue != 8)
            {
                imgvalue++;
                pictureBox1.Image = imageList1.Images[imgvalue];
                pictureBox1.Show();
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
