using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAboutConstructor
{
   class ConstructorDemo
    {
        int firstNum, secNum;
        static int sample;
       
     ConstructorDemo()
        {
            firstNum = 10;
            secNum = 20;
            sample = 30; //Allows static variable like normal methods.
            Console.WriteLine();
            Console.WriteLine("This is Default constructor");
            Console.WriteLine("The addition of {0} and {1} is:{2}",firstNum,secNum,(firstNum+secNum));
            Console.WriteLine();
        }

     ConstructorDemo(int firstValue, int secValue)
        {
            Console.WriteLine();
            sample = 30; //Allows static variable like normal methods.
            Console.WriteLine("This is parameterized constructor");
            Console.WriteLine("The addition of {0} and {1} is:{2}",firstValue,secValue,(firstValue+secValue));
            Console.WriteLine();
        }

     static ConstructorDemo()
        {
            sample = 20; //Allows only static variables and member functions.
           // firstNum = 30; Not valid because firstNum is not static member.
            Console.WriteLine();
            Console.WriteLine("This is static constructor and static sample value is:{0}",sample);
            Console.WriteLine();
            //add(); Not Allowed because it is a non static method.
            int result=Sub(); //Allowed because it is a static method.
        }
     public int add() { return 0; }
     static int Sub() { return 0; }
    static void Main(string[] args) //Calls static constructor.
    {
        ConstructorDemo obj = new ConstructorDemo();//Calls default constructor.
        ConstructorDemo obj1 = new ConstructorDemo(5, 10);//Calls Parameterized constructor.
        Console.ReadKey();
    }


    }
    
}
