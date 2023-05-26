using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrvaForma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            porukattx.Text = label1.Text;
            porukattx.Visible = false;
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 50;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if(progressBar1.Value != 100)
            {
                MessageBox.Show("Nemojte jos zatvarati!");
                e.Cancel = true;
            }
            base.OnFormClosing(e);
        }
    }
}
