using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDEmo
{
    public sealed class Singleton //sealed as no class can create any instance - restrict the inheritence
    //if sealed keyword is removed inherting it to another class will throw error since const is private.
    //sealed keyword is used to restrict inherting inside the class. i.e. nested class inheritence.
    {
        private static int counter = 0;
        private static Singleton instance = null;
        private static readonly Object obj = new Object();
        public static Singleton GetInstance //public property to ensure the return of the instance of the class
        {
            get
            {
                if (instance == null) // double check locking. since lock call is a very expensive call so multiple times check is restricted
                lock(obj) // in parallel thread call it will restict to create multiple instances.
                {
                    if (instance == null)
                        instance = new Singleton();
                }                
                return instance;
            }
        }
        private Singleton() //to ensure object is not initiated other than the class itself
        {
            counter++;
            Console.WriteLine("counter : "+counter);
        }
        public void Print(string message)
        {
            Console.WriteLine(message);
        }

    }
}
