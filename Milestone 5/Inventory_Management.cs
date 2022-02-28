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

        private void button1_Click(object sender, EventArgs e)
        {
            // This will add the text to the large storage box
            listBox1.Items.Add(textBox1.Text);


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

            // Select the thing you want to restock and click re-stock it will duplicate the word and add to the system
            if (listBox1.SelectedItems == null)
            {
                MessageBox.Show("Select an item from the Inventory Database that you would like to re-stock");
            }

            listBox1.Items.Add(listBox1.SelectedItem.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // This will search for an item in the storage box
            var listboxresults = listBox1.Items.Contains(textBox1.Text);
           
           
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                int listboxindex = listBox1.FindString(textBox1.Text);
                // We will find the string using the textbox's input and click the search button when it is time

                if (listboxindex != -1)
                    listBox1.SetSelected(listboxindex, true);
                else
                    MessageBox.Show("We have checked the Inventory Database and there is no match for " + textBox1.Text);
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
            // This will contain upcoming movie ideas for the project.

            // This will take the listbox of items and utilize them into a string array

            List<String> listboxitems = listBox1.Items.Cast<string>().ToList();

            //string[] listboxitems = listBox1.Items.OfType<string>().ToList();
            // This still works if needed just delete the list above.

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // This will save a copy to the user's computer
            MessageBox.Show("This info  will be saved to the a file named: Inventory List.txt");

            var save_info = new SaveFileDialog();
            // This will open a new save file window 

            save_info.Filter = "Text (*.txt)|*.txt";
            // This will set a filter standard saying that it will be a text file

            save_info.FileName = "Inventory List";
            // The file itself will be named Inventory List.txt

            if (save_info.ShowDialog() == System.Windows.Forms.DialogResult.OK); // If the user selects ok from the dialogbox
            {
                using (var sw = new StreamWriter(save_info.FileName, false))

                    foreach (var item in listBox1.Items)
                        // Get every item inside of the inventory system database box

                        sw.Write(item.ToString() + Environment.NewLine);
                        // Write the list of items to a string
            }
            return;
            // Finished
            }

        private void button7_Click(object sender, EventArgs e)
        {
            // This will take you back to the movie library

            this.Close();
            // This inventory will close

            Movie_Library movie_Library = new Movie_Library();
            // This will rebuild the movie library

            movie_Library.Show();
            // This will show the movie library again
            
               
            }
        }
    }
