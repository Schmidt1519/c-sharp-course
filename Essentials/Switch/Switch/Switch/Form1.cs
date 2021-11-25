using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val = 5;
            switch(val)
            {
                case 1:
                    MessageBox.Show("The day is - Sunday");
                    break;
                case 2:
                    MessageBox.Show("The day is - Monday");
                    break;
                case 3:
                    MessageBox.Show("The day is - Tuesday");
                    break;
                case 4:
                    MessageBox.Show("The day is - Wednesday");
                    break;
                case 5:
                    MessageBox.Show("The day is - Thursday");
                    break;
                case 6:
                    MessageBox.Show("The day is - Friday");
                    break;
                case 7:
                    MessageBox.Show("The day is - Saturday");
                    break;
                default:
                    MessageBox.Show("Out of range!");
                    break;
            }
        }
    }
}
