using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    public class Palindrome
    {
        public bool isPalindrome(string str)
        {
            var s = str;
            var l = s.ToCharArray();
             Array.Reverse(l);
            s = new string(l);
            if (s == str)
                return true;
            return false;
        }
    }
}
