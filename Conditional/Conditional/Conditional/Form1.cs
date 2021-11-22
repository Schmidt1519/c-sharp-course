using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conditional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int finalGrades = 59;
            if(finalGrades >= 75){
                MessageBox.Show("First class");
            } else{
                MessageBox.Show("You got a Second class");
            }

        }
    }
}
