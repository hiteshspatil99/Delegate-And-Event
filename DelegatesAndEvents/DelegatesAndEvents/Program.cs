using System;
using static DelegatesAndEvents.EventClass;

namespace DelegatesAndEvents
{
    class Program
    {
        //method
        public static event DelEventHandler Add;
        static void Main(string[] args)
        {
            Console.WriteLine("Delegates And Events program!!\n");

            operation obj = new operation(DelegatesClass.Addition); // : Single Delegate.
            Console.WriteLine("Single Delegate!!...Addition is {0}\n", obj(25, 25));

            Console.WriteLine("MultiCast Delegates...\n");
            MultiCastDelegate.ImplementDelegate();          // : MultiCast Delegate.

            Console.WriteLine("Events....\n");

            Add += new DelEventHandler(EventClass.India);   // : Events.
            Add += new DelEventHandler(EventClass.Florida);
            Add += new DelEventHandler(EventClass.Usa);
            Add.Invoke();
        }
    }
}
           
        
    
