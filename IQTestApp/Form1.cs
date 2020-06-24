using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQTestApp
{
    public partial class Form1 : Form
    {
        private int picNum = 0;
        private int[] answers;
        public Form1()
        {
            InitializeComponent();
            answers = new int[7];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var image1 = new Bitmap(IQTestApp.Properties.Resources.t1);
            pictureBox1.BackgroundImage = image1;
        }

        public void ShowPic(int current)
        {
            int picNum = current + 1;
            label1.Text = "Питання # " + picNum;

            switch (answers[current])
            {
                case 0:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
                case 1:
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
                case 2:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
                case 3:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
                case 4:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = true;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
                case 5:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = true;
                    radioButton6.Checked = false;
                    break;
                case 6:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = true;
                    break;
            }

            switch (current)
            {
                case 0:
                    pictureBox1.BackgroundImage = new Bitmap(IQTestApp.Properties.Resources.t1);

                    break;
                case 1:
                    pictureBox1.BackgroundImage = new Bitmap(IQTestApp.Properties.Resources.t2);
                    break;
                case 2:
                    pictureBox1.BackgroundImage = new Bitmap(IQTestApp.Properties.Resources.t3);
                    break;
                case 3:
                    pictureBox1.BackgroundImage = new Bitmap(IQTestApp.Properties.Resources.t4);
                    break;
                case 4:
                    pictureBox1.BackgroundImage = new Bitmap(IQTestApp.Properties.Resources.t5);
                    break;
                case 5:
                    pictureBox1.BackgroundImage = new Bitmap(IQTestApp.Properties.Resources.t8);
                    break;
                case 6:
                    pictureBox1.BackgroundImage = new Bitmap(IQTestApp.Properties.Resources.t7);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            picNum++;

            if (picNum > 6)
            {
                picNum = 6;
            }
            
            ShowPic(picNum);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picNum--;

            if (picNum < 0)
            {
                picNum = 0;
            }

            ShowPic(picNum);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            answers[picNum] = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            answers[picNum] = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            answers[picNum] = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            answers[picNum] = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            answers[picNum] = 5;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            answers[picNum] = 6;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int correct = 0;
            
            if (answers[0] == 4)
            {
                correct++;
            }
            if (answers[1] == 5)
            {
                correct++;
            }
            if (answers[2] == 1)
            {
                correct++;
            }
            if (answers[3] == 2)
            {
                correct++;
            }
            if (answers[4] == 3)
            {
                correct++;
            }
            if (answers[5] == 2)
            {
                correct++;
            }
            if (answers[6] == 2)
            {
                correct++;
            }

            int correctPercent = correct *100 /7;

            if (correctPercent >= 30 && correctPercent <= 60)
            {
                MessageBox.Show("Слабенько! твій відсоток точних відповідей дорівнює: " + correctPercent + " %");
            }
            if (correctPercent >= 60)
            {
                MessageBox.Show("Непогано! твій відсоток правильних відповідей дорівнює: " + correctPercent + " %");
            }
            else if(correctPercent < 30)
            {
                MessageBox.Show("Дуже слабенько, трэба підвчитися! твій відсоток правильних відповідей дорівнює: " + correctPercent + " %");
            }
        }
    }
}
