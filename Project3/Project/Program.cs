using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstmassive = CreateEmptyMussive();
            string[] = CreateNewMussive();
        }
        static void CreateEmptyMussive(string[] args)
        {
            int[] emptyMassive = { }; //массив заполнится дефолтными значениями 0, чисто технически он не пустой, но математически вроде и пустой
        }
        static void CreateNewMussive(string[] args)
        {
            string[] newMassive = new string[3];
            int number = 32;
            string txt = "Hello";
            newMassive[0] = Convert.ToString(number);
            newMassive[1] = Convert.ToString('\u0041');
            newMassive[2] = "txt";
            Console.WriteLine(newMassive[0], newMassive[1], newMassive[2]);

            number = number + 10;
            newMassive[0] = Convert.ToString(number);
            newMassive[2] = "txt, guys!";
            Console.WriteLine(newMassive[0], newMassive[1], newMassive[2]);
        }
    }
}
