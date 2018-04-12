using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication.SingleTon;
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => instance1(),
                () => instance2(),
                () => instance3(),
                () => instance4()
                );

            Console.WriteLine("Total object(s) created: {0}", SingletonClass.TotalObjectCreations);




            Console.ReadKey();
        }

        private static void  instance1()
        {
            SingletonClass from1 = SingletonClass.GetInstance;
            from1.PrintName("a");
        }
        private static void instance2()
        {
            SingletonClass from2 = SingletonClass.GetInstance;
            from2.PrintName("a");
        }
        private static void instance3()
        {
            SingletonClass from3 = SingletonClass.GetInstance;
            from3.PrintName("a");
        }
        private static void instance4()
        {
            SingletonClass from4 = SingletonClass.GetInstance;
            from4.PrintName("a");
        }
    }
}
