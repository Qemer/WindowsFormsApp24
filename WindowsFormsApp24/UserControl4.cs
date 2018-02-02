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
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private static UserControl4 instance;
        public static UserControl4 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserControl4();
                    return instance;
                }
                return instance;
            }
        }
        static uint large=0;
        static uint little = 0;

        private void UserControl4_Load(object sender, EventArgs e)
        {
            foreach(var item in UserControl1.biletlist)
            {
                large = Convert.ToUInt32(item.Boyuk);
                little = Convert.ToUInt32(item.Ushaq);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.White)
            {
                if (large <= 0 && little <= 0)
                {
                    return;
                }
                else
                {
                    if (large != 0)
                    {
                        large--;
                        btn.BackColor = Color.Red;
                    }
                    else if (little != 0)
                    {
                        little--;
                        btn.BackColor = Color.Red;

                    }
                }
            }
            else if (btn.BackColor == Color.Red)
            {
                if (large >= 0)
                {
                    large++;
                    btn.BackColor = Color.White;
                    return;
                }
                else if (little >= 0)
                {
                    little++;
                    btn.BackColor = Color.White;
                }
            }
        } 

        private void button40_Click(object sender, EventArgs e)
        {
            Controls.Add(UserControl3.Instance);
            UserControl3.Instance.Dock = DockStyle.Fill;
            UserControl3.Instance.BringToFront();
            instance = null;
        }
    }
}
