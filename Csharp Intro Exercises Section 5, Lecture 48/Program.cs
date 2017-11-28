using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Intro_Exercises_Section_5__Lecture_48
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Count how many numbers between 1 and 100 
            //are divisible by 3 with no remainder.
            var i = 1;
            var counter = 0;

            while (i <= 100)
            {
                if (i % 3 == 0)
                    counter++;
                i++;
            }
            Console.WriteLine("There are {0} numbers between 1 and 100 divisible by 3.", counter);

            //2. Continuously ask the user to enter a number or "ok" to exit. 
            //Calculate the sum of all the previously entered numbers
            var input = "";
            var sum = 0;

            while (true)
            {
                Console.WriteLine("Enter a number or 'ok' to exit");
                input = Console.ReadLine();
                if (input == "ok")
                    break;
                else
                    sum += Convert.ToInt32(input);
            }

            Console.WriteLine(sum);

            //3. Ask the user to enter a number and 
            //compute the factorial of the number.
            Console.Write("Give me a number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;
            var count = number;

            for (var j = 1; count >= j; count--)
            {
                factorial *= count;
            }

            Console.WriteLine("{0}! = {1}", number, factorial);

            //4. Picks a random number between 1 and 10. 
            //Give the user 4 chances to guess the number.
            var random = new Random();
            var randomNumber = random.Next(1, 10);
            var guesses = 0;

            while (true)
            {
                Console.Write("Guess a number between 1 and 10: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == randomNumber)
                {
                    Console.WriteLine("You Won!");
                    break;
                }

                guesses++;

                if (guesses == 4)
                {
                    Console.WriteLine("You Lost");
                    break;
                }
            }

            //5. ask the user to enter a series of numbers separated by comma. 
            //Find the maximum of the numbers.
            Console.Write("Give me a list of comma separated numbers '1, 2, 3, etc.': ");
            var numString = Console.ReadLine();
            var max = 0;

            foreach (var numChar in numString)
            {  
                if (numChar != ' ' && numChar != ',')
                {
                    var temp = (int) Char.GetNumericValue(numChar);
                    if (temp > max)
                        max = temp;
                }
            }

            Console.WriteLine("{0} is the maximum of those numbers.", max);
        }  
    }
}
