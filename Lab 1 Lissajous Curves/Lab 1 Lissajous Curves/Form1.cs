using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_Lissajous_Curves
{
    public partial class Form1 : Form
    {
        public double XFreq;
        public double YFreq;
        public double Delta;
        private double X;
        private double Y;

        public Form1()
        {
            InitializeComponent();
            XFreq = 1;
            YFreq = 1;
            Delta = 0;
            DrawCurve();
        }

        private void DrawCurve()
        {
            chartLissajous.Series[0].Points.Clear();

            for (double t = 0; t < 2 * Math.PI; t += 0.01)
            {
                X = Math.Cos(XFreq * t);
                Y = Math.Cos((YFreq * t) + (Delta * Math.PI / 180));
                chartLissajous.Series[0].Points.AddXY(X, Y);
            }
        }

        private void XUpDown_ValueChanged(object sender, EventArgs e)
        {
            XFreq = (double) XUpDown.Value;
            DrawCurve();
        }

        private void YUpDown_ValueChanged(object sender, EventArgs e)
        {
            YFreq = (double) YUpDown.Value;
            DrawCurve();
        }

        private void PhaseUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (PhaseUpDown.Value == 360)
                PhaseUpDown.Value = 0;
            
            Delta = (double) PhaseUpDown.Value;
            DrawCurve();
        }
    }
}
