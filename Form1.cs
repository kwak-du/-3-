using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.MiddleRight;
        }

        private void Font_change(object sender, EventArgs e)
        {
            int number = 1;

            number = checkBox1.Checked ? 2 : 1;

            number *= checkBox3.Checked ? 3 : 1;

            number *= checkBox4.Checked ? 5 : 1;

            number *= checkBox2.Checked ? 7 : 1;



            switch (number)

            {

                case 1: label1.Font = new Font(label1.Font, FontStyle.Regular); break;

                case 2: label1.Font = new Font(label1.Font, FontStyle.Bold); break;

                case 3: label1.Font = new Font(label1.Font, FontStyle.Italic); break;

                case 5: label1.Font = new Font(label1.Font, FontStyle.Strikeout); break;

                case 7: label1.Font = new Font(label1.Font, FontStyle.Underline); break;



                case 6: label1.Font = new Font(label1.Font, FontStyle.Bold | FontStyle.Italic); break;

                case 10: label1.Font = new Font(label1.Font, FontStyle.Bold | FontStyle.Strikeout); break;

                case 14: label1.Font = new Font(label1.Font, FontStyle.Bold | FontStyle.Underline); break;

                case 15: label1.Font = new Font(label1.Font, FontStyle.Italic | FontStyle.Strikeout); break;

                case 21: label1.Font = new Font(label1.Font, FontStyle.Italic | FontStyle.Underline); break;

                case 35: label1.Font = new Font(label1.Font, FontStyle.Strikeout | FontStyle.Underline); break;



                case 30: label1.Font = new Font(label1.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout); break;

                case 42: label1.Font = new Font(label1.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); break;

                case 70: label1.Font = new Font(label1.Font, FontStyle.Bold | FontStyle.Strikeout | FontStyle.Underline); break;

                case 105: label1.Font = new Font(label1.Font, FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline); break;



                case 210: label1.Font = new Font(label1.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline); break;

            }


        }
    }
}
