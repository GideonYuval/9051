using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9051
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Sod1(12345)); //sum of odd indexes is 9
            Console.WriteLine(Sod2(12345)); //sum of even indexes is 6
            Console.WriteLine(Sod3(12345)); //sum of digits divides by 3, so this number divides by 3
            

            Console.WriteLine(Secret1(543)); //sum of digits is 12
            Console.WriteLine(Secret2(543)); //sum of square of digits is 50
            Console.WriteLine(Secret3(25,543)); //return 33

            Console.WriteLine(What1(23748)); //Sum of Even digits = 14
            Console.WriteLine(What2(23748)); //Sum of Odd digits = 10
            Console.WriteLine(What3(23748)); //Abs difference of Even - Odd = 4, which is a perfect square -> True

        }

        public static int Sod1(int x)
        {
            return Sod1H(x, 1); 
        }

        private static int Sod1H(int x, int y)
        {
            if (x == 0) return 0;
            int d = x % 10;
            int s = 0;
            if (y % 2 != 0) s = d;
            return s + Sod1H(x / 10, y + 1);
        }

        public static int Sod2(int x)
        {
            return Sod2H(x, 1); 
        }

        private static int Sod2H(int x, int y)
        {
            if (x == 0) return 0;
            int d = x % 10;
            int s = 0;
            if (y % 2 == 0) s = d;
            return s + Sod2H(x / 10, y + 1);
        }

        public static bool Sod3(int x)
        {
            int s = Sod1(x) + Sod2(x);
            return s % 3 == 0;
        }





        public static int Secret1(int x)
        {
            if (x < 10) 
                return x;
            return (x % 10) + Secret1(x / 10);
        }

        public static int Secret2(int x)
        {
            if (x < 10)
                return x * x;
            return Secret2(x / 10) + (x % 10) * (x % 10);
        }

        public static int Secret3(int x, int y)
        {
            if (y == 0)
                return x;
            int tmp1 = Secret1(x);
            int tmp2 = Secret2(y);
            return Secret3(tmp1 + tmp2, y / 10);
        }


        static int What1(int x)
        {
            if (x == 0) return 0;
            int ld = x % 10;
            int s = What1(x / 10);
            if (ld % 2 == 0)
                return s + ld;
            return s;
        }

        static int What2(int x)
        {
            if (x == 0) return 0;
            int ld = x % 10;
            int s = What2(x / 10);
            if (ld % 2 != 0)
                return s + ld;
            return s;
        }

        static bool What3(int x)
        {
            int x1 = What1(x);
            int x2 = What2(x);
            int d = Math.Abs(x1 - x2);
            double r = Math.Sqrt(d);
            return r * r == d;
        }






    }
}
