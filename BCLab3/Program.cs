using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int userNumber;
            char loopBreaker;
            string userName;

            //Prompt user for number entry
            Console.WriteLine("Please enter an integer in: (1-00)");
            userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your name: ");
            userName = Console.ReadLine();
            

            if (userNumber < 0 || userNumber > 100)
            {
                Console.WriteLine($"ERROR: {userName} you have entered an invalid number");
                Console.WriteLine("Please enter an integer in: (1-00)");
                userNumber = int.Parse(Console.ReadLine());

            }

            if (userNumber % 2 == 1)
            {
                Console.WriteLine($" {userName} The integer you entered: {userNumber} is odd");
                Console.ReadLine();
                if (userNumber > 60)
                {
                    Console.WriteLine($"{userName} The number entered: {userNumber} is odd and greater than 60");
                    Console.ReadLine();
                }
            }

            else if (userNumber %2 == 0)
            {
                if (userNumber >= 2 && userNumber <= 25)
                {
                    Console.WriteLine($"{userName} The number entered is even and in the range of 2-25");
                    Console.ReadLine();
                }
                else if (userNumber >= 26 && userNumber <= 60 )
                {
                    Console.WriteLine($"{userName} The number you have entered is even and in the range of 26-60");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"{userName} The number entered is: {userNumber} and it is even and greater than 60");
                    Console.ReadLine();
                }
            }

            Console.WriteLine("Continue? (y/n): ");
            loopBreaker = char.Parse(Console.ReadLine());

            while (loopBreaker == 'y')
            {
                //Prompt user for number entry
                Console.WriteLine("Please enter an integer in: (1-00)");
                userNumber = int.Parse(Console.ReadLine());

                if (userNumber < 0 || userNumber > 100)
                {
                    Console.WriteLine($"ERROR: {userName} you have entered an Invalid number");
                    Console.WriteLine("Please enter an integer in: (1-00)");
                    userNumber = int.Parse(Console.ReadLine());

                }

                if (userNumber % 2 == 1)
                {
                    Console.WriteLine($"{userName} The integer you entered: {userNumber} is odd");
                    Console.ReadLine();
                    if (userNumber > 60)
                    {
                        Console.WriteLine($"{userName} The number entered: {userNumber} is odd and greater than 60");
                        Console.ReadLine();
                    }
                }

                else if (userNumber % 2 == 0)
                {
                    if (userNumber >= 2 && userNumber <= 25)
                    {
                        Console.WriteLine($"{userName} The number entered is even and in the range of 2-25");
                        Console.ReadLine();
                    }
                    else if (userNumber >= 26 && userNumber <= 60)
                    {
                        Console.WriteLine($"{userName} The number you have entered is even and in the range of 26-60");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"{userName} The number entered is: {userNumber} and it is even and greater than 60");
                        Console.ReadLine();
                    }
                }

                Console.WriteLine("Continue? (y/n): ");
                loopBreaker = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("End of the Program");
            Console.ReadLine();

        }
    }
}
