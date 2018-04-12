using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.SingleTon
{
    public sealed class SingletonClass
    {
        private static SingletonClass instance = null;
        private static int objectCreation_ = 0;
        private SingletonClass()
        {
            objectCreation_++;
        }

        public static SingletonClass GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new SingletonClass();
                return instance;
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
