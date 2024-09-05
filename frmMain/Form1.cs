using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMain
{
    public partial class Form1 : Form
    {
        int percentage;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //converting into percentage value
            percentage = (Int32.Parse(textBox1.Text) * 186) / 100;
            bar1.value = percentage;
            bar1.changeValue();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            bar1.value = trackBar1.Value;
            bar1.changeValue();

        }
    }
}
