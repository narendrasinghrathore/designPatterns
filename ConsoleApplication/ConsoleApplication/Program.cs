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
            #region Singleton lazy loading with thread safe
            Parallel.Invoke(
                () => instance1(),
                () => instance2(),
                () => instance3(),
                () => instance4()
                );

            Console.WriteLine("[Singleton thread safe lazy-loading] Total object(s) created: {0}", SingletonClass.TotalObjectCreations);
            #endregion



            #region Singleton eager-loading
            Parallel.Invoke(
               () => instance11(),
               () => instance22(),
               () => instance33(),
               () => instance44()
               );
            Console.WriteLine("[Singleton thread safe eager-loading] Total object(s) created: {0}", SingletonClassEagerLoading.TotalObjectCreations);
            #endregion



            Console.ReadKey();
        }
        #region Singleton thread safe and lazy loading 
        private static void  instance1()
        {
            SingletonClass from1 = SingletonClass.GetInstance;
            from1.PrintName("a");
        }
        private static void instance2()
        {
            SingletonClass from2 = SingletonClass.GetInstance;
            from2.PrintName("b");
        }
        private static void instance3()
        {
            SingletonClass from3 = SingletonClass.GetInstance;
            from3.PrintName("c");
        }
        private static void instance4()
        {
            SingletonClass from4 = SingletonClass.GetInstance;
            from4.PrintName("d");
        }
        #endregion



        #region Singleton eager loading
        private static void instance11()
        {
            SingletonClassEagerLoading from1 = SingletonClassEagerLoading.GetInstance;
            from1.PrintName("a");
        }
        private static void instance22()
        {
            SingletonClassEagerLoading from2 = SingletonClassEagerLoading.GetInstance;
            from2.PrintName("b");
        }
        private static void instance33()
        {
            SingletonClassEagerLoading from3 = SingletonClassEagerLoading.GetInstance;
            from3.PrintName("c");
        }
        private static void instance44()
        {
            SingletonClassEagerLoading from4 = SingletonClassEagerLoading.GetInstance;
            from4.PrintName("d");
        }
        #endregion
    }
}
