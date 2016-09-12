using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceDemo
{
  class BaseClass
    {
        public int Id;
        public string Name;
        int Salary;
        protected int Age;
        internal string Designation;
        protected internal string Address;
        public virtual void Display()
        {
            Salary = 999999;
            Console.WriteLine("Salary is:{0}",Salary);
        }

       
    }

    class Derived:BaseClass
    {
        public override void Display()
        {
            
            Id = 1;
            Name = "Harry";
            //Salary = 900000; Not valid because Salary is private member of BaseClass.
            Age = 23;
            Designation = "Software Engineer";
            Address = "Shirajgaon Kasba";
            Console.WriteLine("Id:{0}\n Name:{1}\n Age:{2}\n Age:{3}\n Designation:{4}\n Address:{5}",Id,Name,Age,Designation,Address);

        }
        
    }

    class Program //We have not inherit program class from any other class. But as we still in assembly so we can access 
                   //following variables
    {
        static void Main(string[] args)
        {
            Derived derObj = new Derived();
            derObj.Address = "Amravati"; //Protected Internal
            derObj.Designation = "Software Developer"; //Internal
            derObj.Id = 2; //Public
            
            derObj.Display();
            Console.ReadKey();
        }
    }

    
}
