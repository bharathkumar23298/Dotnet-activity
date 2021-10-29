using System;
namespace Generics
{
    public class Myclass<T>
    {
        public bool campare(T a, T b)//(int a,int b)
        {
            if (a.Equals(b))//(a==b)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass<int> check = new Myclass<int>();
            bool res = check.campare('A', 'B');//(6,8)
            Console.WriteLine(res);
            //Console.Readkey();
        }
    }
}
