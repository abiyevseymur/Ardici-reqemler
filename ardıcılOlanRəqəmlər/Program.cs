using System;

namespace ardıcılOlanRəqəmlər
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 500;
            int min = 123;
            int differ = 111;
            int result = 0;
            for (int i = 0; i < b; i += differ)
            {
                result = min + i;
                if (result > b)
                {
                    break;
                }
                Console.WriteLine(result);
            }
            
            Console.ReadKey();
        }
    }
}