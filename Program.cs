using System;

namespace TestConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bool flag1 = false;
            bool flag2 = false;
            //Logic for program 1 in Section 1
            for (int i = 0; i <= 100; i++)
            {
                flag1 = false;
                flag2 = false;
                if (i % 3 == 0)
                {
                    flag1 = true;

                }
                if (i % 5 == 0)
                {
                    flag2 = true;
                }
                if (flag1 && flag2)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (flag1)
                {
                    Console.WriteLine("Fizz");
                }
                else if (flag2)
                {
                    Console.WriteLine("Buzz");
                }


            }
            SecondProgram reverse = new SecondProgram();
            reverse.reverseofString();

        }
    }
    public class SecondProgram
    {
        public void reverseofString()
        {
            string s = Console.ReadLine();
            int strlength = s.Length;
            for (int i = strlength - 1; i >= 0; i--)
            {
                Console.WriteLine(s[i]);
            }
        }

    }
}
