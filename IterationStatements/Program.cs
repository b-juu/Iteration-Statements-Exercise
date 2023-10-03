using System.Diagnostics.CodeAnalysis;

namespace IterationStatements
{
    public class Program
    {

        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        static void PrintNumbers()
        {
            for (int num = 1000; num >= -1000; num--)
            {
                Console.WriteLine(num);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time 
        static void PrintNumbersByThree()
        {
            for (int num = 3; num <= 999; num += 3)
            {
                Console.WriteLine(num);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        static bool AreEqual(int num1, int num2)
        {
            return num1 == num2;
        }
        //Write a method to check whether a given number is even or odd
        static bool IsEven(int number)
        {
            return (number % 2) == 0;
        }
        //Write a method to check whether a given number is positive or negative
        static void CheckSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} is a positive number.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is a negative number.");
            }
            else
            {
                Console.WriteLine($"{number} is zero.");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        static bool CanVote(int age)
        {
            return age >= 18;
        }
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        static bool IsInRange(int number)
        {
            return number >= -10 && number <= 10;
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        static void DisplayMultiplicationTable(int number)
        {
            Console.WriteLine($"Multiplication Table for {number}:");

            for (int i = 1; i <= 12; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");
            }
        }
        //Call the methods to test them in the Main method below
        static void Main(string[] args)
                {
            PrintNumbers();
            PrintNumbersByThree();

            Console.WriteLine("guess my age");
           int guess = int.Parse(Console.ReadLine());
            if (AreEqual(guess, 27))
            {
                Console.WriteLine("correct!");
            }
            else
            {
                Console.WriteLine("wrong.");
            }

            Console.WriteLine("tell me a number and i will determine if it is even or odd.");
            int userNumber = int.Parse(Console.ReadLine());

            if (IsEven(userNumber))
            {
                Console.WriteLine($"{userNumber} is an even number.");
            }
            else
            {
                Console.WriteLine($"{userNumber} is an odd number.");
            }

            Console.WriteLine("tell me a number and i will tell you if it is positive or negative");
            int userNumber2 = int.Parse(Console.ReadLine());
             CheckSign(userNumber2);

            Console.WriteLine("Tell me your age and i will tell you if you can vote.");
            int age = int.Parse(Console.ReadLine());
            if (CanVote(age))
            {
                Console.WriteLine("You can vote.");
            }
            else
            {
                Console.WriteLine("You cannot vote.");
            }
            Console.WriteLine("tell me a number and i will tell you if it is in range of -10 to 10");
            int userNumber3 = int.Parse(Console.ReadLine());

            if (IsInRange(userNumber3))
            {
                Console.WriteLine($"{userNumber3} is in the range -10 to 10.");
            }
            else
            {
                Console.WriteLine($"{userNumber3} is not in the range -10 to 10.");
            }
            
            Console.WriteLine("what number would you like to see a multiplication table for?");
            int tableRequest = int.Parse(Console.ReadLine());
            DisplayMultiplicationTable(tableRequest);



                }
            }
        }
    
