using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //one-dimensional array
            string[] stringArray = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            //user selection of specific index
            Console.WriteLine("Select an index (0-4) to see the corresponding fruit from the string array:");
            int stringIndex = Convert.ToInt32(Console.ReadLine()); 
            //check if index is in 0-4
            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                Console.WriteLine("You selected: " + stringArray[stringIndex]);
            }
            else
            {
                Console.WriteLine("Index does not exist in the string array.");
            }

            int[] intArray = { 10, 20, 30, 40, 50 }; 
            Console.WriteLine("Select an index (0-4) to see the corresponding integer from the integer array:");
            int intIndex = Convert.ToInt32(Console.ReadLine());

            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                Console.WriteLine("You selected: " + intArray[intIndex]);
            }
            else
            {
                Console.WriteLine("Index does not exist in the integer array.");
            }

           //third
            List<string> stringList = new List<string> { "Red", "Green", "Blue", "Yellow", "Purple" };
            Console.WriteLine("Select an index (0-4) to see the corresponding color from the string list:");
            int listIndex = Convert.ToInt32(Console.ReadLine());

            if (listIndex >= 0 && listIndex < stringList.Count)
            {
                Console.WriteLine("You selected: " + stringList[listIndex]);
            }
            else
            {
                Console.WriteLine("Index does not exist in the string list.");
            }
        }
    }
}
