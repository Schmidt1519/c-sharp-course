﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int count = 1;

            //while(count <= 4)
            //{
            //    MessageBox.Show("The value of i is: " + count);
            //    count = count + 1;
            //}

            int count = 1;
            do
            {
                MessageBox.Show("Loop executed successfully");
                count++;
            } while (count <= 4);
        }
    }
}
