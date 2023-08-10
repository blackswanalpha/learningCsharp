using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;

            radioButton1.Click += HandleModeSelection_Click;
            radioButton2.Click += HandleModeSelection_Click;
        }
        private void HandleModeSelection_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                radioButton2.Checked = false;
            if (radioButton2.Checked)
                radioButton1.Checked = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string county = comboBox1.SelectedItem.ToString();
            if (county == "kiambu")
                comboBox2.Items.AddRange(new string[] { "Juja", "Thika", "Ruiru" });
            else
                comboBox2.Items.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            string surname = textBox1.Text.ToString();
            string other = textBox2.Text.ToString();
            string county = comboBox1.SelectedItem.ToString();
            string subcounty = comboBox2.SelectedItem.ToString();
            string mode;
            if (radioButton1.Checked == true)
            {
                mode = " fulltime";
            }
            else if (radioButton2.Checked == true)
            {
                mode = "parttime";
            }
            else {
                mode = " ";
            }

            StringBuilder sports = new StringBuilder();

            if (checkBox2.Checked)
                sports.Append("Basket Ball|");
            if (checkBox3.Checked)
                sports.Append("Hockey|");
            if (checkBox1.Checked)
                sports.Append("Soccer|");

            listBox1.Visible = true;
            listBox1.Items.Add("Surname: " + surname);
            listBox1.Items.Add("Other Names: " + other);
            listBox1.Items.Add("County: " + county);
            listBox1.Items.Add("Sub County: " + subcounty);
            listBox1.Items.Add("Mode of Study: " + mode);
            listBox1.Items.Add("Sports: " + sports);
        }
    }
}
