using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.SingleTon
{
    public sealed class SingletonClassEagerLoading
    {
        private static int objectCreation_ = 0;
        private static readonly Lazy<SingletonClassEagerLoading> instance = new Lazy<SingletonClassEagerLoading>(() => new SingletonClassEagerLoading());
        private SingletonClassEagerLoading()
        {
            objectCreation_++;
        }

        public static SingletonClassEagerLoading GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        public static int TotalObjectCreations
        {
            get
            {
                return objectCreation_;
            }
            private set { }
        }


        public void PrintName(string name)
        {
            Console.WriteLine("Name: {0}", name);
        }
    }
}
