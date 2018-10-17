using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibr;

namespace _1._1._11_form_
{
    public partial class Form1 : Form
    {
        public int length;
        Linear_Array arr;
        int counter = 0;
        int var = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            length = Convert.ToInt32(textBox1.Text);
            arr = new Linear_Array();
            arr.Create(length);
            button1.Visible = false;
            textBox1.ReadOnly = true;
            label1.Text = "Размерность массива:";
            textBox2.Visible = true;
            label2.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arr.Arr[counter] = new Element(Convert.ToInt32(textBox2.Text));
            counter++;
            if (counter == length)
            {
                label2.Text = "МАССИВ: " + arr.Print();
                textBox2.Visible = false;
                button2.Visible = false;
                textBox3.Visible = true;
                button6.Visible = true;
                label3.Visible = true;
            }
            else
                label2.Text = "Введите " + (counter + 1) + " элемент массива";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arr.Addition(var);
            label2.Text = "МАССИВ: " + arr.Print();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            arr.Difference(var);
            label2.Text = "МАССИВ: " + arr.Print();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            arr.ProductOfNumbers(var);
            label2.Text = "МАССИВ: " + arr.Print();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var = Convert.ToInt32(textBox3.Text);
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
        }
    }
}
