using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class animal
    {
        public void animalsound()
        {
            Console.WriteLine("Animal sound");

        }
    }
    public class Dog : animal
    {
        public void animalsound()
        {
            Console.WriteLine("bow bow");
        }
    }
    public class cat : animal
    {
        public void animalsound()
        {
            Console.WriteLine("meaaww");
        }
    }


    public class animal1

    {
        public virtual void animalpoly()
        {
            Console.WriteLine("add the members");

        }

    }
    public class bird : animal1
    {
        public override void animalpoly()
        {
            string one = "parrot";
            Console.WriteLine(one);


        }


    }
    public class birds : animal1
    {
        public override void animalpoly()
        {
            string two = "quil";
            Console.WriteLine(two);
        }
    }


}        


        
            
        
    
