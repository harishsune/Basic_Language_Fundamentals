using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractClasses
{
    abstract class myBaseClass
    {
        int Sample;
       // public abstract int myMethod(int arg1, int arg2);
        public void Display()
        {
            Sample = 10;
            Console.WriteLine("Normal Method of Abstract class" );
            Console.WriteLine("The value of sample is:{0}",Sample);
        }
    }

    //class Demo
    //{
    //    public abstract void show(); //Normal class should not have abstract methods.
    //}

    class myDerivedClass : myBaseClass
    {
        //public override int myMethod(int arg1, int arg2)
        //{
        //    return arg1 + arg2;
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
           // myBaseClass obj = new myBaseClass(); Can't create instance of abstract class.
            myDerivedClass obj = new myDerivedClass();
           // Console.WriteLine("Calling implemented abstract method"+obj.myMethod(10, 20));
            obj.Display();
            Console.ReadKey();
        }
    }
}
