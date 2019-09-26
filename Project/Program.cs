using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            System.TimeSpan t1 = DateTime.Now.TimeOfDay;

            int h = t1.Hours;
            //запуталась в переменных типа и не было времени удалить, введение переменной h1 было не нужным

            if (h >= 9 && h < 12) Console.WriteLine($"It's {h} o'clock Good morning,guys!");
            else if (h >= 12 && h < 15) Console.WriteLine($"It's {h} o'clock Good day,guys!");
            else if (h >= 15 && h < 22) Console.WriteLine($"It's {h} o'clock Good evening,guys!");
            else Console.WriteLine($"It's {h} o'clock Good night,guys!");
        }
    }
}
