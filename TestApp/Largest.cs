using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    public class Largest
    {
        public Largest()
        {

        }
        public int nThLargestElement(int[] l,int n)
        {
            Array.Sort(l);
            //l.Sort();
            return l[^3];
        }
    }
}
