using Proje.Cafe;
using System.CodeDom;

namespace ErenCafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(comboBox1.Text);
            listBox3.Items.Add(comboBox2.Text);

            Proje.Cafe.Kiralama kira = new Proje.Cafe.Kiralama();






        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            listBox5.Items.Add(checkBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();




        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kiralama k = new Kiralama();
            if (comboBox5.Text == "24 saat kiralama")
            {

                k.kiralamaucreti = 1000;
            }
            else if (comboBox5.Text == "48 saat kiralama")
            {
                k.kiralamaucreti = 1500;
            }
            else if (comboBox5.Text == "72 saat kiralama")
            {
                k.kiralamaucreti = 2000;
            }
            else { MessageBox.Show("beklenmedik bir hata oluþtu"); } 
            textBox3.Text = k.kiralamaucreti.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                comboBox4.Enabled = true;
                comboBox5.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                comboBox4.Enabled = false;
                comboBox5.Enabled = true;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kiralama k = new Kiralama();
            if (comboBox4.Text == "24 saat kiralama")
            {

                k.kiralamaucreti = 500;
            }
            else if (comboBox4.Text == "48 saat kiralama")
            {
                k.kiralamaucreti = 1000;
            }
            else if (comboBox4.Text == "72 saat kiralama")
            {
                k.kiralamaucreti = 1500;
            }
            else { MessageBox.Show("beklenmedik bir hata oluþtu"); }
            textBox3.Text = k.kiralamaucreti.ToString();
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            listBox5.Items.Add(checkBox2.Text);

        }
    }
}