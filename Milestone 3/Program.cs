using System.IO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Media;

/*
 * Activity 12 by Branden M.
 * CST-150
 * Grand Canyon University
 */

// We need to open/ create and open a file

public class inventory_system
{
    static void Main(string[] args)
    {
        /*
         * 1. Need to be able to add an item
         * 2. Remove an item
         * 3. Re-stock an item
         * 4. Display the current set of items
         * 5. Search for the items in the inventory
         */

        Console.WriteLine("Welcome to Milestone 3!");
        // This will show welcome to the milestone


        //---------------------------END OF GREETING-----------------//

        Console.WriteLine("So tell me, what is your name?");
        // This will ask the user for their name

        string user_name = Console.ReadLine();
        // This will take the user's name

        Console.WriteLine("Welcome: " + user_name);


        string[] inventory_items = new string[10];
        inventory_items[0] = "1, item#1";
        inventory_items[1] = "2, item #2";
        inventory_items[2] = "3, item #3";
        inventory_items[3] = "4, item #4";
        inventory_items[4] = "5, item #5";
        // This is a basic inventory array of 4 items for the user to choose from

        Console.WriteLine("Here are the list of items we currently have: " + inventory_items[0] + " , " +
                          inventory_items[1] +
                          " , " + inventory_items[2] + "" + inventory_items[3] + " or " + inventory_items[4]);



        string val;
        Console.Write("Enter a number between 1 - 4:");
        val = Console.ReadLine();
        
        string searchable = inventory_items[1];

        Console.WriteLine("Array before deletion");
        foreach (string value in inventory_items)
        {
            Console.WriteLine(value);
        }

        int indexToRemove = 3;
        inventory_items = inventory_items.Where((source, index) => index != indexToRemove).ToArray();
        Console.WriteLine("Array after deletion");

        foreach (string value in inventory_items)
        {
            Console.WriteLine(value);
        }

        string newitem = "item #4";
        List<string> list = new List<string>(inventory_items.ToList());
        list.Add(newitem);
        inventory_items = list.ToArray();
        foreach (var ni  in inventory_items)
        {
            Console.WriteLine(String.Join("\n", inventory_items + ni));
        }
        
        var search = Array.Find(inventory_items, element => element == searchable); // returns item number 2 from the 
        Console.WriteLine("The search result brought back: " + search + "." + " This is named item 2, and has a value of 2!");
    }
}