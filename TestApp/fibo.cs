using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    public class fibo
    {
        public int[] Fibonacci(int n)
        {
            var n1 = 0;
            var n2 = 1;
            int[] arr = new int[n];
            arr[0] = 0;
            arr[1] = 1;
            for(int i=2;i<n;i++)
                arr[i] = arr[i - 1] + arr[i - 2];
            return arr;
        }
    }
}
