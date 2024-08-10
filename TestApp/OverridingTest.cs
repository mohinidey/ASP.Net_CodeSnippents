using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
   public class OverridingTest
    {
        public void test()
        {
            Console.WriteLine("Base class");
        }
    }
    public class OverridingChildTest : OverridingTest
    {
        public void test()
        {
            Console.WriteLine("Child class");
        }
    }
}
