using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num1 = 10;
            int num2 = 30;
            num1 = num2;
            num2 = 65;
            Console.WriteLine(num1);

            int[] numbers = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };
            numbers = numbers2;
            numbers2[0] = 999;

            //garbage collector - çöp toplayıcısı heapte kullanılmayan adres değerini siler..
        }
    }
}
