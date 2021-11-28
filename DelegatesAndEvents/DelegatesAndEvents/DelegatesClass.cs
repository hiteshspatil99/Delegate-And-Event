using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
    public delegate int operation(int x, int y);
    class DelegatesClass
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }
    }
}
