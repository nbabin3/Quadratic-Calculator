using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quadratic_Calculator
{
    public partial class QuadraticCalculator : Form
    {
        public QuadraticCalculator()
        {
            InitializeComponent();
        }

        private void QuadraticCalculator_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string rawA = textBoxA.Text;
            double doubleA = Convert.ToDouble(rawA);
            if(doubleA == 0)
            {
                MessageBox.Show("This equation is not quadratic.");
            }
            else
            {
                string rawB = textBoxB.Text;
                double doubleB = Convert.ToDouble(rawB);

                string rawC = textBoxC.Text;
                double doubleC = Convert.ToDouble(rawC);

                double oppB = doubleB * -1;
                double squareB = doubleB * doubleB;
                double fourAC = 4 * doubleA * doubleC;
                double discriminate = squareB - fourAC;
                if (discriminate < 0)
                {
                    MessageBox.Show("No real roots.");
                }
                else
                {
                    double sqrtDiscr = Math.Sqrt(discriminate);
                    double twoA = 2 * doubleA;
                    double answerPlus = (oppB + sqrtDiscr) / twoA;
                    double answerMinus = (oppB - sqrtDiscr) / twoA;
                    double vertexX = oppB / twoA;
                    double vertexXsqr = vertexX * vertexX;
                    double vertexY = (doubleA * vertexXsqr) + (doubleB * vertexX) + doubleC;
                    MessageBox.Show("The real roots are: " + answerPlus + ", " + answerMinus + "." + "\n" +
                        "The vertex is: (" + vertexX + ", " + vertexY + ")");
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
