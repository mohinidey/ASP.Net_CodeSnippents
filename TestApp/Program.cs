﻿using System;
using System.Collections.Generic;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = new string[100];
            List<int> v = new List<int>();
            v.Add(1);
            string res = "";
            #region Reverse String
            //string s1 = Console.ReadLine();
            //var arr = s1.Split();
            //for (int i = 0; i < arr.Length; i = i + 2)
            //{
            //    res += reverse(arr[i]);
            //    if(i+1<arr.Length)
            //    res += " " + arr[i + 1];
            //    res += " ";
            //}
            // Console.WriteLine(res); 
            #endregion
            #region Nth Large Element
            //var num = Console.ReadLine();
            //var m = Convert.ToInt32(Console.ReadLine());
            //var nums = num.Split();
            //int[] n = new int[nums.Length];
            //for (int i = 0; i < nums.Length; i++)
            //    n[i] = Convert.ToInt32(nums[i]);
            //Largest obj = new Largest();
            //var res1 = obj.nThLargestElement(n, m);
            //Console.WriteLine(res1); 
            #endregion
            #region Fibonacci
            //var f = Convert.ToInt32(Console.ReadLine());
            //fibo obj = new fibo();
            //var fibo = obj.Fibonacci(f);
            //foreach (int num in fibo)
            //    Console.WriteLine(num); 
            #endregion
            #region Palindrome
            //var str = Console.ReadLine();
            //Palindrome obj = new Palindrome();
            //var r = obj.isPalindrome(str) == true ? "Is Palindrome" : "not Palindrome";
            //Console.WriteLine(r); 
            #endregion
            #region Sorting
            var num = Console.ReadLine();
            var nums = num.Split();
            int[] n = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
                n[i] = Convert.ToInt32(nums[i]);
            Sort obj = new Sort();
            //var l = obj.BubbleSort(n);
            //obj.QuickSort(n, 0, n.Length - 1);
            //foreach (var a in n)
            //    Console.WriteLine(a); 
            #region Conversion base
            //int value = 8;
            //string binary = Convert.ToString(value, 2);//To Base
            //Console.WriteLine(binary);
            //// binary to base 10
            //value = Convert.ToInt32(binary, 2);//From Base
            //Console.WriteLine(value); 
            #endregion
            #endregion
        }
        static string reverse(string s)
        {
            var c = s.ToCharArray();
            Array.Reverse(c);
            return new string(c);
        }
    }
}
