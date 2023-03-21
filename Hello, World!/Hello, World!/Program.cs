using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello__World_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("점수 입력");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("과목 1 점수 : " + a);
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("과목 2 점수 : " + b);
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("과목 3 점수 : " + c);
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("과목 4 점수 : " + d);
            int e = a + b + c + d;
            Console.WriteLine("4과목 점수 총합 : " + e);
            int f = e / 4;
            Console.WriteLine("4과목 점수 평균 : " + f);
            if (f >= 90)
            {
                Console.WriteLine("등급 : A");
            }
            else if (f >= 80)
            {
                Console.WriteLine("등급 : B");
            }
            else if (f >= 70)
            {
                Console.WriteLine("등급 : C");
            }
            else if (f >= 60)
            {
                Console.WriteLine("등급 : D");
            }
            else if (f < 60)
                Console.WriteLine("등급 : E");
        }
    }
}
