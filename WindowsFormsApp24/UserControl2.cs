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
            foreach (var item in UserControl1.biletlist)
            {
                label5.Text = item.Haradan + "-" + item.Hara;
            }
        }
    }
}
