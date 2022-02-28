using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Milestone 5 by Branden M.
 * CST-150
 * Grand Canyon University
 */

namespace Milestone_5
{
    public partial class Movie_Library : Form
    {
        public Movie_Library()
        {
            InitializeComponent();
        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            // This will contain movie number 4
        }

       

        private void button9_Click(object sender, EventArgs e)
        {
            // This is the watch button that should play movie number 1

            var watch_movie1 = new Movie_Watching();
            watch_movie1.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // This is the like button for movie number 1
            MessageBox.Show(" Glad you liked it! We will get more recommendations like this for you!", label1.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // This is the dislike button for movie number 1
            // Want the dislike button to remove the movie from the stack

            DialogResult dialogResultm1 = MessageBox.Show(label1.Text + " won't be recommended to your list anymore!");

            DialogResult dialogResultm1_2 = MessageBox.Show("Would you like to delete it from your list?", label1.Text + " Deletion", MessageBoxButtons.YesNo);

            if (dialogResultm1_2 == DialogResult.Yes) // If the user clicks the yes button
            {
                panel1.Dispose(); // This will remove the movie from the user's list.
            }

            if (dialogResultm1_2 == DialogResult.No) // If the user clicks the no button
            {
                return; // This will do nothing and the user will be brought back to their movie list
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // This is the watch button for movie number 2

            var watch_movie1 = new Movie_Watching();
            watch_movie1.ShowDialog();
            // Open the movie player form
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // This is the like button for movie number 2 
            MessageBox.Show(" Glad you liked it! We will get more recommendations like this for you!", label2.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // This is the dislike button for movie number 2
            // Want the dislike button to remove the movie from the stack

            DialogResult dialogResultm2 = MessageBox.Show(label2.Text + " won't be recommended to your list anymore!");

            DialogResult dialogResultm2_1 = MessageBox.Show("Would you like to delete it from your list?", label2.Text + " Deletion", MessageBoxButtons.YesNo);

            if (dialogResultm2_1 == DialogResult.Yes) // If the user clicks the yes button
            {
                panel2.Dispose(); // This will remove the movie from the user's list.
            }

            if (dialogResultm2_1 == DialogResult.No) // If the user clicks the no button
            {
                return; // This will do nothing and the user will be brought back to their movie list
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            // This will be the watch button for movie number 3
            var watch_movie1 = new Movie_Watching();
            watch_movie1.ShowDialog();
            // Open the movie player form
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // This is the like button for movie number 3
            MessageBox.Show(" Glad you liked it! We will get more recommendations like this for you!", label3.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // This is the dislike button for movie number 3
            // Want the dislike button to remove the movie from the stack

            DialogResult dialogResultm3 = MessageBox.Show(label3.Text + " won't be recommended to your list anymore!");

            DialogResult dialogResultm3_1 = MessageBox.Show("Would you like to delete it from your list?", label3.Text + " Deletion", MessageBoxButtons.YesNo);

            if (dialogResultm3_1 == DialogResult.Yes) // If the user clicks the yes button
            {
                panel3.Dispose(); // This will remove the movie from the user's list.
            }

            if (dialogResultm3_1 == DialogResult.No) // If the user clicks the no button
            {
                return; // This will do nothing and the user will be brought back to their movie list
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            // This is the watch movie button for movie 4
            var watch_movie1 = new Movie_Watching();
            watch_movie1.ShowDialog();
            // Open the movie player form
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // This will be the label for panel 4 holding movie 4
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // This is the dislike button for movie number 4

            // Want the dislike button to remove the movie from the stack

            DialogResult dialogResultm4 = MessageBox.Show(label4.Text + " won't be recommended to your list anymore!");

            DialogResult dialogResultm4_1 = MessageBox.Show("Would you like to delete it from your list?", label4.Text + " Deletion", MessageBoxButtons.YesNo);

            if (dialogResultm4_1 == DialogResult.Yes) // If the user clicks the yes button
            {
                panel4.Dispose(); // This will remove the movie from the user's list.
            }

            if (dialogResultm4_1 == DialogResult.No) // If the user clicks the no button
            {
                return; // This will do nothing and the user will be brought back to their movie list
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This is the like button for movie number 4

            MessageBox.Show(" Glad you liked it! We will get more recommendations like this for you!", label4.Text);

        }
        private void button13_Click(object sender, EventArgs e)
        {
            // This will be the manage movies item, this will pull up the inventory manager
            var third_form = new Inventory_Management();
            third_form.ShowDialog();
            Movie_Library.ActiveForm.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Movie_Library_Load(object sender, EventArgs e)
        {
                Form1.ActiveForm.Hide();
         
        }
    }
}
