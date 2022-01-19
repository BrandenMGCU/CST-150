namespace Activity_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //This is the skinny text box

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This will be the Submit Button
                MessageBox.Show("First box says: " + textBox1.Text + Environment.NewLine + "Second box says: " + richTextBox1.Text);
           
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //This will be the Reset Button

            textBox1.Text = "";
            richTextBox1.Text = "";

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //This is for the progress bar
        }
    }
}