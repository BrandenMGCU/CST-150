// Corrected By Branden M.
//This is my own work
//Grand Canyon University
//CST-150


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lydia's code - find the errors!
namespace CST117_IC08_console
{    
   public static class Set    //Didnt provide main class - I added one and made it public -Branden
    {        
        private static List<int> elements; //Main class wasn't defined and threw off all elements
        public static void Set1() => elements = new List<int>(); //Set is the name of the class can't use it again
        public static bool addElement(int val ) //Changed to staic to make usable       
        {
            if (containsElement(val)) return false; 
            else { elements.Add(val); return true; }
        }
        private bool containsElement(int val) 
        { for (int i = 0; i < elements.Count; i++) { if (val == elements[i]) return true; else return false; } return false; }
        public override string ToString() 
        { string str = ""; foreach (int i in elements) { str += i + " "; } return str; }
        public void clearSet() 
        { elements.Clear(); }
        public Set union(Set rhs) 
        { for (int i = 0; i < rhs.elements.Count; i++) { this.addElement(rhs.elements[i]); } return rhs; }
    }
    //The process throughout this is that because of the class not being set and these elements are trying to unify with a foundation that is not there!
}