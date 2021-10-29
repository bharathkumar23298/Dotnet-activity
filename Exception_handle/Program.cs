using System;
namespace exception
{
    class Handling
    {
        static void Main(String[] args)
        {
            try 
            {
                Console.WriteLine("Enter the number:");
                var num=int.Parse(Console.ReadLine());
                Console.WriteLine($"square of{num} is{num *num}");
            }
            catch(Exception ex)
            {
               Console.Write("Error info:"+ex.Message);
            }
            finally
            {
               Console.Write("Re-try with a different number "); 
            }
        }
    }
}
