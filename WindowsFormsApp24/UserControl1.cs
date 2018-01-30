using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp24
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            monthCalendar1.Visible = false;
     
            panel1.Visible = false;
        }
        private static UserControl1 instance;
        Bilet bilet;
        public static List<Bilet> biletlist;
        public static UserControl1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserControl1();
                    return instance;
                }
                return instance;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            monthCalendar2.Visible = true;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked=true;
            comboBox1.Items.Add("Fransa");
            comboBox1.Items.Add("Canada");
            comboBox1.Items.Add("isvecre");
            comboBox2.Items.Add("Fransa");
            comboBox2.Items.Add("Canada");
            comboBox2.Items.Add("isvecre");


            monthCalendar1.MinDate = DateTime.Now;
            monthCalendar2.MinDate = DateTime.Now;

            comboBox3.Items.Add("0");
            comboBox3.Items.Add("1");
            comboBox3.Items.Add("2");
            comboBox3.Items.Add("3");
            comboBox3.Items.Add("4");

            comboBox4.Items.Add("0");
            comboBox4.Items.Add("1");
            comboBox4.Items.Add("2");
            comboBox4.Items.Add("3");
            comboBox4.Items.Add("4");

            comboBox5.Items.Add("0");
            comboBox5.Items.Add("1");
            comboBox5.Items.Add("2");
            comboBox5.Items.Add("3");
            comboBox5.Items.Add("4");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = comboBox1.Text;
            string str1 = comboBox2.Text;


            comboBox2.Text = str;
            comboBox1.Text = str1;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox2.Text) || string.IsNullOrWhiteSpace(comboBox3.Text) ||
                textBox1.Text != monthCalendar1.SelectionStart.ToShortDateString() || checkBox2.Checked == false)
            {
                if (string.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    comboBox1.BackColor = Color.Red;

                }
                else
                    comboBox1.BackColor = Color.White;
                if (string.IsNullOrWhiteSpace(comboBox2.Text))
                {
                    comboBox2.BackColor = Color.Red;

                }
                else
                    comboBox2.BackColor = Color.White;
                if (string.IsNullOrWhiteSpace(comboBox3.Text))
                {
                    comboBox3.BackColor = Color.Red;

                }
                else
                    comboBox3.BackColor = Color.White;

                if (textBox1.Text != monthCalendar1.SelectionStart.ToShortDateString())
                {
                    textBox1.BackColor = Color.Red;
                }
                else
                    textBox1.BackColor = Color.White;
                if (checkBox2.Checked == false)
                {
                    checkBox2.ForeColor = Color.Red;
                }
                else
                    checkBox2.ForeColor = Color.White;
            }
            else
            {
                bilet = new Bilet();
                biletlist = new List<Bilet>();

                bilet.Haradan = comboBox1.Text;
                bilet.Hara = comboBox2.Text;
                bilet.Boyuk = comboBox3.Text;
                bilet.Ushaq = comboBox4.Text;
                bilet.Korpe = comboBox5.Text;
                bilet.GedTarix = textBox1.Text;
                if (panel1.Visible)
                {
                    bilet.GelTarix = textBox2.Text;
                }
                biletlist.Add(bilet);
                Controls.Add(UserControl2.Instance);
                UserControl2.Instance.Dock = DockStyle.Fill;
                UserControl2.Instance.BringToFront();
                instance = null;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
   public class Bilet
    {
        public string Haradan;
        public string Hara;
        public string GedTarix;
        public string GelTarix;
        public string Boyuk;
        public string Ushaq;
        public string Korpe;
        public string Vaqon;
    }
}
