using System;
public class AreaOfRectangle
{
    public static void Main()
    {
        Console.WriteLine("Enter number of rows :");
        int rows = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("\n");
        }
        Console.ReadKey();
    }
}  