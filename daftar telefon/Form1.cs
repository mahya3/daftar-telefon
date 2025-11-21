using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace daftar_telefon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("contactlist.txt"))
                listBox1.Items.AddRange(File.ReadAllLines("contactlist.txt"));
            else
                MessageBox.Show("پرونده موجود نیست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0 && textBox2.TextLength != 0 && textBox3.TextLength != 0 && textBox4.TextLength != 0)
            {
                string contact = textBox1.Text + "\t" + textBox2.Text + "\t" + textBox3.Text + "\t" + textBox4.Text + "\t";
                File.AppendAllText("contactlist.txt", contact + "\r\n");
                listBox1.Items.Add(contact);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else
                MessageBox.Show("لطفا اطلاعات را کامل کنید");
        }
    }
}
