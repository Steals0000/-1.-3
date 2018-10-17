using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibr._2._1._11;

namespace _2._1._11_form_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void choosePerformanceClassRButton_CheckedChanged(object sender, EventArgs e)
        {
            yearOfWritingLabel.Visible = false;
            yearOfWritingTextBox.Visible = false;
            outputLabel.Text = "";
        }

        private void choosePerformanceChildClassRButton_CheckedChanged(object sender, EventArgs e)
        {
            yearOfWritingLabel.Visible = true;
            yearOfWritingTextBox.Visible = true;
            outputLabel.Text = "";
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            if (choosePerformanceChildClassRButton.Checked == true)
            {
                try
                {
                    PerformanceChild performanceChild = new PerformanceChild(Convert.ToInt32(startViewersCountTextBox.Text), Convert.ToInt32(endViewersCountTextBox.Text), nameTextBox.Text, Convert.ToInt32(yearOfWritingTextBox.Text));
                    outputLabel.Text = "Качество спектакля - " + Math.Round(performanceChild.GetQuality(), 2);
                }
                catch
                {
                    MessageBox.Show("Введите корректные значения");
                }
            }
            else
            {
                try
                {
                    Performance performance = new Performance(Convert.ToInt32(startViewersCountTextBox.Text), Convert.ToInt32(endViewersCountTextBox.Text), nameTextBox.Text);
                    outputLabel.Text = "Качество спектакля - " + Math.Round(performance.GetQuality(), 2);
                }
                catch
                {
                    MessageBox.Show("Введите корректные значения");
                }
            }
        }
    }
}
