namespace Milestone_2
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //This will be the like button for movie #2
            MessageBox.Show("You've liked Movie #2, we'll suggest more movies like this!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //This will be the like button for movie #1
            MessageBox.Show("You've liked Movie #1, we'll suggest more movies like this!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //This will be the dislike button for movie #1
            MessageBox.Show("You've disliked Movie #1, we wont suggest more movies like this!");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //This will be the dislike button for movie #2
            MessageBox.Show("You've disliked Movie #2, we wont suggest more movies like this!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //This will be the form that contains all the elements
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //This will be the like button for movie #3
            MessageBox.Show("You've liked Movie #3, we'll suggest more movies like this!");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //This will be the dislike button for movie #3
            MessageBox.Show("You've disliked Movie #3, we wont suggest more movies like this!");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //This will be the like button for movie #4
            MessageBox.Show("You've liked Movie #4, we'll suggest more movies like this!");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //This will be the dislike button for movie #4
            MessageBox.Show("You've disliked Movie #4, we wont suggest more movies like this!");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //This will contain the additional movie information for movie #1

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This will show more movies in the future
            DialogResult dialogResult = MessageBox.Show("This feature will be added in the next update very soon...");
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            //This will hold the text for movie #3
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //This will play Movie #1
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //This will play Movie #2
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //This will play Movie #3
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //This will play Movie #4
        }
    }
}