using System;

namespace $safeprojectname$
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduction
            PrintSlow("**Hi! I am MathPal**");
            PrintSlow("Your friendly math assistant bot");

            // Ask for user's name
            Console.Write("May I know your name? ");
            string userName = Console.ReadLine();

            PrintSlow($"\nNice to meet you, {userName}!");

            // Ask about the user's day
            Console.Write($"How was your day so far, {userName}? ");
            string dayResponse = Console.ReadLine().ToLower();

            if (dayResponse.Contains("good"))
            {
                PrintSlow("That's wonderful to hear!\n");
            }
            else
            {
                PrintSlow("I hope it gets better!\n");
            }

            // Ask about readiness to learn math
            Console.Write($"Are you ready to explore some math with MathPal, {userName}? ");
            string readinessResponse = Console.ReadLine().ToLower();

            if (readinessResponse.Contains("yes"))
            {
                PrintSlow("Great! Let's dive into the world of math.\n");
            }
            else
            {
                PrintSlow("No worries! Whenever you're ready, just let me know.\n");
            }

            // Responsibilities introduction
            PrintSlow($"As your math assistant, {userName}, here are some things I can help you with:");

            while (true)
            {
                Console.WriteLine("\nSelect an activity:");
                Console.WriteLine("1. Find the area of different shapes.");
                Console.WriteLine("2. Find the square root of a number.");
                Console.WriteLine("3. Find the volume of 3D shapes.");
                Console.WriteLine("4. Exit");

                Console.Write("Please choose an activity (1, 2, 3, or 4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CalculateArea();
                        break;
                    case "2":
                        CalculateSquareRoot();
                        break;
                    case "3":
                        CalculateVolume();
                        break;
                    case "4":
                        Exit();
                        break;
                    default:
                        PrintSlow("Invalid choice. Please enter 1, 2, 3, or 4.\n");
                        break;
                }
            }
        }

        // Filter function to detect keywords
        static int Filter(string input)
        {
            string[] areaKeywords = { "shape", "area" };
            string[] sqrtKeywords = { "squareroot", "root", "square root" };
            string[] exitKeywords = { "exit", "quit", "close", "thanks", "thank you", "cancel" };
            string[] volumeKeywords = { "volume", "cylinder", "cone", "sphere" };

            foreach (string word in areaKeywords)
            {
                if (input.Contains(word))
                    return 1;
            }

            foreach (string word in sqrtKeywords)
            {
                if (input.Contains(word))
                    return 2;
            }

            foreach (string word in exitKeywords)
            {
                if (input.Contains(word))
                    return 3;
            }

            foreach (string word in volumeKeywords)
            {
                if (input.Contains(word))
                    return 4;
            }

            Console.WriteLine("\nPlease try again with math-related questions.\n");
            return Filter(Console.ReadLine().ToLower());
        }

        // Calculate area of shapes
        static void CalculateArea()
        {
            Console.WriteLine("Bot: I can help you calculate the area of a shape.");
            Console.WriteLine("Bot: Give me any shape (e.g., rectangle, square, triangle, circle), or type 'exit' to go back.\n");

            while (true)
            {
                Console.Write("Send a message: ");
                string shapeInput = Console.ReadLine().ToLower();

                if (shapeInput.Contains("rectangle"))
                {
                    CalculateRectangleArea();
                }
                else if (shapeInput.Contains("square"))
                {
                    CalculateSquareArea();
                }
                else if (shapeInput.Contains("triangle"))
                {
                    CalculateTriangleArea();
                }
                else if (shapeInput.Contains("circle"))
                {
                    CalculateCircleArea();
                }
                else if (shapeInput.Contains("exit"))
                {
                    // User wants to go back to the main menu
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid shape. Please try again or type 'exit' to go back.\n");
                }
            }
        }

        // Helper method to calculate rectangle area
        static void CalculateRectangleArea()
        {
            Console.Write("What is the length of the rectangle? (cm)\n>>");
            double length = GetPositiveDoubleInput();

            Console.Write("What is the width of the rectangle? (cm)\n>>");
            double width = GetPositiveDoubleInput();

            double area = length * width;
            Console.WriteLine($"The area of the rectangle is {area} square centimeters.\n");
        }

        // Helper method to calculate square area
        static void CalculateSquareArea()
        {
            Console.Write("What is the length of the square? (cm)\n>>");
            double length = GetPositiveDoubleInput();

            double area = length * length;
            Console.WriteLine($"The area of the square is {area} square centimeters.\n");
        }

        // Helper method to calculate triangle area
        static void CalculateTriangleArea()
        {
            Console.Write("What is the height of the triangle? (cm)\n>>");
            double height = GetPositiveDoubleInput();

            Console.Write("What is the base of the triangle? (cm)\n>>");
            double baseLength = GetPositiveDoubleInput();

            double area = 0.5 * height * baseLength;
            Console.WriteLine($"The area of the triangle is {area} square centimeters.\n");
        }

        // Helper method to calculate circle area
        static void CalculateCircleArea()
        {
            Console.Write("What is the radius of the circle? (cm)\n>>");
            double radius = GetPositiveDoubleInput();

            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of the circle is {area} square centimeters.\n");
        }

        // New method to calculate volume
        static void CalculateVolume()
        {
            Console.WriteLine("Bot: I can help you calculate the volume of a 3D shape.");
            Console.WriteLine("Bot: Give me any 3D shape (e.g., cylinder, cone, sphere), or type 'exit' to go back.\n");

            while (true)
            {
                Console.Write("Send a message: ");
                string shapeInput = Console.ReadLine().ToLower();

                if (shapeInput.Contains("cylinder"))
                {
                    CalculateCylinderVolume();
                }
                else if (shapeInput.Contains("cone"))
                {
                    CalculateConeVolume();
                }
                else if (shapeInput.Contains("sphere"))
                {
                    CalculateSphereVolume();
                }
                else if (shapeInput.Contains("exit"))
                {
                    // User wants to go back to the main menu
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid shape. Please try again or type 'exit' to go back.\n");
                }
            }
        }

        // New method to calculate cylinder volume
        static void CalculateCylinderVolume()
        {
            Console.Write("What is the radius of the cylinder? (cm)\n>>");
            double radius = GetPositiveDoubleInput();

            Console.Write("What is the height of the cylinder? (cm)\n>>");
            double height = GetPositiveDoubleInput();

            double volume = Math.PI * Math.Pow(radius, 2) * height;
            Console.WriteLine($"The volume of the cylinder is {volume} cubic centimeters.\n");
        }

        // New method to calculate cone volume
        static void CalculateConeVolume()
        {
            Console.Write("What is the radius of the cone? (cm)\n>>");
            double radius = GetPositiveDoubleInput();

            Console.Write("What is the height of the cone? (cm)\n>>");
            double height = GetPositiveDoubleInput();

            double volume = (1.0 / 3) * Math.PI * Math.Pow(radius, 2) * height;
            Console.WriteLine($"The volume of the cone is {volume} cubic centimeters.\n");
        }

        // New method to calculate sphere volume
        static void CalculateSphereVolume()
        {
            Console.Write("What is the radius of the sphere? (cm)\n>>");
            double radius = GetPositiveDoubleInput();

            double volume = (4.0 / 3) * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"The volume of the sphere is {volume} cubic centimeters.\n");
        }

        // Helper method to calculate square root
        static void CalculateSquareRoot()
        {
            Console.Write("\nPlease enter any positive number.\n>>");
            double num = GetPositiveDoubleInput();
            double squareRoot = Math.Sqrt(num);
            Console.WriteLine($"The square root of {num} is {squareRoot}.\n");
        }

        // Helper method to get positive double input
        static double GetPositiveDoubleInput()
        {
            double value;
            while (!double.TryParse(Console.ReadLine(), out value) || value < 0)
            {
                Console.Write("Invalid input. Please enter a positive number: ");
            }
            return value;
        }

        // Exit request
        static void Exit()
        {
            PrintSlow("You are welcome, have a nice day!\n\n");
            Environment.Exit(0);
        }

        // Helper method to print text slowly
        static void PrintSlow(string text)
        {
            foreach (char letter in text)
            {
                Console.Write(letter);
                System.Threading.Thread.Sleep(70);
            }
            Console.WriteLine();
        }
    }
}
