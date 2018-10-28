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
    public partial class PerformanceForm : Form
    {
        public PerformanceForm()
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
            Performance performance;
            if (choosePerformanceChildClassRButton.Checked == true)
            {
                performance = new PerformanceChild(Convert.ToInt32(startViewersCountTextBox.Text), Convert.ToInt32(endViewersCountTextBox.Text), nameTextBox.Text, Convert.ToInt32(yearOfWritingTextBox.Text));
                outputLabel.Text = "Качество спектакля - " + Math.Round(performance.GetQuality(), 2);
            }
            else
            {
                performance = new Performance(Convert.ToInt32(startViewersCountTextBox.Text), Convert.ToInt32(endViewersCountTextBox.Text), nameTextBox.Text);
                outputLabel.Text = "Качество спектакля - " + Math.Round(performance.GetQuality(), 2);
            }
        }

        private void startViewersCountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void endViewersCountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void yearOfWritingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
