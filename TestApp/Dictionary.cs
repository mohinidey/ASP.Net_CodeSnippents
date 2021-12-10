using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    public class Dictionary
    {
        //If input [1,1,2,2,2,8,8,8,8,8,5,5] then o/p will be {{1,2},{5,2},{2,3},{8,5}}
        public void OrderDict(List<int> n)
        {
            Dictionary<int, int> sortedNumbers = new Dictionary<int, int>();
             n.Sort();
            foreach(var num in n)
            {
                //int cnt = 0;
                var rm = num % 100;
                if (sortedNumbers.Keys.Contains(rm))
                    sortedNumbers[rm] += 1;
                else
                    sortedNumbers.Add(rm,1);
            }
            var sortedDict = from entry in sortedNumbers orderby entry.Value ascending select entry;
            foreach ( var i in sortedDict)
            {
                Console.WriteLine("Key: {0}, Value: {1}",i.Key,i.Value);
            }
        }

    }
}
