using System;
using static System.Console;
namespace 엑스트라_유틸리티2
{
    class EU
    {
        public static void Swap<T>(ref T a, ref T b) where T:struct
        {
            T tmp = a;
            a = b;
            b = tmp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            float hodu = 3.14f;
            float klee = 69.74f;
            WriteLine($"스와핑 전 : 호두:{hodu}, 클레:{klee}");
            EU.Swap(ref hodu, ref klee);
            WriteLine($"스와핑 후 : 호두:{hodu}, 클레:{klee}");
        }
    }
}
