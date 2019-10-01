using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            } 
            Console.WriteLine($"{numbers[0]}, {numbers[1]}, {numbers[2]}, {numbers[3]}, {numbers[4]}, {numbers[5]}");

            numbers[2] = numbers[2] * 10;
            Console.WriteLine($"{numbers[0]}, {numbers[1]}, {numbers[2]}, {numbers[3]}, {numbers[4]}, {numbers[5]}");
        }
    }
}
