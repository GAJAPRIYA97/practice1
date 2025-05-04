using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


    internal class whileloop
    {
        public void loopmethod()
        {
            int i = 5;
            while ((i>0))
            {
                Console.WriteLine(i);
                i--;
            }
        }
 



    public class dowhile
    {
        public void domethod()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i > 5);
        }
    }

        

    public class weather
    {
        public void wethermethod()
        {
            Console.WriteLine("enter the temp");
            int i =Convert.ToInt32(Console.ReadLine());
            switch(i)
            {
                case int temp when(temp < 0):
                       Console.WriteLine("freezing");
                        break;
                case int temp when (temp<10 && temp >20 ):
                    Console.WriteLine("very cold");
                    break;

                case int temp when (temp < 20 && temp > 40):
                    Console.WriteLine("normal");
                    break;
            }

        }
    }
    public class trafic
    {
        public void traficmethod()
        {
            Console.WriteLine("enter the trafic colour");
            string lights = Console.ReadLine();

            switch (lights)
            {
                case string light when light is "red":

                    Console.WriteLine("STOP");
                    break;
                case string light when light is "yellow":
                    Console.WriteLine("SLOW DOWN");
                    break;
                case string light when light is "green":
                    Console.WriteLine("go");
                    break;
            }
        }
        public class login
        {
            public void loginmethod()
            {
                string username = "gaja";
                string password = "9090";

                Console.WriteLine("username");
                string name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("pssword");
                string id = Convert.ToString(Console.ReadLine());


                if (username == name && password == id)
                {
                    Console.WriteLine("login successful");

                }
                else
                {
                    Console.WriteLine("retry");
                }
            }
        }
        public class discount
        {
            public void discountmethod()
            {
                Console.WriteLine("enter your amount");
                var amounts = Convert.ToInt32(Console.ReadLine());

                switch (amounts)
                {
                    case int amount when amount < 100:
                        Console.WriteLine("no discount");
                        break;
                    case int amount when amount >= 100 && amount <= 500:
                        Console.WriteLine("10% discount");
                        break;
                    case int amount when amount > 500:
                        Console.WriteLine("20% discount");
                        break;



                }
            }
        }
        public class grade
        {
            public void grademethod()
            {
                Console.WriteLine("enter your mark");
                int mark = Convert.ToInt32(Console.ReadLine());

                switch (mark)
                {
                    case int marks when marks >= 90 && marks <= 100:
                        Console.WriteLine("a");
                        break;

                    case int marks when marks >= 80 && marks <= 89:
                        Console.WriteLine("b");
                        break;

                    case int marks when marks >= 70 && marks <= 79:
                        Console.WriteLine("c");
                        break;

                    case int marks when marks >= 60 && marks <= 69:
                        Console.WriteLine("d");
                        break;

                    case int marks when marks < 60:
                        Console.WriteLine("e");
                        break;
                }
            }
        }
        public class natural
        {
            public void naturalmethod()

            {
                int i = 1;
                int sum = 0;

                do
                {

                    Console.WriteLine(i);
                    i++;
                }

                while (i <= 10);
                
                {

                    sum += i;
                    Console.WriteLine("total=" + sum);

                }

            }
        }
    }
    public class prime
    {
        public void primemethod()


        {
            for (int i = 2; i >= 100; i++)
                for(int j=2; j >= 100; j--)
                {
                    if (i % j == 0) ;
                    break;
                    {
                        if (i == j) ;

                    }  
                    Console.WriteLine(i);    

                    
                }

        } 
          
            
        
    }




}

