using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo2
{
    public class StaticClass2
    {
        public static string StaticClass2Name;
        public string GetName()
        {
            MainStatic.MainClass.Name = "Sune";
            StaticClass2Name = MainStatic.MainClass.Name;
            return MainStatic.MainClass.Name;
        }
    }
}
