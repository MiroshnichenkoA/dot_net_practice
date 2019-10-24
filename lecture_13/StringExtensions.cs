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
            string[] newString = new string[5]; 
            for (int i = 0; i < 5; i++)
            {
                newString[i]= splited[i];
            }
            string newString2 = String.Join("", newString);
            return newString2;
        }
    }
}
