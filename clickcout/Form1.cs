using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clickcout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int clicks = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            clicks += 1;
            label1.Text = Convert.ToString(clicks);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clicks = 0;
            label1.Text = Convert.ToString(clicks);
        }
    }
}
