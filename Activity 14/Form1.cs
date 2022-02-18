/*
 * Branden M
 * CST-150
 * Grand Canyon University
 */

namespace Activity14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This will represent list box 1
        }

        private void button2_Click(object sender, EventArgs e)
        {

            {
                listBox1.Items.Add(this.textBox1.Text);

                textBox1.Text = "";
            }
            // This button will add the the user's message from textbox1
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // This will be for yes, I'm done radio button
                MessageBox.Show("You want to add the word: " + textBox1.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // This will take the user's text
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            // This will be for no, I'M NOT FINISHED

            if (radioButton1.Checked)
            {
                // This will be for yes, I'm done radio button
                MessageBox.Show("You DON'T want to add the word: " + textBox1.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // This will reset the text box

            textBox1.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // This will tell if the user wants the information saved to a text file

            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Your information will be saved to a file named: " + "\n" + "\n" + "Your_Information.txt");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                // This will tell the software they do not want the info to be saved to a text file
                MessageBox.Show("Your information will NOT be saved anywhere!"); 

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                MessageBox.Show("You didn't want anything saved!");
                return;
            }

           else if (checkBox1.Checked)
            {
                var save_info = new SaveFileDialog();
                save_info.Filter = "Text (*.txt)|*.txt";
                save_info.FileName = "Your_Information";
                if (save_info.ShowDialog() == System.Windows.Forms.DialogResult.OK);
                {
                    using (var sw = new StreamWriter(save_info.FileName, false))
                        foreach (var item in listBox1.Items)
                            sw.Write(item.ToString() + Environment.NewLine);
                    MessageBox.Show("The information was saved to the file Your_Information.txt!");
                }

              if (save_info.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    {
                        MessageBox.Show("You hit cancel!");
                    }
                }
            }


        }
    }