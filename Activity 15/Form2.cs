using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/*
 * Branden M.
 * CST-150, Activity 15
 * Grand Canyon University
 */


namespace Activity_15
{
    public partial class Form2 : Form
    {

        public Form2(Form1 form1)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // This will display the words "Your lucky number is" onto the screen
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // This will load the second form with the user's lucky number
            //This will display the lucky number
            
            Random rnd = new Random();
            
            Random rnd2 = new Random();
                // This will give us a random from 99 and under
            
            var a = rnd.NextInt64() / rnd2.NextInt64();
                label2.Text = a.ToString();
            //I want to display the user's favorite color to the text
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

