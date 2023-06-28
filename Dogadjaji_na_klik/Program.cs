using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Dogadjaji_na_klik
{
    public delegate void DelegateEventHandler();
    internal class Program:Form
    {
        public event DelegateEventHandler dodaj;
        public Program()
        {
            Button btn = new Button();
            btn.Parent = this;
            btn.Text = "Klikni na mene!!";
            btn.Location = new Point(100,100);
            btn.Size = new Size(150, 100);

            btn.Click += new EventHandler(NaKlik);
            dodaj += new DelegateEventHandler(Iniciraj);

            dodaj();

            Button btn2 = new Button();
            btn2.Parent = this;
            btn2.Text = "Klikni na mene isto!";
            btn2.Location = new Point(0, 0);
            btn2.Click += new EventHandler(NaKlik);
        }

        private void Iniciraj()
        {
            Console.WriteLine("Dogadjaj pokrenut!");
        }

        public void NaKlik(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            MessageBox.Show("Kliknuo si me!");
            btn.Size = new Size(200, 200);
            btn.Enabled = false;
            btn.Visible = false;
        }

        static void Main(string[] args)
        {
            Application.Run(new Program());
        }
    }
}
