using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingDemo
{
    class Program
    {
        void Add()
        {
            Console.WriteLine("10 + 2 is 12");
        }

        void Add(int a)
        { }
        void Add(int a, int b)
        {
            Console.WriteLine("Addition of int {0} and {1} is:{2}",a,b,(a+b));
        }
        void Add(double a, double b)
        {
            Console.WriteLine("Addition of double {0} and {1} is:{2}",a,b,(a + b));
        }
        void Add(int a, int b,int c)
        {
            Console.WriteLine("Addition of {0},{1} and {2} is:{3}",a,b,c,(a + b+c));
        }

        //int Add()
        //{       same like void Add() no issue if you specified different return type.
        //}

        static void Main(string[] args)
        {
            Program Obj = new Program();
            Obj.Add();
            Obj.Add('a');
            Obj.Add(2, 4);
            Obj.Add(3.3, 4.4);
            Obj.Add(2, 3, 4);
            Console.ReadKey();
        }
    }
}
