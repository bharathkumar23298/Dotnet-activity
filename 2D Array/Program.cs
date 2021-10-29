using System;

namespace MyProject3
{
    class Twodimensionalarray
    {
        static void Main(string[] args)
        {

            int[,] arry = new int[3, 3];
            int a = 0, i, j;
            //Using an automatic variable to fill the array
            for (i = 0; i < arry.GetLength(0); i++)
            {
                for (j = 0; j < arry.GetLength(1); j++)
                {
                    arry[i, j] = a;
                    Console.Write("The value of element in [{0},{1}] is:", i, j);
                    Console.WriteLine(a);
                    a += 1;
                }
            }
            //Getting numbers to fill the array
            /*for (i = 0; i < 3; i++)
			{
				for (j = 0; j < 3; j++)
				{
					Console.Write("Enter a value for element - [{0},{1}] : ", i, j);
					arry[i, j] = Convert.ToInt32(Console.ReadLine());
				}
			}*/
            // Getting output as a 3x3 matrix
            Console.Write("\nThe matrix is : \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", arry[i, j]);
                }
            }
            Console.Write("\nThe matrix is : \n");
            for (i = 2; i >= 0; i--)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", arry[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}