namespace Activity_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //This will be the top text box bar

            // 60 greater than or equal to 1 minute

                if (textBox1.Text == "60")
                MessageBox.Show("I can work with this!");
            if (textBox1.Text == null || textBox1.Text.Length == 0)
                MessageBox.Show("Please enter 60 or more!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //This will be the second (middle) text box bar

            //Take the user's number and divide it by the number 60 

            //textBox2 = int.Parse(textBox1) / 60;
            //double.TryParse(textBox2);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //This will be the third box at the bottom

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //This will be the box that shows the hours
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This will be the Submit Button

            //if textBox1.Text >= 60, Message

            // textBox2 = int.Parse(textBox1) / 60;

            //textBox2 = textBox1 / "60"; 

           // int a = Convert.ToInt32(textBox1.Text);
            //This will be our submit button

            Int32 a = Convert.ToInt32(textBox1.Text);
            // This will take what the user put into the text box and put it into a int value

            Int32 b = 60;
            // This will be the value mutiplied by the user's age

            Int32 c = a / b;
            // This will take the multiple of a times 12 and give the value of c

            textBox2.Text = Convert.ToString(c);
            // This will take the answer and give it to text box 2

            Int32 d = c / b;
            textBox4.Text = Convert.ToString(d);
            // TextBox 4 will tell the number of days


            Int32 f = d / 24;
            textBox3.Text = Convert.ToString(f);
            //TextBox 3 will tell the number of hours

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //This will be the Reset Button

            textBox1.Text = ""; //This will reset box 1
            textBox2.Text = ""; //This will reset box 2
            textBox3.Text = ""; //This will reset box 3
            textBox4.Text = ""; //This will reset box 4
        }

    }
}