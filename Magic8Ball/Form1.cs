using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic8Ball
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = randGen.Next(1, 7);

            switch (number)
            {
                case 1:
                    outputLabel.Text = "Yes";
                    break;
                case 2:
                    outputLabel.Text = "No";
                    break;
                case 3:
                    outputLabel.Text = "Possibly";
                    break;
                case 4:
                    outputLabel.Text = "Very Doubtful";
                    break;
                case 5:
                    outputLabel.Text = "Ask Again Later";
                    break;
                case 6:
                    outputLabel.Text = "Best if I not say";
                    break;
            }
        }
    }
}
