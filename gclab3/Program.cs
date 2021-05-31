using System;

namespace gclab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name ="";
            string answer = "";

            Console.WriteLine("Hello, what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Great to have you here " +  name + "!");
            do
            {
                Console.WriteLine(name + ", " +   "please enter an integer between 1 and 100.");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput >=1 && userInput <= 100)
                {
                    if(userInput % 2 != 0)
                    {
                        Console.WriteLine(userInput + " is Odd");

                    }
                    else if (userInput % 2 == 0 && userInput < 25 && userInput >= 2)
                    {
                        Console.WriteLine("Even and less than 25");

                    }
                    else if (userInput % 2 == 0 && userInput >= 26 && userInput <= 60)
                    {
                        Console.WriteLine("Even");

                    }
                    else if (userInput % 2 == 0 && userInput > 60)
                    {
                        Console.WriteLine(userInput + " is Even");

                    }
                    else if (userInput % 2 != 0 && userInput > 60)
                    {
                        Console.WriteLine(userInput + " is Odd");

                    }
                    else
                    {
                       

                    }                    

                }
                else
                {
                    Console.WriteLine("Invalid input. Please check to make sure you entered a whole number in the range of 1 to 100.");
                }

                Console.WriteLine("Is there another number you would like to input, " + name + "? " + "Yes or No");
                answer = Console.ReadLine();


            } while (answer.ToLower() != "no" || answer.ToLower() != "n");

            Console.WriteLine("Thanks for using this program " + name +  "! " + " Come back anytime!");

            
        }
    }
}
