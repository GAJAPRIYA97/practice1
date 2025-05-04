
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class task_1
    {
        public static void Task1Method()
        {
            Console.WriteLine("Enter the first number");
            int number1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int number2 = Convert.ToInt16(Console.ReadLine());
            int add=(number1 + number2);
            Console.WriteLine("total="+add);

            int sub = (number1 - number2);
            Console.WriteLine("total=" + sub);


            int mul= (number1 * number2);
            Console.WriteLine("total=" + mul);



            int div= (number1 / number2);
            Console.WriteLine("total=" + div);


            int mod= (number1 % number2);
            Console.WriteLine("total=" + mod);
        }
    }
}
namespace Practice
{
    public class task_2
    {
        public void Task2Method()
        {
            Console.WriteLine("enter your year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("leap year");

            }
            else
            {
                Console.WriteLine("non leap year");
            }
        }
    }
}
namespace Practice
{
    public class task_3
    {
        public void voteMethod()
        {
            Console.WriteLine("enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("eligible for vote");
            }
            else
            {
                Console.WriteLine("not eligible");
            }
        }
    }
}
namespace Practice
{
    public class task4
    {
        public void OddMethod()
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("even");

            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
namespace Practice
{
    internal class taskfive
    {
        public void tnumberMethod()
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }


            }
        }
    }
}



namespace Practice
{
    public class PracticeOwn
    {
        public void starMethod()
        {
            int i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("even");

                }
                else
                {
                    Console.WriteLine("odd");
                }
            }



            /*for(int i=1; i<=5; i++)

              {
                  for(int j=1; j<=i; j++)
                  {

                      Console.Write(i+ " ");
                  }
                  Console.WriteLine();*/
        }
    }
}





