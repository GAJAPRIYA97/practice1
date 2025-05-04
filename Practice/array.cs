using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public partial class array
    {
        public void arraymethod()
        {
            int[] number = [10];
            int[] numb1 = [15, 29, 35, 48, 57, 69,];
           

            {
                Console.WriteLine(numb1[3]);
                Console.WriteLine(numb1.Length);
                Console.WriteLine(string.Join(", ", numb1));
                numb1[3] = 56;
                Console.WriteLine(string.Join(", ", numb1));
                //Array.Sort(numb1);
                Array.Reverse(numb1);
                Console.WriteLine(string.Join(", ", numb1));


                int index = Array.IndexOf(numb1,35);
                //Console.WriteLine(index);   


            }
        }

        public void arraymethod2()
        {
            int[] number = [1, 2, 3, 4, 5 ];
            Array.Reverse(number);
            {
                Console.WriteLine(string.Join(",",number));
                Console.WriteLine(number.Length);
                Console.WriteLine(number.Max());
                Console.WriteLine(number.Min());

            }
        }
        public void arraymethod3()
        {
            int[] numbers = new int[5];
            for(int i=0;i<numbers.Length;i++)
            {
                Console.Write("enter a number");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }
           /* for(int i=0;i<numbers.Length;i++)
            {
                Console.WriteLine($" {numbers[i]}");
            }*/

            foreach(int num in numbers)
            {
                Console.WriteLine($"{num}");
            }


                
        }
        public void arraymethod4()
        {
            int[] angles = new int[3];
            for(int i=0; i<angles.Length; i++)
            {
                Console.WriteLine($"enter the value {i}:");
                angles[i]= Convert.ToInt32(Console.ReadLine());


            }
            int sum = 0;
            foreach(int num in angles)
            {
                Console.WriteLine( num );
                sum = sum + num;

            }
            Console.WriteLine(sum);
            Console.WriteLine(sum==180 ? "valid":"invalid");
        }
        

        public void arraymethod5()
        {
            string[] stuname= new string[2];
            int[,] marks = new int[3,5];

            int total = 0;
            for(int i=0;i<3;i++)
            {
                Console.Write($"student name {i+1}:");
                string name = Convert.ToString(Console.ReadLine());
                
                for(int j=0;j<5;j++)
                {
                    Console.Write($"enter mark {j+1}:");
                    int mark  =Convert.ToInt32(Console.ReadLine());
                    
                }
                
                Console.WriteLine();




                
            }
            
            
        }
        

    }
      
}
