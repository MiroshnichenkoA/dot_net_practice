using System;
using System.Collections.Generic;
using System.Text;

namespace Project_4
{
    public class Shape : IScale
    {
        readonly string _name;

        public virtual double Scale()
        {
            double result = 0;
            return result;
        }

        public virtual string Name()
        {
            string name = _name;
            return name;
        }

        protected double UserInsert()
        {
            string consoleInput = Console.ReadLine();
            double consoleInputChecked;
            bool check = double.TryParse(consoleInput, out consoleInputChecked);
            while (check == false)
            {
                Console.WriteLine("Please, insert a number");
                consoleInput = Console.ReadLine();
                check = double.TryParse(consoleInput, out consoleInputChecked);
            }
            consoleInputChecked = double.Parse(consoleInput);
            return consoleInputChecked;
        }

        protected void AskUser(string nameofShape)
        {
            Console.WriteLine($"Please, insert the value for the {nameofShape}");
        }
    }             
}