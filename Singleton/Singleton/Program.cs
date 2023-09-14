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
            employee.PrintDetails("This is a singleton design pattern example!");
            Singleton student = Singleton.GetInstance();
            student.PrintDetails("This is a singleton design pattern example ");

        }

        

    }

    //LAZY LOADING

    //public sealed class Singleton
    //{
    //    public static Singleton Instance = null;
    //    private static readonly object _lock = new object();
    //    public static Singleton GetInstance()
    //    {
    //        if (Instance == null)
    //        {  
    //            lock (_lock)
    //            {
    //                if (Instance == null)
    //                {
    //                    Instance = new Singleton();
    //                }
    //            }


    //        }
    //        return Instance;
    //    }

    //    private Singleton()
    //    {
    //        Console.WriteLine("new singleton");
    //    }

    //    public void PrintDetails(string details)
    //    {
    //        Console.WriteLine(details);
    //    }
    //}

    //EAGER LOADING

    //public sealed class Singleton
    //{
    //    public static readonly Singleton Instance = new Singleton();

    //    public static Singleton GetInstance()
    //    {

    //        return Instance;
    //    }

    //    private Singleton()
    //    {
    //        Console.WriteLine("new singleton");
    //    }

    //    public void PrintDetails(string details)
    //    {
    //        Console.WriteLine(details);
    //    }
    //}

    public sealed class Singleton
    {   private static int counter = 0;
        public static readonly Lazy<Singleton> Instance = new Lazy<Singleton>(() => new Singleton());

        public static Singleton GetInstance()
        {

            return Instance.Value;
        }

        private Singleton()
        {
            Console.WriteLine("new singleton instance!!!!");
            counter++;
            
        }

        public void PrintDetails(string details)
        {
            Console.WriteLine(details);
            Console.WriteLine(counter);
        }
    }
}
