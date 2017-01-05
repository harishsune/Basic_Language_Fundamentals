using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo1
{
    public class StaticClass1
    {
        public static string StaticClass1Name;
        public string GetName()
        {
            MainStatic.MainClass.Name = "Harish";
            StaticClass1Name = MainStatic.MainClass.Name;
            return MainStatic.MainClass.Name;
        }
    }
}
