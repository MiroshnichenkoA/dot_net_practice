using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пустой массив:");
            CreateEmptyMussive();
            Console.WriteLine("Новый массив:");
            CreateNewMussive();
            Console.WriteLine("Третий массив:");
            MaxNum();
            Console.WriteLine("Упаковка/распаковка:");
            Boxing();
        }
        static void CreateEmptyMussive()
        {
            int[] emptyMassive = {}; //не заполнился ничем, потому что нет у него размерности
            for (int i = 0; i < emptyMassive.Length; i++)
            {
                Console.WriteLine(emptyMassive[i]);
            }
        }
        static void CreateNewMussive()
        {
            string[] newMassive = new string[3];
            int number = 32;
            string txt = "Hello";
            newMassive[0] = Convert.ToString(number);
            newMassive[1] = Convert.ToString('\u0041');
            newMassive[2] = txt;
            for (int i = 0; i < newMassive.Length; i++)
            {
                Console.WriteLine(newMassive[i]);
            }
            number = number + 10;
            newMassive[0] = Convert.ToString(number);
            newMassive[2] = $"{txt}, guys!";
            for (int i = 0; i < newMassive.Length; i++)
            {
                Console.WriteLine(newMassive[i]);
            }
        }
        static void MaxNum()
        {
        int[] massive = new int[13];
            for (int i = 0; i < massive.Length; i++)
            {
                Random fortuna = new Random();
                massive[i] = fortuna.Next();
                Console.WriteLine(massive[i]);
            }
        int maxNum = int.MinValue;
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] > maxNum) maxNum = massive[i];
            }
            Console.WriteLine($"Максимальное значение данного массива: {maxNum}");
        }
        static void Boxing()
        {
            short variableForBoxing = 10;
            object variableBoxed = variableForBoxing;
            System.SByte variableUnboxed = (SByte)(short)variableBoxed;
            Console.WriteLine($"Значение переменной {variableUnboxed}, тип переменной {variableUnboxed.GetType()}");
        }
    }
}
