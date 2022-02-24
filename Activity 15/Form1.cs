using System.Collections.ObjectModel;

/*
 * Branden M.
 * CST-150, Activity 15 
 * Professor Mark Smithers
 * Grand Canyon University
 */

namespace Activity_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            // This is the label for birth year
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Here is the box that will allow you to select your birth year

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This will display the possible birth year in drop-down menu

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This will display the birth months in a drop-down menu 

            if (comboBox2.SelectedIndex == 0)
            {
                comboBox2.ForeColor = Color.Blue;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            // This will display the user's birthday
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This will display the options for the user's birthday

            if (comboBox3.SelectedIndex == 0)
            {
                comboBox3.ForeColor = Color.Red;
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                comboBox3.ForeColor = Color.Green;
            }
            else if (comboBox3.SelectedIndex == 2)
            {
                comboBox3.ForeColor = Color.Blue;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // This will tell the user to select their favorite color
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This will show a list of colors for the user to pick from

            if (comboBox4.SelectedIndex == 0) // When Red is the first color it will set the word to the color Red
            {
                (comboBox1 as ComboBox).ForeColor = Color.Red;
                (comboBox2 as ComboBox).ForeColor = Color.Red;
                (comboBox3 as ComboBox).ForeColor = Color.Red;
                comboBox4.ForeColor = Color.Red;
            }
            // Will set every other box to the user's favorite color.

            else if (comboBox4.SelectedIndex == 1) // When the second color is selceted it will set the word to the color Blue
            {
                (comboBox1 as ComboBox).ForeColor = Color.Blue;
                (comboBox2 as ComboBox).ForeColor = Color.Blue;
                (comboBox3 as ComboBox).ForeColor = Color.Blue;
                comboBox4.ForeColor = Color.Blue;
            }
            // Will set every other elements to blue.

            else if (comboBox4.SelectedIndex == 2) // When the third color is selceted it will set the word to the color Blue
            {
               (comboBox1 as ComboBox).ForeColor = Color.Yellow;
               (comboBox2 as ComboBox).ForeColor = Color.Yellow;
               (comboBox3 as ComboBox).ForeColor = Color.Yellow;
                comboBox4.ForeColor = Color.Yellow;
            }
            else if (comboBox4.SelectedIndex == 3) // When the fourth color is selceted it will set the word to the color Blue
            {
                (comboBox1 as ComboBox).ForeColor = Color.Green;
                (comboBox2 as ComboBox).ForeColor = Color.Green;
                (comboBox3 as ComboBox).ForeColor = Color.Green;
                comboBox4.ForeColor = Color.Green;
            }
            else if (comboBox4.SelectedIndex == 4) // When the fifth color is selceted it will set the word to the color Blue
            {
                (comboBox1 as ComboBox).ForeColor = Color.Orange;
                (comboBox2 as ComboBox).ForeColor = Color.Orange;
                (comboBox3 as ComboBox).ForeColor = Color.Orange;
                comboBox4.ForeColor = Color.Orange;
            }
            else if (comboBox4.SelectedIndex == 5) // When the second color is selceted it will set the word to the color Blue
            {
                (comboBox1 as ComboBox).ForeColor = Color.Purple;
                (comboBox2 as ComboBox).ForeColor = Color.Purple;
                (comboBox3 as ComboBox).ForeColor = Color.Purple;
                comboBox4.ForeColor = Color.Purple;
            }
            else if (comboBox4.SelectedIndex == 6) // When the second color is selceted it will set the word to the color Blue
            {
                (comboBox1 as ComboBox).ForeColor = Color.Black;
                (comboBox2 as ComboBox).ForeColor = Color.Black;
                (comboBox3 as ComboBox).ForeColor = Color.Black;
                comboBox4.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                // This will display a new form
                Form2 secondForm = new Form2(this);


            // This will be set to show the new form

            if (comboBox4.SelectedIndex == 0)
            {
                secondForm.ForeColor = Color.Red;
            } // Will show the user's favorite on the words click me in Form 2

            else if (comboBox4.SelectedIndex == 1)
            {   
                secondForm.ForeColor = Color.Blue;
            } // Will show the user's favorite on the words click me in Form 2

            else if (comboBox4.SelectedIndex == 2)
            {
                secondForm.ForeColor = Color.Yellow;
            } // Will show the user's favorite on the words click me in Form 2

            else if (comboBox4.SelectedIndex == 3)
            {
                secondForm.ForeColor = Color.Green;
            } // Will show the user's favorite on the words click me in Form 2

            else if (comboBox4.SelectedIndex == 4)
            {
                secondForm.ForeColor = Color.Orange;
            } // Will show the user's favorite on the words click me in Form 2

            else if (comboBox4.SelectedIndex == 5)
            {
                secondForm.ForeColor = Color.Purple;
            } // Will show the user's favorite on the words click me in Form 2

            else if (comboBox4.SelectedIndex == 6)
            {
                secondForm.ForeColor = Color.Black;
            } // Will show the user's favorite on the words click me in Form 2

            // All have been put in place so that the user's favorite color will appear


            secondForm.ForeColor = comboBox4.BackColor;
            secondForm.ForeColor = comboBox4.ForeColor;
            // These are here to match the user's favorite color.


            secondForm.Show();
                // This will show the second form

        }

    }
    }
    