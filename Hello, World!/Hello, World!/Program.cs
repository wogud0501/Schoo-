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
            Console.Write("삼각형의 높이를 입력하세요 : ");
            int height = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }

               
                for (int k = 1; k <= i * 2 - 1; k++)
                {
                    Console.Write("*");
                }

                
                Console.WriteLine();
            }
        }
    }
}
