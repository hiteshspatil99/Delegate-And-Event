using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
    class EventClass
    {
        public delegate void DelEventHandler();
        public static void India()
        {
            Console.WriteLine("India\n");
        }
        public static void Florida()
        {
            Console.WriteLine("Florida\n");
        }
        public static void Usa()
        {
            Console.WriteLine("Usa\n");
        }
    }
}
