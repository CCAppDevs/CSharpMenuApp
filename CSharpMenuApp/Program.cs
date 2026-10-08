namespace CSharpMenuApp
{
    internal class Program
    {
        static int width = 0;
        static int height = 0;
        static int length = 0;

        static void Main(string[] args)
        {
            // build a menu driven app (console) that calculates the area of a cube

            // loop until exit is called
            // print the menu
            // capture the dimensions of the cube (width, height, length)

            // calculate the area - good
            // exit - good
            // reset the app - good
            bool isRunning = true;
            int choice = -1;



            while (isRunning)
            {
                PrintMenu();

                choice = Prompt("What would you like to do? (1-3, 0)");

                switch (choice)
                {
                    case 1: // capture dimensions
                        GatherDimensions();
                        break;
                    case 2: // calculate
                        Calculate();
                        break;
                    case 3: // reset
                        Reset();
                        break;
                    case 0: // exit
                        Console.WriteLine("Exiting...");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option. Please try again.");
                        break;
                }
            }
        }

        static int Prompt(string question)
        {
            Console.Write($"{question} ");
            return int.Parse(Console.ReadLine()); // TODO: fix this when input is invalid
        }

        static void PrintMenu()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\tMain Menu");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.WriteLine("1. Capture Dimensions");
            Console.WriteLine("2. Calculate");
            Console.WriteLine("3. Reset");
            Console.WriteLine("0. Exit");
        }

        static void GatherDimensions()
        {
            Console.WriteLine("Capturing Dimensions");
            width = Prompt("What is the width?");
            height = Prompt("What is the height?");
            length = Prompt("What is the length?");
        }

        static void Calculate()
        {
            Console.WriteLine($"The current dimensions are: width - {width} height - {height} length - {length}");
            Console.WriteLine("Calculating...");
            Console.WriteLine($"Area is: {width * height * length}");
        }

        static void Reset()
        {
            Console.WriteLine("Resetting...");
        }
    }
}
