/*
 * Milestone 4 by Branden M.
 * CST-150
 * Grand Canyon University
 */
namespace Milestone_4
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
               // This will display the user name
                MessageBox.Show("The User Name is: admin");
            }
            return;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            // This will display the label name password
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // This will display the user's password

            if (textBox2.Text == string.Empty)
            {
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
            // If the user name is correct the text will turn green

            if (textBox2.Text == "password")
            {
                MessageBox.Show("The Password is CORRECT!");
                textBox2.ForeColor = Color.Green;

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(); // We will use the sound player feature
                player.SoundLocation = @"H:\door-12-open.wav"; // Curent sound to play
                player.Load(); // Load the sound
                player.Play(); // Play the sound
                // This is here to load the sound file and play it when the login info is correct



                Movie_Library secondForm = new Movie_Library();
                // If both the username and the password match then close this form and open the second form.

                secondForm.ShowDialog();
                // This will show the user the current list of movies
               
            }

            // If the user name isn't right the user will have to try again
           if (textBox1.Text != "admin")
            {
                MessageBox.Show("User Name is NOT CORRECT, TRY AGAIN!");
                // If the user name is wrong it will tell you

                textBox1.ForeColor = Color.Red;
                // It will turn the text red

                MessageBox.Show("The User Name is: admin");
                // It will show what the user name actually is
            }

           // If the password isn't correct the user will have to try again
           if (textBox2.Text != "password") 
            {
                MessageBox.Show("Password is NOT CORRECT, TRY AGAIN!");
                // If the password isn't correct it will show it

                textBox2.ForeColor = Color.Red;
                // Change the color to red

                MessageBox.Show("The Password is: password");
                // Tell the user the password

                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = @"H:\door-lock-1.wav";
                player.Load();
                player.Play();
                // This is here to load the sound file and play it when the password is wrong
            }
            return;
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // This will quit the Application

            Application.Exit();

        }


    }
}