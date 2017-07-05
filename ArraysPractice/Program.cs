using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring an array without initializing
            int[] myFirstArray;
            //declaring and initializing a second array
            string[] mySecondArray = { "First", "Second", "Third", "Fourth" };
            //declare and initialize a char array with the letters of your last name
            char[] myLastNameArray = { 'K', 'i', 'n', 'g' };
            //I want my console to print three elements of my array
            Console.WriteLine(myLastNameArray[0]);
            Console.WriteLine(myLastNameArray[2]);
            Console.WriteLine(myLastNameArray[3]);

            //Create the following arrays and print using the correct index numbers:
            //Array of Top 10 Vacation spots
            //Print the first and last vacation spots
            //Array of the ages of 3 children you know
            //print each child's age
            //Array of GPA's on a 4.0 scale of 8 student - you don't have to print
            //Array of the first letter of 4 of your classmate's names who are sitting near you
            //Print all four on the same line

            string[] topVacationSpots = { "Hawaii", "Nantucket", "Denver", "Costa Rica", "Melbourne", "Yucatan", "Key West", "Amsterdam", "Thailand", "Johannesberg" };
            Console.WriteLine(topVacationSpots[0]);
            Console.WriteLine(topVacationSpots[9]);

            int[] childrensAges = { 1, 3, 1 };
            Console.WriteLine(childrensAges[0]);
            Console.WriteLine(childrensAges[1]);
            Console.WriteLine(childrensAges[2]);

            double[] gradePointAverages = { 3.8, 4.2, 2.3, 1.9, 0.7, 2.2, 3.5, 3.1 };

            char[] classmatesFirstNames = { 'B', 'A', 'P', 'H', };
            Console.WriteLine(classmatesFirstNames);

        }
    }
}
