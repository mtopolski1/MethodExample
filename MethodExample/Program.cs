using System;

namespace MethodExample
{
    class Program
    {
        static void Main(string[] args)  //Main Method
        {
            //handle all into
            ProgramIntro();

            //get numbers
            double x = getInput(); //First User Input
            double y = getInput(); //Second User Input
            //double z = getInput(); //Third User Input

            //All extra methods
            //Console.WriteLine(GetArea(x, y));
            //Console.WriteLine(GetPerimeter(x, y));
            //Console.WriteLine(GetVolume(x, y, z));

            CountDown(100);
            CountDownEven(100);

            //Runs all methods in runProgram, aka Doing all the Math
            runProgram(x, y);
        }

        static void runProgram(double x, double y) //Method result in a variable = Doing all the Math with x, y
        {
            bool loopProgram = true;
            while (loopProgram)
            {

                int menuChoice;

                //Display menu options
                Console.WriteLine("Choice an option");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Option 1 to Add");
                Console.WriteLine("Option 2 to Subtraction");
                Console.WriteLine("Option 3 to Multiply");
                Console.WriteLine("Option 4 to Divider"); ;
                Console.WriteLine("-------------------------");

                while (true)//get user choics for which calc they want to do
                {

                    menuChoice = int.Parse(Console.ReadLine());
                    if (menuChoice >= 1 && menuChoice <= 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was not a menu option, Please select 1 -4");
                    }
                }
                //Using display result to get a nicer display
                if (menuChoice == 1)
                {
                    DispayResult(Adder(x, y));
                }
                else if (menuChoice == 2)
                {
                    DispayResult(Subber(x, y));
                }
                else if (menuChoice == 3)
                {
                    DispayResult(Mulitpler(x, y));
                }
                else if (menuChoice == 4)
                {
                    DispayResult(Divider(x, y));
                }

                //No longer using WriteLine//

                // Console.WriteLine(Adder(x,y));
                // Console.WriteLine(Subber(x, y));
                // Console.WriteLine(Mulitpler(x, y));
                // Console.WriteLine(Divider(x, y));

                Console.WriteLine("Do you want to continue? y/n");
                while (true)
                {
                    string continueResults = Console.ReadLine();

                    if (continueResults == "y")
                    {
                        break;
                    }
                    else if (continueResults == "n")
                    {
                        loopProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid input");
                    }
                }
            }
        }

        private static void ProgramIntro()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age;
            while (true)
            {
                age = int.Parse(Console.ReadLine());//get age from user
                if (age <= 0)
                {
                    Console.WriteLine("Your age is to low. Please enter a age greater than 0");
                }
                else//Correct input
                {
                    break;
                }
            }
            //Display user into
            Console.WriteLine(ReturnHelloUser(name, age));
        }

        //Number from User
        static double getInput()
        {
            Console.WriteLine("Please enter a number");
            double input = double.Parse(Console.ReadLine());//User Input
            return input;//Return from Number
        }

        // Methd with 2 double parameters. returns a double
        static double Adder(double x, double y)
        {
            return x + y;
        }

        static double Subber(double x, double y)
        {
            return x - y;
        }

        static double Mulitpler(double x, double y)
        {
            return x * y;
        }

        static double Divider(double x, double y)
        {
            return x / y;
        }

        //Method overload for Adder
        static double Adder(double x, double y, double z)
        {
            return x + y + z;
        }

        //Method overload for Substraction
        static double Subber(double x, double y, double z)
        {
            return x - y - z;
        }


        //Method overload for 2 parameters
        static string ReturnHelloUser(string user, int age)//Method to return formatted message
        {
            string greeting = $"Hello, {user}. You are {age} years old";
            return greeting;//end of method. No code past the return will run
        }
        //Method overload for 1 parameter
        static string ReturnHelloUser(string user)//Method to return formatted message
        {
            string greeting = $"Hello, {user}";
            return greeting;
        }
        //Method with no parameters
        static string ReturnHelloUser()
        {
            string greeting = $"Hello, user";
            return greeting;
        }

        static void DispayResult(double result)
        {
            Console.WriteLine($"Your answer was {result}");
        }

        //Extra method practice. Not used in main program
        static double GetArea(double length, double width)
        {
            return length * width;
        }

        static double GetPerimeter(double length, double width)
        {
            return (length * 2) + (width * 2);
        }

        //Overload Method - Reason, adding togther length, width and height
        static double GetVolume(double length, double width, double height)
        {
            return length * width * height;
        }

        //Uses for loop, Starts at Value and counts down to 0
        static void CountDown(int value)
        {
            for (int i = value; i > 0; i--)//stat at value, go down by 1 until it reach 0
            {
                Console.WriteLine(i);
            }
        }

        // Method to get Even Numbers only
        static void CountDownEven(int valueNumber)
        {
            for (int n = valueNumber; n > 0; n--)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}

//Every Method is a set of instructions - Each Method is a singlar interaction and can interlink with each other!

//Practice creating a method overload
// overloader of the adder, substractor

////Method overload for 2 parameters

