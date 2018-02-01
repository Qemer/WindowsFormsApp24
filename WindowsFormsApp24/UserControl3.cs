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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
           
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private static UserControl3 instance;
        public static UserControl3 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserControl3();
                    return instance;
                }
                return instance;
            }
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
           
            comboBox1.Items.Add("isvec");
            comboBox1.Items.Add("Fransiz");
            comboBox1.Items.Add("Ingilis");

            comboBox2.Items.Add("isvec");
            comboBox2.Items.Add("Fransiz");
            comboBox2.Items.Add("Ingilis");

            comboBox3.Items.Add("isvec");
            comboBox3.Items.Add("Fransiz");
            comboBox3.Items.Add("Ingilis");
            comboBox4.Items.Add("isvec");
            comboBox4.Items.Add("Fransiz");
            comboBox4.Items.Add("Ingilis");

            foreach (  var item in UserControl1.biletlist)
            {
                label10.Text = "boyuk (sernisin 1)";
                label10.ForeColor = SystemColors.HotTrack;
                if (Convert.ToInt32(item.Boyuk) > 1)
                {
                    panel4.Visible = true;
                    label11.Text = "boyuk (sernishin 2)";
                    label11.ForeColor = SystemColors.HotTrack;
                }
                if (Convert.ToInt32(item.Ushaq) > 0)
                {
                    panel3.Visible = true;
                    label9.Text = "Ushaq (sernishin 1)";
                    label9.ForeColor = SystemColors.HotTrack;
                }
                if (Convert.ToInt32(item.Ushaq) == 2)
                {
                    panel2.Visible = true;
                    label12.Text = "Ushaq (sernishin 2)";
                    label12.ForeColor = SystemColors.HotTrack;
                }
            }
     
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controls.Add(UserControl2.Instance);
            UserControl2.Instance.Dock = DockStyle.Fill;
            UserControl2.Instance.BringToFront();
            instance = null;
        }
    }
}
