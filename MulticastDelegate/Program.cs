using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void NumberChanger(int n);

namespace MulticastDelegate
{
    class Program
    {
         int num = 10;
        public void AddNum(int p)
        {
            num += p;
            Console.WriteLine("The value of num is:{0}",num);
        }

        public void MultNum(int q)
        {
            num *= q;
            Console.WriteLine("The value of num is:{0}", num);
        }
        public int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            //create delegate instances
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(p.AddNum);
            NumberChanger nc2 = new NumberChanger(p.MultNum);
            nc = nc1;
            nc += nc2;
            //calling multicast
            nc(5);
            Console.WriteLine("Value of Num: {0}", p.getNum());
            Console.ReadKey();
        }
    }
}
