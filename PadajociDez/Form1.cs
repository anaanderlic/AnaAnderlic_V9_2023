using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadajociDez
{
    public partial class Form1 : Form
    {
        private List<Kapljica> dež = new List<Kapljica>();
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void NarediKapljo()
        { 
            for (int i = 0; i < 4; i++)
                dež.Add(new Kapljica(rnd.Next(pictureBox.Width), 0, false));
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            foreach (Kapljica kaplja in dež)
            {
                if (!kaplja.NaMestu)
                {
                    if (kaplja.Y + 1 > pictureBox.Height) kaplja.NaMestu = true;
                    else if (dež.Contains(new Kapljica(kaplja.X, kaplja.Y + 1, true))) kaplja.NaMestu = true;
                    else kaplja.Y += 1;
                }
            }
            NarediKapljo();
            pictureBox.Refresh();
        }

        private void Risanje(object sender, PaintEventArgs e)
        {
            Graphics podlaga = e.Graphics;

            foreach (Kapljica kaplja in dež)
            {
                podlaga.DrawEllipse(new Pen(Color.DarkBlue, 1), new Rectangle(kaplja.X, kaplja.Y, 1, 1));
            }
        }

        private void Zacetek(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
