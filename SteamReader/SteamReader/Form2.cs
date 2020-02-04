using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamReader
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = (Properties.Settings.Default.friend1);
            textBox2.Text = (Properties.Settings.Default.friend2);
            textBox3.Text = (Properties.Settings.Default.friend3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.friend1 = textBox1.Text;
            Properties.Settings.Default.friend2 = textBox2.Text;
            Properties.Settings.Default.friend3 = textBox3.Text;
            this.Close();

        }
    }
}
