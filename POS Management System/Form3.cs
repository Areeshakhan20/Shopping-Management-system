using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Management_System
{
    public partial class Form3 :  Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Form1_POS f1 = new Form1_POS();
            f1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
