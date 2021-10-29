using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the value for num1...Then Press ENTER");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for num2...Then Press ENTER");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the operation");
            Console.WriteLine("add -> a");
            Console.WriteLine("subtract -> s");
            Console.WriteLine("multiply -> m");
            Console.WriteLine("division -> d");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine("The addtion of num1 and num 2 is" + (num1 + num2));
                    break;

                case "s":
                    Console.WriteLine("The substract of num1 and num 2 is" + (num1 - num2));
                    break;

                case "m":
                    Console.WriteLine("The multiplication of num1 and num 2 is" + (num1 * num2));
                    break;

                case "d":
                    Console.WriteLine("The division of num1 and num 2 is" + (num1 / num2));
                    break;

            }


        }
    }
}
