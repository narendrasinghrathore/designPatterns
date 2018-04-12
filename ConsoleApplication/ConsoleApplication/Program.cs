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
            SingletonClass from1 = SingletonClass.GetInstance;
            SingletonClass from2 = SingletonClass.GetInstance;
            SingletonClass from3 = SingletonClass.GetInstance;
            SingletonClass from4 = SingletonClass.GetInstance;

            from1.PrintName("a");
            from2.PrintName("b");
            from3.PrintName("c");
            from4.PrintName("d");


            Console.WriteLine("Total object(s) created: {0}", SingletonClass.TotalObjectCreations);




            Console.ReadKey();
        }
    }
}
