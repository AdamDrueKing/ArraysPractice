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

            //string[] topVacationSpots = { "Hawaii", "Nantucket", "Denver", "Costa Rica", "Melbourne", "Yucatan", "Key West", "Amsterdam", "Thailand", "Johannesberg" };
            //Console.WriteLine(topVacationSpots[0]);
            //Console.WriteLine(topVacationSpots[9]);

            //int[] childrensAges = { 1, 3, 1 };
            //Console.WriteLine(childrensAges[0]);
            //Console.WriteLine(childrensAges[1]);
            //Console.WriteLine(childrensAges[2]);

            //double[] gradePointAverages = { 3.8, 4.2, 2.3, 1.9, 0.7, 2.2, 3.5, 3.1 };

            //char[] classmatesFirstNames = { 'B', 'A', 'P', 'H', };
            //Console.WriteLine(classmatesFirstNames);  




            //dataType[] nameOfArray = new dataType{#ofElements};
            int[] numberOfSeats = new int[21];
            string[] studentsInClass = new string[21];

            //nameofArray[index] = Element;
            studentsInClass[0] = "Jordan";

            Console.WriteLine("Please enter in the name of the next student.");
            studentsInClass[1] = Console.ReadLine();
            Console.WriteLine("The student in the second seat is {0}.", studentsInClass[1]);

            //Ask user for input
            Console.WriteLine("Please enter the age of the person in the first seat.");
            //Create a new int array with 21 spots and call it ageOfStudentsInClass
            int[] ageOfStudentsInClass = new int[21];
            //Assign the value of the int at the 0 index of ageOfStudentsInClass to...
            //...the user's input converted into an int
            ageOfStudentsInClass[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("The age of the student in the first seat is " + ageOfStudentsInClass[0]); 
            //Create a new string variable and set it equal to the int at the index of 0...
            //...and convert it into a string
            string firstIndex = ageOfStudentsInClass[0].ToString(); 


        }
    }
}
