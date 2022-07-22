using System;

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountString("Fpt software company hcm"," sroft"));
            Console.ReadLine();
        }
        public static int CountString(string inputString, string subString)
        {
            int count = 0;
            if(inputString.Length == subString.Length)
            {
                if(inputString == subString)
                {
                    count++;
                }
            }
            else if(inputString.Length > subString.Length)
            {
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (i + subString.Length < inputString.Length)
                    {
                        if (inputString.Substring(i, subString.Length) == subString)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
