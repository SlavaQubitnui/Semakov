using System;
using System.Drawing;
using System.Windows.Forms;

namespace Grap
{
    public partial class Gr : Form
    {
        public Gr()
        {
            InitializeComponent();
        }

        private void result_Click(object sender, EventArgs e)
        {
            int iMax = 100;
            int t = 4;
            int amp = 60;
            int h = 40;
            int x0 = 20;
            int y0 = 2 * h + amp;
            double[] f = new double[iMax * t + 10];

            for (int i = 0; i < iMax * t; i++)
            {
                f[i] = Math.Round(amp * (Math.Cos(6 * Math.PI / iMax * i) * Math.Cos(6 * Math.PI / iMax * i) + Math.Cos(6 * Math.PI / iMax * i)));

            }
            Graphics g = Pole.CreateGraphics();
            g.Clear(Color.White);
            Pen p = Pens.Blue;
            g.DrawString("График (cos(x))^2+cos(x)", new Font("Arial", 12), Brushes.Red, 0, 0);
            g.DrawLine(new Pen(Brushes.Black, 2), x0, y0, x0 + iMax * t, y0);
            g.DrawLine(new Pen(Brushes.Black, 2), x0, y0 - amp, x0, y0 + amp);
            for (int i = 0; i < iMax * t; i++)
            {
                int f1 = y0 - (int)f[i];
                int f2 = y0 - (int)f[i + 1];
                g.DrawLine(p, x0 + i, f1, x0 + i + 1, f2);
            }
        }
    }
}
