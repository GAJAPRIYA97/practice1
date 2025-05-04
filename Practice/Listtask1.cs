using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Practice
{
    public class Listtask1
    {
        public void studentmark()
        {
            List<string> studentlist = new List<string>();
            studentlist.AddRange(new string[] { "gaja", "priya", "preethi", "kaarun" });
            foreach (string name in studentlist)
            {
                Console.WriteLine("Enter the mark for " + name);
                Console.WriteLine("enter the mark1");
                int sub1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter the mark2");
                int sub2 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("enter the mark3");
                int sub3 = Convert.ToInt32(Console.ReadLine());
                studenttotal(name, sub1, sub2, sub3);

            }
        }


        public void studenttotal(string name, int sub1, int sub2, int sub3)
        {
            var total = sub1 + sub2 + sub3;
            Console.WriteLine(name + " total is= " + total);

        }

        public double Iprice = 0;

        public void shopping()
        {

            // List<int> itemlist = new List<int>();

            Console.WriteLine("if you want to store any item");
            Console.WriteLine("yes or no");
            string billItem = Console.ReadLine();


            if (billItem == "yes")
            {
                shoppingtotal();
            }
        }
        public void shoppingtotal()
        {
            Console.WriteLine("enter the itemprice");
            var itemprice = Convert.ToDouble(Console.ReadLine());
            Iprice += itemprice;
            Console.WriteLine("total is=" + Iprice);
            shopping();
        }







        public void shoppingcard()
        {
            Console.WriteLine("how many items you enter");
            int total = Convert.ToInt32(Console.ReadLine());
            if (total == 1)
            {
                Console.WriteLine("enter the item price");
                int item1 = Convert.ToInt32(Console.ReadLine());
                totalshopping(item1);
            }
            else if (total > 1)
            {   
                double[] itemArray =new double[total];

            for (int i = 0; i< total; i++)
                {
                    Console.WriteLine($"enter the item{i + 1}price");
                    itemArray[i]= Convert.ToDouble(Console.ReadLine());
                    
                }
                totalshopping(itemArray);

            }

        }
        public double total = 0;
        public void totalshopping(double price)
        {
            total = total + price;
            Console.WriteLine("total is:" + total);
        }

        public void totalshopping(double[] iprice)
        {
            foreach (double itemprice in iprice)
            { 
                total = total + itemprice;
            }
            

            Console.WriteLine("total is:" + total);


        }
        
    }


 }


