using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testSUM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result.Text = Sum(int.Parse(Start.Text), int.Parse(End.Text), int.Parse(Seed.Text)).ToString();
        }

        public int Sum(int Start, int End, int Seed)
        {
            if (Start < End)
            {
                return Start + End + Sum(Start + Seed, End - Seed, Seed);
            }
            else if (Start == End)
            {
                return Start;
            }
            else
            {
                return 0;
            }
	    return 0;
        }
    }
}
