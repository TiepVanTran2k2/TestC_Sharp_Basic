using System;
using System.Collections.Generic;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new[]
            {
                'a', 'e'
            };
            Console.WriteLine(ReplaceString("Tran Van Tiep", chars));
            Console.ReadLine();
        }
        public static string ReplaceString(string inputString, params char[] replaceChar)
        {
            string str = "NET05";
            string strNew = null;
            List<string> strings = new List<string>();
            for(int i = 0; i < inputString.Length; i++)
            {
                strings.Add(inputString.Substring(i, 1));
            }
            for(int i = 0; i < strings.Count; i++)
            {
                for(int j = 0; j < replaceChar.Length; j++)
                {
                    if (strings[i].ToString() == replaceChar[j].ToString())
                    {
                        strings[i] = str;
                    }
                }
                strNew += strings[i];
            }
            return strNew;
        }
    }
}
