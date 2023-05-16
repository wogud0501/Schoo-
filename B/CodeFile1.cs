using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.InteropServices;


class MainClass
{
    static void Main(string[] args)
    {
        Console.Write("나눌 숫자를 입력하세요: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("나누는 숫자를 입력하세요: ");
        int num2 = int.Parse(Console.ReadLine());

        try
        {
            int result = num1 / num2;
            Console.WriteLine("{0}를 {1}로 나눈 결과: {2}", num1, num2, result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("0으로 나눌 수 없습니다.");
        }
    }
}