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
    public partial class Form1 : Form
    {
        public int imgvalue = 0;
        public bool comboflag = false;
        public bool listflag = false;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text.Equals("Exit"))
            {
                Application.Exit();
            }
            else
            {
                ImageForm NewForm = new ImageForm(imgvalue, comboflag, listflag);
                NewForm.Show();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            button1.Enabled = false;
            switch (checkBox1.CheckState)
            {
                case CheckState.Checked:
                    panel1.Enabled = true;
                    break;
                case CheckState.Unchecked:
                    panel1.Enabled = false;
                    comboBox1.SelectedIndex = -1;
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    break;

            }
            switch (checkBox2.CheckState)
            {
                case CheckState.Checked:
                    panel2.Enabled = true;
                    
                    break;
                case CheckState.Unchecked:
                    listBox1.SelectedIndex = -1;
                    panel2.Enabled = false;
                    
                    break;

            }

            if(checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                button2.Text = "Show";
            }
            else
            {
                button2.Text = "Exit";
            }

            if (checkBox1.Checked && checkBox2.Checked || checkBox1.Checked && checkBox3.Checked || checkBox2.Checked && checkBox3.Checked)
            {
                panel1.Enabled = false;
                panel2.Enabled = false;
                listBox1.SelectedIndex = -1;
                comboBox1.SelectedIndex = -1;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                button2.Text = "Exit";
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                comboflag = true;
                imgvalue = comboBox1.SelectedIndex;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                listflag = true;
                imgvalue = listBox1.SelectedIndex;
            }
        }
    }
}
