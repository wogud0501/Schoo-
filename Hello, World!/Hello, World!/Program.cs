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
            Console.WriteLine("Typing Your Name : ");
            string a = Console.ReadLine();
            Console.WriteLine("my name is :" + a);
            Console.WriteLine("Typing User Age : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("I am " + b + " Years Old.");    
        }
    }
}
