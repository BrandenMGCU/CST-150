/*
 * Milestone 3 by Branden M.
 * CST-150
 * Grand Canyon University
 */
namespace Milestone_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // This will be the form that holds all the information needed to login

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @"H:\Tones_and_I_-_Fly_Away.wav";
            player.Load();
            player.Play();
            // This is just here to play the song while this form is up
        }


        private void label1_Click(object sender, EventArgs e)
        {
            // This will display the username
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // This will be where the user puts their username
               
            
            if (textBox1.Text == string.Empty)
            {
                //Console.Beep();
                MessageBox.Show("The User Name is: admin");
            }
            return;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            // This will display the label password
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // This will display the user's password

            if (textBox2.Text == string.Empty)
            {
                //Console.Beep(); // Wanted a beep for when the user got the info wrong. 
                MessageBox.Show("The password is: password");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This will be the login button

            if (textBox1.Text == "admin")
            {
                MessageBox.Show("The User Name is CORRECT!");
                textBox1.ForeColor = Color.Green;
            }

            if (textBox2.Text == "password")
            {
                MessageBox.Show("The Password is CORRECT!");
                textBox2.ForeColor = Color.Green;      

               Movie_Library secondForm = new Movie_Library();
                // If both the username and the password match then close this form and open the second form.

                secondForm.ShowDialog();
                this.Close();
            }

            // If the user name isn't right the user will have to try again
           if (textBox1.Text != "admin")
            {
                MessageBox.Show("User Name is NOT CORRECT, TRY AGAIN!");
                textBox1.ForeColor = Color.Red;
                MessageBox.Show("The User Name is: testuser1");
            }

           // If the password isn't correct the user will have to try again
           if (textBox2.Text != "password") 
            {
                MessageBox.Show("Password is NOT CORRECT, TRY AGAIN!");
                textBox2.ForeColor = Color.Red;
                MessageBox.Show("The Password is: password");
            }
            return;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            // This will display the register buttton
        }


    }
}