using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class if_statement
    {
        public void ifclass()
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("positive number");
            }
            else if (num < 0)
            {
                Console.WriteLine("number is negative");
            }
            else
            {
                Console.WriteLine("number is zero");
            }
        }


        public void oddoreven()
        {
            Console.WriteLine("enter the num");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("number is even");

            }
            else
            {
                Console.WriteLine("number is odd");
            }
        }

        public void age()
        {
            Console.WriteLine("enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("eligible for vote");

            }
            else
            {
                {
                    Console.WriteLine("not eligible");
                }
            }
        }
        public void grade()
        {
            Console.WriteLine("enter your mark");
            double mark = Convert.ToDouble(Console.ReadLine());
            if (mark >= 90)
            {
                Console.WriteLine("A");

            }
            else if (mark >= 80)
            {
                Console.WriteLine("B");
            }
            else if (mark >= 70)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("fail");
            }
        }
        public void username()
        {
            string username = "gajapriya";
            var password = "gaja@123";
            Console.WriteLine("enter your username");
            string id = Console.ReadLine();
            Console.WriteLine("enter your password");
            var pass = Console.ReadLine();
            if (id == username && pass == password)
            {
                Console.WriteLine("login successfuly");
            }
            else
            {
                Console.WriteLine("retry");

            }
        }
        public void num(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                Console.WriteLine("a is largest num");

            }
            else if (b > a && b > c)
            {
                Console.WriteLine("b is largest num");

            }
            else
            {
                Console.WriteLine("c is largest num");
            }
        }

        public void password()
        {
            Console.WriteLine("enter your password");
            string pass = Console.ReadLine();

            strenth(pass);
        }
        public void strenth(string pass)

        {

            if (pass.Length >= 8 && pass.Any(char.IsUpper) && pass.Any(char.IsLower) && pass.Any(char.IsDigit))
            {
                Console.WriteLine("password is strenthen");

            }
            else
            {
                Console.WriteLine("retry");
                password();
            }

        }
        public void pattern()
        {
            
            Console.WriteLine("enter to print pattern count :");
            int rows = Convert.ToInt32(Console.ReadLine());


            int i = 1;
            while (i <= rows)
            {
                int j = 1;
                while (j <= i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }
    }
}
