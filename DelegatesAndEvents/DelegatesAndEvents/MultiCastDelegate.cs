using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
    class MultiCastDelegate
    {
        delegate void Multi(int x, int y);
        public static void ImplementDelegate()
        {
            Multi obj = operation.Add;
            obj += operation.Square;

            obj(5, 5);
            obj(5, 4);
            Console.WriteLine("");
        }
    }
    public class operation
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition is {0}", a + b);
        }
        public static void Square(int a, int b)
        {
            Console.WriteLine("square is {0}", a * b);
        }
    }
}

