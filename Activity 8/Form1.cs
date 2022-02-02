namespace Activity_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //This will contain the user's fat calories count
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //This will contain the user's carb calories count
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //This will show the user's results
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This will give the user's results

            var FatCalories = textBox1.Text + "grams";
            var CarbCalories = textBox2.Text;
            var FC = int.Parse(textBox1.Text) * 9;
            var CC = int.Parse(textBox2.Text) * 4;

            FatCalories = Convert.ToString(textBox1.Text);
            // Will multiply the user's given info by 9 to get their calories from fat

            CarbCalories = Convert.ToString(textBox2.Text);
            //Will multiply the user's given info by 4 to get their calories from carbs

            richTextBox1.Text = "Your Fat Calories are: " + FC + " grams." + Environment.NewLine + Environment.NewLine + "Your Carb Calories are: " + CC + " grams."; // "Your Carb Calories are " + CC;

            //Want to play a sound
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Branden\Downloads\MagicWand.wav");
            player.Play();


        }
    }
}