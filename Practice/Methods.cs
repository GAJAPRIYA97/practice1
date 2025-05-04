using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Methods
    {
        // without argument without return type
        public void Method1()
        {
            int a = 7;
            int b = 5;
            int c = a + b;
            Console.WriteLine(c);
        }
        // without argument with return type
        public int Method2()
        {
            int a = 5;
            int b = 5;
            int c = a + b;
            return c;
        }

        // with argument with return type
        public int method3(int value)
        {
            int c = value*2;
            return c;
        }
        // with argument without return type
        public void method4(int value)
        {























            int c = value * 2;
            Console.WriteLine(c);
        }
    }
}
