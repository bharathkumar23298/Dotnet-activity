using System;

namespace login_system
{
    class input
    {
        string username, password, userid, userpwd;
        public void inp()
        {
            Console.Write("Enter a Username:" + " ");
            username = Console.ReadLine();
            Console.Write("Enter a Password:" + " ");
            password = Console.ReadLine();
            Console.Clear();
        }
        public void check()
        {
            int i = 0;
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter your UserID");
                userid = Console.ReadLine();
                Console.WriteLine("Enter your Password");
                userpwd = Console.ReadLine();
                Console.Clear();
                if (username == userid && password == userpwd)
                {
                    Console.WriteLine("Welcome" + " " + username);
                    break;
                }

                else if (i == 2)
                {
                    Console.WriteLine("You are not a valid user");
                }
                else if (i < 2)
                {
                    Console.WriteLine("please enter a valid UserId & pasword combination");
                }
            }
        }
        public class all
        {
            static void Main(string[] args)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Create a New Account");
                Console.WriteLine("-------------------------------");
                //string username = Console.ReadLine();
                input myObj = new input();
                myObj.inp();
                myObj.check();
                Console.ReadKey();
            }
        }


    }
}