using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

/*namespace Practice
{
    internal class oddnumberusingloop
    {
        public void odd()
        {
            Console.WriteLine("enter your number");
            int num=Convert.ToInt32(Console.ReadLine());
            
            for(int i=1; i<=num;i++)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(i);


                }
            }
     }

    }
}*/

namespace Practice
{
    public class even
    {
        public void evenMethod()
        {
            Console.WriteLine("enter the number");
            int num =Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= num; i++)

            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }

            }

            {
                Console.WriteLine("total:" + sum);


            }   
                   
                
                
            
            

        }

    }
} 


namespace downnumber
{
    public class down
    {
        public void downMethod()
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            {
                
                for(int i=10; i<=1; i--)
                {
                    Console.WriteLine(i);

                }
                    
            }
        }



}    }




namespace Practice
{
    public class multible
    {
        public void multibleMethod()

        {
            Console.WriteLine("enter the n value");
            int constant = Convert.ToInt32(Console.ReadLine());

            {
                for (int i = 1; i <= 10; i++)
                {
                    int total = i * constant;

                    Console.WriteLine($"{i} x{constant} ={total}");

                }
            }
        }
    }  
}    

                
                

                



            

            
        
    