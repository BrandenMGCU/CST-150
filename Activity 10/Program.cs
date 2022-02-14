// Corrected By Branden M.
//This is my own work
//Grand Canyon University
//CST-150


//use for IC08
//Lydia's code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CST117_IC08_console
{    
    class Program    
    {       
       public static void Main (string[] args) //Modified to public to try and make it accessable        
        {
            //make some sets
            HashSet<string> A = new HashSet<string>(); // Corrected By Branden M.  Change from Set to HashSet
            A.Add("This is to show that HashSet A is working and holding that string!");

            HashSet<string> B = new HashSet<string>(); // I've changed these both to HashSets to utlize a string value and make them functionable
            B.Add("This is to show that HashSet B is working and holding this string!");

            /*
             * The HashSet's are each now holding their own string values and will be printed to the console
             * */

            foreach(var hashA in A)
            {
                Console.WriteLine(hashA);
            }
            foreach(var hashB in B)
            {
                Console.WriteLine(hashB);
            }
            //This is to show that the HashSet's have been corrected and utilized as well
            //put some stuff in the sets

            Random r = new Random();
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine(i); //This will show the set of 0-9 and that we want every number under 10 from our i variable
            }

            HashSet<int> C = new HashSet<int>();
            {
                C.Add(r.Next(4)); //Dont need the phrase element and I built another HashSet that will handle the integers as well - Branden
            }

            HashSet <int> D = new HashSet<int>();
            D.Add(r.Next(12));  //Dont need the phrase element and I built another HashSet that will handle the integers as well - Branden

            //display each set and the union

            foreach (var hashA in A)
            {
                Console.WriteLine("The original A HashSet said: " + hashA); //Brought back the original hashset hashA
            }

            foreach (var hashB in B)
            {
                Console.WriteLine("The original B HashSet said: " + hashB);  //Brought back the original hashset hashB
            }

            foreach (var hashA in A)
                foreach(var hashB in B)
            {
                Console.WriteLine("The union of both is: " + hashA + " and "  + "\n" + hashB + A.Union(B)); 
            }


            //display original sets (should be unchanged)
            foreach (var hashA in A)
                foreach (var hashB in B)
            {
                Console.WriteLine("The originals: " + hashA + "\n" +  hashB);
            }

            //Console.WriteLine("After union operation");
            foreach (var hashA in A)
                foreach (var hashB in B)
                    foreach (var hashC in C)
                        foreach (var hashD in D)
                        {
                            Console.WriteLine("Unionized: " + hashA + "\n" + hashB);
                            Console.WriteLine("New Union holds integer value instead of words: " + hashC + "\n" + hashD);            
                        }
        }

    }
}