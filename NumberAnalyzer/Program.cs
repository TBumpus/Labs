using System;

namespace NumberAnalyzer
{
    class Program
    {

        static void Main(string[] args)
        {

            string repeat = "y";
            Console.WriteLine("Hello user please enter your name.");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello {0} and welcome to our number analyzer", userName);

            while (repeat == "y")
            {

                Console.WriteLine("Please enter a number between 1 and 100");

                var userInput = Console.ReadLine();
                int parsedInt;
                var isInt = int.TryParse(userInput, out parsedInt);

                //int number = int.Parse(userInput);

                if (isInt)
                {
                    int number = parsedInt;


                    if (number > 1 && number < 100)
                    {

                        if (number < 60 && number % 2 != 0)
                        {
                            Console.WriteLine(userName + ", {0} is odd and Less than 60.", number);
                        }
                        else if (number > 1 && number < 25 && number % 2 == 0)
                        {
                            Console.WriteLine(userName + ", {0} is even and less than 25.", number);
                        }
                        else if (number > 25 && number <= 60 && number % 2 == 0)
                        {
                            Console.WriteLine(userName + ", {0} is even and between 26 and 60 inclusive.", number);
                        }
                        else if (number > 60 && number % 2 == 0)
                        {
                            Console.WriteLine(userName + ", {0} is even and greater than 60", number);
                        }
                        else if (number > 60 && number % 2 != 0)
                        {
                            Console.WriteLine(userName + ", {0} is odd and greater than 60", number);
                        }
                        else break;
                    }
                    else
                        Console.WriteLine("{0}, that is not a number between 1 and 100", userName);


                    //Console.WriteLine(userName + ", Would you like to continue? (y/n)");
                    //repeat = Console.ReadLine();
                }
                Console.WriteLine(userName + ", Would you like to continue? (y/n)");
                repeat = Console.ReadLine();
            }
            Console.WriteLine("Goodbye {0}!", userName);
        }
    }
}
/*Console.WriteLine("Give me a number: ");
var userInput = Console.ReadLine();
int parsedInt;
var isInt = int.TryParse(userInput, out parsedInt);

if (isInt)
{
    Console.WriteLine(parsedInt);
}
else
{
    Console.WriteLine("hey thats not an integer");
}*/
