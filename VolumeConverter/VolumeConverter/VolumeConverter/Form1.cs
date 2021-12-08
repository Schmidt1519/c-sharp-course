using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeConverter
{
    public partial class volumeConverter : Form
    {
        public volumeConverter()
        {
            InitializeComponent();
            litreTextBox.Enabled = false;
        
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            float cl;
            float litre;
            cl = Convert.ToInt32(clTextBox.Text);
            litre = cl / 100;
            litreTextBox.Text = (litre.ToString());
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clTextBox.Text = "";
            litreTextBox.Text = "";
        }
    }
}
