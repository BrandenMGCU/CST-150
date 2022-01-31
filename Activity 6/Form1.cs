namespace Activity_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //This is the text box that will get the user's age

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //This will be the text box that will tell the user's age in months

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This will be the submit button

            var a = Convert.ToDecimal(textBox1.Text);

            //var convertDecimal = Convert.ToDecimal(value);
            var b = Convert.ToDecimal(12);
            
            var c = Convert.ToDecimal(a * b);
             textBox2.Text = Convert.ToString(c);



            //Simple error handling for program
            try
            {
                textBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Error occurred.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //This will be the reset button

            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}