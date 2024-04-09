using System;

namespace HW0406
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Task1 task1 = new Task1();

            task1.GameMoving();

            Console.WriteLine();

            Console.Write("Hello world : ");

            Console.Write(Task2.Coder("Hello world"));

            Console.ReadLine();
        }
    }
}
