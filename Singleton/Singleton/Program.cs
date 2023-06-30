using System;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton employee = Singleton.GetInstance();
            employee.PrintDetails("This is a singleton design pattern example");
            Singleton student = Singleton.GetInstance();
            student.PrintDetails("This is a singleton design pattern example 2");

        }

        

    }

    public sealed class Singleton
    {
        public static Singleton Instance = null;
        private static readonly object _lock = new object();
        public static Singleton GetInstance()
        {
            if (Instance == null)
            {  
                lock (_lock)
                {
                    if (Instance == null)
                    {
                        Instance = new Singleton();
                    }
                }
                

            }
            return Instance;
        }

        private Singleton()
        {
            Console.WriteLine("new singleton");
        }

        public void PrintDetails(string details)
        {
            Console.WriteLine(details);
        }
    }
           
}
