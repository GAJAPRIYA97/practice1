using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class get_set
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int Id { get; set; }

        public get_set(string name, string location,int id)
        {
            this.Name = name;
            this.Location = location;
            this.Id = id;

        }
        public get_set(string name)
        {
            this.Name = name;
        }
        
        public void companydetails()
        {
            Console.WriteLine($"Name is {Name} and Id {Id} location {Location}");
        }
        

       
    }
}
