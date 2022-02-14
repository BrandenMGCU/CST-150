/*
 * Branden McNeill
 * CST-105
 * Grand Canyon University
 */

namespace Activity9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //This will be the container that holds the functions to come
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //This will calculate the sum of two random numbers
            //I want to keep this simple and try and show the numbers that are being choosen for the calculation

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //This will allow for the user's first number input
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //This will allow for the user's second number input 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            void ADDITION_OF_NUMBERS() { } //This will be the additional method for problem 1

            //NEEDS TO TAKE TWO NUMBERS
            //This will calculate the result of the two numbers
            int number1 = Convert.ToInt32(textBox1.Text); //This will give us our first number and from there I wanted the calculations to be simple and keep the numbers below 100
            int number2 = Convert.ToInt32(textBox2.Text);
            DialogResult dialogResult = MessageBox.Show("The numbers you entered were: " + "(" + number1 + " " + "," + " " + number2 + ")" + "\n" + "When these two numbers are added together, the sum is: " + Convert.ToString(number1 + number2), "Problem 1");
        }
        //-----------------------END OF REQUIREMENT 1-------------//

        //-----------------------START OF REQUIREMENT 2-----------//

        private void label2_Click(object sender, EventArgs e)
        {
            //This will show what exercise 2 will be
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Box 1 for doubles
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Box 2 for doubles
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //Box 3 for doubles
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //Box 4 for doubles
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //Box 5 for doubles
        }

        private void button2_Click(object sender, EventArgs e)
        {
            void AVERAGE_OF_DOUBLES() { } //This will be the additional method for problem 2
            //This will be the button the user will press to generate 5 doubles and get the average displayed back


            int number1 = Convert.ToInt32(textBox3.Text);
            int number2 = Convert.ToInt32(textBox4.Text);
            int number3 = Convert.ToInt32(textBox5.Text);
            int number4 = Convert.ToInt32(textBox6.Text);
            int number5 = Convert.ToInt32(textBox7.Text);
            //This will take the user's input from all 5 of the text boxes 

            //We need to multiply all 5 textboxes input by 5 to get the average for the user's doubles
            MessageBox.Show("The numbers you enetered were: " + "(" + number1 + "," + number2 + "," + number3 + "," + number4 + "," + number5 + ")", "Problem 2"); //This will display the user's entered doubles from the textboxes

            int doubles_answer = number1 * number2 * number3 * number4 * number5 / 5; //This will multiply the user's doubles and divide them by the amount of doubles (5)

            MessageBox.Show("The average of the given doubles is: " + doubles_answer, "Problem 2");
            //The answer is correct but I want to correct the commas for the number as well

        }
        //--------------------END OF REQUIREMENT 2 -----------//

        //-----------------------START OF REQUIREMENT 3-----------//

        private void button3_Click(object sender, EventArgs e)
        {
            void RANDOMNUMBERS() { } //This will be the additional method for problem 3
            //This will generate two random integers and give their sum

            Random rnd = new Random();  //This will allow for the generation of random numbers
            var number1 = rnd.Next(100);
            var number2 = rnd.Next(100);
            MessageBox.Show("The randomly generated numbers were: " + "(" + number1 + " " + "," + " " + number2 + ")" + "\n" + "When these two numbers are added together, the sum is: " + Convert.ToString(number1 + number2), "Problem 3");
        }
        //-----------------------END OF REQUIREMENT 3-----------//

        //---------------------START OF REQUIREMENT 4--------------//
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //This is the first box for exercise 4
        }


        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            //This will be the second box for exercise 4
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            //This is the third box for exercise 4
        }

        private void button4_Click(object sender, EventArgs e)
        {
            void SUM_OF_THREE_INTEGERS_DIVISIBILITY() { } //This will be the additional method for problem 4
            //This button will give the answer for the 3 integers, show the sum and tell if it is divisible by 3

            //These will take the input from the user so that we can calulate their sum
            int number1 = Convert.ToInt32(textBox8.Text);
            int number2 = Convert.ToInt32(textBox9.Text);
            int number3 = Convert.ToInt32(textBox10.Text);

            int sum_answer2 = number1 * number2 * number3; //This will mutiply the user's given numbers

            MessageBox.Show("The numbers you entered were: " + "(" + number1 + " ," + number2 + " ," + number3 + ")" , "Problem 4"); //This will show the user's numbers that they gave
            if (sum_answer2 % 3 == 0)
                MessageBox.Show("The sum of the three numbers you put in ARE divisible by 3!", "Problem 4");
            else if (sum_answer2 % 3 != 0)
                MessageBox.Show("The sum of the three numbers you put in AREN'T divisible by 3!" + "\n" + "This is " + false, "Problem 4");

        }
        //---------------------END OF REQUIREMENT 4-----------------------//

        //---------------------START OF REQUIREMENT 5-----------------------//

        private void label3_Click(object sender, EventArgs e)
        {
            //This will tell the name of Activity 5
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            //This will take the user's first word
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            //This will take the user's second word
        }

        private void button5_Click(object sender, EventArgs e)
        { 
            void shortest_word() { } //This will be the additional method for problem 5
        
            //This will spit out which word is the shortest

            var a = textBox11.Text.Length; //This will get the amount of characters in a word for the first box
            var b = textBox12.Text.Length; //This will get the amount of characters in a word for the second box

            if (a >= b)
                MessageBox.Show("The shortest word is: " + textBox12.Text + "\n" + "\n" + "The length of that word is: " + "with " + b + " characters total!", "Problem 5");
            else if (b >= a)
                MessageBox.Show("The shortest word is: " + textBox11.Text + "\n" + "\n" + "The length of that word is: " + "with " + a + " characters total!", "Problem 5");
        }

        //---------------------END OF REQUIREMENT 5-----------------------//

        //------------------------START OF REQUIREMENT 6--------------------------//
        private void label7_Click(object sender, EventArgs e)
        {
            //TELLS THAT THIS IS ACTIVITY 6 
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            //first box for user's double
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            //second box for user's double 
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            //third box for the user's double
        }

        private void button6_Click(object sender, EventArgs e)
        {
            void largest_double() { } //This will be the additional method for problem 6
            //This will tell the largest double from the array

            var a = int.Parse(textBox13.Text);
            var b = int.Parse(textBox14.Text);
            var c = int.Parse(textBox15.Text);

            int[] array = { a, b, c };
            //This will contain the doubles from the textboxes above

            if (a >= b && a >= c)
                MessageBox.Show("The double in the first box is the largest value in the array!" + "\n" + "That number is: " + a, "Problem 6");
            else if (b >= a && b >= c)
                MessageBox.Show("The double in the second box is the largest value in the array!" + "\n" + "That number is: " + b, "Problem 6");
            if (c >= a && c >= b)
                MessageBox.Show("The double in the third box is the largest value in the array!" + "\n" + "That number is: " + c, "Problem 6");
            return;
        }
        //------------------------END OF REQUIREMENT 6--------------------------//

        //------------------------START OF REQUIREMENT 7--------------------------//
        private void label8_Click(object sender, EventArgs e)
        {
            //THIS IS THE PROBLEM 7 LABEL
        }

        private void button7_Click(object sender, EventArgs e)
        {
            void array_of_integers() { } //This will be the additional method for problem 7
            //THIS WILL GIVE THE ARRAY OF MULTIPLE INTEGERS
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
                31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50};
            foreach (var item in array)
            {
                MessageBox.Show("The 50 numbers in the array are: " + item, "Problem 7");
            }

        }

        //---------------------------END OF PROBLEM 7----------------------------//

        //---------------------------START OF PROBLEM 8-----------------------------//

        private void label9_Click(object sender, EventArgs e)
        {
            //PROBLEM 8 LABEL
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            //HOLDS THE USER'S WORD FOR BOX 1
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            //HOLDS THE USER'S WORD FOR BOX 2
        }

        private void button8_Click(object sender, EventArgs e)
        { 
             void boolvariables() { } //This will be the additional method for problem 8 
                {
                    var a = textBox16.Text;
                    var b = textBox17.Text;
                    if (a == b)
                        MessageBox.Show("This is " + true + "!" + "\n" + "These words ARE the same!", "Problem 8");
                    else if (a != b)
                        MessageBox.Show("This is " + false + "!" + "\n" + "These words ARE NOT the same!", "Problem 8");
                    return;
                }
            }
        //---------------------------END OF PROBLEM 8----------------------------//

        //---------------------------START OF PROBLEM 9---------------------------//

        private void label10_Click(object sender, EventArgs e)
        {
            //Problem 9 Label
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            //Textbox for number or double #1
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            //Textbox for number or double #2
        }

        private void button9_Click(object sender, EventArgs e)
        {
            void DOUBLE_TIMES_NUMBER() { } //This will be the additional method for problem 9
            //This will take the two numbers and give their product

            var a = Convert.ToInt32(textBox18.Text);
            var b = Convert.ToInt32(textBox19.Text);
            var c = (a * b);

            MessageBox.Show("The two numbers you entered were: " + "( " + a + " , " + b + " )" + "\n"
                + "The answer is: " + c, "Problem 9");
        }

        //-----------------------END OF PROBLEM 9-----------------------//

        //-------------------------START OF PROBLEM 10----------------------//

        private void label11_Click(object sender, EventArgs e)
        {
            //Problem 10 Label
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            //Textbox 1 for problem 10
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            //Textbox 2 for problem 10
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            ////Textbox 3 for problem 10
        }

        private void button10_Click(object sender, EventArgs e)
        {
            void AVERAGE_OF_NUMBERS() { } //This will be the additional method for problem 10
            //This will be the 2D Array of integers that tells the average of entries

            var a = int.Parse(textBox20.Text);
            var b = int.Parse(textBox21.Text);
            var c = int.Parse(textBox22.Text);

            var array = new Array[3, 1];
            var d = a * b * c / 3;

            MessageBox.Show("The numbers you entered were: " + "( " + a + " , " + b + " , " + c + " )" + "\n" +
               "The average of the numbers you provided is: " + d, "Problem 10");

        }
    }
}
