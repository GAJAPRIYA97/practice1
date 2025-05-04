

using System.Numerics;

namespace practice
{
    public class loop
    {
        public void loop1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

        }

        public void loop2()
        {
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0) // print odd number
                    continue;// skip even number
                Console.WriteLine(i);
            }


        }
        public void loop3()
        {
            Console.WriteLine("which table you want");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 15; i++)
            {
                int total = i * num;
                Console.WriteLine($"{i}x{num}={total}");




            }
        }

        public void loop4()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");

                }
                {
                    Console.WriteLine();
                }
            }
        }

        public void pramid()

        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i * 2 - 1; k++)

                { 
                    Console.Write(k);
                }
                Console.WriteLine();
            }

        }

    }
}