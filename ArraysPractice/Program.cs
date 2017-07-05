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
            //int[] myFirstArray;
            ////declaring and initializing a second array
            //string[] mySecondArray = { "First", "Second", "Third", "Fourth" };
            ////declare and initialize a char array with the letters of your last name
            //char[] myLastNameArray = { 'K', 'i', 'n', 'g' };
            ////I want my console to print three elements of my array
            //Console.WriteLine(myLastNameArray[0]);
            //Console.WriteLine(myLastNameArray[2]);
            //Console.WriteLine(myLastNameArray[3]);

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
            //int[] numberOfSeats = new int[21];
            //string[] studentsInClass = new string[21];

            ////nameofArray[index] = Element;
            //studentsInClass[0] = "Jordan";

            //Console.WriteLine("Please enter in the name of the next student.");
            //studentsInClass[1] = Console.ReadLine();
            //Console.WriteLine("The student in the second seat is {0}.", studentsInClass[1]);

            ////Ask user for input
            //Console.WriteLine("Please enter the age of the person in the first seat.");
            ////Create a new int array with 21 spots and call it ageOfStudentsInClass
            //int[] ageOfStudentsInClass = new int[21];
            ////Assign the value of the int at the 0 index of ageOfStudentsInClass to...
            ////...the user's input converted into an int
            //ageOfStudentsInClass[0] = int.Parse(Console.ReadLine());
            //Console.WriteLine("The age of the student in the first seat is " + ageOfStudentsInClass[0]); 
            ////Create a new string variable and set it equal to the int at the index of 0...
            ////...and convert it into a string
            //string firstIndex = ageOfStudentsInClass[0].ToString(); 



            //string[] restaurantsInMall = { "Subway", "Saki", "Dunkin Donuts", "Red Lobster", "Chick Fil-A" };
            //Console.WriteLine(restaurantsInMall.Length);

            ////For review
            ////Declare and not initialize
            //int[] myIntArrayAgain;
            ////Declare and initialize an array when I know the elements
            //char[] lettersInFirstName = { 'A', 'D', 'A', 'M' };
            ////To decalre and initialize an array when I DON'T know the elements but know how many there will be
            //string[] variableName = new string[42];

            ////To practice using .Length, create a char array of the letters in your middle name
            ////...and print the number of char's to the Console.

            //char[] myMiddleNameLetters = { 'D', 'r', 'u', 'e' };
            //Console.WriteLine(myMiddleNameLetters.Length);

            //Declare and initialize a string array.
            //Using the length property, print the SECOND TO LAST element in the array

            //string[] restaurantsInMall = { "Subway", "Saki", "Dunkin Donuts", "Red Lobster", "Chick Fil-A" };
            //string secondToLastIndex = restaurantsInMall[3].ToString();
            //Console.WriteLine(restaurantsInMall[3].Length);

            //int numberOfRestaurants = restaurantsInMall.Length;
            //Console.WriteLine(restaurantsInMall[numberOfRestaurants - 2]);  

            //IndexOf is a method used to search an array for a specified value and returns...
            //the index position of the first matching value found.

            //int[] bestYearsEver = { 1985, 1999, 1991, 2000, 1985 };
            //Console.WriteLine(Array.IndexOf(bestYearsEver, 1985));

            ////LastIndexOf is a method used to search an array for a specified value and returns...
            ////the index position of the last matching value found.
            //Console.WriteLine(Array.LastIndexOf(bestYearsEver, 1985));


            //Reverse Method
            //int[] palindromeNumbers = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(palindromeNumbers[0]);
            //Console.WriteLine(palindromeNumbers[2]);
            //Array.Reverse(palindromeNumbers);
            //Console.WriteLine(palindromeNumbers[0]);
            //Console.WriteLine(palindromeNumbers[2]);


            //Sort
            //will sort numbers in an array from lowest to highest
            //will sort char's and strings in alphabetical order from A-Z
            //string[] powerRangers = { "Green", "Yellow", "Pink", "Blue", "Red", "Black" };
            //Console.WriteLine(powerRangers[0]);
            //Array.Sort(powerRangers);
            //Console.WriteLine(powerRangers[0]);


            //Declare and initialize a string array of first names. Choose a name to find and print the IndexOf.
            string[] listOfNames = { "Adam", "Bob", "Paige", "Iris", "Hope", "Mike", "Shaun" };
            Console.WriteLine(Array.IndexOf(listOfNames, "Adam"));

            //Create an array of lucky numbers. Each number should repeat at least once.Choose a lucky number, find and print the last index of it.
            int[] luckyNumbers = { 7, 13, 22, 4, 10, 21, 7, 10, 22, 13, 4, 17, 4, 10, 13, 21, 17, 84 };
            Console.WriteLine(Array.LastIndexOf(luckyNumbers, 17));

            //Create an array of alphabet characters. Print the first index of the array.Now reverse the array and print the first index.
            string[] alphabetCharacters = { "a", "b", "c", "d", "e", "f", "g" };
            Console.WriteLine(alphabetCharacters[0]);
            Array.Reverse(alphabetCharacters);
            Console.WriteLine(alphabetCharacters[0]);

            //Create an array of student names in random order. Order the students’ names using the sort method.Print the first and last students’ names.
            string[] listOfNamesToo = { "Mike", "Jessica", "Jay", "Adam", "Bob", "Paige", "Iris", "Hope", "Mike", "Shaun" };
            Console.WriteLine(listOfNamesToo[0]);
            Console.WriteLine(listOfNamesToo[9]);
            Array.Sort(listOfNames);
            //int = classNames
            Console.WriteLine(listOfNamesToo[0]);
            Console.WriteLine(listOfNamesToo[9]);

            //Ask 10 people for their favorite numbers and create an array of those numbers.Order the numbers using the sort method.Print the first and last numbers.
            int[] favoriteNumbers = { 4, 6, 9, 22, 11, 14, 13, 9, 3, 7 };
            Console.WriteLine(favoriteNumbers[0]);
            Console.WriteLine(favoriteNumbers[9]);
            Array.Sort(favoriteNumbers);
            Console.WriteLine(favoriteNumbers[0]);
            Console.WriteLine(favoriteNumbers[9]);




        }
    }
}
