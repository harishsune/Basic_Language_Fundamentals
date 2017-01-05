using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StaticDemo1;

namespace StaticTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            StaticClass1 staticClass1 =new StaticClass1();
            Debug.Write(staticClass1.GetName());
           string name1= StaticClass1.StaticClass1Name;
            StaticDemo2.StaticClass2 staticClass2 = new StaticDemo2.StaticClass2();
            Debug.Write(staticClass2.GetName());
            string name2 = StaticDemo2.StaticClass2.StaticClass2Name;
        }
    }
}
