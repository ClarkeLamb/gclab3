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
                string userInput = Console.ReadLine();

                int num = -1;

                if(!int.TryParse(userInput, out num))
                {
                    Console.WriteLine("That is not an integer.");
                }
                
                
                if (num >= 1 && num <= 100)
                {
                    if(num % 2 != 0)
                    {
                        Console.WriteLine(num + " is Odd");

                    }
                    else if (num % 2 == 0 && num < 25 && num >= 2)
                    {
                        Console.WriteLine("Even and less than 25");

                    }
                    else if (num % 2 == 0 && num >= 26 && num <= 60)
                    {
                        Console.WriteLine("Even");

                    }
                    else if (num % 2 == 0 && num > 60)
                    {
                        Console.WriteLine(num + " is Even");

                    }
                    else if (num % 2 != 0 && num > 60)
                    {
                        Console.WriteLine(num + " is Odd");

                    }
                    else
                    {

                    }
                             
                                      

                }
                else
                {
                    Console.WriteLine("Invalid input. Please check to make sure you entered a whole number in the range of 1 to 100.");
                }


                Console.WriteLine("Is there another number you would like to input, " + name + "? " + "Yes or No?");
                answer = Console.ReadLine();
                                

            } while (answer.ToLower() != "no");

            Console.WriteLine("Thanks for using this program " + name +  "! " + " Come back anytime!");

            
        }
    }
}
