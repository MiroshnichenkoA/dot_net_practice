using System;
using System.Collections.Generic;
using System.Text;

namespace lecture_13
{
   static class StringExtensions
    {
        public static string CutString(this String stringUser)
        {
            string[] splited = stringUser.Split();
            string[] newString; 
            for (int i = 0; i < splited[5]; i++)
            {
                newString[i] = splited[i];
            }
            string newString = String.Join(, newString);
            return newString;
        }
    }
}
