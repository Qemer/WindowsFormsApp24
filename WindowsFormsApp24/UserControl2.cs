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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        int boyukqiy = 10;
        int ushaqqiy = 8;
        int sum = 0;
        private static UserControl2 instance;
        public static UserControl2 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserControl2();
                    return instance;
                }
                return instance;
            }
        }
        private void UserControl2_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int bow_yer = 26;
            foreach (var item in UserControl1.biletlist)
            {
                
                label5.Text = item.Haradan + "-" + item.Hara;
                label4.Text = rand.Next(100, 500).ToString();
                label6.Text = item.GedTarix;
                label9.Text = item.Boyuk;
                label8.Text = item.Ushaq;
                label7.Text = item.Korpe;
                label15.Text = item.Haradan;
                label16.Text = item.Hara;
                label17.Text = label4.Text;
                boyukqiy *= Convert.ToInt32(item.Boyuk);
                ushaqqiy *= Convert.ToInt32(item.Ushaq);
                sum = boyukqiy + ushaqqiy;
                label18.Text = "KP";
                ListViewItem item1 = new ListViewItem(new string[] { bow_yer.ToString(), sum.ToString(), item.Vaqon });
                listView1.Items.Add(item1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controls.Add(UserControl1.Instance);
            UserControl1.Instance.Dock = DockStyle.Fill;
            UserControl1.Instance.BringToFront();
            instance = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controls.Add(UserControl3.Instance);
            UserControl3.Instance.Dock = DockStyle.Fill;
            UserControl3.Instance.BringToFront();
            instance = null;
        }
    }
}
