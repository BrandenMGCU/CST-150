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
 * Milestone 3 by Branden M.
 * CST-150
 * Grand Canyon University
 */

namespace Milestone_3
{
    public partial class Inventory_Management : Form
    {
        public Inventory_Management()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // This will be the new search box to check inside of the richtextbox
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // This will store new movies into a list
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This will add the text to the large storage box
            listBox1.Items.Add(this.textBox1.Text);

            // This will empty the textbox after adding something to the large list
            textBox1.Text = string.Empty;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // This will remove an item from the large storage box

            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // This will re-stock a removed item to the storage box


        }

        private void button4_Click(object sender, EventArgs e)
        {
            // This will search for an item in the storage box
            var listboxresults = listBox1.Items.Contains(textBox1.Text);

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                int listboxindex = listBox1.FindStringExact(textBox1.Text);
                // We will find the string using the textbox's input and click the search button when it is time

                if (listboxindex != -1)
                    listBox1.SetSelected(listboxindex, true);
                else
                    MessageBox.Show("We have checked the list box and there is not match!");
                // This will tell id there was no match found inside of the list box
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // This will reset the textbox

            textBox1.Text = String.Empty; 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This will contain upcoming movies

            // This will take the listbox of items and utilize them into a string array
            string[] listboxitems = listBox1.Items.OfType<string>().ToArray();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // This will save a copy to the user's computer
            MessageBox.Show("This feature is still being implemented...");
        }
    }
}
