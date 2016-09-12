using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingInterfaces
{
    interface ITalkative
    {
        void SayHello();
        void SayGoodBye();
        
    }

    class myExampleClass : ITalkative
    {
        public void SayHello()
        {
            Console.WriteLine("Implicit Saying hello!");
        }

        public void SayGoodBye()
        {
            Console.WriteLine("Implicit Saying goodbye!");
        }

        void ITalkative.SayHello()
        {
            Console.WriteLine("Explicitly declaration Saying Hello!");
        }

        void ITalkative.SayGoodBye()
        {
            Console.WriteLine("Explicitly declaration Saying goodbye!");
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Calling Explicitly implemented interface. By creating reference of Interface.
            //If we don't implement Explicitly interface then we can also call implicitly declared method of Interface
            //using reference of interface.
            //Using reference is always preferred and it is standard practice too.
            ITalkative Italk = new myExampleClass();

            Italk.SayHello();
            Italk.SayGoodBye();

            //Calling implicitly implemented interface. By creating object of class.
            myExampleClass myEx = new myExampleClass();
            myEx.SayHello();
            myEx.SayGoodBye();

            Console.ReadLine();
        }
    }
}
