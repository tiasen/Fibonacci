using System;

namespace Fibonacci
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }
        
        public static int GetResult(int number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else if (number == 1 || number == 2)
            {
                return 1;
            }
            else
            {
                return GetResult(number - 1) + GetResult(number - 2);
            }
        }

        public static ulong[] GetValueCache(int length)
        {

            var list = new ulong[length + 1];
            for (int i = 0; i <= length; i++)
            {
                if (i == 0)
                {
                    list[i] = 0;
                }
                else if (i == 1 || i == 2)
                {
                    list[i] = 1;
                }
                else
                {
                    list[i] = list[i - 1] + list[i - 2];
                }
            }

            return list;
        }


        public static ulong GetResultNew(int number)
        {
            return number < 0 ? 0 : GetValueCache(number)[number];
        }
    }
}