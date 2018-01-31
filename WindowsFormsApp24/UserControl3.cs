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

            }

        }
    }
}
