using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAboutStatic
{
    
   static class Demo
    {

        private static int b = 10;
       
        public static int B
        {
            get { return b; }
            set { b = value; }
        }
        public static void Show()
        {
            
            Console.WriteLine(B);
        }
        //Demo()
        //{
        //}
    
        static Demo()
        {
            Console.WriteLine("Static constructor");
        }
    }
    class Program
    {
        static int a;
        int b;
        static void Display()
        {
         // b = 40; Static function will access only static members of the class.
            a = 100;
            
            Console.WriteLine(a);
        }
        static Program()
        {
            a = 500;
            Console.WriteLine(a);
        }
        void show()
        {
            b = 30;
            a = 50;
            Display();
            Console.WriteLine(a);
        }

        Program()
        {
            Console.WriteLine("Program Constructor");
        }

        static void Main(string[] args)
        {
            //Demo d = new Demo();
            //Demo.B = 50;
            //Demo.Show();
            
            //Program p = new Program();
            
            //p.show();
            //Program.Display();
            Console.ReadKey();

        }
    }
}
