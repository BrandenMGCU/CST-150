using System.IO;
using System.Threading.Tasks;

/*
 * Activity 12 by Branden M.
 * CST-150
 * Grand Canyon University
 */

    public class File_Setup
    /* Here in this class, I want to save the same string from the text being worked on to show proof,
     * and verification that the information is the same as when it came in
     */
    {
    public static void Main(string[] args)


    // Want to read write_to_file to an array 
    {

        string text = "Don't be late, teatime will not wait!";
        // This is the text that was given to us to process and handle for this assignment

        File.WriteAllText(@"H:\brand\Documents\ACTIVITY12.txt", text);
        // This will be where we will write the text to the test folder

        Console.WriteLine("The sentence saying: " + "\n" + text + "\n" + "\n" + "has be saved to a file named ACTIVITY12!");

        Console.WriteLine("\n");
        // This is just to provide space when reading from the console 

        string readtest = File.ReadAllText(@"H:\brand\Documents\ACTIVITY12.txt"); // This will be where we are reading the sample.txt file we made earlier

        Console.WriteLine("Opening Activity12.txt will show the same sentence you see up above");
        // This is to tell the user that the information before is going to be the same inside of the Activity12 text file

        Console.WriteLine("\n");
        // This is just to provide space when reading this from the console

        int e_and_tcounter = 2; // Our counter for e's and t's the 2 letter's we're looking for

        /* Here is where we will then run the code to check how many e's as well as t's are in the text provided to us */

        string[] letterchecker = text.Split(' '); //This will tell the code check for any spaces in between words and if so split up the words

        foreach (string word in letterchecker)
        {
            char[] essentials = word.ToCharArray(); 
            // We will split the needed characters up into a character array to check for the needed letters
            
            if (essentials[essentials.Length - 1] == 'e' || essentials[essentials.Length - 1] == 't')
                // We will tell it to check the new char array for any last letter (-1) that ends with either the letter e or t
                    
            {
                        e_and_tcounter++;  
                        // This is tell our counter for every word ending with e or t count that value and hold it here
            }
        }
         // This is the end of the foreach condition

        Console.WriteLine("After counting, there are: " + e_and_tcounter + " words that end with either e or t!");

    }

}

