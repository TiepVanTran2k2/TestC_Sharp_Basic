using System;

namespace Test3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] i = new int[5]
            {
                2,1,13,4,5
            };
            Console.WriteLine(CompareArrayWithCurrentYear(i));
            Console.WriteLine(CheckArray(i));

            Console.ReadLine();
        }
        public static string CompareArrayWithCurrentYear(int[] array)
        {
            int check = 0;
            for(int i = 0; i < array.Length; i++)
            {
                check += array[i];
            }
            if(check > DateTime.Now.Year)
            {
                return "Higher";
            }
            else if(check < DateTime.Now.Year)
            {
                return "Lower";
            }
            else
            {
                return "Equaler";
            }
            return "";
        }
        public static string CheckArray(int[] array)
        {
            bool check = false;
            int sumLe = 0;
            int numberLe = 0;
            int sumChan = 0;
            int numberChan = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == 0)
                {
                    check = true;
                }
                if(array[i] % 2 == 0)
                {
                    sumChan += array[i];
                    numberChan++;
                }
                if (array[i] % 2 != 0)
                {
                    sumLe += array[i];
                    numberLe++;
                }
            }
            if (check)
            {
                return "Array must not containts Zero";
            }
            else if(sumChan > sumLe && numberChan > numberLe)
            {
                return "Even-Even";
            }
            else if(sumChan > sumLe && numberChan < numberLe)
            {
                return "Even-Odd";
            }
            else if(sumChan < sumLe && numberChan > numberLe)
            {
                return "Odd-Even";
            }
            else
            {
                return "Odd-Odd";
            }
        }
    }
}
