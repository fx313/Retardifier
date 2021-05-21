using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retardifier
{
    public partial class Retardifier : Form
    {
        public Retardifier()
        {
            InitializeComponent();
            labelTitle.Text = "R E T A R D I F I E R";
            timer1.Enabled = true;
        }

        private string retardThis(string input)
        {
            string stringOutput = "";
            //char charToCheck;
            char[] charArray = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {

                if (i % 2 == 0)
                {
                    charArray[i] = Char.ToLower(input[i]);
                }
                else
                {
                    charArray[i] = Char.ToUpper(input[i]);
                }
            }

            for (int i = 0; i < charArray.Length; i++)
            {
                stringOutput = stringOutput + charArray[i];
            }

            
            return stringOutput;
        }
        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            textBoxOutput.Text = retardThis(textBoxInput.Text);
        }

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);

            labelTitle.ForeColor = label1.ForeColor = label2.ForeColor = Color.FromArgb(A, R, G, B);
           
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int value;

            value = trackBar1.Maximum - trackBar1.Value;
            if (value < 1)
            {
                value = 1;
            }
            timer1.Interval = value;

        }
    }
}
