using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            System.TimeSpan t1 = DateTime.Now.TimeOfDay;

            int h = t1.Hours;
                int h1 = (int)h; //запуталась в переменных типа и не было времени удалить, введение переменной h1 было не нужным

            if (h1 >= 9 && h1 < 12) Console.WriteLine("Good morning,guys!");
            else if (h1 >= 12 && h1 < 15) Console.WriteLine("Good day,guys!");
            else if (h1 >= 15 && h1 < 22) Console.WriteLine("Good evening,guys!");
            else Console.WriteLine("Good night,guys!");










            Console.WriteLine("Hello World!");
        }
    }
}
