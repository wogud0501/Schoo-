using System;
using System.IO;
using System.Collections;
using System.Threading;
using System.Runtime;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Mainclass
{
    static void Main(string[] args)
    {
        string[] a = { "사과", "배", "바나나", "수박", "참외", "딸기" };
        Console.WriteLine("배열의 길이 : " + a.Length);
        for ( int i = 0; i < a.Length; i++ )
        {
            if (a[i] == "바나나")
            {
                Console.WriteLine("바나나의 위치 : " + i);
                break;
            }
        }
    }
}