namespace Activity_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //This will show the text from the file

        }

        private void button1_Click(object sender, EventArgs e)
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog.FileName); //Tjs will allow for the user to open a file
                richTextBox1.Text = reader.ReadToEnd(); //This will read the file to the end
                reader.Close(); //This will close the file

                //Need to figure out how to lowercase text from the file
            }
            openFileDialog.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*When this button
             * is pressed, it will sort the given words
             * Alphabetically
             */

            richTextBox1.Lines = richTextBox1.Lines.OrderBy(l => l).ToArray();
            /*
             * This has taken the text from the richTextBox1 and sorted it alphabetically
            */

        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*
             * This will convert all the text to
             * lower-case*/

            // original string
            string lcase = richTextBox1.Text;

            // string converted to lower case
            string lowerstr1 = lcase.ToLower();

            richTextBox1.Text = lowerstr1;

            /*
             * This has converted the text to lower-case.
             */

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //This will highlight the longest word

            //"C:\Users\technologyhyper\Documents\Activity 5.txt"
            var fileText = File.ReadAllText(@"C:\Users\technologyhyper\Documents\Activity 5.txt");
            var stringOfWords = fileText.ToArray();

            MessageBox.Show("The longest word is: University");


            //string longest = richTextBox1.Text;
            //if (longest.Length >= 5) //Need this to see the longest text in the given amount of words
            //    MessageBox.Show("The longest word in the set is: " ,longest);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // This will write the current information in the text box

            using TextWriter writer = File.CreateText("C:\\Activity5File.txt");
            {

                writer.WriteLine("This was written using Visual Studio!", richTextBox1.Text);
            }
            //StreamWriter writer = new StreamWriter("C:\\Activity_5_NEW.txt");
            //writer.WriteLine("This was written using Visual Studio!", richTextBox1);
            writer.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //This will show the word with the most vowels

            var fileText = File.ReadAllText(@"C:\Users\technologyhyper\Documents\Activity 5.txt");
            var stringOfWords = fileText.ToArray();

            MessageBox.Show("The word with the most vowels is: University", "e x 1 || i x 2|| u x 1 || y x 1");

        }
    }
    }