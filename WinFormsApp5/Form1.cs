using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    BackColor = Control.DefaultBackColor;
                    break;
                case 1:
                    BackColor = Color.Red;
                    break;
                case 2:
                    BackColor = Color.Green;
                    break;
                case 3:
                    BackColor = Color.Blue;
                    break;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox2.Text);
	    MessageBox.Show(comboBox2.Text);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = textBox1.Text.Trim();
            if (Text == "")
            {
                MessageBox.Show("Нельзя добавить пустое значение");
            }
            else
            {
                comboBox2.Items.Add(Text);
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Text = textBox1.Text.Trim();
            if (Text == "")
            {
                MessageBox.Show("Нельзя добавить пустое значение");
            }
            else
            {
                listBox1.Items.Add(Text);
                textBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
                listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
                comboBox2.Items.Insert(0,listBox1.SelectedItem.ToString());                
        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            comboBox2.Items.AddRange(richTextBox1.Lines);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(richTextBox1.Lines);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(string i in comboBox2.Items)
            {
                if (i.Contains("-1")) e.Cancel = true;
            }
            foreach (string i in listBox1.Items)
            {
                if (i.Contains("-1")) e.Cancel = true;
            }
        }
    }
}
